#pragma warning disable CA1416
using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using CostAnalysis.Data;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms.DataVisualization.Charting;

namespace CostAnalysisApp
{
    public partial class DashboardForm : Form
    {
        private CostAnalysisContext _ctx;

        public DashboardForm()
        {
            InitializeComponent();
            chartCosts = new Chart
            {
                Dock = DockStyle.Top,
                Height = 300
            };
            chartCosts.ChartAreas.Add(new ChartArea());
            Controls.Add(chartCosts);

            dgvSummary = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = true
            };
            Controls.Add(dgvSummary);

            _ctx = new CostAnalysisContext();
            LoadData();
        }

        private void LoadData()
        {
            _ctx.Categories.Load();
            _ctx.Items.Include(i => i.Category).Load();

            var yearly = _ctx.Items.Local
                .GroupBy(i => i.DateIncurred.Year)
                .Select(g => new
                {
                    Year = g.Key,
                    Total = g.Sum(i => i.Amount)
                })
                .OrderBy(x => x.Year)
                .ToList();

            chartCosts.Series.Clear();
            var s = chartCosts.Series.Add("Costuri");
            s.ChartType = SeriesChartType.Column;
            s.XValueType = ChartValueType.Int32;
            s.XValueMember = "Year";
            s.YValueMembers = "Total";

            chartCosts.DataSource = yearly;
            chartCosts.DataBind();

            //var summary = _ctx.Categories.Local
            //    .GroupJoin(
            //        _ctx.Items.Local,
            //        cat => cat.Id,
            //        it => it.CategoryId,
            //        (cat, gr) => new
            //        {
            //            Categorie = cat.Name,
            //            Total = gr.Sum(i => i.Amount)
            //        })
            //    .Where(x => x.Total > 0)
            //    .OrderBy(x => x.Categorie)
            //    .ToList();

            //dgvSummary.DataSource = summary;
            //dgvSummary.Columns["Categorie"].HeaderText = "Categorie";
            //dgvSummary.Columns["Total"].HeaderText = "Suma totala";

            //var filtered = summary
            //    .Where(x => x.Total > 0)
            //    .ToList();

            //dataGridView1.DataSource = filtered;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView1.Columns["Categorie"].HeaderText = "Categorie";
            //dataGridView1.Columns["Total"].HeaderText = "Suma totala";
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnExportChart_Click(object sender, EventArgs e)
        {
            var tempImg = Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".png");
            chartCosts.SaveImage(tempImg, ImageFormat.Png);

            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Dashboard");
            ws.AddPicture(tempImg)
              .MoveTo(ws.Cell("B2"))
              .Scale(0.75);

            var dest = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "CostDashboard.xlsx");
            wb.SaveAs(dest);

            Process.Start(new ProcessStartInfo(dest) { UseShellExecute = true });
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _ctx.Dispose();
            base.OnFormClosed(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panelBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}