using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();

            // esconde o formulário do login
            pnlLogin.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e) {
            // centraliza o panel
            pnlLogin.Location = new Point(
                this.Width / 2 - pnlLogin.Width / 2,
                this.Height / 2 - pnlLogin.Height / 2
            );

            // mostra o formulário de login
            pnlLogin.Visible = true;

            // muda a cor do botão
            btnEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);
            btnEntrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(8, 72, 103);
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            // usuário em branco
            if (txtUsuario.Text == "") {
                MessageBox.Show("Preencha campo usuário");
                txtUsuario.Focus();
                return;
            }

            // senha em branco
            if (txtSenha.Text == "") {
                MessageBox.Show("Preencha campo senha");
                txtSenha.Focus();
                return;
            }

            // Código para o login
            // Continua apenas se usuário e senha estiverem OK
            FrmMenu form = new FrmMenu();

            // mostra formulário
            form.Show();

            // encerra a janela de login
            this.Hide();
        }

        // quando uma tecla é pressionada
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e) {
            MessageBox.Show("Fuck");
        }
    }
}
