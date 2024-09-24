using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Ad_Edit : Form
    {
        int id_Contactos;
        bool editar;
        public Ad_Edit(int id_Contactos = -1)
        {
            InitializeComponent();
            this.id_Contactos = id_Contactos;
            //Verificar se o id_Contactos for = -1 
            editar = id_Contactos == -1 ? false : true;
        }
        private void Ad_Edit_Load(object sender, EventArgs e)
        {
            //Verificando a condicao 
            if (editar)
                ApresentarContactos();
        }
        private void ApresentarContactos()
        {
            //_____________________________________________________________
            //Apresentar o contacto selecionado nos textbox para editar-lo
            //____________________________________________________________
            //Abrir a conexao
            SqlCeConnection conect = new SqlCeConnection("Data Source =" + Vars.Base_Dados);
            conect.Open();
            DataTable dados = new DataTable();
            string inst = "SELECT * FROM CONTACTOS WHERE id_contatos="+ id_Contactos;
            //int v = 0;
            SqlCeDataAdapter instrucao = new SqlCeDataAdapter(inst, conect);
            instrucao.Fill(dados);

            tx_Nome.Text = dados.Rows[0]["nome"].ToString();
            tx_Numero.Text = dados.Rows[0]["telefone"].ToString();
            //Fechar a conexao
            conect.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Guardar_Click(object sender, EventArgs e)
        {
            //Criar ligacao
            SqlCeConnection ligacao = new SqlCeConnection("Data Source = " + Vars.Base_Dados);
            ligacao.Open();
            //Apresentando os contactos

            //Verificar os campos estao vazios
            //-------------------------------------------------------
            #region VerificacoesCampos
            //Verificar se os campos estao preenchidos
            if (tx_Nome.Text == "" || tx_Numero.Text == "")
            {
                MessageBox.Show("Pelo menos um dos campos esta vazio");
                //Para que o codigo nao continua a sendo executado
                return;
            }



            #endregion

            //--------------------------------------------------------
            //GUARDAR NOVO CONTACTO
            //________________________________________________________
            #region Novo Contatos
            if (!editar)
            {
                //Configuracoes para verificar o Id, se existe adicionar + 1
                string inst = "SELECT MAX(id_Contatos) AS MAXID FROM CONTACTOS";
                SqlCeDataAdapter instrucao = new SqlCeDataAdapter(inst, ligacao);
                DataTable dados = new DataTable();
                instrucao.Fill(dados);
                //Verifica se o valor e null 
                if (DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_Contactos = 0;
                }
                else
                    //Senao for Null ele adiciona + 1
                    id_Contactos = Convert.ToInt16(dados.Rows[0][0]) + 1;

                //Comanndo para gravar novo contacto
                SqlCeCommand gravar = new SqlCeCommand();
                gravar.Connection = ligacao;

                //Parametros
                gravar.Parameters.AddWithValue("@Id_Contactos", id_Contactos);
                gravar.Parameters.AddWithValue("@Nome", tx_Nome.Text);
                gravar.Parameters.AddWithValue("@Telefone", tx_Numero.Text);
                gravar.Parameters.AddWithValue("@Atualizacao", DateTime.Now);

                //Verifica se ja existe o mesmo nome ou contacto
                instrucao = new SqlCeDataAdapter();
                dados = new DataTable();
                gravar.CommandText = "SELECT * FROM CONTACTOS WHERE nome=@Nome AND telefone=@Telefone ";
                instrucao.SelectCommand = gravar;
                instrucao.Fill(dados);
                //Verifica se ao selecionar for encontrado dados exatamente iguais ele retorna
                if(dados.Rows.Count != 0)
                {
                    //Essa tabela foi preenchido ele avisa que ja tem um contacto ou um nome igual no banco de dados
                    if(MessageBox.Show("Ja existe um Contactos igual a este" + Environment.NewLine + "Desejas Continuar ?", "Atencao" 
                        ,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No) 
                    tx_Nome.Text = "";
                    tx_Nome.Focus();
                    tx_Numero.Text = "";
                    return;
                }

                //Texto query
                gravar.CommandText = "INSERT INTO CONTACTOS VALUES ("+
                    "@Id_Contactos, @Nome, @Telefone, @Atualizacao)";
                gravar.ExecuteNonQuery();

                //Fechar a conoxao
                gravar.Dispose();
                ligacao.Dispose();
                MessageBox.Show("Contactos guardado com sucesso.");

                //Limpar os campos 
                tx_Nome.Text = "";
                tx_Nome.Focus();
                tx_Numero.Text = "";
            }
            #endregion
            //--------------------------------------------------------
            #region Editar Contatos
            else
            {
                //Comanndo para Editar o contacto
                SqlCeCommand gravar = new SqlCeCommand();
                gravar.Connection = ligacao;

                //Parametros
                gravar.Parameters.AddWithValue("@Id_Contactos", id_Contactos);
                gravar.Parameters.AddWithValue("@Nome", tx_Nome.Text);
                gravar.Parameters.AddWithValue("@Telefone", tx_Numero.Text);
                gravar.Parameters.AddWithValue("@Atualizacao", DateTime.Now);

                //Verifica se ja existe no banco de dados
                DataTable dados = new DataTable();
                gravar.CommandText = "SELECT * FROM CONTACTOS WHERE nome=@Nome AND id_Contatos <> @Id_Contactos";
                SqlCeDataAdapter instrucao = new SqlCeDataAdapter();
                instrucao.SelectCommand = gravar;
                
                instrucao.Fill(dados);
                //verifica se existe um registro com mesmo nome
                if(dados.Rows.Count != 0)
                {
                    if (MessageBox.Show("Ja existe um Contactos com mesmo nome" + Environment.NewLine + "Desejas Continuar ?", "Atencao"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    //    //tx_Nome.Text = "";
                    //tx_Nome.Focus();
                    ////tx_Numero.Text = "";
                    return;
                }
                //Editar o registro selecionado
                gravar.CommandText = "UPDATE CONTACTOS SET nome = @nome," +
                                     "telefone = @Telefone," +
                                     "atualizacao = @Atualizacao WHERE id_contatos=@Id_Contactos";
                gravar.ExecuteNonQuery();
                //Fechar a janela
                this.Close();
            }
            #endregion

        }
    }
}
