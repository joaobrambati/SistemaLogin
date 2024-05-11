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
    public partial class Form1 : Form {

        SqlConnection conexao = new SqlConnection(@"Data Source=DESKTOP-77B3660\SQLEXPRESS; integrated security=SSPI; initial catalog=SistemaLogin");

        public Form1() {
            InitializeComponent();
        }

        private void Login_BtnFechar_Click (object sender, EventArgs e) {
            Application.Exit();
        }

        private void Login_BtnMinimizar_Click (object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_CadastroAgora_Click (object sender, EventArgs e) {
            Cadastro cadForm = new Cadastro();
            cadForm.Show();
            this.Hide();
        }

        private void Login_BtnEntrar_Click (object sender, EventArgs e) {
            if(Login_Usuario.Text == "" || Login_Senha.Text == "") {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if(conexao.State != ConnectionState.Open) {
                    try {
                        conexao.Open();

                        String selecionarDado = "SELECT * FROM Usuarios WHERE Nome = @Nome AND Senha = @Senha";
                        using (SqlCommand cmd = new SqlCommand(selecionarDado, conexao)) {
                            cmd.Parameters.AddWithValue("@Nome", Login_Usuario.Text.Trim());
                            cmd.Parameters.AddWithValue("@Senha", Login_Senha.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1) {
                                MessageBox.Show("Logado com secesso!", "Logado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Logado logado = new Logado();
                                logado.Show();
                                this.Hide();
                            }
                            else {
                                MessageBox.Show("Usuario ou Senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    } catch(Exception ex){
                        MessageBox.Show("Erro na conexão com o banco de dados",  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } finally {
                        conexao.Close();
                    }
                }
            }
        }

        private void Login_ExibirSenha_Click (object sender, EventArgs e) {
            Login_OcultarSenha.BringToFront();
            Login_Senha.PasswordChar = '\0';
        }

        private void Login_OcultarSenha_Click (object sender, EventArgs e) {
            Login_ExibirSenha.BringToFront();
            Login_Senha.PasswordChar = '•';
        }

        private void Login_BtnEntrar_MouseMove (object sender, MouseEventArgs e) {
            Login_BtnEntrar.BackColor = Color.White;
            Login_BtnEntrar.ForeColor = Color.FromArgb(0, 122, 204);
        }

        private void Login_BtnEntrar_MouseLeave (object sender, EventArgs e) {
            Login_BtnEntrar.BackColor = Color.Black;
            Login_BtnEntrar.ForeColor = Color.White;
        }
    }
}
