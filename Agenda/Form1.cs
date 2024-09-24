using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            Lb_versao.Text = Vars.Versao;
        }

        private void Agenda_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {          
            if (MessageBox.Show("Desejas mesmo sair?", "Aviso",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //form_Inserir form_Inser = new form_Inserir();
            //form_Inser.Show();
            //form_Inser.FormClosed += Logout;
            //this.Hide();
            fr_Apresentar fr = new fr_Apresentar();
            fr.ShowDialog();
            
        }
        public void Logout(object sender, FormClosedEventArgs e)
        {         
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar form_P = new Pesquisar();
            form_P.ShowDialog();
            //Verifica se for cancelado 
            if (form_P.Cancelado)
            {
                form_P.Dispose();
                return;
            }
            //Executar a pesquisa
            //string texto = form_P.texto_Pesquisa;
            //string query = "SELECT * FROM CONTACTOS WHERE nome LIKE '%" + texto + "'%'";
            fr_Apresentar form_A = new fr_Apresentar(form_P.texto_Pesquisa);
            form_A.ShowDialog();
        
        }

        private void bt_Adicionar_Click(object sender, EventArgs e)
        {
            Ad_Edit sh = new Ad_Edit();
            sh.ShowDialog();
        }
    }
}
