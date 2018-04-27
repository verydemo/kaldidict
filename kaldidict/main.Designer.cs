namespace kaldidict
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidictdata = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labdgvcompara = new System.Windows.Forms.Label();
            this.dgvcompareword = new System.Windows.Forms.DataGridView();
            this.nofoundword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Batchnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnreplacetext = new System.Windows.Forms.Button();
            this.btnexportdict = new System.Windows.Forms.Button();
            this.btnimportcompare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labdgvcmu = new System.Windows.Forms.Label();
            this.dgvcmudata = new System.Windows.Forms.DataGridView();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dictid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronunciation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labnote = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtlexiconp_silprob = new System.Windows.Forms.TextBox();
            this.txtlexiconp = new System.Windows.Forms.TextBox();
            this.txtword = new System.Windows.Forms.TextBox();
            this.txtlexicon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompareword)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcmudata)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmidictdata});
            this.系统ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // tsmidictdata
            // 
            this.tsmidictdata.Name = "tsmidictdata";
            this.tsmidictdata.Size = new System.Drawing.Size(170, 32);
            this.tsmidictdata.Text = "字典数据";
            this.tsmidictdata.Click += new System.EventHandler(this.tsmidictdata_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1329, 671);
            this.splitContainer1.SplitterDistance = 630;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(620, 660);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "对比";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.labdgvcompara);
            this.groupBox6.Controls.Add(this.dgvcompareword);
            this.groupBox6.Location = new System.Drawing.Point(1, 118);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(613, 542);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "信息";
            // 
            // labdgvcompara
            // 
            this.labdgvcompara.AutoSize = true;
            this.labdgvcompara.Location = new System.Drawing.Point(8, 65);
            this.labdgvcompara.Name = "labdgvcompara";
            this.labdgvcompara.Size = new System.Drawing.Size(119, 20);
            this.labdgvcompara.TabIndex = 1;
            this.labdgvcompara.Text = "没有找到!!!";
            this.labdgvcompara.Visible = false;
            // 
            // dgvcompareword
            // 
            this.dgvcompareword.AllowUserToAddRows = false;
            this.dgvcompareword.AllowUserToDeleteRows = false;
            this.dgvcompareword.AllowUserToResizeRows = false;
            this.dgvcompareword.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvcompareword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcompareword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompareword.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nofoundword,
            this.Batchnumber,
            this.id,
            this.status,
            this.note,
            this.splitword,
            this.examname});
            this.dgvcompareword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcompareword.Location = new System.Drawing.Point(3, 26);
            this.dgvcompareword.Name = "dgvcompareword";
            this.dgvcompareword.RowHeadersVisible = false;
            this.dgvcompareword.RowTemplate.Height = 27;
            this.dgvcompareword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcompareword.Size = new System.Drawing.Size(607, 513);
            this.dgvcompareword.TabIndex = 0;
            // 
            // nofoundword
            // 
            this.nofoundword.DataPropertyName = "word";
            this.nofoundword.HeaderText = "单词";
            this.nofoundword.Name = "nofoundword";
            this.nofoundword.ReadOnly = true;
            this.nofoundword.Width = 150;
            // 
            // Batchnumber
            // 
            this.Batchnumber.DataPropertyName = "batchno";
            this.Batchnumber.HeaderText = "Batchnumber";
            this.Batchnumber.Name = "Batchnumber";
            this.Batchnumber.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 80;
            // 
            // note
            // 
            this.note.DataPropertyName = "note";
            this.note.HeaderText = "说明";
            this.note.Name = "note";
            this.note.ReadOnly = true;
            // 
            // splitword
            // 
            this.splitword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.splitword.DataPropertyName = "wordsplit";
            this.splitword.HeaderText = "拆分";
            this.splitword.Name = "splitword";
            // 
            // examname
            // 
            this.examname.DataPropertyName = "examname";
            this.examname.HeaderText = "考试";
            this.examname.Name = "examname";
            this.examname.ReadOnly = true;
            this.examname.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnreplacetext);
            this.panel1.Controls.Add(this.btnexportdict);
            this.panel1.Controls.Add(this.btnimportcompare);
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnreplacetext
            // 
            this.btnreplacetext.Location = new System.Drawing.Point(413, 24);
            this.btnreplacetext.Name = "btnreplacetext";
            this.btnreplacetext.Size = new System.Drawing.Size(158, 41);
            this.btnreplacetext.TabIndex = 1;
            this.btnreplacetext.Text = "生成替换文本";
            this.btnreplacetext.UseVisualStyleBackColor = true;
            this.btnreplacetext.Click += new System.EventHandler(this.btnreplacetext_Click);
            // 
            // btnexportdict
            // 
            this.btnexportdict.Location = new System.Drawing.Point(209, 24);
            this.btnexportdict.Name = "btnexportdict";
            this.btnexportdict.Size = new System.Drawing.Size(156, 41);
            this.btnexportdict.TabIndex = 1;
            this.btnexportdict.Text = "生成最新dict";
            this.btnexportdict.UseVisualStyleBackColor = true;
            this.btnexportdict.Click += new System.EventHandler(this.btnexportdict_Click);
            // 
            // btnimportcompare
            // 
            this.btnimportcompare.Location = new System.Drawing.Point(49, 24);
            this.btnimportcompare.Name = "btnimportcompare";
            this.btnimportcompare.Size = new System.Drawing.Size(109, 41);
            this.btnimportcompare.TabIndex = 0;
            this.btnimportcompare.Text = "导入对比";
            this.btnimportcompare.UseVisualStyleBackColor = true;
            this.btnimportcompare.Click += new System.EventHandler(this.btnimportcompare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CMU";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.labdgvcmu);
            this.groupBox3.Controls.Add(this.dgvcmudata);
            this.groupBox3.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(11, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 118);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "结果";
            // 
            // labdgvcmu
            // 
            this.labdgvcmu.AutoSize = true;
            this.labdgvcmu.Location = new System.Drawing.Point(11, 30);
            this.labdgvcmu.Name = "labdgvcmu";
            this.labdgvcmu.Size = new System.Drawing.Size(119, 20);
            this.labdgvcmu.TabIndex = 1;
            this.labdgvcmu.Text = "没有找到!!!";
            this.labdgvcmu.Visible = false;
            // 
            // dgvcmudata
            // 
            this.dgvcmudata.AllowUserToAddRows = false;
            this.dgvcmudata.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvcmudata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvcmudata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcmudata.ColumnHeadersVisible = false;
            this.dgvcmudata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.dictid,
            this.pronunciation});
            this.dgvcmudata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcmudata.Location = new System.Drawing.Point(3, 26);
            this.dgvcmudata.MultiSelect = false;
            this.dgvcmudata.Name = "dgvcmudata";
            this.dgvcmudata.ReadOnly = true;
            this.dgvcmudata.RowHeadersVisible = false;
            this.dgvcmudata.RowTemplate.Height = 27;
            this.dgvcmudata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcmudata.Size = new System.Drawing.Size(661, 89);
            this.dgvcmudata.TabIndex = 0;
            // 
            // word
            // 
            this.word.DataPropertyName = "dictword";
            this.word.HeaderText = "dictword";
            this.word.Name = "word";
            this.word.ReadOnly = true;
            this.word.Visible = false;
            // 
            // dictid
            // 
            this.dictid.DataPropertyName = "dictid";
            this.dictid.HeaderText = "dictid";
            this.dictid.Name = "dictid";
            this.dictid.ReadOnly = true;
            this.dictid.Visible = false;
            // 
            // pronunciation
            // 
            this.pronunciation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pronunciation.DataPropertyName = "pronunciation";
            this.pronunciation.HeaderText = "pronunciation";
            this.pronunciation.Name = "pronunciation";
            this.pronunciation.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 72);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsearch.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsearch.Location = new System.Drawing.Point(584, 24);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(78, 31);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "查找";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtsearch.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtsearch.Location = new System.Drawing.Point(6, 24);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(550, 30);
            this.txtsearch.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.labnote);
            this.groupBox4.Controls.Add(this.btnadd);
            this.groupBox4.Controls.Add(this.txtlexiconp_silprob);
            this.groupBox4.Controls.Add(this.txtlexiconp);
            this.groupBox4.Controls.Add(this.txtword);
            this.groupBox4.Controls.Add(this.txtlexicon);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(8, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(684, 433);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加到kaldi的字典库";
            // 
            // labnote
            // 
            this.labnote.AutoSize = true;
            this.labnote.Location = new System.Drawing.Point(18, 284);
            this.labnote.Name = "labnote";
            this.labnote.Size = new System.Drawing.Size(0, 20);
            this.labnote.TabIndex = 3;
            // 
            // btnadd
            // 
            this.btnadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnadd.Location = new System.Drawing.Point(537, 350);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 36);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtlexiconp_silprob
            // 
            this.txtlexiconp_silprob.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlexiconp_silprob.Location = new System.Drawing.Point(209, 259);
            this.txtlexiconp_silprob.Name = "txtlexiconp_silprob";
            this.txtlexiconp_silprob.Size = new System.Drawing.Size(430, 30);
            this.txtlexiconp_silprob.TabIndex = 1;
            // 
            // txtlexiconp
            // 
            this.txtlexiconp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlexiconp.Location = new System.Drawing.Point(208, 170);
            this.txtlexiconp.Name = "txtlexiconp";
            this.txtlexiconp.Size = new System.Drawing.Size(430, 30);
            this.txtlexiconp.TabIndex = 1;
            // 
            // txtword
            // 
            this.txtword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtword.Location = new System.Drawing.Point(208, 59);
            this.txtword.Name = "txtword";
            this.txtword.Size = new System.Drawing.Size(430, 30);
            this.txtword.TabIndex = 1;
            // 
            // txtlexicon
            // 
            this.txtlexicon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtlexicon.Location = new System.Drawing.Point(208, 111);
            this.txtlexicon.Name = "txtlexicon";
            this.txtlexicon.Size = new System.Drawing.Size(430, 30);
            this.txtlexicon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "lexiconp_silprob:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "lexiconp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "lexicon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "word:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "CREAT 1 K R IY0 EY1 T";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "CREAT 1 0.19 1.00 1.00 K R IY0 EY1 T";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "例:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "例:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 706);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "发音字典库";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompareword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcmudata)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmidictdata;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvcmudata;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn dictid;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronunciation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtlexiconp;
        private System.Windows.Forms.TextBox txtlexicon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlexiconp_silprob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labnote;
        private System.Windows.Forms.Label labdgvcmu;
        private System.Windows.Forms.DataGridView dgvcompareword;
        private System.Windows.Forms.Button btnimportcompare;
        private System.Windows.Forms.Label labdgvcompara;
        private System.Windows.Forms.Button btnreplacetext;
        private System.Windows.Forms.Button btnexportdict;
        private System.Windows.Forms.DataGridViewTextBoxColumn nofoundword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Batchnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn splitword;
        private System.Windows.Forms.DataGridViewTextBoxColumn examname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}