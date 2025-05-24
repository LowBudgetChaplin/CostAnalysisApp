using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data.Entity;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using CostAnalysis.Data;
using CostAnalysis.Data.Models;
using CostAnalysis.WinForms.Controls;
using Microsoft.VisualBasic;
using CostAnalysis.WinForms.Layouts;

namespace CostAnalysisApp
{
    public partial class MainForm : Form
    {
        private CostAnalysisContext ctx;
        private int categoryColIndex;
        const string OtherLabel = "Altele";

        public MainForm()
        {
            InitializeComponent();
            dgvItems.DataError += (s, e) => e.ThrowException = false;
            dgvItems.CurrentCellDirtyStateChanged += (s, e) =>
            {
                if (dgvItems.IsCurrentCellDirty)
                    dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
            };
            dgvItems.CellValueChanged += dgvItems_CellValueChanged;
            dgvItems.DataError += (s, e) => e.ThrowException = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ctx = new CostAnalysisContext();
            ctx.Categories.Load();
            if (!ctx.Categories.Any())
            {
                ctx.Categories.AddRange(new[]
                {
                    new CostCategory { Name = "Salarii"      },
                    new CostCategory { Name = "Materii prime"},
                    new CostCategory { Name = "Utilitati"    },
                    new CostCategory { Name = "Marketing"    },
                    new CostCategory { Name = "Transport"    },
                    new CostCategory { Name = "Servicii IT"  },
                    new CostCategory { Name = "Depozitare"   },
                    new CostCategory { Name = "Taxe"         },
                    new CostCategory { Name = OtherLabel     }
                });
                ctx.SaveChanges();
                ctx.Categories.Load();
            }

            ctx.Items.Include(i => i.Category).Load();

            dgvItems.AutoGenerateColumns = false;
            dgvItems.Columns.Clear();

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Descriere",
                Width = 200
            });

            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Amount",
                HeaderText = "Suma",
                DefaultCellStyle = { Format = "F2" },
                Width = 100
            });

            var combo = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "CategoryId",
                HeaderText = "Categorie",
                DataSource = ctx.Categories.Local.ToBindingList(),
                DisplayMember = "Name",
                ValueMember = "Id",
                Width = 150,
                FlatStyle = FlatStyle.Flat
            };
            categoryColIndex = dgvItems.Columns.Add(combo);

            dgvItems.Columns.Add(new DataGridViewCalendarColumn
            {
                DataPropertyName = "DateIncurred",
                HeaderText = "Data",
                Width = 230
            });
            dgvItems.DataSource = ctx.Items.Local.ToBindingList();
        }

        private void dgvItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                MessageBox.Show("Detaliile au fost salvate cu succes", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare la salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var xl = new Excel.Application { Visible = false };
            var wb = xl.Workbooks.Add();
            var sh = (Excel.Worksheet)wb.Worksheets[1];

            ((Excel.Range)sh.Cells[1, 1]).Value = "Descriere";
            ((Excel.Range)sh.Cells[1, 2]).Value = "Suma";
            ((Excel.Range)sh.Cells[1, 3]).Value = "Categorie";
            ((Excel.Range)sh.Cells[1, 4]).Value = "Data";

            var list = (BindingList<CostItem>)dgvItems.DataSource;
            int row = 2;
            foreach (var item in list)
            {
                ((Excel.Range)sh.Cells[row, 1]).Value = item.Description;
                ((Excel.Range)sh.Cells[row, 2]).Value = item.Amount;
                ((Excel.Range)sh.Cells[row, 3]).Value = item.Category?.Name;
                ((Excel.Range)sh.Cells[row, 4]).Value = item.DateIncurred.ToShortDateString();
                row++;
            }

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CostReport.xlsx");
            wb.SaveAs(path);
            wb.Close();
            xl.Quit();
            Marshal.ReleaseComObject(sh);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(xl);

            MessageBox.Show($"Export Excel salvat la:\n{path}", "Export finalizat", MessageBoxButtons.OK);
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            var wd = new Word.Application { Visible = false };
            var doc = wd.Documents.Add();

            var p = doc.Content.Paragraphs.Add();
            p.Range.Text = "Raport Costuri";
            p.Range.InsertParagraphAfter();

            var list = (BindingList<CostItem>)dgvItems.DataSource;
            var table = doc.Tables.Add(p.Range, list.Count + 1, 4);
            table.Borders.Enable = 1;

            table.Cell(1, 1).Range.Text = "Descriere";
            table.Cell(1, 2).Range.Text = "Suma";
            table.Cell(1, 3).Range.Text = "Categorie";
            table.Cell(1, 4).Range.Text = "Data";

            int r = 2;
            foreach (var item in list)
            {
                table.Cell(r, 1).Range.Text = item.Description;
                table.Cell(r, 2).Range.Text = item.Amount.ToString("F2");
                table.Cell(r, 3).Range.Text = item.Category?.Name;
                table.Cell(r, 4).Range.Text = item.DateIncurred.ToShortDateString();
                r++;
            }

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CostReport.docx");
            doc.SaveAs2(path);
            doc.Close();
            wd.Quit();
            Marshal.ReleaseComObject(table);
            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(wd);

            MessageBox.Show($"Export Word salvat la:\n{path}", "Export finalizat", MessageBoxButtons.OK);
        }

        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != categoryColIndex || e.RowIndex < 0) return;

            var cell = dgvItems.Rows[e.RowIndex].Cells[categoryColIndex] as DataGridViewComboBoxCell;
            if (cell?.Value == null) return;

            int selectedId = (int)cell.Value;
            var alt = ctx.Categories.Local.FirstOrDefault(c => c.Name == OtherLabel);
            if (alt == null || selectedId != alt.Id) return;

            string input = Interaction.InputBox("Introduceti numele noii categorii:",
                                                "Categorie personalizata", "");
            if (string.IsNullOrWhiteSpace(input)) return;

            var newCat = new CostCategory { Name = input.Trim() };
            ctx.Categories.Add(newCat);
            ctx.SaveChanges();

            (cell.DataSource as BindingList<CostCategory>)?.ResetBindings();
            cell.Value = newCat.Id;
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dgvItems.CurrentRow == null) return;

            var item = dgvItems.CurrentRow.DataBoundItem as CostItem;
            if (item == null) return;

            if (MessageBox.Show($"Sterge „{item.Description}” ?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            ctx.Items.Remove(item);
            ctx.SaveChanges();
            dgvItems.Refresh();
        }

        private void btnManageCategories_Click(object sender, EventArgs e)
        {
            using var f = new CategoriesForm(ctx);
            f.ShowDialog();

            var comboBoxColumn = dgvItems.Columns[categoryColIndex] as DataGridViewComboBoxColumn;
            if (comboBoxColumn != null)
            {
                comboBoxColumn.DataSource = ctx.Categories.Local.ToBindingList();
            }
        }
    }
}