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
    public partial class form_Inserir : Form
    {
        public form_Inserir()
        {
            InitializeComponent();
        }

        private void form_Inserir_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir a conecao
            SqlCeConnection conect = new SqlCeConnection();
            conect.Open();
            //instrucoes
            conect.ConnectionString = @"Data source =E:\BD\Loja.sdf";
            //Fechar a conecao
            conect.Close();
        }
    }
}
