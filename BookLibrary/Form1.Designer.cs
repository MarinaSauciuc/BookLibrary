namespace BookLibrary
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabControl Biblioteca;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Romance = new System.Windows.Forms.TabPage();
            this.RomanceGrid = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mystery = new System.Windows.Forms.TabPage();
            this.MysteryGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SF = new System.Windows.Forms.TabPage();
            this.SFGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Psychology = new System.Windows.Forms.TabPage();
            this.PsychologyGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Adventure = new System.Windows.Forms.TabPage();
            this.AdventureGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Other = new System.Windows.Forms.TabPage();
            this.OtherGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.Alright = new System.Windows.Forms.Button();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.CAUTARE = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.CheckBox();
            this.Counter = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SearchResultBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            Biblioteca = new System.Windows.Forms.TabControl();
            Biblioteca.SuspendLayout();
            this.Romance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RomanceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.Mystery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MysteryGrid)).BeginInit();
            this.SF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFGrid)).BeginInit();
            this.Psychology.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PsychologyGrid)).BeginInit();
            this.Adventure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdventureGrid)).BeginInit();
            this.Other.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Biblioteca
            // 
            Biblioteca.Controls.Add(this.Romance);
            Biblioteca.Controls.Add(this.Mystery);
            Biblioteca.Controls.Add(this.SF);
            Biblioteca.Controls.Add(this.Psychology);
            Biblioteca.Controls.Add(this.Adventure);
            Biblioteca.Controls.Add(this.Other);
            Biblioteca.Cursor = System.Windows.Forms.Cursors.Hand;
            Biblioteca.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Biblioteca.ItemSize = new System.Drawing.Size(100, 22);
            Biblioteca.Location = new System.Drawing.Point(713, 90);
            Biblioteca.Name = "Biblioteca";
            Biblioteca.SelectedIndex = 0;
            Biblioteca.Size = new System.Drawing.Size(559, 437);
            Biblioteca.TabIndex = 99;
            // 
            // Romance
            // 
            this.Romance.BackColor = System.Drawing.Color.Black;
            this.Romance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Romance.Controls.Add(this.RomanceGrid);
            this.Romance.ForeColor = System.Drawing.Color.Black;
            this.Romance.Location = new System.Drawing.Point(4, 26);
            this.Romance.Name = "Romance";
            this.Romance.Padding = new System.Windows.Forms.Padding(3);
            this.Romance.Size = new System.Drawing.Size(551, 407);
            this.Romance.TabIndex = 0;
            this.Romance.Text = "Romance";
            this.Romance.Click += new System.EventHandler(this.Romance_Click);
            // 
            // RomanceGrid
            // 
            this.RomanceGrid.AutoGenerateColumns = false;
            this.RomanceGrid.BackgroundColor = System.Drawing.Color.Black;
            this.RomanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RomanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.authorDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.RomanceGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RomanceGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.RomanceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomanceGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RomanceGrid.Location = new System.Drawing.Point(3, 3);
            this.RomanceGrid.Name = "RomanceGrid";
            this.RomanceGrid.RowHeadersWidth = 51;
            this.RomanceGrid.RowTemplate.Height = 29;
            this.RomanceGrid.Size = new System.Drawing.Size(541, 397);
            this.RomanceGrid.TabIndex = 98;
            this.RomanceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Title
            // 
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Read";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Entities.Book);
            // 
            // Mystery
            // 
            this.Mystery.BackColor = System.Drawing.Color.Black;
            this.Mystery.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Mystery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Mystery.Controls.Add(this.MysteryGrid);
            this.Mystery.ForeColor = System.Drawing.Color.Black;
            this.Mystery.Location = new System.Drawing.Point(4, 26);
            this.Mystery.Name = "Mystery";
            this.Mystery.Padding = new System.Windows.Forms.Padding(3);
            this.Mystery.Size = new System.Drawing.Size(551, 407);
            this.Mystery.TabIndex = 1;
            this.Mystery.Text = "Mystery";
            // 
            // MysteryGrid
            // 
            this.MysteryGrid.AutoGenerateColumns = false;
            this.MysteryGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MysteryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MysteryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.MysteryGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MysteryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MysteryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MysteryGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MysteryGrid.Location = new System.Drawing.Point(3, 3);
            this.MysteryGrid.Name = "MysteryGrid";
            this.MysteryGrid.RowHeadersWidth = 51;
            this.MysteryGrid.RowTemplate.Height = 29;
            this.MysteryGrid.Size = new System.Drawing.Size(541, 397);
            this.MysteryGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn2.HeaderText = "Author";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // SF
            // 
            this.SF.AutoScroll = true;
            this.SF.BackColor = System.Drawing.Color.Black;
            this.SF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SF.Controls.Add(this.SFGrid);
            this.SF.ForeColor = System.Drawing.Color.Black;
            this.SF.Location = new System.Drawing.Point(4, 26);
            this.SF.Name = "SF";
            this.SF.Padding = new System.Windows.Forms.Padding(3);
            this.SF.Size = new System.Drawing.Size(551, 407);
            this.SF.TabIndex = 2;
            this.SF.Text = "SF";
            // 
            // SFGrid
            // 
            this.SFGrid.AutoGenerateColumns = false;
            this.SFGrid.BackgroundColor = System.Drawing.Color.Black;
            this.SFGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SFGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn2});
            this.SFGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SFGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.SFGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SFGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SFGrid.Location = new System.Drawing.Point(3, 3);
            this.SFGrid.Name = "SFGrid";
            this.SFGrid.RowHeadersWidth = 51;
            this.SFGrid.RowTemplate.Height = 29;
            this.SFGrid.Size = new System.Drawing.Size(541, 397);
            this.SFGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn4.HeaderText = "Title";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn5.HeaderText = "Author";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn2.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 125;
            // 
            // Psychology
            // 
            this.Psychology.BackColor = System.Drawing.Color.Black;
            this.Psychology.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Psychology.Controls.Add(this.PsychologyGrid);
            this.Psychology.ForeColor = System.Drawing.Color.Black;
            this.Psychology.Location = new System.Drawing.Point(4, 26);
            this.Psychology.Name = "Psychology";
            this.Psychology.Padding = new System.Windows.Forms.Padding(3);
            this.Psychology.Size = new System.Drawing.Size(551, 407);
            this.Psychology.TabIndex = 3;
            this.Psychology.Text = "Psychology";
            // 
            // PsychologyGrid
            // 
            this.PsychologyGrid.AutoGenerateColumns = false;
            this.PsychologyGrid.BackgroundColor = System.Drawing.Color.Black;
            this.PsychologyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PsychologyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewCheckBoxColumn3});
            this.PsychologyGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PsychologyGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.PsychologyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PsychologyGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PsychologyGrid.Location = new System.Drawing.Point(3, 3);
            this.PsychologyGrid.Name = "PsychologyGrid";
            this.PsychologyGrid.RowHeadersWidth = 51;
            this.PsychologyGrid.RowTemplate.Height = 29;
            this.PsychologyGrid.Size = new System.Drawing.Size(541, 397);
            this.PsychologyGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn7.HeaderText = "Title";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn8.HeaderText = "Author";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn9.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn3.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 125;
            // 
            // Adventure
            // 
            this.Adventure.BackColor = System.Drawing.Color.Black;
            this.Adventure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Adventure.Controls.Add(this.AdventureGrid);
            this.Adventure.ForeColor = System.Drawing.Color.Black;
            this.Adventure.Location = new System.Drawing.Point(4, 26);
            this.Adventure.Name = "Adventure";
            this.Adventure.Padding = new System.Windows.Forms.Padding(3);
            this.Adventure.Size = new System.Drawing.Size(551, 407);
            this.Adventure.TabIndex = 4;
            this.Adventure.Text = "Adventure";
            // 
            // AdventureGrid
            // 
            this.AdventureGrid.AutoGenerateColumns = false;
            this.AdventureGrid.BackgroundColor = System.Drawing.Color.Black;
            this.AdventureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdventureGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn4});
            this.AdventureGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdventureGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.AdventureGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdventureGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdventureGrid.Location = new System.Drawing.Point(3, 3);
            this.AdventureGrid.Name = "AdventureGrid";
            this.AdventureGrid.RowHeadersWidth = 51;
            this.AdventureGrid.RowTemplate.Height = 29;
            this.AdventureGrid.Size = new System.Drawing.Size(541, 397);
            this.AdventureGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Title";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn11.HeaderText = "Author";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn4.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 125;
            // 
            // Other
            // 
            this.Other.BackColor = System.Drawing.Color.Black;
            this.Other.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Other.Controls.Add(this.OtherGrid);
            this.Other.ForeColor = System.Drawing.Color.Black;
            this.Other.Location = new System.Drawing.Point(4, 26);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(551, 407);
            this.Other.TabIndex = 5;
            this.Other.Text = "Other";
            // 
            // OtherGrid
            // 
            this.OtherGrid.AutoGenerateColumns = false;
            this.OtherGrid.BackgroundColor = System.Drawing.Color.Black;
            this.OtherGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewCheckBoxColumn5});
            this.OtherGrid.DataSource = this.bookBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OtherGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OtherGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OtherGrid.Location = new System.Drawing.Point(3, 3);
            this.OtherGrid.Name = "OtherGrid";
            this.OtherGrid.RowHeadersWidth = 51;
            this.OtherGrid.RowTemplate.Height = 29;
            this.OtherGrid.Size = new System.Drawing.Size(541, 403);
            this.OtherGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn13.HeaderText = "Title";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "author";
            this.dataGridViewTextBoxColumn14.HeaderText = "Author";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "genre";
            this.dataGridViewTextBoxColumn15.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "status";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn5.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 125;
            // 
            // AuthorBox
            // 
            this.AuthorBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AuthorBox.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AuthorBox.ForeColor = System.Drawing.Color.Black;
            this.AuthorBox.Location = new System.Drawing.Point(163, 437);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(511, 30);
            this.AuthorBox.TabIndex = 3;
            // 
            // GenreBox
            // 
            this.GenreBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.GenreBox.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenreBox.ForeColor = System.Drawing.Color.Black;
            this.GenreBox.Location = new System.Drawing.Point(164, 494);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(511, 30);
            this.GenreBox.TabIndex = 4;
            // 
            // Alright
            // 
            this.Alright.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Alright.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Alright.ForeColor = System.Drawing.Color.Gold;
            this.Alright.Location = new System.Drawing.Point(198, 584);
            this.Alright.Name = "Alright";
            this.Alright.Size = new System.Drawing.Size(118, 47);
            this.Alright.TabIndex = 6;
            this.Alright.Text = "ALRIGHT";
            this.Alright.UseVisualStyleBackColor = false;
            this.Alright.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // TitleBox
            // 
            this.TitleBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TitleBox.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleBox.ForeColor = System.Drawing.Color.Black;
            this.TitleBox.Location = new System.Drawing.Point(163, 377);
            this.TitleBox.Multiline = true;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(511, 30);
            this.TitleBox.TabIndex = 2;
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SearchBox.Font = new System.Drawing.Font("Lucida Console", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(26, 146);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(472, 30);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.SearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchBox_KeyPress);
            // 
            // CAUTARE
            // 
            this.CAUTARE.BackColor = System.Drawing.Color.Transparent;
            this.CAUTARE.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CAUTARE.ForeColor = System.Drawing.Color.Gold;
            this.CAUTARE.Location = new System.Drawing.Point(26, 90);
            this.CAUTARE.Name = "CAUTARE";
            this.CAUTARE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CAUTARE.Size = new System.Drawing.Size(341, 34);
            this.CAUTARE.TabIndex = 100;
            this.CAUTARE.Text = "SEARCH FOR BOOKS...\r\n\r\n";
            this.CAUTARE.Click += new System.EventHandler(this.label1_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OK.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OK.ForeColor = System.Drawing.Color.Gold;
            this.OK.Location = new System.Drawing.Point(528, 146);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(85, 36);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OK_MouseClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(427, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 72);
            this.label2.TabIndex = 767;
            this.label2.Text = "Book Management";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(26, 302);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(341, 34);
            this.label3.TabIndex = 87;
            this.label3.Text = "ADD BOOKS:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 36);
            this.label1.TabIndex = 1000;
            this.label1.Text = "Title";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 36);
            this.label4.TabIndex = 110;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 36);
            this.label5.TabIndex = 120;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 36);
            this.label6.TabIndex = 130;
            this.label6.Text = "Read";
            // 
            // StatusBox
            // 
            this.StatusBox.AutoSize = true;
            this.StatusBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusBox.ForeColor = System.Drawing.Color.Transparent;
            this.StatusBox.Location = new System.Drawing.Point(164, 550);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(18, 17);
            this.StatusBox.TabIndex = 5;
            this.StatusBox.UseVisualStyleBackColor = false;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.BackColor = System.Drawing.Color.Black;
            this.Counter.Font = new System.Drawing.Font("Lucida Fax", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Counter.ForeColor = System.Drawing.Color.White;
            this.Counter.Location = new System.Drawing.Point(971, 557);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(106, 32);
            this.Counter.TabIndex = 160;
            this.Counter.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(713, 556);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(234, 34);
            this.label8.TabIndex = 170;
            this.label8.Text = "TOTAL BOOKS:\n";
            // 
            // SearchResultBox
            // 
            this.SearchResultBox.BackColor = System.Drawing.Color.White;
            this.SearchResultBox.Enabled = false;
            this.SearchResultBox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchResultBox.ForeColor = System.Drawing.Color.Black;
            this.SearchResultBox.Location = new System.Drawing.Point(164, 221);
            this.SearchResultBox.Name = "SearchResultBox";
            this.SearchResultBox.Size = new System.Drawing.Size(511, 27);
            this.SearchResultBox.TabIndex = 1076;
            this.SearchResultBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 36);
            this.label7.TabIndex = 1002;
            this.label7.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 674);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SearchResultBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alright);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(Biblioteca);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.CAUTARE);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.SearchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            Biblioteca.ResumeLayout(false);
            this.Romance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RomanceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.Mystery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MysteryGrid)).EndInit();
            this.SF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SFGrid)).EndInit();
            this.Psychology.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PsychologyGrid)).EndInit();
            this.Adventure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdventureGrid)).EndInit();
            this.Other.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OtherGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SearchBox;
        private Label CAUTARE;
        private Button OK;
        private TabControl Biblioteca;
        private TabPage SF;
        private TabPage Psychology;
        private TabPage Adventure;
        private TabPage Other;
        private TabPage Romance;
        private TabPage Mystery;
        private TextBox TitleBox;
        private Button Alright;
        private TextBox AuthorBox;
        private TextBox GenreBox;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private DataGridView RomanceGrid;
        private BindingSource bookBindingSource;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridView MysteryGrid;
        private DataGridView SFGrid;
        private DataGridView PsychologyGrid;
        private DataGridView AdventureGrid;
        private DataGridView OtherGrid;
        private Label label6;
        private CheckBox StatusBox;
        private Label Counter;
        private Label label8;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private TextBox SearchResultBox;
        private Label label7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
    }
}