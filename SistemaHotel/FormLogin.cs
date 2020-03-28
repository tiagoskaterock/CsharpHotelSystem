using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel {
    public partial class frmLogin : Form {
        public frmLogin() {
            InitializeComponent();

            // esconde o painel de login
            pnlLogin.Visible = false;
        }

        // evento disparado quando carrega a tela
        private void frmLogin_Load(object sender, EventArgs e) {
            CentralizaPainel();           

            // deixa o painel visível apenas depois de estar centralizado
            pnlLogin.Visible = true;

            // muda a cor do botão quando o mouse está em cima
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);

            // muda a cor do botão quando o mouse não está em cima
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);

            // teste de início
            // MessageBox.Show("fuck 3");
        }

        // evento disparado ao clicar no botão entrar
        private void btnEntrar_Click(object sender, EventArgs e) {
            // se botão ENTRAR clicado chama método ChamarLogin
            ChamarLogin();
        }

        // evento de tecla clicada
        private void frmLogin_KeyDown(object sender, KeyEventArgs e) {
            // se ENTER pressionada chama método ChamarLogin()
            if (e.KeyCode == Keys.Enter) {
                ChamarLogin();
            }
        }

        // chama a tela Menu e encerra/esconde a janela de login
        private void ChamarLogin() {
            // se usuário estiver em branco
            if (txtUsuario.Text.ToString().Trim() == "") {
                txtUsuario.Text = "";
                MessageBox.Show("Preencha campo usuário", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
                return;
            }

            // se senha estiver em branco
            if (txtSenha.Text.ToString().Trim() == "") {
                txtSenha.Text = "";
                MessageBox.Show("Preencha campo senha", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
                return;
            }

            // AQUI VAI O CÓDIGO PARA O LOGIN
            frmMenu form = new frmMenu();

            // limpa os campos
            limpar();

            // mostra a janela de menu
            form.Show();

            // encerra a janela de login
            // this.Close();

            // esconde a janela de login
            // this.Hide();

        }

        // método que limpa os campos da tela e volta o foco para campo usuário
        private void limpar() {
            txtUsuario.Text = "";
            txtSenha.Text = "";
            txtUsuario.Focus();
        }

        // evento que acontece quando a janela é redimensionada
        private void frmLogin_Resize(object sender, EventArgs e) {
            CentralizaPainel();
        }

        // centraliza o painel
        private void CentralizaPainel() {
            pnlLogin.Location = new Point(
                this.Width / 2 - pnlLogin.Width / 2,
                this.Height / 2 - pnlLogin.Height / 2
            );
        }
    }
}
