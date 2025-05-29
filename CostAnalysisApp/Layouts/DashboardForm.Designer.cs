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
            ((System.ComponentModel.ISupportInitialize)dgvSummary).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSummary
            // 
            dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSummary.Dock = DockStyle.Fill;
            dgvSummary.Location = new Point(0, 0);
            dgvSummary.Name = "dgvSummary";
            dgvSummary.ReadOnly = true;
            dgvSummary.Size = new Size(820, 447);
            dgvSummary.TabIndex = 0;
            dgvSummary.CellContentClick += dgvSummary_CellContentClick;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnExportChart);
            panelBottom.Controls.Add(btnRefresh);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 447);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10);
            panelBottom.Size = new Size(820, 73);
            panelBottom.TabIndex = 1;
            panelBottom.Paint += panelBottom_Paint;
            // 
            // btnExportChart
            // 
            btnExportChart.BackColor = SystemColors.MenuHighlight;
            btnExportChart.Location = new Point(680, 13);
            btnExportChart.Name = "btnExportChart";
            btnExportChart.Size = new Size(127, 50);
            btnExportChart.TabIndex = 1;
            btnExportChart.Text = "Export chart";
            btnExportChart.UseVisualStyleBackColor = false;
            btnExportChart.Click += btnExportChart_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.Info;
            btnRefresh.Location = new Point(13, 13);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(131, 50);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 375);
            Controls.Add(dgvSummary);
            Controls.Add(panelBottom);
            Name = "DashboardForm";
            Text = "Dashboard – Cost Analysis";
            ((System.ComponentModel.ISupportInitialize)dgvSummary).EndInit();
            panelBottom.ResumeLayout(false);
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
    }
}