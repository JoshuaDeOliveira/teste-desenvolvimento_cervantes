using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AplicativoAgendamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarSalas();

            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
        }

        public void CarregarSalas()
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var visualizarsalas = new NpgsqlDataAdapter("SELECT * FROM sala", conexao);
                using var DataTable = new DataTable();
                visualizarsalas.Fill(DataTable);
                SalasView.DataSource = DataTable;
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var SalaNome = txtNomeSala.Text.Trim();

            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var inserirSala = new NpgsqlCommand("INSERT INTO sala (nome) VALUES (@Nome)", conexao);
                inserirSala.Parameters.AddWithValue("@Nome", SalaNome);
                inserirSala.ExecuteNonQuery();

                txtNomeSala.Clear();
                txtNomeSala.Focus();
                CarregarSalas();
            }
            catch (NpgsqlException error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalasView_SelectionChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = SalasView.SelectedRows.Count > 0;
            btnDeletar.Enabled = SalasView.SelectedRows.Count > 0;
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DataGridViewRow infoid = SalasView.SelectedRows[0];
            string SalaId = infoid.Cells["id"].Value.ToString();

            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var deletarSala = new NpgsqlCommand("DELETE FROM sala WHERE id = (@Id)", conexao);
                deletarSala.Parameters.AddWithValue("@id", int.Parse(SalaId));

                deletarSala.ExecuteNonQuery();
                CarregarSalas();
            } catch (NpgsqlException error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}