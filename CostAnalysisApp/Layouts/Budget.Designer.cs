namespace CostAnalysis.WinForms.Layouts
{
    partial class Budget
    {
        private System.Windows.Forms.DataGridView dgvBudgets;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;

        private void InitializeComponent()
        {
            this.dgvBudgets = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBudgets
            // 
            this.dgvBudgets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBudgets.AutoGenerateColumns = true;
            this.dgvBudgets.Location = new System.Drawing.Point(12, 12);
            this.dgvBudgets.Name = "dgvBudgets";
            this.dgvBudgets.Size = new System.Drawing.Size(560, 350);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Text = "Adaugă";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(497, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Salvează";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.Text = "Şterge";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BudgetForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 405);
            this.Controls.Add(this.dgvBudgets);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Name = "BudgetForm";
            this.Text = "Bugete şi planificare";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudgets)).EndInit();
            this.ResumeLayout(false);
        }
    }
}