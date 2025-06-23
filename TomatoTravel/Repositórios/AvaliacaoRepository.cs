using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TomatoTravel.Repositórios
{
    internal class AvaliacaoRepository
    {
        private readonly string _connectionString;

        public AvaliacaoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool SalvarAvaliacao(string email_usuario, int id_lugar, int nota)
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"
                INSERT INTO avaliacao (email_usuario, id_lugar, nota)
                VALUES (@Email_usuario, @Id_lugar, @Nota)
                ON DUPLICATE KEY UPDATE nota = @Nota";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email_usuario", email_usuario);
                    cmd.Parameters.AddWithValue("@Id_lugar", id_lugar);
                    cmd.Parameters.AddWithValue("@Nota", nota);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public int? ObterNotaDoUsuario(string email, int id)
        {
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT nota FROM avaliacao WHERE email_usuario = @email_usuario ";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email_usuario", email);
                    

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return null; // Nenhuma avaliação encontrada
        }
    }
}
