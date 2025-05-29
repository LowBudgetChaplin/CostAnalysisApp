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
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStats
            // 
            dgvStats.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStats.Dock = DockStyle.Fill;
            dgvStats.Location = new Point(0, 0);
            dgvStats.Name = "dgvStats";
            dgvStats.ReadOnly = true;
            dgvStats.Size = new Size(600, 360);
            dgvStats.TabIndex = 0;
            // 
            // btnExportWord
            // 
            btnExportWord.BackColor = SystemColors.MenuHighlight;
            btnExportWord.Dock = DockStyle.Left;
            btnExportWord.FlatStyle = FlatStyle.Popup;
            btnExportWord.ForeColor = Color.White;
            btnExportWord.Location = new Point(10, 10);
            btnExportWord.Margin = new Padding(10);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(120, 40);
            btnExportWord.TabIndex = 1;
            btnExportWord.Text = "Export Word";
            btnExportWord.UseVisualStyleBackColor = false;
            btnExportWord.Click += btnExportWord_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = SystemColors.MenuHighlight;
            btnExportExcel.Dock = DockStyle.Left;
            btnExportExcel.FlatStyle = FlatStyle.Popup;
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(130, 10);
            btnExportExcel.Margin = new Padding(10);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(120, 40);
            btnExportExcel.TabIndex = 0;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = SystemColors.Control;
            panelBottom.Controls.Add(btnExportExcel);
            panelBottom.Controls.Add(btnExportWord);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 360);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(600, 60);
            panelBottom.TabIndex = 1;
            // 
            // CategoryStatsForm
            // 
            ClientSize = new Size(600, 420);
            Controls.Add(dgvStats);
            Controls.Add(panelBottom);
            Name = "CategoryStatsForm";
            Text = "Statistici pe Categorii";
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}