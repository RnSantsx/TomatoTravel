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
using TomatoTravel.formularios;
using TomatoTravel.Repositórios;


namespace TomatoTravel
{
    internal partial class TomatoTravel : Form
    {
        private Usuario usuarioLogado;
        private List<Lugar> lugares;
        private int indiceAtual = 0;
        
        public TomatoTravel(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
        }

        private void TomatoTravel_Load(object sender, EventArgs e)
            
        {
            LugarRepository repo = new LugarRepository(utilsegundojoao.connectionString);
            lugares = repo.ObterTodosLugares();
            ExibirLugar();
            for (int i = 0; i <= 5; i++)
            {
                cbnota.Items.Add(i);

            }
        }

        private void btanterior_Click(object sender, EventArgs e)
        {
            if (indiceAtual > 0) 
            { 
               indiceAtual--;
               ExibirLugar();
            }
            lblnotamsg.Text = "";
            lbnota.Text = "";
        }

        private void btproximo_Click(object sender, EventArgs e)
        {
            if (indiceAtual < lugares.Count - 1)
            { 
               indiceAtual++;
               ExibirLugar();
            }
            lblnotamsg.Text = "";
            lbnota.Text = "";
            
        }
        
        

        private void imagemlugar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTT addtt = new addTT();
            addtt.Show();

            this.entraradd.Click += new System.EventHandler(this.button1_Click);
        }

        private void desclabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAvaliar_Click(object sender, EventArgs e)
        {
            if (lugares == null || lugares.Count == 0) return;

            int nota = Convert.ToInt32(cbnota.SelectedItem.ToString());
            int idLugar = lugares[indiceAtual].Id;
            string email = usuarioLogado.Email;

            AvaliacaoRepository repo = new AvaliacaoRepository(utilsegundojoao.connectionString);
            bool sucesso = repo.SalvarAvaliacao(email, idLugar, nota);

            lblnotamsg.ForeColor = sucesso ? Color.LightGreen : Color.OrangeRed;
            lblnotamsg.Text = sucesso ? "Avaliação registrada." : "Erro ao registrar avaliação";
            
            

        }
        private void ExibirLugar()
        {
            if (lugares == null || lugares.Count == 0) return;

            Lugar lugar = lugares[indiceAtual];

            nomelugarlbl.Text = lugar.Nome_lugar;
            desclabel.Text = lugar.Descricao;
            imagemlugar.Image = imageUtil.ConverterBytesParaImagem(lugar.Imagem);

            btanterior.Enabled = indiceAtual > 0;
            btproximo.Enabled = indiceAtual < lugares.Count - 1;

            // Buscar e exibir nota do usuário
            AvaliacaoRepository repo = new AvaliacaoRepository(utilsegundojoao.connectionString);
            int? nota = repo.ObterNotaDoUsuario(usuarioLogado.Email, lugar.Id);

            if (nota.HasValue)
            {
                cbnota.SelectedItem = nota.Value.ToString();
                lbnota.ForeColor = Color.LightGray;
                lbnota.Text = "Sua nota anterior: " + nota.Value;
            }
            else
            {
                cbnota.SelectedItem = "5"; // Valor padrão
                lbnota.Text = "";
            }



        }
        private void cbnota_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

