namespace CostAnalysis.WinForms.Layouts
{
    partial class CategoryStatsForm
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
        //private void InitializeComponent()
        //{
        //    this.components = new System.ComponentModel.Container();
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(800, 450);
        //    this.Text = "CategoryStatsForm";
        //}

        #endregion

        private DataGridView dgvStats;
        private Button btnExportExcel;
        private Button btnExportWord;
        private Panel panelBottom;

        private void InitializeComponent()
        {
            dgvStats = new DataGridView();
            btnExportWord = new Button();
            btnExportExcel = new Button();
            panelBottom = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            SuspendLayout();
            // 
            // dgvStats
            // 
            dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStats.Dock = DockStyle.Fill;
            dgvStats.Location = new Point(0, 0);
            dgvStats.Name = "dgvStats";
            dgvStats.ReadOnly = true;
            dgvStats.Size = new Size(443, 462);
            dgvStats.TabIndex = 0;
            //dgvStats.CellContentClick += dgvStats_CellContentClick;

            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Height = 50;
            panelBottom.Controls.Add(btnExportExcel);
            panelBottom.Controls.Add(btnExportWord);

            // 
            // btnExportWord
            // 
            btnExportWord.Location = new Point(0, 414);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(118, 48);
            btnExportWord.TabIndex = 1;
            btnExportWord.Text = "Export Word";
            btnExportWord.UseVisualStyleBackColor = true;
            //btnExportWord.Click += btnExportWord_Click_1;
            btnExportExcel.Click += new EventHandler(btnExportExcel_Click);
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(317, 414);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(126, 48);
            btnExportExcel.TabIndex = 2;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportWord.Click += new EventHandler(btnExportWord_Click);
            // 
            // CategoryStatsForm
            // 
            ClientSize = new Size(443, 462);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExportWord);
            Controls.Add(dgvStats);
            Name = "CategoryStatsForm";
            Text = "Raport de cheltuieli pe categorii";
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            ResumeLayout(false);
        }
    }
}