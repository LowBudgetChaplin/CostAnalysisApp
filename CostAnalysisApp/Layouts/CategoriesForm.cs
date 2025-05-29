using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostAnalysis.WinForms.Layouts
{
    public partial class CategoriesForm : Form
    {
        private System.ComponentModel.IContainer components;
        private ListBox lstCategories;
        private Button btnDelete;
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            lstCategories = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lstCategories
            // 
            lstCategories.BackColor = Color.White;
            lstCategories.Dock = DockStyle.Top;
            lstCategories.ItemHeight = 15;
            lstCategories.Location = new Point(0, 0);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(359, 199);
            lstCategories.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(0, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(359, 57);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sterge categorie selectata";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // CategoriesForm
            // 
            ClientSize = new Size(359, 282);
            Controls.Add(lstCategories);
            Controls.Add(btnDelete);
            Name = "CategoriesForm";
            Text = "Editeaza categoriile";
            ResumeLayout(false);
        }

        private void CategoriesForm_Load(object sender, EventArgs e) {}
    }
}
