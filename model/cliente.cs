using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211362.model
{
    public class cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idCidade { get; set; }
        public DateTime dataNascimento { get; set; }
        public double renda { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public bool venda { get; set; }

        public void insert()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("insert into clientes (nome, idCidade, dataNascimento, renda, cpf, foto, venda) values (@nome, @idCidade, @dataNascimento, @renda, @cpf, @foto, @venda)", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@idCidade", idCidade);
                banco.comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                banco.comando.Parameters.AddWithValue("@renda", renda);
                banco.comando.Parameters.AddWithValue("@cpf", cpf);
                banco.comando.Parameters.AddWithValue("@foto", foto);
                banco.comando.Parameters.AddWithValue("@venda", venda);

                banco.comando.ExecuteNonQuery();

                banco.fecha_conexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void update()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("update clientes set nome = @nome, idCidade = @idCidade, dataNascimento = @dataNascimento, renda = @renda, cpf = @cpf, foto = @foto, venda = @venda where id = @id", banco.conexao);

                banco.comando.Parameters.AddWithValue("@nome", nome);
                banco.comando.Parameters.AddWithValue("@idCidade", idCidade);
                banco.comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                banco.comando.Parameters.AddWithValue("@renda", renda);
                banco.comando.Parameters.AddWithValue("@cpf", cpf);
                banco.comando.Parameters.AddWithValue("@foto", foto);
                banco.comando.Parameters.AddWithValue("@venda", venda);
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

                banco.comando = new MySqlCommand("delete from clientes where id = @id", banco.conexao);
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

                banco.comando = new MySqlCommand("SELECT cl.*, ci.nome cidade, ci.uf FROM cidades where nome like @nome " +
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
