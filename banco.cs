using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _211362
{
    public class banco
    {
        public static MySqlConnection conexao;

        public static MySqlCommand comando;

        public static MySqlDataAdapter adaptador;//inserção de dados numa dataTable

        public static DataTable data_table;//liga o banco em controles -> propriedade DataSource

        public static void abre_conexao()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fecha_conexao()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void cria_banco()
        {
            try
            {
                abre_conexao();

                comando = new MySqlCommand("create database if not exists vendas; use vendas;", conexao);
                comando.ExecuteNonQuery();

                comando = new MySqlCommand("create table if not exists cidades "+
                                           "(id integer auto_increment primary key, " +
                                           "nome varchar (40), " +
                                           "uf char(2))", conexao);
                comando.ExecuteNonQuery();

                fecha_conexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}