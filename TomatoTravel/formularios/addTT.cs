using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TomatoTravel.Entidades;
using TomatoTravel.Repositórios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TomatoTravel.formularios
{
    public partial class addTT : Form
    {
        public addTT()
        {
            InitializeComponent();
        }
      

        private void addTT_Load(object sender, EventArgs e)
        {

        }

        private void txtnomlugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_lugar = txtnomlugar.Text;
            string descricao = txtdescricao.Text;

            LugarRepository repo = new LugarRepository(utilsegundojoao.connectionString);
            Lugar novoLugar = new Lugar
            {

                Nome_lugar = nome_lugar,
                Descricao = descricao
            };

            try
            {
                int linhas = repo.InserirLugar(novoLugar);
                if (linhas > 0)
                {
                    lbladdlugar.ForeColor = Color.Green;
                    lbladdlugar.Text = "Lugar Cadastrado com Sucesso!";
                    LimparCamposadd();

                }
                else
                {
                    lbladdlugar.ForeColor = Color.Red;
                    lbladdlugar.Text = "Não foi possível cadastrar.";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                if (ex.Number == 1062)
                    lbladdlugar.ForeColor = Color.Red;
                    lbladdlugar.Text = "Já existe esse lugar no banco de dados";
            }
            catch (Exception ex)
            {
                lbladdlugar.ForeColor = Color.Red;
                lbladdlugar.Text = "Erro inesperado";
            }
            void LimparCamposadd()
            {
                txtnomlugar.Text = "";
                txtdescricao.Text = "";
                
            }




        }
    }
}
