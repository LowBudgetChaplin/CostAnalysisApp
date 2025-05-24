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
            lstCategories.Dock = DockStyle.Top;
            lstCategories.ItemHeight = 15;
            lstCategories.Location = new Point(0, 0);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(300, 199);
            lstCategories.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.Location = new Point(0, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(300, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sterge categorie selectata";
            btnDelete.Click += btnDelete_Click;
            // 
            // CategoriesForm
            // 
            ClientSize = new Size(300, 240);
            Controls.Add(lstCategories);
            Controls.Add(btnDelete);
            Name = "CategoriesForm";
            Text = "Editeaza categoriile";
            ResumeLayout(false);
        }

        private void CategoriesForm_Load(object sender, EventArgs e) {}
    }
}
