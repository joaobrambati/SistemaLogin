using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaLogin {
    public partial class Cadastro : Form {

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-77B3660\SQLEXPRESS; integrated security=SSPI; initial catalog=SistemaLogin");

        public Cadastro () {
            InitializeComponent();
        }

        private void Cadastro_BtnFechar_Click (object sender, EventArgs e) {
            Application.Exit();
        }

        private void Cadastro_BtnMinimizar_Click (object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Cadastro_LoginAqui_Click (object sender, EventArgs e) {
            Form1 lgForm = new Form1();
            lgForm.Show();
            this.Hide();
        }

        private void Cadastro_BtnCadastrar_Click (object sender, EventArgs e) {
            if(Cadastro_Usuario.Text == "" || Cadastro_Senha.Text == "") {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (conexao.State != ConnectionState.Open) {
                    try {
                        conexao.Open();
                        String verificarNomeUsuario = "SELECT * FROM Usuarios WHERE Nome = '"
                            + Cadastro_Usuario.Text.Trim() + "'";

                        using (SqlCommand verificarUsuario = new SqlCommand(verificarNomeUsuario, conexao)) {
                            SqlDataAdapter adapter = new SqlDataAdapter(verificarUsuario);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1) {
                                MessageBox.Show(Cadastro_Usuario+" já existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else {
                                string inserirDados = "INSERT INTO Usuarios (Nome, Senha) " +
                                    "VALUES(@Nome, @Senha)";

                                using (SqlCommand cmd = new SqlCommand(inserirDados, conexao)) {
                                    cmd.Parameters.AddWithValue("@Nome", Cadastro_Usuario.Text.Trim());
                                    cmd.Parameters.AddWithValue("@Senha", Cadastro_Senha.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show($"Cadastrado com sucesso!");

                                    Form1 lgForm = new Form1();
                                    lgForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    } catch(Exception ex) {
                        MessageBox.Show("Erro na conexão com o banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } finally {
                        conexao.Close();
                    }
                }
            
            }
        }

        private void Cadastro_ExibirSenha_Click (object sender, EventArgs e) {
            Cadastro_OcultarSenha.BringToFront();
            Cadastro_Senha.PasswordChar = '\0';
        }

        private void Cadastro_OcultarSenha_Click (object sender, EventArgs e) {
            Cadastro_ExibirSenha.BringToFront();
            Cadastro_Senha.PasswordChar = '•';
        }

        private void Cadastro_BtnCadastrar_MouseLeave (object sender, EventArgs e) {
            Cadastro_BtnCadastrar.BackColor = Color.Black;
            Cadastro_BtnCadastrar.ForeColor = Color.White;
        }

        private void Cadastro_BtnCadastrar_MouseMove (object sender, MouseEventArgs e) {
            Cadastro_BtnCadastrar.BackColor = Color.White;
            Cadastro_BtnCadastrar.ForeColor = Color.FromArgb(0, 122, 204);
        }
    }
}
