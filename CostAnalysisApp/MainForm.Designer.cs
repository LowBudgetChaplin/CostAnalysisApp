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
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItems.Location = new Point(12, 12);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(776, 315);
            dgvItems.TabIndex = 0;
            dgvItems.CellContentClick += dgvItems_CellContentClick;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportExcel.Location = new Point(12, 345);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(102, 41);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportWord
            // 
            btnExportWord.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportWord.Location = new Point(12, 399);
            btnExportWord.Name = "btnExportWord";
            btnExportWord.Size = new Size(102, 41);
            btnExportWord.TabIndex = 2;
            btnExportWord.Text = "Export Word";
            btnExportWord.UseVisualStyleBackColor = true;
            btnExportWord.Click += btnExportWord_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(648, 360);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(140, 58);
            btnSaveChanges.TabIndex = 3;
            btnSaveChanges.Text = "Salveaza";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSave_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Location = new Point(152, 399);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(102, 41);
            btnDeleteRow.TabIndex = 4;
            btnDeleteRow.Text = "Sterge rand";
            btnDeleteRow.UseVisualStyleBackColor = true;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // btnManageCategories
            // 
            btnManageCategories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnManageCategories.Location = new Point(152, 345);
            btnManageCategories.Name = "btnManageCategories";
            btnManageCategories.Size = new Size(102, 41);
            btnManageCategories.TabIndex = 5;
            btnManageCategories.Text = "Editeaza categoriile";
            btnManageCategories.Click += btnManageCategories_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(297, 345);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(96, 41);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Generare dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}