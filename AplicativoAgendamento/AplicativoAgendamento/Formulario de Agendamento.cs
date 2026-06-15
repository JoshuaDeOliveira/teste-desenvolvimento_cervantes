using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

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
            DataInicio.MinDate = DateTime.Now;
            DataFinal.MinDate = DateTime.Now;
        }

        /*Cadastro e Visualização de Salas*/

        private string? SalaEditandoId = null;

        private void SalasView_SelectionChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = SalasView.SelectedRows.Count > 0;
            btnDeletar.Enabled = SalasView.SelectedRows.Count > 0;
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
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();

                if (string.IsNullOrEmpty(SalaEditandoId))
                {
                    var NovoNome = txtNomeSala.Text.Trim();
                    using var inserirSala = new NpgsqlCommand("INSERT INTO sala (nome) VALUES (@Nome)", conexao);
                    inserirSala.Parameters.AddWithValue("@Nome", NovoNome);
                    inserirSala.ExecuteNonQuery();
                }
                else
                {
                    var NovoNome = txtNomeSala.Text.Trim();
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
            string SalaId = infoid.Cells["id"].Value.ToString();

            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var deletarSala = new NpgsqlCommand("DELETE FROM sala WHERE id = (@Id)", conexao);
                deletarSala.Parameters.AddWithValue("@id", long.Parse(SalaId));

                deletarSala.ExecuteNonQuery();
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
            btnSalvar.Text = "Atualizar Sala";
            SalaEditandoId = SalaId;
        }

        /*Cadastro de Agendamentos e Visualização*/

        public void CarregarAgendamentos()
        {
            try
            {
                using var conexao = new Database().Conectar();
                conexao.Open();
                using var visualizaragendamentos = new NpgsqlDataAdapter("SELECT agendamento.id, sala.nome, agendamento.data_inicio,agendamento.data_fim " +
                    "FROM agendamento JOIN sala ON agendamento.qual_sala = sala.id", conexao);
                using var DataTable = new DataTable();
                visualizaragendamentos.Fill(DataTable);
                AgendamentoView.DataSource = DataTable;
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

        public void SalasCadastradas()
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
            try {
                if (AgenSalas.SelectedValue == null)
                {
                    MessageBox.Show("Cadastre uma sala antes de realizar um agendamento!");
                    return;
                }

                var QualSala = AgenSalas.SelectedValue.ToString();
                var AgenInicio = DataInicio.Value;
                var AgenFim = DataFinal.Value;

                using var conexao = new Database().Conectar();
                conexao.Open();
                using var NovoAgendamento = new NpgsqlCommand("INSERT INTO agendamento(qual_sala, data_inicio, data_fim) VALUES (@IdSala, @DataInicio, @DataFim)", conexao);
                NovoAgendamento.Parameters.AddWithValue("@DataInicio", AgenInicio);
                NovoAgendamento.Parameters.AddWithValue("@DataFim", AgenFim);
                NovoAgendamento.Parameters.AddWithValue("@IdSala", long.Parse(QualSala));
                NovoAgendamento.ExecuteNonQuery();

                AtualizarInfo();
            } catch (NpgsqlException error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {error.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Log de Operações*/

        public void CarregarLog()
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

        public void AtualizarInfo()
        {
            SalasCadastradas();
            CarregarLog();
            CarregarSalas();
            CarregarAgendamentos();
        }
    }
}