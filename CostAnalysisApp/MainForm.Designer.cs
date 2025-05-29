using System;
using System.Drawing;
using System.Windows.Forms;

namespace CostAnalysisApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components;
        private DataGridView dgvItems;
        private Button btnExportExcel;
        private Button btnExportWord;
        private Button btnSaveChanges;
        private Button btnDeleteRow;
        private Button btnManageCategories;

        private void InitializeComponent()
        {
            dgvItems = new DataGridView();
            btnExportExcel = new Button();
            btnExportWord = new Button();
            btnSaveChanges = new Button();
            btnDeleteRow = new Button();
            btnManageCategories = new Button();
            btnDashboard = new Button();
            btnCategoryStats = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.Location = new Point(12, 12);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(718, 301);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportExcel.BackColor = SystemColors.ActiveCaption;
            btnExportExcel.FlatStyle = FlatStyle.Popup;
            btnExportExcel.Location = new Point(11, 328);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(102, 41);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportWord
            // 
            btnExportWord.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportWord.BackColor = SystemColors.ActiveCaption;
            btnExportWord.FlatStyle = FlatStyle.Popup;
            btnExportWord.Location = new Point(11, 382);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(102, 41);
            btnExportWord.TabIndex = 2;
            btnExportWord.Text = "Export Word";
            btnExportWord.UseVisualStyleBackColor = false;
            btnExportWord.Click += btnExportWord_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(192, 192, 0);
            btnSaveChanges.FlatStyle = FlatStyle.Popup;
            btnSaveChanges.Location = new Point(567, 341);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(140, 58);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Salveaza";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += btnSave_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.BackColor = Color.FromArgb(192, 0, 0);
            btnDeleteRow.FlatStyle = FlatStyle.Popup;
            btnDeleteRow.ForeColor = Color.White;
            btnDeleteRow.Location = new Point(151, 382);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(102, 41);
            btnDeleteRow.TabIndex = 4;
            btnDeleteRow.Text = "Sterge rand";
            btnDeleteRow.UseVisualStyleBackColor = false;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnManageCategories.BackColor = Color.FromArgb(192, 192, 0);
            btnManageCategories.FlatStyle = FlatStyle.Popup;
            btnManageCategories.Location = new Point(151, 328);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(102, 41);
            btnManageCategories.TabIndex = 5;
            btnManageCategories.Text = "Editeaza categoriile";
            btnManageCategories.UseVisualStyleBackColor = false;
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = SystemColors.MenuHighlight;
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(296, 328);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(129, 41);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Generare dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnCategoryStats
            // 
            btnCategoryStats.BackColor = SystemColors.MenuHighlight;
            btnCategoryStats.FlatStyle = FlatStyle.Popup;
            btnCategoryStats.ForeColor = Color.White;
            btnCategoryStats.Location = new Point(296, 382);
            btnCategoryStats.Name = "btnCategoryStats";
            btnCategoryStats.Size = new Size(129, 41);
            btnCategoryStats.TabIndex = 7;
            btnCategoryStats.Text = "Raport de cheltuieli pe categorii";
            btnCategoryStats.UseVisualStyleBackColor = false;
            btnCategoryStats.Click += btnCategoryStats_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(742, 450);
            Controls.Add(btnCategoryStats);
            Controls.Add(btnDashboard);
            Controls.Add(btnDeleteRow);
            Controls.Add(btnSaveChanges);
            Controls.Add(btnExportWord);
            Controls.Add(btnExportExcel);
            Controls.Add(dgvItems);
            Controls.Add(btnManageCategories);
            Name = "MainForm";
            Text = "Cost Analysis";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                ctx?.Dispose();
            }
            base.Dispose(disposing);
        }
        private Button btnDashboard;
        private Button btnCategoryStats;
    }
}