using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros {
    public partial class FrmFuncionarios : Form {
        public FrmFuncionarios() {
            InitializeComponent();
            MessageBox.Show("funcionario teste");
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            // do nothing
        }

        // habilita os campos
        private void HabilitarCampos() {
            txtNome.Enabled = true;
            txtApartamento.Enabled = true;
            txtBairro.Enabled = true;
            txtBuscarCPF.Enabled = true;
            txtBuscarNome.Enabled = true;
            txtCEP.Enabled = true;
            txtCidade.Enabled = true;
            txtCPF.Enabled = true;
            txtEmail.Enabled = true;
            txtEstado.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtTelefone.Enabled = true;
            cbCargo.Enabled = true;
        }

        // desabilita os campos
        private void DesabilitarCampos() {
            txtNome.Enabled = false;
            txtApartamento.Enabled = false;
            txtBairro.Enabled = false;
            txtBuscarCPF.Enabled = false;
            txtBuscarNome.Enabled = false;
            txtCEP.Enabled = false;
            txtCidade.Enabled = false;
            txtCPF.Enabled = false;
            txtEmail.Enabled = false;
            txtEstado.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtTelefone.Enabled = false;
            cbCargo.Enabled = false;
        }

        // limpa os campos
        private void LimparCampos() {
            txtNome.Text = "";
            txtApartamento.Text = "";
            txtBairro.Text = "";
            txtBuscarCPF.Text = "";
            txtBuscarNome.Text = "";
            txtCEP.Text = "";
            txtCidade.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtEstado.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtTelefone.Text = "";
        }

        // formulário carregado
        private void FrmFuncionarios_Load(object sender, EventArgs e) {
            // determina que o campo estará marcado assim que o form carrega
            rbNome.Checked = true;
        }

        // clique ou alteração no radio nome
        private void rbNome_CheckedChanged(object sender, EventArgs e) {            
            txtBuscarNome.Visible = true;
            txtBuscarNome.Enabled = true;
            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
            txtBuscarCPF.Visible = false;
            txtBuscarCPF.Enabled = false;
        }

        // clique ou alteração no radio cpf
        private void rbCPF_CheckedChanged(object sender, EventArgs e) {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;
            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
            txtBuscarCPF.Visible = true;
            txtBuscarCPF.Enabled = true;
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
            

            // CPF vazio
            if (txtCPF.Text == "   .   .   -") {
                MessageBox.Show("Preencha campo CPF", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Text = "";
                txtCPF.Focus();
                return;
            }
            

            // email vazio
            if (txtEmail.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo email", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                txtEmail.Focus();
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

        // clique no datagrid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            // do nothing
        }

        // clique no botão editar
        private void btnEditar_Click(object sender, EventArgs e) {
            MessageBox.Show("botão editar clicado");
            // nome vazio
            if (txtNome.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo nome", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }


            // CPF vazio
            if (txtCPF.Text == "   .   .   -") {
                MessageBox.Show("Preencha campo CPF", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Text = "";
                txtCPF.Focus();
                return;
            }


            // email vazio
            if (txtEmail.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha campo email", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            // ao terminar de editar
            MessageBox.Show("Registro editado com sucesso", "Dados editados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            txtNome.Text = "";
            LimparCampos();
            DesabilitarCampos();
            btnSalvar.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            // do nothing
        }

        private void dataGridView1_Click(object sender, EventArgs e) {
            MessageBox.Show("datagrid clicado");
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            HabilitarCampos();
            txtNome.Focus();
        }

        // clique em deletar
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
    }
}
