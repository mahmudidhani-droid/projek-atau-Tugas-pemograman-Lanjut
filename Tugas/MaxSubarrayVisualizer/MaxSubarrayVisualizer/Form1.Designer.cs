namespace MaxSubarrayVisualizer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.gbLegend = new System.Windows.Forms.GroupBox();
            this.lblKuning = new System.Windows.Forms.Label();
            this.lblMerah = new System.Windows.Forms.Label();
            this.gbLegend2 = new System.Windows.Forms.GroupBox();
            this.lblHijau2 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbBF = new System.Windows.Forms.GroupBox();
            this.btnResetBF = new System.Windows.Forms.Button();
            this.btnAutoBF = new System.Windows.Forms.Button();
            this.btnNextBF = new System.Windows.Forms.Button();
            this.btnPrevBF = new System.Windows.Forms.Button();
            this.lblStepInfoBF = new System.Windows.Forms.Label();
            this.lblMaxSumBF = new System.Windows.Forms.Label();
            this.txtKeteranganBF = new System.Windows.Forms.TextBox();
            this.dgvBruteForce = new System.Windows.Forms.DataGridView();
            this.gbDC = new System.Windows.Forms.GroupBox();
            this.btnResetDC = new System.Windows.Forms.Button();
            this.btnAutoDC = new System.Windows.Forms.Button();
            this.btnNextDC = new System.Windows.Forms.Button();
            this.btnPrevDC = new System.Windows.Forms.Button();
            this.lblStepInfoDC = new System.Windows.Forms.Label();
            this.lblMaxSumDC = new System.Windows.Forms.Label();
            this.txtKeteranganDC = new System.Windows.Forms.TextBox();
            this.dgvDivideConquer = new System.Windows.Forms.DataGridView();
            this.gbBenchmark = new System.Windows.Forms.GroupBox();
            this.lblBenchInfo = new System.Windows.Forms.Label();
            this.btnBenchmark = new System.Windows.Forms.Button();
            this.txtBenchmark = new System.Windows.Forms.TextBox();
            this.timerAutoBF = new System.Windows.Forms.Timer(this.components);
            this.timerAutoDC = new System.Windows.Forms.Timer(this.components);
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.gbLegend.SuspendLayout();
            this.gbLegend2.SuspendLayout();
            this.gbBF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBruteForce)).BeginInit();
            this.gbDC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivideConquer)).BeginInit();
            this.gbBenchmark.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(27, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(677, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "VISUALISASI MAXIMUM SUBARRAY PROBLEM";
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.White;
            this.gbData.Controls.Add(this.dgvData);
            this.gbData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.Location = new System.Drawing.Point(27, 68);
            this.gbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbData.Size = new System.Drawing.Size(1787, 160);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data Fluktuasi Saham Harian";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(20, 31);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvData.Size = new System.Drawing.Size(1733, 111);
            this.dgvData.TabIndex = 0;
            // 
            // gbLegend
            // 
            this.gbLegend.BackColor = System.Drawing.Color.White;
            this.gbLegend.Controls.Add(this.lblKuning);
            this.gbLegend.Controls.Add(this.lblMerah);
            this.gbLegend.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLegend.Location = new System.Drawing.Point(27, 240);
            this.gbLegend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLegend.Name = "gbLegend";
            this.gbLegend.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLegend.Size = new System.Drawing.Size(409, 98);
            this.gbLegend.TabIndex = 2;
            this.gbLegend.TabStop = false;
            this.gbLegend.Text = "Keterangan Warna";
            // 
            // lblKuning
            // 
            this.lblKuning.AutoSize = true;
            this.lblKuning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuning.Location = new System.Drawing.Point(20, 31);
            this.lblKuning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKuning.Name = "lblKuning";
            this.lblKuning.Size = new System.Drawing.Size(281, 20);
            this.lblKuning.TabIndex = 0;
            this.lblKuning.Text = "Kuning = Rentang yang sedang dianalisis";
            // 
            // lblMerah
            // 
            this.lblMerah.AutoSize = true;
            this.lblMerah.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMerah.Location = new System.Drawing.Point(20, 59);
            this.lblMerah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMerah.Name = "lblMerah";
            this.lblMerah.Size = new System.Drawing.Size(313, 20);
            this.lblMerah.TabIndex = 1;
            this.lblMerah.Text = "Merah = Titik potong (mid) Divide && Conquer";
            // 
            // gbLegend2
            // 
            this.gbLegend2.BackColor = System.Drawing.Color.White;
            this.gbLegend2.Controls.Add(this.lblHijau2);
            this.gbLegend2.Controls.Add(this.lblInfo);
            this.gbLegend2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLegend2.Location = new System.Drawing.Point(454, 236);
            this.gbLegend2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLegend2.Name = "gbLegend2";
            this.gbLegend2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLegend2.Size = new System.Drawing.Size(453, 98);
            this.gbLegend2.TabIndex = 3;
            this.gbLegend2.TabStop = false;
            // 
            // lblHijau2
            // 
            this.lblHijau2.AutoSize = true;
            this.lblHijau2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijau2.Location = new System.Drawing.Point(20, 18);
            this.lblHijau2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHijau2.Name = "lblHijau2";
            this.lblHijau2.Size = new System.Drawing.Size(282, 20);
            this.lblHijau2.TabIndex = 0;
            this.lblHijau2.Text = "Hijau = Subarray dengan profit maksimal";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(20, 59);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(316, 20);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Gunakan tombol Next/Prev untuk step-by-step";
            // 
            // gbBF
            // 
            this.gbBF.BackColor = System.Drawing.Color.White;
            this.gbBF.Controls.Add(this.btnResetBF);
            this.gbBF.Controls.Add(this.btnAutoBF);
            this.gbBF.Controls.Add(this.btnNextBF);
            this.gbBF.Controls.Add(this.btnPrevBF);
            this.gbBF.Controls.Add(this.lblStepInfoBF);
            this.gbBF.Controls.Add(this.lblMaxSumBF);
            this.gbBF.Controls.Add(this.txtKeteranganBF);
            this.gbBF.Controls.Add(this.dgvBruteForce);
            this.gbBF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBF.Location = new System.Drawing.Point(27, 351);
            this.gbBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBF.Name = "gbBF";
            this.gbBF.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBF.Size = new System.Drawing.Size(880, 382);
            this.gbBF.TabIndex = 4;
            this.gbBF.TabStop = false;
            this.gbBF.Text = "ALGORITMA BRUTE FORCE (O(n^2))";
            // 
            // btnResetBF
            // 
            this.btnResetBF.BackColor = System.Drawing.Color.LightPink;
            this.btnResetBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetBF.Location = new System.Drawing.Point(487, 302);
            this.btnResetBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetBF.Name = "btnResetBF";
            this.btnResetBF.Size = new System.Drawing.Size(133, 43);
            this.btnResetBF.TabIndex = 7;
            this.btnResetBF.Text = "Reset";
            this.btnResetBF.UseVisualStyleBackColor = false;
            this.btnResetBF.Click += new System.EventHandler(this.btnResetBF_Click);
            // 
            // btnAutoBF
            // 
            this.btnAutoBF.BackColor = System.Drawing.Color.Khaki;
            this.btnAutoBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoBF.Location = new System.Drawing.Point(313, 302);
            this.btnAutoBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutoBF.Name = "btnAutoBF";
            this.btnAutoBF.Size = new System.Drawing.Size(160, 43);
            this.btnAutoBF.TabIndex = 6;
            this.btnAutoBF.Text = "Auto Play";
            this.btnAutoBF.UseVisualStyleBackColor = false;
            this.btnAutoBF.Click += new System.EventHandler(this.btnAutoBF_Click);
            // 
            // btnNextBF
            // 
            this.btnNextBF.BackColor = System.Drawing.Color.LightGreen;
            this.btnNextBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBF.Location = new System.Drawing.Point(167, 302);
            this.btnNextBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextBF.Name = "btnNextBF";
            this.btnNextBF.Size = new System.Drawing.Size(133, 43);
            this.btnNextBF.TabIndex = 5;
            this.btnNextBF.Text = "Next";
            this.btnNextBF.UseVisualStyleBackColor = false;
            this.btnNextBF.Click += new System.EventHandler(this.btnNextBF_Click);
            // 
            // btnPrevBF
            // 
            this.btnPrevBF.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrevBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevBF.Location = new System.Drawing.Point(20, 302);
            this.btnPrevBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevBF.Name = "btnPrevBF";
            this.btnPrevBF.Size = new System.Drawing.Size(133, 43);
            this.btnPrevBF.TabIndex = 4;
            this.btnPrevBF.Text = "Prev";
            this.btnPrevBF.UseVisualStyleBackColor = false;
            this.btnPrevBF.Click += new System.EventHandler(this.btnPrevBF_Click);
            // 
            // lblStepInfoBF
            // 
            this.lblStepInfoBF.AutoSize = true;
            this.lblStepInfoBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepInfoBF.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblStepInfoBF.Location = new System.Drawing.Point(440, 258);
            this.lblStepInfoBF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepInfoBF.Name = "lblStepInfoBF";
            this.lblStepInfoBF.Size = new System.Drawing.Size(87, 23);
            this.lblStepInfoBF.TabIndex = 3;
            this.lblStepInfoBF.Text = "Step: 0 / 0";
            // 
            // lblMaxSumBF
            // 
            this.lblMaxSumBF.AutoSize = true;
            this.lblMaxSumBF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSumBF.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaxSumBF.Location = new System.Drawing.Point(20, 258);
            this.lblMaxSumBF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxSumBF.Name = "lblMaxSumBF";
            this.lblMaxSumBF.Size = new System.Drawing.Size(170, 25);
            this.lblMaxSumBF.TabIndex = 2;
            this.lblMaxSumBF.Text = "Profit Maksimal: -";
            // 
            // txtKeteranganBF
            // 
            this.txtKeteranganBF.BackColor = System.Drawing.Color.LightYellow;
            this.txtKeteranganBF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeteranganBF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeteranganBF.Location = new System.Drawing.Point(20, 172);
            this.txtKeteranganBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKeteranganBF.Multiline = true;
            this.txtKeteranganBF.Name = "txtKeteranganBF";
            this.txtKeteranganBF.ReadOnly = true;
            this.txtKeteranganBF.Size = new System.Drawing.Size(839, 73);
            this.txtKeteranganBF.TabIndex = 1;
            // 
            // dgvBruteForce
            // 
            this.dgvBruteForce.AllowUserToAddRows = false;
            this.dgvBruteForce.AllowUserToDeleteRows = false;
            this.dgvBruteForce.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBruteForce.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvBruteForce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBruteForce.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvBruteForce.EnableHeadersVisualStyles = false;
            this.dgvBruteForce.Location = new System.Drawing.Point(20, 37);
            this.dgvBruteForce.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBruteForce.Name = "dgvBruteForce";
            this.dgvBruteForce.ReadOnly = true;
            this.dgvBruteForce.RowHeadersVisible = false;
            this.dgvBruteForce.RowHeadersWidth = 51;
            this.dgvBruteForce.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBruteForce.Size = new System.Drawing.Size(840, 123);
            this.dgvBruteForce.TabIndex = 0;
            // 
            // gbDC
            // 
            this.gbDC.BackColor = System.Drawing.Color.White;
            this.gbDC.Controls.Add(this.btnResetDC);
            this.gbDC.Controls.Add(this.btnAutoDC);
            this.gbDC.Controls.Add(this.btnNextDC);
            this.gbDC.Controls.Add(this.btnPrevDC);
            this.gbDC.Controls.Add(this.lblStepInfoDC);
            this.gbDC.Controls.Add(this.lblMaxSumDC);
            this.gbDC.Controls.Add(this.txtKeteranganDC);
            this.gbDC.Controls.Add(this.dgvDivideConquer);
            this.gbDC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDC.Location = new System.Drawing.Point(933, 351);
            this.gbDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDC.Name = "gbDC";
            this.gbDC.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbDC.Size = new System.Drawing.Size(880, 382);
            this.gbDC.TabIndex = 5;
            this.gbDC.TabStop = false;
            this.gbDC.Text = "ALGORITMA DIVIDE && CONQUER (O(n log n))";
            // 
            // btnResetDC
            // 
            this.btnResetDC.BackColor = System.Drawing.Color.LightPink;
            this.btnResetDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDC.Location = new System.Drawing.Point(487, 302);
            this.btnResetDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetDC.Name = "btnResetDC";
            this.btnResetDC.Size = new System.Drawing.Size(133, 43);
            this.btnResetDC.TabIndex = 7;
            this.btnResetDC.Text = "Reset";
            this.btnResetDC.UseVisualStyleBackColor = false;
            this.btnResetDC.Click += new System.EventHandler(this.btnResetDC_Click);
            // 
            // btnAutoDC
            // 
            this.btnAutoDC.BackColor = System.Drawing.Color.Khaki;
            this.btnAutoDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDC.Location = new System.Drawing.Point(313, 302);
            this.btnAutoDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAutoDC.Name = "btnAutoDC";
            this.btnAutoDC.Size = new System.Drawing.Size(160, 43);
            this.btnAutoDC.TabIndex = 6;
            this.btnAutoDC.Text = "Auto Play";
            this.btnAutoDC.UseVisualStyleBackColor = false;
            this.btnAutoDC.Click += new System.EventHandler(this.btnAutoDC_Click);
            // 
            // btnNextDC
            // 
            this.btnNextDC.BackColor = System.Drawing.Color.LightGreen;
            this.btnNextDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDC.Location = new System.Drawing.Point(167, 302);
            this.btnNextDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextDC.Name = "btnNextDC";
            this.btnNextDC.Size = new System.Drawing.Size(133, 43);
            this.btnNextDC.TabIndex = 5;
            this.btnNextDC.Text = "Next";
            this.btnNextDC.UseVisualStyleBackColor = false;
            this.btnNextDC.Click += new System.EventHandler(this.btnNextDC_Click);
            // 
            // btnPrevDC
            // 
            this.btnPrevDC.BackColor = System.Drawing.Color.LightBlue;
            this.btnPrevDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevDC.Location = new System.Drawing.Point(20, 302);
            this.btnPrevDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrevDC.Name = "btnPrevDC";
            this.btnPrevDC.Size = new System.Drawing.Size(133, 43);
            this.btnPrevDC.TabIndex = 4;
            this.btnPrevDC.Text = "Prev";
            this.btnPrevDC.UseVisualStyleBackColor = false;
            this.btnPrevDC.Click += new System.EventHandler(this.btnPrevDC_Click);
            // 
            // lblStepInfoDC
            // 
            this.lblStepInfoDC.AutoSize = true;
            this.lblStepInfoDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStepInfoDC.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblStepInfoDC.Location = new System.Drawing.Point(440, 258);
            this.lblStepInfoDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepInfoDC.Name = "lblStepInfoDC";
            this.lblStepInfoDC.Size = new System.Drawing.Size(87, 23);
            this.lblStepInfoDC.TabIndex = 3;
            this.lblStepInfoDC.Text = "Step: 0 / 0";
            // 
            // lblMaxSumDC
            // 
            this.lblMaxSumDC.AutoSize = true;
            this.lblMaxSumDC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSumDC.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaxSumDC.Location = new System.Drawing.Point(20, 258);
            this.lblMaxSumDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxSumDC.Name = "lblMaxSumDC";
            this.lblMaxSumDC.Size = new System.Drawing.Size(170, 25);
            this.lblMaxSumDC.TabIndex = 2;
            this.lblMaxSumDC.Text = "Profit Maksimal: -";
            // 
            // txtKeteranganDC
            // 
            this.txtKeteranganDC.BackColor = System.Drawing.Color.Lavender;
            this.txtKeteranganDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeteranganDC.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeteranganDC.Location = new System.Drawing.Point(20, 172);
            this.txtKeteranganDC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKeteranganDC.Multiline = true;
            this.txtKeteranganDC.Name = "txtKeteranganDC";
            this.txtKeteranganDC.ReadOnly = true;
            this.txtKeteranganDC.Size = new System.Drawing.Size(839, 73);
            this.txtKeteranganDC.TabIndex = 1;
            // 
            // dgvDivideConquer
            // 
            this.dgvDivideConquer.AllowUserToAddRows = false;
            this.dgvDivideConquer.AllowUserToDeleteRows = false;
            this.dgvDivideConquer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDivideConquer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvDivideConquer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDivideConquer.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvDivideConquer.EnableHeadersVisualStyles = false;
            this.dgvDivideConquer.Location = new System.Drawing.Point(20, 37);
            this.dgvDivideConquer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDivideConquer.Name = "dgvDivideConquer";
            this.dgvDivideConquer.ReadOnly = true;
            this.dgvDivideConquer.RowHeadersVisible = false;
            this.dgvDivideConquer.RowHeadersWidth = 51;
            this.dgvDivideConquer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDivideConquer.Size = new System.Drawing.Size(840, 123);
            this.dgvDivideConquer.TabIndex = 0;
            // 
            // gbBenchmark
            // 
            this.gbBenchmark.BackColor = System.Drawing.Color.White;
            this.gbBenchmark.Controls.Add(this.lblBenchInfo);
            this.gbBenchmark.Controls.Add(this.btnBenchmark);
            this.gbBenchmark.Controls.Add(this.txtBenchmark);
            this.gbBenchmark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBenchmark.Location = new System.Drawing.Point(27, 751);
            this.gbBenchmark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBenchmark.Name = "gbBenchmark";
            this.gbBenchmark.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbBenchmark.Size = new System.Drawing.Size(1787, 283);
            this.gbBenchmark.TabIndex = 6;
            this.gbBenchmark.TabStop = false;
            this.gbBenchmark.Text = "FITUR BENCHMARKING (10.000 Data)";
            this.gbBenchmark.Enter += new System.EventHandler(this.gbBenchmark_Enter);
            // 
            // lblBenchInfo
            // 
            this.lblBenchInfo.AutoSize = true;
            this.lblBenchInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenchInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblBenchInfo.Location = new System.Drawing.Point(20, 222);
            this.lblBenchInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenchInfo.Name = "lblBenchInfo";
            this.lblBenchInfo.Size = new System.Drawing.Size(347, 40);
            this.lblBenchInfo.TabIndex = 2;
            this.lblBenchInfo.Text = "Benchmark menggunakan array acak 10.000 elemen.\nTidak divisualisasikan agar progr" +
    "am tidak crash.";
            // 
            // btnBenchmark
            // 
            this.btnBenchmark.BackColor = System.Drawing.Color.Orange;
            this.btnBenchmark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBenchmark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBenchmark.ForeColor = System.Drawing.Color.White;
            this.btnBenchmark.Location = new System.Drawing.Point(1373, 37);
            this.btnBenchmark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBenchmark.Name = "btnBenchmark";
            this.btnBenchmark.Size = new System.Drawing.Size(373, 62);
            this.btnBenchmark.TabIndex = 1;
            this.btnBenchmark.Text = "Jalankan Benchmark";
            this.btnBenchmark.UseVisualStyleBackColor = false;
            this.btnBenchmark.Click += new System.EventHandler(this.btnBenchmark_Click);
            // 
            // txtBenchmark
            // 
            this.txtBenchmark.BackColor = System.Drawing.Color.Black;
            this.txtBenchmark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBenchmark.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBenchmark.ForeColor = System.Drawing.Color.Lime;
            this.txtBenchmark.Location = new System.Drawing.Point(20, 37);
            this.txtBenchmark.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBenchmark.Multiline = true;
            this.txtBenchmark.Name = "txtBenchmark";
            this.txtBenchmark.ReadOnly = true;
            this.txtBenchmark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBenchmark.Size = new System.Drawing.Size(1333, 172);
            this.txtBenchmark.TabIndex = 0;
            this.txtBenchmark.TextChanged += new System.EventHandler(this.txtBenchmark_TextChanged);
            // 
            // timerAutoBF
            // 
            this.timerAutoBF.Interval = 800;
            this.timerAutoBF.Tick += new System.EventHandler(this.timerAutoBF_Tick);
            // 
            // timerAutoDC
            // 
            this.timerAutoDC.Interval = 1200;
            this.timerAutoDC.Tick += new System.EventHandler(this.timerAutoDC_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1867, 1055);
            this.Controls.Add(this.gbBenchmark);
            this.Controls.Add(this.gbDC);
            this.Controls.Add(this.gbBF);
            this.Controls.Add(this.gbLegend2);
            this.Controls.Add(this.gbLegend);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximum Subarray Problem - Brute Force vs Divide & Conquer";
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.gbLegend.ResumeLayout(false);
            this.gbLegend.PerformLayout();
            this.gbLegend2.ResumeLayout(false);
            this.gbLegend2.PerformLayout();
            this.gbBF.ResumeLayout(false);
            this.gbBF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBruteForce)).EndInit();
            this.gbDC.ResumeLayout(false);
            this.gbDC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivideConquer)).EndInit();
            this.gbBenchmark.ResumeLayout(false);
            this.gbBenchmark.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.GroupBox gbLegend;
        private System.Windows.Forms.Label lblKuning;
        private System.Windows.Forms.Label lblMerah;
        private System.Windows.Forms.GroupBox gbLegend2;
        private System.Windows.Forms.Label lblHijau2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbBF;
        private System.Windows.Forms.DataGridView dgvBruteForce;
        private System.Windows.Forms.TextBox txtKeteranganBF;
        private System.Windows.Forms.Label lblMaxSumBF;
        private System.Windows.Forms.Label lblStepInfoBF;
        private System.Windows.Forms.Button btnPrevBF;
        private System.Windows.Forms.Button btnNextBF;
        private System.Windows.Forms.Button btnAutoBF;
        private System.Windows.Forms.Button btnResetBF;
        private System.Windows.Forms.GroupBox gbDC;
        private System.Windows.Forms.DataGridView dgvDivideConquer;
        private System.Windows.Forms.TextBox txtKeteranganDC;
        private System.Windows.Forms.Label lblMaxSumDC;
        private System.Windows.Forms.Label lblStepInfoDC;
        private System.Windows.Forms.Button btnPrevDC;
        private System.Windows.Forms.Button btnNextDC;
        private System.Windows.Forms.Button btnAutoDC;
        private System.Windows.Forms.Button btnResetDC;
        private System.Windows.Forms.GroupBox gbBenchmark;
        private System.Windows.Forms.TextBox txtBenchmark;
        private System.Windows.Forms.Button btnBenchmark;
        private System.Windows.Forms.Label lblBenchInfo;
        private System.Windows.Forms.Timer timerAutoBF;
        private System.Windows.Forms.Timer timerAutoDC;
    }
}