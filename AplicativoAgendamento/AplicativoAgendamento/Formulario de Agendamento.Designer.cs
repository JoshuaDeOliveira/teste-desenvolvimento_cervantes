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
            label1 = new Label();
            btnDeletar = new Button();
            btnEditar = new Button();
            NomeDaSala = new Label();
            SalasView = new DataGridView();
            btnSalvar = new Button();
            txtNomeSala = new TextBox();
            tabAgendamento = new TabPage();
            tabLogOperacao = new TabPage();
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
            tabSalas.Controls.Add(label1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(407, 33);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 10;
            label1.Text = "Lista de Salas";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(213, 157);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(62, 34);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(27, 157);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(53, 36);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // NomeDaSala
            // 
            NomeDaSala.AutoSize = true;
            NomeDaSala.Font = new Font("Segoe UI", 12F);
            NomeDaSala.Location = new Point(27, 48);
            NomeDaSala.Name = "NomeDaSala";
            NomeDaSala.Size = new Size(110, 21);
            NomeDaSala.TabIndex = 7;
            NomeDaSala.Text = "Nome da Sala:";
            // 
            // SalasView
            // 
            SalasView.AllowUserToAddRows = false;
            SalasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalasView.Location = new Point(407, 81);
            SalasView.MultiSelect = false;
            SalasView.Name = "SalasView";
            SalasView.Size = new Size(419, 335);
            SalasView.TabIndex = 6;
            SalasView.SelectionChanged += SalasView_SelectionChanged;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(27, 110);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(248, 41);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Adicionar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtNomeSala
            // 
            txtNomeSala.Location = new Point(27, 81);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(248, 23);
            txtNomeSala.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 461);
            Controls.Add(Salas);
            Name = "Form1";
            Text = "Formulario de Agendamento";
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
        private Label label1;
    }
}
