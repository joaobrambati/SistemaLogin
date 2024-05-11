namespace SistemaLogin {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_Usuario = new System.Windows.Forms.TextBox();
            this.Login_BtnEntrar = new System.Windows.Forms.Button();
            this.Login_BtnFechar = new System.Windows.Forms.PictureBox();
            this.Login_BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.Login_Senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login_CadastroAgora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_OcultarSenha = new System.Windows.Forms.PictureBox();
            this.Login_ExibirSenha = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BtnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_OcultarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_ExibirSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Usuario
            // 
            this.Login_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Login_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Usuario.ForeColor = System.Drawing.Color.Linen;
            this.Login_Usuario.Location = new System.Drawing.Point(339, 69);
            this.Login_Usuario.Name = "Login_Usuario";
            this.Login_Usuario.Size = new System.Drawing.Size(373, 27);
            this.Login_Usuario.TabIndex = 1;
            this.Login_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login_BtnEntrar
            // 
            this.Login_BtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_BtnEntrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BtnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_BtnEntrar.Location = new System.Drawing.Point(339, 215);
            this.Login_BtnEntrar.Name = "Login_BtnEntrar";
            this.Login_BtnEntrar.Size = new System.Drawing.Size(373, 40);
            this.Login_BtnEntrar.TabIndex = 3;
            this.Login_BtnEntrar.Text = "ENTRAR";
            this.Login_BtnEntrar.UseVisualStyleBackColor = true;
            this.Login_BtnEntrar.Click += new System.EventHandler(this.Login_BtnEntrar_Click);
            this.Login_BtnEntrar.MouseLeave += new System.EventHandler(this.Login_BtnEntrar_MouseLeave);
            this.Login_BtnEntrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_BtnEntrar_MouseMove);
            // 
            // Login_BtnFechar
            // 
            this.Login_BtnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_BtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("Login_BtnFechar.Image")));
            this.Login_BtnFechar.Location = new System.Drawing.Point(733, 6);
            this.Login_BtnFechar.Name = "Login_BtnFechar";
            this.Login_BtnFechar.Size = new System.Drawing.Size(50, 25);
            this.Login_BtnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_BtnFechar.TabIndex = 5;
            this.Login_BtnFechar.TabStop = false;
            this.Login_BtnFechar.Click += new System.EventHandler(this.Login_BtnFechar_Click);
            // 
            // Login_BtnMinimizar
            // 
            this.Login_BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("Login_BtnMinimizar.Image")));
            this.Login_BtnMinimizar.Location = new System.Drawing.Point(691, 6);
            this.Login_BtnMinimizar.Name = "Login_BtnMinimizar";
            this.Login_BtnMinimizar.Size = new System.Drawing.Size(50, 25);
            this.Login_BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_BtnMinimizar.TabIndex = 6;
            this.Login_BtnMinimizar.TabStop = false;
            this.Login_BtnMinimizar.Click += new System.EventHandler(this.Login_BtnMinimizar_Click);
            // 
            // Login_Senha
            // 
            this.Login_Senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Login_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login_Senha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Senha.ForeColor = System.Drawing.Color.Linen;
            this.Login_Senha.Location = new System.Drawing.Point(339, 138);
            this.Login_Senha.Name = "Login_Senha";
            this.Login_Senha.PasswordChar = '•';
            this.Login_Senha.Size = new System.Drawing.Size(373, 27);
            this.Login_Senha.TabIndex = 9;
            this.Login_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(397, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Não possui uma conta?";
            // 
            // Login_CadastroAgora
            // 
            this.Login_CadastroAgora.AutoSize = true;
            this.Login_CadastroAgora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_CadastroAgora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_CadastroAgora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Login_CadastroAgora.Location = new System.Drawing.Point(521, 306);
            this.Login_CadastroAgora.Name = "Login_CadastroAgora";
            this.Login_CadastroAgora.Size = new System.Drawing.Size(140, 13);
            this.Login_CadastroAgora.TabIndex = 13;
            this.Login_CadastroAgora.Text = "CADASTRE-SE AGORA";
            this.Login_CadastroAgora.Click += new System.EventHandler(this.Login_CadastroAgora_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(335, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "SENHA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(335, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "USUARIO";
            // 
            // Login_OcultarSenha
            // 
            this.Login_OcultarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_OcultarSenha.Image = ((System.Drawing.Image)(resources.GetObject("Login_OcultarSenha.Image")));
            this.Login_OcultarSenha.Location = new System.Drawing.Point(710, 138);
            this.Login_OcultarSenha.Name = "Login_OcultarSenha";
            this.Login_OcultarSenha.Size = new System.Drawing.Size(50, 27);
            this.Login_OcultarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_OcultarSenha.TabIndex = 16;
            this.Login_OcultarSenha.TabStop = false;
            this.Login_OcultarSenha.Click += new System.EventHandler(this.Login_OcultarSenha_Click);
            // 
            // Login_ExibirSenha
            // 
            this.Login_ExibirSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_ExibirSenha.Image = ((System.Drawing.Image)(resources.GetObject("Login_ExibirSenha.Image")));
            this.Login_ExibirSenha.Location = new System.Drawing.Point(710, 138);
            this.Login_ExibirSenha.Name = "Login_ExibirSenha";
            this.Login_ExibirSenha.Size = new System.Drawing.Size(50, 27);
            this.Login_ExibirSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Login_ExibirSenha.TabIndex = 17;
            this.Login_ExibirSenha.TabStop = false;
            this.Login_ExibirSenha.Click += new System.EventHandler(this.Login_ExibirSenha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.Login_ExibirSenha);
            this.Controls.Add(this.Login_OcultarSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Login_CadastroAgora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_Senha);
            this.Controls.Add(this.Login_BtnMinimizar);
            this.Controls.Add(this.Login_BtnFechar);
            this.Controls.Add(this.Login_BtnEntrar);
            this.Controls.Add(this.Login_Usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BtnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_OcultarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login_ExibirSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Login_Usuario;
        private System.Windows.Forms.Button Login_BtnEntrar;
        private System.Windows.Forms.PictureBox Login_BtnFechar;
        private System.Windows.Forms.PictureBox Login_BtnMinimizar;
        private System.Windows.Forms.TextBox Login_Senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Login_CadastroAgora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Login_OcultarSenha;
        private System.Windows.Forms.PictureBox Login_ExibirSenha;
    }
}

