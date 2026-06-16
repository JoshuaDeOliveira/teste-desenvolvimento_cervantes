using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace AplicativoAgendamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AtualizarInfo();

            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
            btnDeletarAgen.Enabled = false;
            btnEditarAgen.Enabled = false;
            DataInicio.MinDate = DateTime.Now;
            DataFinal.MinDate = DateTime.Now;
        }

        /*Cadastro e Visualização de Salas*/

        private string? SalaEditandoId = null;
        private string? AgenEditandoId = null;

        private void SalasView_SelectionChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = SalasView.SelectedRows.Count > 0;
            btnDeletar.Enabled = SalasView.SelectedRows.Count > 0;
        }

        private void CarregarSalas()
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var visualizarsalas = new NpgsqlDataAdapter("SELECT * FROM sala", conexao);
                using var DataTable = new DataTable();
                visualizarsalas.Fill(DataTable);
                SalasView.DataSource = DataTable;
                foreach (DataGridViewColumn coluna in SalasView.Columns)
                {
                    coluna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
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
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();

                var NovoNome = txtNomeSala.Text.Trim();

                if (string.IsNullOrEmpty(SalaEditandoId))
                {
                    using var inserirSala = new NpgsqlCommand("INSERT INTO sala (nome) VALUES (@Nome)", conexao);
                    inserirSala.Parameters.AddWithValue("@Nome", NovoNome);
                    inserirSala.ExecuteNonQuery();
                }
                else
                {
                    using var atualizarSala = new NpgsqlCommand("UPDATE sala SET nome = (@Nome) WHERE id = (@Id)", conexao);
                    atualizarSala.Parameters.AddWithValue("@Nome", NovoNome);
                    atualizarSala.Parameters.AddWithValue("@Id", long.Parse(SalaEditandoId));
                    atualizarSala.ExecuteNonQuery();

                    SalaEditandoId = null;
                    btnSalvar.Text = "Adicionar";
                }
                txtNomeSala.Clear();
                txtNomeSala.Focus();
                AtualizarInfo();
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
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DataGridViewRow infoid = SalasView.SelectedRows[0];

            try
            {
                string SalaId = infoid.Cells["id"].Value.ToString();
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var deletarSala = new NpgsqlCommand("DELETE FROM sala WHERE id = (@Id)", conexao);
                deletarSala.Parameters.AddWithValue("@id", long.Parse(SalaId));

                deletarSala.ExecuteNonQuery();
                txtNomeSala.Clear();
                AtualizarInfo();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow infosala = SalasView.SelectedRows[0];
            string SalaId = infosala.Cells["id"].Value.ToString();
            string SalaNome = infosala.Cells["nome"].Value.ToString();

            txtNomeSala.Text = SalaNome;
            btnSalvar.Text = "Atualizar";
            SalaEditandoId = SalaId;
        }

        /*Cadastro de Agendamentos e Visualização*/

        private void AgenView_SelectionChanged(object sender, EventArgs e)
        {
            btnEditarAgen.Enabled = AgenView.SelectedRows.Count > 0;
            btnDeletarAgen.Enabled = AgenView.SelectedRows.Count > 0;
        }

        private void CarregarAgendamentos()
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var visualizaragendamentos = new NpgsqlDataAdapter("SELECT agendamento.id, agendamento.qual_sala, sala.nome, agendamento.data_inicio,agendamento.data_fim " +
                    "FROM agendamento JOIN sala ON agendamento.qual_sala = sala.id", conexao);
                using var DataTable = new DataTable();
                visualizaragendamentos.Fill(DataTable);
                AgenView.DataSource = DataTable;

                AgenView.Columns["id"].Visible = false;
                AgenView.Columns["qual_sala"].Visible = false;
                AgenView.Columns["nome"].HeaderText = "Sala";
                AgenView.Columns["data_inicio"].HeaderText = "Data/Horario de Início";
                AgenView.Columns["data_fim"].HeaderText = "Data/Horario Final";
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

        private void SalasCadastradas()
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var salascadastradas = new NpgsqlDataAdapter("SELECT id, nome FROM sala", conexao);
                var datatable = new DataTable();
                salascadastradas.Fill(datatable);
                AgenSalas.DisplayMember = "nome";
                AgenSalas.ValueMember = "id";
                AgenSalas.DataSource = datatable;
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

        private void btn_SalvarAgen_Click(object sender, EventArgs e)
        {
            try
            {
                if (AgenSalas.SelectedValue == null || AgenSalas.SelectedValue == DBNull.Value)
                {
                    MessageBox.Show("Cadastre uma sala antes de realizar um agendamento!");
                    return;
                }

                using var conexao = new Database().Conectar();
                conexao.Open();

                var QualSala = AgenSalas.SelectedValue.ToString();
                var AgenInicio = DataInicio.Value;
                var AgenFim = DataFinal.Value;

                if (AgenEditandoId == null)
                {
                    using var NovoAgendamento = new NpgsqlCommand("INSERT INTO agendamento(qual_sala, data_inicio, data_fim) VALUES (@IdSala, @DataInicio, @DataFim)", conexao);
                    NovoAgendamento.Parameters.AddWithValue("@DataInicio", AgenInicio);
                    NovoAgendamento.Parameters.AddWithValue("@DataFim", AgenFim);
                    NovoAgendamento.Parameters.AddWithValue("@IdSala", long.Parse(QualSala));
                    NovoAgendamento.ExecuteNonQuery();
                }
                else
                {

                    using var atualizarAgendamento = new NpgsqlCommand("UPDATE agendamento SET qual_sala = (@IdSala), data_inicio = (@DataInicio), data_fim = (@DataFim) WHERE id = (@Id)", conexao);
                    atualizarAgendamento.Parameters.AddWithValue("@IdSala", long.Parse(QualSala));
                    atualizarAgendamento.Parameters.AddWithValue("@DataInicio", AgenInicio);
                    atualizarAgendamento.Parameters.AddWithValue("@DataFim", AgenFim);
                    atualizarAgendamento.Parameters.AddWithValue("@Id", long.Parse(AgenEditandoId));
                    atualizarAgendamento.ExecuteNonQuery();

                    btn_SalvarAgen.Text = "Adicionar";
                    AgenEditandoId = null;
                }

                AtualizarInfo();
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

        private void btnDeletarAgen_Click(object sender, EventArgs e)
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                var idAgen = AgenView.SelectedRows[0].Cells["id"].Value.ToString();
                using var deletarAgendamento = new NpgsqlCommand("DELETE FROM agendamento WHERE id = (@Id)", conexao);
                deletarAgendamento.Parameters.AddWithValue("@id", long.Parse(idAgen));
                deletarAgendamento.ExecuteNonQuery();

                AtualizarInfo();
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

        private void btnEditarAgen_Click(object sender, EventArgs e)
        {
            DataGridViewRow infoAgen = AgenView.SelectedRows[0];

            btn_SalvarAgen.Text = "Atualizar";
            DataInicio.Value = DateTime.Parse(infoAgen.Cells["data_inicio"].Value.ToString());
            DataFinal.Value = DateTime.Parse(infoAgen.Cells["data_fim"].Value.ToString());
            AgenSalas.SelectedValue = infoAgen.Cells["qual_sala"].Value.ToString();
            AgenEditandoId = infoAgen.Cells["id"].Value.ToString();
        }

        /*Log de Operações*/

        private void CarregarLog()
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var visualizarlogs = new NpgsqlDataAdapter("SELECT * FROM log_operacao", conexao);
                using var DataTable = new DataTable();
                visualizarlogs.Fill(DataTable);
                LogView.DataSource = DataTable;
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

        /*Metodos gerais da Aplicação*/

        private void AtualizarInfo()
        {
            SalasCadastradas();
            CarregarLog();
            CarregarSalas();
            CarregarAgendamentos();
        }
    }
}