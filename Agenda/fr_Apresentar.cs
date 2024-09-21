using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class fr_Apresentar : Form
    {
        int id_Contacto;
        public fr_Apresentar()
        {
            InitializeComponent();
        }
        //______________________________________________________
        private void bt_Fechar_Click(object sender, EventArgs e)
        {
            //Frchar o programa 
            this.Close();
        }
        //______________________________________________________
        private void Construir_Grelha()
        {
            //CONSTRUIR A GRELHA DE REGISTRO

            //Ligar o banco de dados
            SqlCeConnection conect = new SqlCeConnection("Data Source = " + Vars.Base_Dados);
            conect.Open();

            //Buscar Informacoes
            SqlCeDataAdapter instrucao = new SqlCeDataAdapter("SELECT * FROM CONTACTOS ORDER BY nome", conect);
            DataTable dados = new DataTable();
            instrucao.Fill(dados);

            //Apresentar od dados na Grelha
            gr_Resultados.DataSource = dados;

            //Apresentar a quantidade de informacoes que estao de base de dados
            lb_Quantidade.Text = "Total de contactos: " + gr_Resultados.Rows.Count;

            //Esconder Colunas id_Contactos | Atualizacao
            gr_Resultados.Columns[0].Visible = false;
            gr_Resultados.Columns[3].Visible = false;

            //Redimencionar as colunas 
            gr_Resultados.Columns[1].Width = 250;
            gr_Resultados.Columns[2].Width = 100;


            //Controlar a visibildade dos Comandos
            bt_Editar.Enabled = false;
            bt_Apagar.Enabled = false;
            //Fechar o Banco de dados
            conect.Dispose();
            instrucao.Dispose();
        }

        private void fr_Apresentar_Load(object sender, EventArgs e)
        {
            Construir_Grelha();
        }
        //______________________________________________________
        private void gr_Resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Receber o valor do item selecionado na tabela
            id_Contacto = Convert.ToInt16(gr_Resultados.Rows[e.RowIndex].Cells[0].Value);
            bt_Apagar.Enabled = true;
            bt_Editar.Enabled = true;
        }
        //_______________________________________________________
        private void bt_Apagar_Click(object sender, EventArgs e)
        {
            //Verificar o item seleciona atravez da variavel id_Contactos e eliminar-lo
            //Abrir a conecao
            SqlCeConnection conect = new SqlCeConnection("Data Source = " + Vars.Base_Dados);
            conect.Open();

            //Confirmar a eliminacao
            if(MessageBox.Show("Voce realmente prentende apagar este contactos ?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //Instrucao query
            SqlCeCommand instrucao = new SqlCeCommand("DELETE FROM CONTACTOS WHERE id_Contatos ="
                + id_Contacto, conect);
            instrucao.ExecuteNonQuery();

            //Fechar as conexoes
            instrucao.Dispose();
            conect.Dispose();

            //Atualizar a tabela
            Construir_Grelha();
        }

        private void bt_Editar_Click(object sender, EventArgs e)
        {
            Ad_Edit adt = new Ad_Edit(id_Contacto);
            adt.ShowDialog();
            //Atualizar a grelha
            Construir_Grelha();
        }
    }
}
