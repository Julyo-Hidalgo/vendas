using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _211362.model
{
    public class produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public double estoque { get; set; }
        public double valorVenda { get; set; }
        public string foto { get; set; }

        public void delete()
        {
            try
            {
                banco.abre_conexao();

                banco.comando = new MySqlCommand("delete from produtos where id = @id", banco.conexao);
                //banco.comando.Parameters.AddWithValue("@id", id);

                banco.comando.ExecuteNonQuery();

                banco.fecha_conexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}