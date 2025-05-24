using Org.BouncyCastle.Asn1.Crmf;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace CostAnalysisApp
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components;
        private Chart chartCosts;
        private DataGridView dgvSummary;
        private Panel panelBottom;
        private Button btnRefresh;
        private Button btnExportChart;

        private void InitializeComponent()
        {
            dgvSummary = new DataGridView();
            panelBottom = new Panel();
            btnExportChart = new Button();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgvSummary
            // 
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.Dock = DockStyle.Fill;
            dgvSummary.Location = new Point(0, 0);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.Size = new Size(820, 309);
            dgvSummary.TabIndex = 0;
            dgvSummary.CellContentClick += dgvSummary_CellContentClick;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(dataGridView1);
            panelBottom.Controls.Add(btnExportChart);
            panelBottom.Controls.Add(btnRefresh);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 309);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(820, 211);
            panelBottom.TabIndex = 1;
            panelBottom.Paint += panelBottom_Paint;
            // 
            // btnExportChart
            // 
            btnExportChart.Location = new Point(421, 172);
            btnExportChart.Name = "btnExportChart";
            btnExportChart.Size = new Size(121, 32);
            btnExportChart.TabIndex = 1;
            btnExportChart.Text = "Export chart";
            btnExportChart.Click += btnExportChart_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(234, 172);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 32);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(820, 166);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 520);
            Controls.Add(dgvSummary);
            Controls.Add(panelBottom);
            Name = "DashboardForm";
            Text = "Dashboard – Cost Analysis";
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
                _ctx?.Dispose();
            }
            base.Dispose(disposing);
        }
        private DataGridView dataGridView1;
    }
}