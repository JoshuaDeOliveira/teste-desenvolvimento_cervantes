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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            Salas = new TabControl();
            tabSalas = new TabPage();
            groupBox2 = new GroupBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnDeletar = new Button();
            groupBox1 = new GroupBox();
            NomeDaSala = new Label();
            txtNomeSala = new TextBox();
            label7 = new Label();
            label1 = new Label();
            SalasView = new DataGridView();
            tabAgendamento = new TabPage();
            groupBox5 = new GroupBox();
            DataF = new Label();
            DataFinal = new DateTimePicker();
            groupBox6 = new GroupBox();
            label5 = new Label();
            AgenSalas = new ComboBox();
            groupBox4 = new GroupBox();
            label3 = new Label();
            DataInicio = new DateTimePicker();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btn_DeletarAgen = new Button();
            btn_EditarAgen = new Button();
            btn_SalvarAgen = new Button();
            label8 = new Label();
            AgenView = new DataGridView();
            tabLogOperacao = new TabPage();
            LogView = new DataGridView();
            label6 = new Label();
            Salas.SuspendLayout();
            tabSalas.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalasView).BeginInit();
            tabAgendamento.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
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
            Salas.Dock = DockStyle.Fill;
            Salas.Location = new Point(0, 0);
            Salas.Name = "Salas";
            Salas.SelectedIndex = 0;
            Salas.Size = new Size(844, 458);
            Salas.SizeMode = TabSizeMode.FillToRight;
            Salas.TabIndex = 0;
            // 
            // tabSalas
            // 
            tabSalas.BackColor = Color.LightGray;
            tabSalas.Controls.Add(groupBox2);
            tabSalas.Controls.Add(groupBox1);
            tabSalas.Controls.Add(label7);
            tabSalas.Controls.Add(label1);
            tabSalas.Controls.Add(SalasView);
            tabSalas.Location = new Point(4, 24);
            tabSalas.Name = "tabSalas";
            tabSalas.Padding = new Padding(3);
            tabSalas.Size = new Size(836, 430);
            tabSalas.TabIndex = 0;
            tabSalas.Text = "Salas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(btnEditar);
            groupBox2.Controls.Add(btnDeletar);
            groupBox2.Location = new Point(9, 116);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 69);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(6, 22);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(148, 40);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Adicionar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ControlText;
            btnEditar.Location = new Point(249, 22);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(83, 40);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.White;
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(160, 22);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(83, 40);
            btnDeletar.TabIndex = 9;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(NomeDaSala);
            groupBox1.Controls.Add(txtNomeSala);
            groupBox1.Location = new Point(9, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 61);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // NomeDaSala
            // 
            NomeDaSala.AutoSize = true;
            NomeDaSala.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NomeDaSala.Location = new Point(6, 20);
            NomeDaSala.Name = "NomeDaSala";
            NomeDaSala.Size = new Size(55, 21);
            NomeDaSala.TabIndex = 7;
            NomeDaSala.Text = "Nome";
            // 
            // txtNomeSala
            // 
            txtNomeSala.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeSala.Location = new Point(67, 18);
            txtNomeSala.Name = "txtNomeSala";
            txtNomeSala.Size = new Size(247, 27);
            txtNomeSala.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.Location = new Point(6, 14);
            label7.Name = "label7";
            label7.Size = new Size(214, 32);
            label7.TabIndex = 11;
            label7.Text = "Cadastro de Salas";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(396, 14);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 32);
            label1.TabIndex = 10;
            label1.Text = "Lista de Salas Cadastradas";
            // 
            // SalasView
            // 
            SalasView.AllowUserToAddRows = false;
            SalasView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = Color.WhiteSmoke;
            SalasView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            SalasView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalasView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SalasView.BackgroundColor = SystemColors.Control;
            SalasView.BorderStyle = BorderStyle.None;
            SalasView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.Padding = new Padding(1);
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            SalasView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            SalasView.ColumnHeadersHeight = 30;
            SalasView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = SystemColors.Window;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle19.Padding = new Padding(1);
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            SalasView.DefaultCellStyle = dataGridViewCellStyle19;
            SalasView.GridColor = SystemColors.ControlLight;
            SalasView.Location = new Point(396, 49);
            SalasView.MultiSelect = false;
            SalasView.Name = "SalasView";
            SalasView.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = SystemColors.Control;
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            SalasView.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            SalasView.RowHeadersVisible = false;
            SalasView.RowTemplate.Height = 40;
            SalasView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SalasView.Size = new Size(430, 373);
            SalasView.TabIndex = 6;
            SalasView.SelectionChanged += SalasView_SelectionChanged;
            // 
            // tabAgendamento
            // 
            tabAgendamento.BackColor = Color.LightGray;
            tabAgendamento.Controls.Add(groupBox5);
            tabAgendamento.Controls.Add(groupBox6);
            tabAgendamento.Controls.Add(groupBox4);
            tabAgendamento.Controls.Add(label2);
            tabAgendamento.Controls.Add(groupBox3);
            tabAgendamento.Controls.Add(label8);
            tabAgendamento.Controls.Add(AgenView);
            tabAgendamento.Location = new Point(4, 24);
            tabAgendamento.Name = "tabAgendamento";
            tabAgendamento.Padding = new Padding(3);
            tabAgendamento.Size = new Size(836, 430);
            tabAgendamento.TabIndex = 1;
            tabAgendamento.Text = "Agendamentos";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(DataF);
            groupBox5.Controls.Add(DataFinal);
            groupBox5.Location = new Point(8, 193);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(326, 57);
            groupBox5.TabIndex = 19;
            groupBox5.TabStop = false;
            // 
            // DataF
            // 
            DataF.AutoSize = true;
            DataF.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataF.Location = new Point(6, 18);
            DataF.Name = "DataF";
            DataF.Size = new Size(80, 21);
            DataF.TabIndex = 18;
            DataF.Text = "Data Final";
            // 
            // DataFinal
            // 
            DataFinal.CustomFormat = "dd/MM/yyyy HH:mm";
            DataFinal.Font = new Font("Segoe UI", 11F);
            DataFinal.Format = DateTimePickerFormat.Custom;
            DataFinal.Location = new Point(99, 18);
            DataFinal.Name = "DataFinal";
            DataFinal.Size = new Size(203, 27);
            DataFinal.TabIndex = 4;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(AgenSalas);
            groupBox6.Location = new Point(8, 44);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(326, 57);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(46, 21);
            label5.TabIndex = 18;
            label5.Text = "Salas";
            // 
            // AgenSalas
            // 
            AgenSalas.DropDownStyle = ComboBoxStyle.DropDownList;
            AgenSalas.Font = new Font("Segoe UI", 11F);
            AgenSalas.FormattingEnabled = true;
            AgenSalas.Location = new Point(58, 19);
            AgenSalas.Name = "AgenSalas";
            AgenSalas.Size = new Size(244, 28);
            AgenSalas.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(DataInicio);
            groupBox4.Location = new Point(6, 120);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(328, 57);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 18;
            label3.Text = "Data Inicial";
            // 
            // DataInicio
            // 
            DataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            DataInicio.Font = new Font("Segoe UI", 11F);
            DataInicio.Format = DateTimePickerFormat.Custom;
            DataInicio.Location = new Point(101, 19);
            DataInicio.MaxDate = new DateTime(3000, 12, 31, 0, 0, 0, 0);
            DataInicio.MinDate = new DateTime(2026, 6, 15, 0, 0, 0, 0);
            DataInicio.Name = "DataInicio";
            DataInicio.Size = new Size(203, 27);
            DataInicio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(308, 31);
            label2.TabIndex = 17;
            label2.Text = "Cadastro de Agendamentos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_DeletarAgen);
            groupBox3.Controls.Add(btn_EditarAgen);
            groupBox3.Controls.Add(btn_SalvarAgen);
            groupBox3.Location = new Point(8, 256);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 70);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            // 
            // btn_DeletarAgen
            // 
            btn_DeletarAgen.Cursor = Cursors.Hand;
            btn_DeletarAgen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_DeletarAgen.Location = new Point(133, 15);
            btn_DeletarAgen.Name = "btn_DeletarAgen";
            btn_DeletarAgen.Size = new Size(84, 42);
            btn_DeletarAgen.TabIndex = 13;
            btn_DeletarAgen.Text = "Deletar";
            btn_DeletarAgen.UseVisualStyleBackColor = true;
            btn_DeletarAgen.Click += btn_DeletarAgen_Click;
            // 
            // btn_EditarAgen
            // 
            btn_EditarAgen.Cursor = Cursors.Hand;
            btn_EditarAgen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_EditarAgen.Location = new Point(223, 15);
            btn_EditarAgen.Name = "btn_EditarAgen";
            btn_EditarAgen.Size = new Size(85, 42);
            btn_EditarAgen.TabIndex = 12;
            btn_EditarAgen.Text = "Editar";
            btn_EditarAgen.UseVisualStyleBackColor = true;
            btn_EditarAgen.Click += btn_EditarAgen_Click;
            // 
            // btn_SalvarAgen
            // 
            btn_SalvarAgen.Cursor = Cursors.Hand;
            btn_SalvarAgen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_SalvarAgen.Location = new Point(4, 15);
            btn_SalvarAgen.Name = "btn_SalvarAgen";
            btn_SalvarAgen.Size = new Size(123, 42);
            btn_SalvarAgen.TabIndex = 8;
            btn_SalvarAgen.Text = "Salvar";
            btn_SalvarAgen.UseVisualStyleBackColor = true;
            btn_SalvarAgen.Click += btn_SalvarAgen_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(349, 9);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(256, 31);
            label8.TabIndex = 15;
            label8.Text = "Lista de Agendamentos";
            // 
            // AgenView
            // 
            AgenView.AllowUserToAddRows = false;
            AgenView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = Color.WhiteSmoke;
            AgenView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            AgenView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AgenView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AgenView.BackgroundColor = SystemColors.Control;
            AgenView.BorderStyle = BorderStyle.None;
            AgenView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new Padding(1);
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            AgenView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            AgenView.ColumnHeadersHeight = 30;
            AgenView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Window;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle15.Padding = new Padding(1);
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            AgenView.DefaultCellStyle = dataGridViewCellStyle15;
            AgenView.GridColor = SystemColors.ControlLight;
            AgenView.Location = new Point(349, 44);
            AgenView.MultiSelect = false;
            AgenView.Name = "AgenView";
            AgenView.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            AgenView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            AgenView.RowHeadersVisible = false;
            AgenView.RowTemplate.Height = 30;
            AgenView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AgenView.Size = new Size(479, 378);
            AgenView.TabIndex = 14;
            AgenView.SelectionChanged += AgenView_SelectionChanged;
            // 
            // tabLogOperacao
            // 
            tabLogOperacao.BackColor = Color.LightGray;
            tabLogOperacao.Controls.Add(LogView);
            tabLogOperacao.Controls.Add(label6);
            tabLogOperacao.Location = new Point(4, 24);
            tabLogOperacao.Name = "tabLogOperacao";
            tabLogOperacao.Padding = new Padding(3);
            tabLogOperacao.Size = new Size(836, 430);
            tabLogOperacao.TabIndex = 2;
            tabLogOperacao.Text = "Log de Operações (Admin)";
            // 
            // LogView
            // 
            LogView.AllowUserToAddRows = false;
            LogView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = Color.WhiteSmoke;
            LogView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            LogView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LogView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LogView.BackgroundColor = SystemColors.Control;
            LogView.BorderStyle = BorderStyle.None;
            LogView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle22.Padding = new Padding(1);
            dataGridViewCellStyle22.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
            LogView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            LogView.ColumnHeadersHeight = 30;
            LogView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = SystemColors.Window;
            dataGridViewCellStyle23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle23.Padding = new Padding(1);
            dataGridViewCellStyle23.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
            LogView.DefaultCellStyle = dataGridViewCellStyle23;
            LogView.GridColor = SystemColors.ControlLight;
            LogView.Location = new Point(8, 51);
            LogView.MultiSelect = false;
            LogView.Name = "LogView";
            LogView.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = SystemColors.Control;
            dataGridViewCellStyle24.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
            LogView.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            LogView.RowHeadersVisible = false;
            LogView.RowTemplate.Height = 30;
            LogView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LogView.Size = new Size(822, 371);
            LogView.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(8, 13);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(218, 32);
            label6.TabIndex = 1;
            label6.Text = "Log de Operações";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(844, 458);
            Controls.Add(Salas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Sistema de Agendamento";
            Salas.ResumeLayout(false);
            tabSalas.ResumeLayout(false);
            tabSalas.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalasView).EndInit();
            tabAgendamento.ResumeLayout(false);
            tabAgendamento.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
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
        private DateTimePicker DataFinal;
        private DateTimePicker DataInicio;
        private ComboBox AgenSalas;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView AgenView;
        private DataGridView LogView;
        private Label label8;
        private Label label2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Button btn_DeletarAgen;
        private Button btn_EditarAgen;
        private Button btn_SalvarAgen;
        private GroupBox groupBox5;
        private Label DataF;
        private GroupBox groupBox6;
        private Label label5;
        private Label label3;
    }
}
