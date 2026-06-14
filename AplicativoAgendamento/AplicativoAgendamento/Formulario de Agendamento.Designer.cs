namespace AplicativoAgendamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Salas = new TabControl();
            tabSalas = new TabPage();
            tabAgendamento = new TabPage();
            tabLogOperacao = new TabPage();
            txtNomeSala = new TextBox();
            btnSalvar = new Button();
            SalasView = new DataGridView();
            NomeDaSala = new Label();
            btnEditar = new Button();
            btnDeletar = new Button();
            Salas.SuspendLayout();
            tabSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalasView).BeginInit();
            SuspendLayout();
            // 
            // Salas
            // 
            Salas.Controls.Add(tabSalas);
            Salas.Controls.Add(tabAgendamento);
            Salas.Controls.Add(tabLogOperacao);
            Salas.Location = new Point(-3, -2);
            Salas.Name = "Salas";
            Salas.SelectedIndex = 0;
            Salas.Size = new Size(854, 469);
            Salas.TabIndex = 0;
            // 
            // tabSalas
            // 
            tabSalas.BackColor = Color.DarkGray;
            tabSalas.Controls.Add(btnDeletar);
            tabSalas.Controls.Add(btnEditar);
            tabSalas.Controls.Add(NomeDaSala);
            tabSalas.Controls.Add(SalasView);
            tabSalas.Controls.Add(btnSalvar);
            tabSalas.Controls.Add(txtNomeSala);
            tabSalas.Location = new Point(4, 24);
            tabSalas.Name = "tabSalas";
            tabSalas.Padding = new Padding(3);
            tabSalas.Size = new Size(846, 441);
            tabSalas.TabIndex = 0;
            tabSalas.Text = "Salas";
            // 
            // tabAgendamento
            // 
            tabAgendamento.BackColor = Color.DarkGray;
            tabAgendamento.Location = new Point(4, 24);
            tabAgendamento.Name = "tabAgendamento";
            tabAgendamento.Padding = new Padding(3);
            tabAgendamento.Size = new Size(846, 441);
            tabAgendamento.TabIndex = 1;
            tabAgendamento.Text = "Agendamentos";
            // 
            // tabLogOperacao
            // 
            tabLogOperacao.BackColor = Color.DarkGray;
            tabLogOperacao.Location = new Point(4, 24);
            tabLogOperacao.Name = "tabLogOperacao";
            tabLogOperacao.Padding = new Padding(3);
            tabLogOperacao.Size = new Size(846, 441);
            tabLogOperacao.TabIndex = 2;
            tabLogOperacao.Text = "Log de Operações (Admin)";
            // 
            // txtNomeSala
            // 
            txtNomeSala.Location = new Point(89, 12);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(248, 23);
            txtNomeSala.TabIndex = 0;
            txtNomeSala.TextChanged += textBox1_TextChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(3, 41);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 23);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // SalasView
            // 
            SalasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalasView.Location = new Point(3, 70);
            SalasView.Name = "SalasView";
            SalasView.Size = new Size(840, 368);
            SalasView.TabIndex = 6;
            // 
            // NomeDaSala
            // 
            NomeDaSala.AutoSize = true;
            NomeDaSala.Location = new Point(6, 15);
            NomeDaSala.Name = "NomeDaSala";
            NomeDaSala.Size = new Size(80, 15);
            NomeDaSala.TabIndex = 7;
            NomeDaSala.Text = "Nome da Sala";
            NomeDaSala.Click += label1_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(114, 41);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(228, 41);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(108, 23);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 464);
            Controls.Add(Salas);
            Name = "Form1";
            Text = "Form1";
            Salas.ResumeLayout(false);
            tabSalas.ResumeLayout(false);
            tabSalas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalasView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Salas;
        private TabPage tabSalas;
        private TabPage tabAgendamento;
        private TabPage tabLogOperacao;
        private TextBox txtNomeSala;
        private DataGridView SalasView;
        private Button btnSalvar;
        private Label NomeDaSala;
        private Button btnDeletar;
        private Button btnEditar;
    }
}
