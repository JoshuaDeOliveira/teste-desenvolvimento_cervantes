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
            btnDeletarAgen = new Button();
            btnEditarAgen = new Button();
            btn_SalvarAgen = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            DataFinal = new DateTimePicker();
            DataInicio = new DateTimePicker();
            AgenSalas = new ComboBox();
            label2 = new Label();
            AgenView = new DataGridView();
            tabLogOperacao = new TabPage();
            label6 = new Label();
            LogView = new DataGridView();
            Salas.SuspendLayout();
            tabSalas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalasView).BeginInit();
            tabAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgenView).BeginInit();
            tabLogOperacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogView).BeginInit();
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
            label1.Location = new Point(399, 18);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 10;
            label1.Text = "Lista de Salas";
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(213, 159);
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
            NomeDaSala.Location = new Point(27, 57);
            NomeDaSala.Name = "NomeDaSala";
            NomeDaSala.Size = new Size(110, 21);
            NomeDaSala.TabIndex = 7;
            NomeDaSala.Text = "Nome da Sala:";
            // 
            // SalasView
            // 
            SalasView.AllowUserToAddRows = false;
            SalasView.AllowUserToDeleteRows = false;
            SalasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalasView.Location = new Point(399, 57);
            SalasView.MultiSelect = false;
            SalasView.Name = "SalasView";
            SalasView.Size = new Size(433, 370);
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
            tabAgendamento.Controls.Add(btnDeletarAgen);
            tabAgendamento.Controls.Add(btnEditarAgen);
            tabAgendamento.Controls.Add(btn_SalvarAgen);
            tabAgendamento.Controls.Add(label5);
            tabAgendamento.Controls.Add(label4);
            tabAgendamento.Controls.Add(label3);
            tabAgendamento.Controls.Add(DataFinal);
            tabAgendamento.Controls.Add(DataInicio);
            tabAgendamento.Controls.Add(AgenSalas);
            tabAgendamento.Controls.Add(label2);
            tabAgendamento.Controls.Add(AgenView);
            tabAgendamento.Location = new Point(4, 24);
            tabAgendamento.Name = "tabAgendamento";
            tabAgendamento.Padding = new Padding(3);
            tabAgendamento.Size = new Size(849, 441);
            tabAgendamento.TabIndex = 1;
            tabAgendamento.Text = "Agendamentos";
            // 
            // btnDeletarAgen
            // 
            btnDeletarAgen.Location = new Point(22, 248);
            btnDeletarAgen.Name = "btnDeletarAgen";
            btnDeletarAgen.Size = new Size(77, 23);
            btnDeletarAgen.TabIndex = 13;
            btnDeletarAgen.Text = "Deletar";
            btnDeletarAgen.UseVisualStyleBackColor = true;
            btnDeletarAgen.Click += btnDeletarAgen_Click;
            // 
            // btnEditarAgen
            // 
            btnEditarAgen.Location = new Point(115, 248);
            btnEditarAgen.Name = "btnEditarAgen";
            btnEditarAgen.Size = new Size(85, 23);
            btnEditarAgen.TabIndex = 12;
            btnEditarAgen.Text = "Editar";
            btnEditarAgen.UseVisualStyleBackColor = true;
            btnEditarAgen.Click += btnEditarAgen_Click;
            // 
            // btn_SalvarAgen
            // 
            btn_SalvarAgen.Location = new Point(22, 219);
            btn_SalvarAgen.Name = "btn_SalvarAgen";
            btn_SalvarAgen.Size = new Size(178, 23);
            btn_SalvarAgen.TabIndex = 8;
            btn_SalvarAgen.Text = "Salvar";
            btn_SalvarAgen.UseVisualStyleBackColor = true;
            btn_SalvarAgen.Click += btn_SalvarAgen_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 44);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 7;
            label5.Text = "Salas Cadastradas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 109);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Data Inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 163);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Data Final";
            // 
            // DataFinal
            // 
            DataFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            DataFinal.Format = DateTimePickerFormat.Custom;
            DataFinal.Location = new Point(22, 181);
            DataFinal.Name = "DataFinal";
            DataFinal.Size = new Size(178, 23);
            DataFinal.TabIndex = 4;
            // 
            // DataInicio
            // 
            DataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            DataInicio.Format = DateTimePickerFormat.Custom;
            DataInicio.Location = new Point(22, 127);
            DataInicio.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            DataInicio.MinDate = new DateTime(2026, 6, 15, 0, 0, 0, 0);
            DataInicio.Name = "DataInicio";
            DataInicio.Size = new Size(178, 23);
            DataInicio.TabIndex = 3;
            // 
            // AgenSalas
            // 
            AgenSalas.DropDownStyle = ComboBoxStyle.DropDownList;
            AgenSalas.FormattingEnabled = true;
            AgenSalas.Location = new Point(22, 72);
            AgenSalas.Name = "AgenSalas";
            AgenSalas.Size = new Size(121, 23);
            AgenSalas.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 44);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 1;
            label2.Text = "Lista de Agendamentos";
            // 
            // AgenView
            // 
            AgenView.AllowUserToAddRows = false;
            AgenView.AllowUserToDeleteRows = false;
            AgenView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AgenView.Location = new Point(370, 72);
            AgenView.Name = "AgenView";
            AgenView.ReadOnly = true;
            AgenView.Size = new Size(462, 355);
            AgenView.TabIndex = 0;
            AgenView.SelectionChanged += AgenView_SelectionChanged;
            // 
            // tabLogOperacao
            // 
            tabLogOperacao.BackColor = Color.DarkGray;
            tabLogOperacao.Controls.Add(label6);
            tabLogOperacao.Controls.Add(LogView);
            tabLogOperacao.Location = new Point(4, 24);
            tabLogOperacao.Name = "tabLogOperacao";
            tabLogOperacao.Padding = new Padding(3);
            tabLogOperacao.Size = new Size(849, 441);
            tabLogOperacao.TabIndex = 2;
            tabLogOperacao.Text = "Log de Operações (Admin)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 1;
            label6.Text = "Log de Operações";
            // 
            // LogView
            // 
            LogView.AllowUserToAddRows = false;
            LogView.AllowUserToDeleteRows = false;
            LogView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogView.Location = new Point(6, 56);
            LogView.Name = "LogView";
            LogView.ReadOnly = true;
            LogView.Size = new Size(834, 371);
            LogView.TabIndex = 0;
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
            tabAgendamento.ResumeLayout(false);
            tabAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AgenView).EndInit();
            tabLogOperacao.ResumeLayout(false);
            tabLogOperacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogView).EndInit();
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
        private Button btn_SalvarAgen;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker DataFinal;
        private DateTimePicker DataInicio;
        private ComboBox AgenSalas;
        private Label label2;
        private DataGridView AgenView;
        private Label label6;
        private DataGridView LogView;
        private Button btnDeletarAgen;
        private Button btnEditarAgen;
    }
}
