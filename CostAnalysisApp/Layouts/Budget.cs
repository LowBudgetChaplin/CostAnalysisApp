using CostAnalysis.Data;
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
    public partial class Budget : Form
    {

        private readonly CostAnalysisContext ctx = new CostAnalysisContext();

        public Budget()
        {
            InitializeComponent();
            LoadBudgets();
        }

        private void LoadBudgets()
        {
            //ctx.Budgets.Load();
            //dgvBudgets.DataSource = ctx.Budgets.Local.ToBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Validate();
                dgvBudgets.EndEdit();
                ctx.SaveChanges();
                MessageBox.Show("Bugetele au fost salvate cu succes.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "Eroare la salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //var newBudget = new Budget { Name = "Nou buget", PeriodStart = DateTime.Today, PeriodEnd = DateTime.Today.AddMonths(1), AllocatedAmount = 0m };
            //ctx.Budgets.Add(newBudget);
            ctx.SaveChanges();
            LoadBudgets();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBudgets.CurrentRow == null) return;
            var b = dgvBudgets.CurrentRow.DataBoundItem as Budget;
            if (b == null) return;

            if (MessageBox.Show($"Sterge bugetul '{b.Name}'?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            //ctx.Budgets.Remove(b);
            ctx.SaveChanges();
            LoadBudgets();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ctx.Dispose();
            base.OnFormClosing(e);
        }

        private void Budget_Load(object sender, EventArgs e)
        {

        }
    }
}
