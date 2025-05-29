using CostAnalysis.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Runtime.InteropServices;

namespace CostAnalysis.WinForms.Layouts
{
    public partial class CategoryStatsForm : Form
    {
        public CategoryStatsForm()
        {
            InitializeComponent();
            LoadStats();
        }

        private void LoadStats()
        {
            using var ctx = new CostAnalysisContext();

            var stats = ctx.Items
                .Include(i => i.Category)
                .GroupBy(i => i.Category.Name)
                .Select(g => new
                {
                    Categorie = g.Key,
                    Total = g.Sum(i => i.Amount)
                })
                .ToList();

            dgvStats.DataSource = stats;
        }

        private void ExportToExcel()
        {
            if (dgvStats.DataSource == null)
            {
                MessageBox.Show("Nu exista date de exportat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stats = dgvStats.DataSource as System.Collections.IEnumerable;
            var xl = new Excel.Application { Visible = false };
            var wb = xl.Workbooks.Add();
            var sh = (Excel.Worksheet)wb.Worksheets[1];

            sh.Cells[1, 1] = "Categorie";
            sh.Cells[1, 2] = "Total €";

            int row = 2;
            foreach (dynamic item in stats)
            {
                sh.Cells[row, 1] = item.Categorie;
                sh.Cells[row, 2] = item.Total;
                row++;
            }

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RaportCategorii.xlsx");
            wb.SaveAs(path);
            wb.Close(false);
            xl.Quit();
            Marshal.ReleaseComObject(sh);
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(xl);

            MessageBox.Show($"Export Excel salvat la:\n{path}", "Export finalizat", MessageBoxButtons.OK);
        }

        private void ExportToWord()
        {
            if (dgvStats.DataSource == null)
            {
                MessageBox.Show("Nu exista date de exportat", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stats = dgvStats.DataSource as System.Collections.IEnumerable;
            var wd = new Word.Application { Visible = false };
            var doc = wd.Documents.Add();

            var p = doc.Content.Paragraphs.Add();
            p.Range.Text = "Raport Cheltuieli pe categorii";
            p.Range.InsertParagraphAfter();

            int count = dgvStats.Rows.Count;
            var table = doc.Tables.Add(p.Range, count + 1, 2);
            table.Borders.Enable = 1;

            table.Cell(1, 1).Range.Text = "Categorie";
            table.Cell(1, 2).Range.Text = "Total €";

            int r = 2;
            foreach (dynamic item in stats)
            {
                table.Cell(r, 1).Range.Text = item.Categorie;
                table.Cell(r, 2).Range.Text = item.Total.ToString("F2");
                r++;
            }

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "RaportCategorii.docx");
            doc.SaveAs2(path);
            doc.Close(false);
            wd.Quit();
            Marshal.ReleaseComObject(table);
            Marshal.ReleaseComObject(doc);
            Marshal.ReleaseComObject(wd);

            MessageBox.Show($"Export Word salvat la:\n{path}", "Export finalizat", MessageBoxButtons.OK);
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            ExportToWord();
        }

        private void dgvStats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}