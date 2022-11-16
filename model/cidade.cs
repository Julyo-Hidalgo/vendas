using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _211362.model
{
    internal class cidade
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
        
        public void insert()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("insert into cidades (nome, uf) values (@nome, @uf)", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@uf", uf);

                banco.comando.ExecuteNonQuery();

                banco.fecha_conexao();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("update cidades set nome = @nome, uf = @uf where id = @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@uf", uf);
                banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();

                banco.fecha_conexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void delete()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("delete * from cidades where id = @id", banco.conexao);
                banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();

                banco.fecha_conexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable consultar()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("SELECT * FROM cidades where nome like @nome " +
                    "order by nome ASC", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome + "%");
                banco.adaptador = new MySqlDataAdapter(banco.comando);
                banco.data_table = new DataTable();
                banco.adaptador.Fill(banco.data_table);

                banco.fecha_conexao();
                return banco.data_table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}