using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros {
    public partial class FrmCargo : Form {
        public FrmCargo() {
            InitializeComponent();
        }

        // clique no botão novo
        private void btnNovo_Click(object sender, EventArgs e) {
            txtNome.Enabled = true;
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletar.Enabled = false;
            txtNome.Focus();
        }

        // clique no botão salvar
        private void btnSalvar_Click(object sender, EventArgs e) {
            // nome vazio
            if (txtNome.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha o cargo", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            // ao terminar de salvar
            MessageBox.Show("Registro salvo com sucesso", "SALVO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }

        // clique no datagrid
        private void dataGridView1_Click(object sender, EventArgs e) {
            btnEditar.Enabled = true;
            btnDeletar.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Enabled = true;
            txtNome.Focus();
        }

        // clique em editar
        private void btnEditar_Click(object sender, EventArgs e) {
            // nome vazio
            if (txtNome.Text.ToString().Trim() == "") {
                MessageBox.Show("Preencha o cargo", "Campo vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtNome.Focus();
                return;
            }

            // ao terminar de salvar
            MessageBox.Show("Registro editado com sucesso", "SALVO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            txtNome.Text = "";
            txtNome.Enabled = false;
        }

        // clique em excluir
        private void btnDeletar_Click(object sender, EventArgs e) {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Exclusão!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes){
                MessageBox.Show("Registro EXCLUÍDO com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
            }
            else {
                MessageBox.Show("Registro NÃO excluído.");
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                txtNome.Text = "";
                txtNome.Enabled = false;
            }
        }
    }
}
