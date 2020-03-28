using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel {
    public partial class FrmProdutos : Form {
        public FrmProdutos() {
            InitializeComponent();
        }

        // habilita os campos
        private void HabilitarCampos() {
            txtNome.Enabled = true;
            txtDescricao.Enabled = true;
            txtEstoque.Enabled = true;
            txtValor.Enabled = true;
            cbFornecedor.Enabled = true;
            txtNome.Focus();
            btnImg.Enabled = true;
        }

        // desabilita os campos
        private void DesabilitarCampos() {
            txtNome.Enabled = false;
            txtDescricao.Enabled = false;
            txtEstoque.Enabled = false;
            txtValor.Enabled = false;
            cbFornecedor.Enabled = false;
            btnImg.Enabled = false;
        }

        // limpa os campos
        private void LimparCampos() {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtEstoque.Text = "";
            txtValor.Text = "";
            cbFornecedor.Text = "";
            txtNome.Focus();
            limparFoto();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e) {
            // do nothing
        }

        private void label12_Click(object sender, EventArgs e) {
            // do nothing
        }

        private void label1_Click(object sender, EventArgs e) {
            // do nothing
        }

        // limpa a foto
        private void limparFoto() {
            img.Image = Properties.Resources.sem_foto;
        }

        // carregado formulário de produtos
        private void FrmProdutos_Load(object sender, EventArgs e) {
            limparFoto();
        }

        // clique no botão novo
        private void btnNovo_Click(object sender, EventArgs e) {
            HabilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        // clique no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e) {
            // nome vazio
            if (txtNome.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo nome", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }


            // valor vazio
            if (txtValor.Text == "") {
                MessageBox.Show("Preencha campo valor", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }


            // descrição vazio
            if (txtDescricao.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo descrição", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return;
            }

            // ao terminar de salvar
            MessageBox.Show("Registro salvo com sucesso", "SALVO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            LimparCampos();
            DesabilitarCampos();
        }

        // clique no botão editar
        private void btnEditar_Click(object sender, EventArgs e) {
            // nome vazio
            if (txtNome.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo nome", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }


            // valor vazio
            if (txtValor.Text == "") {
                MessageBox.Show("Preencha campo valor", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValor.Text = "";
                txtValor.Focus();
                return;
            }


            // descrição vazio
            if (txtDescricao.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo descrição", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescricao.Text = "";
                txtDescricao.Focus();
                return;
            }

            // ao terminar de editar
            MessageBox.Show("Registro editado com sucesso", "EDITADO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnDeletar.Enabled = false;
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnDeletar_Click(object sender, EventArgs e) {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) {
                MessageBox.Show("Registro EXCLUÍDO com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
                LimparCampos();
            }
            else {
                MessageBox.Show("Registro NÃO excluído.");
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
                LimparCampos();
            }
        }

        private void btnImg_Click(object sender, EventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Imagens(*.jpg, *.png)|*.jpg;*.png|Todos os arquivos(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK) {

            }
        }
    }
}
