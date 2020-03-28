using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel {
    public partial class frmMenu : Form {
        public frmMenu() {
            InitializeComponent();

            // esconde o botão de fechar X que está sobrando
            btnClose.Hide();
        }

        // quando a janela é redimensionada
        private void frmMenu_Resize(object sender, EventArgs e) {
            // remaximiza a janela automaticamente
            this.WindowState = FormWindowState.Maximized;
        }

        // fecha janela com o botão X
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        // logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        // quando carrega o formulário
        private void frmMenu_Load(object sender, EventArgs e) {
            // cor do painel no topo
            pnlTopo.BackColor = Color.FromArgb(213, 213, 213);

            // cor do painel na lateral
            pnlDireita.BackColor = Color.FromArgb(100, 100, 100);
        }

        private void lblData_Click(object sender, EventArgs e) {
            // do nothing
        }

        // clique na guia funcionários
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            // instancia novo
            Cadastros.FrmFuncionarios form = new Cadastros.FrmFuncionarios();

            // mostra formulário
            form.Show();
        }

        // clique na guia cargo
        private void cargoToolStripMenuItem_Click(object sender, EventArgs e) {
            // instancia novo
            Cadastros.FrmCargo form = new Cadastros.FrmCargo();

            // mostra formulário
            form.Show();
        }

        // clique na guia produtos
        private void button1_Click(object sender, EventArgs e) {
            // instancia novo
            FrmProdutos form = new FrmProdutos();

            // mostra formulário
            form.Show();
        }

        // clique em novo produto
        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e) {
            // instancia novo
            FrmProdutos form = new FrmProdutos();

            // mostra formulário
            form.Show();
        }
    }
}
