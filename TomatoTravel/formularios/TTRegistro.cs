using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomatoTravel
{
    public partial class TTRegistro : Form
    {
        
            public TTRegistro()
            {
                InitializeComponent();
            }

            private void TTRegistro_Load(object sender, EventArgs e)
            {

            }

        private void BotaoRegistrar_Click(object sender, EventArgs e)
        {

            string nome = textBox4.Text.Trim();
            string email = textBox5.Text.Trim();
            string senha = textBox6.Text;
            string Confirmarsenha = textBox7.Text;

           if (!nome.All(char.IsLetter))
            {
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "O nome deve conter apenas letras.";
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "Email inválido.";
                return;
            }

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(Confirmarsenha)) 
            {
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "Preencha todos os campos.";
                return;
            }

            if (senha != Confirmarsenha)
            {
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "As senhas não coincidem.";
                return;
            }

            UsuarioRepository repo = new UsuarioRepository(utilsegundojoao.connectionString);
            Usuario novoUsuario = new Usuario
            {

                Nome = nome,
                Email = email,
                Senha = senha
            };

            try
            {
                int linhas = repo.InserirUsuario(novoUsuario);
                if (linhas > 0)
                {
                    lblmessage.ForeColor = Color.Green;
                    lblmessage.Text = "Usuário Cadastrado com Sucesso!";
                    LimparCampos();
                    
                }
                else
                {
                    lblmessage.ForeColor = Color.Red;
                    lblmessage.Text = "Não foi possível cadastrar.";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) 
            { 
              if (ex.Number == 1062)
                lblmessage.ForeColor = Color.Red;
                lblmessage.Text = "Já existe um usuário com este email";            
            }
            catch (Exception ex) 
            { 
                lblmessage.ForeColor= Color.Red;    
                lblmessage.Text = "Erro inesperado";
            }
            void LimparCampos()
            {
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }
        
    }
}