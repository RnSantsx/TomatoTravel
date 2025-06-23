using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using TomatoTravel.Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TomatoTravel.Repositórios
{
    internal class LugarRepository
    {
        private readonly string _connectionString;

        public LugarRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<Lugar> ObterTodosLugares()
        {
            List<Lugar> lugares = new List<Lugar>();

            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT id, nome_lugar, imagem, descricao FROM lugares";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lugares.Add(new Lugar
                        {
                            Id = reader.GetInt32("id"),
                            Nome_lugar = reader.GetString("nome_lugar"),                            
                            Descricao = reader.GetString("descricao"),
                            Imagem = reader["imagem"] as byte[]
                        });
                    }
                }
            }

            return lugares;
        }

        public int InserirLugar(Lugar lugar)
        {
            int linhasAfetadas = -1;
            using (var conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO lugares (nome_lugar, descricao) VALUES ( @Nome_lugar, @descricao)";
                using (var command = new MySqlCommand(query, conn))
                {                  
                    command.Parameters.AddWithValue("@Nome_lugar", lugar.Nome_lugar);                    
                    command.Parameters.AddWithValue("@Descricao", lugar.Descricao);
                    linhasAfetadas = command.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }
    }
}
