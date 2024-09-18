using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlServerCe;

namespace Agenda
{
    public static partial class Vars
    {
        public static string Versao = "V.1.0.0";
        public static string Pasta_Dados;
        public static string Base_Dados;

        public static void Iniciar()
        {
            // Localização da pasta onde vai conter o app
            Pasta_Dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSql\";
            // Verificação da pasta, se não existir vai criar uma pasta 
            if (!Directory.Exists(Pasta_Dados))
            {
                Directory.CreateDirectory(Pasta_Dados);
            }
            // Verifique se a base de dados existe
            Base_Dados = Pasta_Dados + "dados.sdf";
            if (!File.Exists(Base_Dados))
            {
                //Chamar o metodo criar banco de dados
                Criar_Banco_de_Dados();
            }
        }

        public static void Criar_Banco_de_Dados()
        {
            //Criar o banco de dados
            SqlCeEngine motor = new SqlCeEngine("Data Source=" + Base_Dados);
            motor.CreateDatabase();
            //Estrutura do banco de dados
            SqlCeConnection Conect = new SqlCeConnection();
            Conect.ConnectionString = "Data Source=" + Base_Dados;
            Conect.Open();

            //Criando tabela
            SqlCeCommand instrucao = new SqlCeCommand();
            instrucao.CommandText = " CREATE TABLE CONTACTOS ( " +
                "id_Contatos              int not null primary key," +
                "nome                     nvarchar(50)," +
                "telefone                 nvarchar(20)," +
                "atualizacao              datetime )";
            instrucao.Connection = Conect;
            instrucao.ExecuteNonQuery();

            instrucao.Dispose();
            Conect.Dispose();
        }
    }
}
