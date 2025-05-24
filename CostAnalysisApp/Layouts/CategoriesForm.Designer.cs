using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using CostAnalysis.Data;
using CostAnalysis.Data.Models;

    namespace CostAnalysis.WinForms.Layouts
    {
    public partial class CategoriesForm : Form
        {
            private readonly CostAnalysisContext _ctx;
            private readonly BindingList<CostCategory> _source;

            public CategoriesForm(CostAnalysisContext ctx)
            {
                InitializeComponent();
                _ctx = ctx;

                _source = ctx.Categories.Local.ToBindingList();
                lstCategories.DataSource = _source;
                lstCategories.DisplayMember = "Name";
            }

            private void btnDelete_Click(object sender, EventArgs e)
            {
                if (lstCategories.SelectedItem is not CostCategory cat) return;

                if (_ctx.Items.Any(i => i.CategoryId == cat.Id))
                {
                    MessageBox.Show("Categoria este folosita de inregistrari si nu poate fi stearsa");
                    return;
                }

                if (MessageBox.Show($"Sterge „{cat.Name}” ?", "Confirm",
                       MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                _ctx.Categories.Remove(cat);
                _ctx.SaveChanges();
                _source.ResetBindings();
            }
        }
    }
