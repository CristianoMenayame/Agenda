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
    public partial class Pesquisar : Form
    {
        //------------------------------------------------------
        public string texto_Pesquisa { get; set; }
        public bool Cancelado { get; set; }
        public Pesquisar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cancelado = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Chama o formulario de resultados se o textbox preenchido
            if (tx_Pesquisar.Text == "")
            {
                Cancelado = true;
            }
            else
            {
                texto_Pesquisa = tx_Pesquisar.Text;
            }
            this.Close();
        }
    }
}
