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
            //Apresentando os contactos


            //--------------------------------------------------------
            #region Novo Contatos
            if (!editar)
            {
                //Configuracoes para editar 
            }
            #endregion
            //--------------------------------------------------------
            #region Editar Contatos
            else
            {

            }
            #endregion

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
