namespace CostAnalysis.ExcelAddIn
{
    partial class CostAnalysisRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CostAnalysisRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.tab2 = this.Factory.CreateRibbonTab();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.tabCostAnalysis = this.Factory.CreateRibbonLabel();
            this.groupDashboard = this.Factory.CreateRibbonGroup();
            this.btnRefreshDashboard = this.Factory.CreateRibbonButton();
            this.btnGenerateReport = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.group2.SuspendLayout();
            this.groupDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // group1
            // 
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // tab2
            // 
            this.tab2.Groups.Add(this.group2);
            this.tab2.Groups.Add(this.groupDashboard);
            this.tab2.Label = "tab2";
            this.tab2.Name = "tab2";
            // 
            // group2
            // 
            this.group2.Items.Add(this.tabCostAnalysis);
            this.group2.Name = "group2";
            // 
            // tabCostAnalysis
            // 
            this.tabCostAnalysis.Label = "CostAnalysis";
            this.tabCostAnalysis.Name = "tabCostAnalysis";
            // 
            // groupDashboard
            // 
            this.groupDashboard.Items.Add(this.btnRefreshDashboard);
            this.groupDashboard.Items.Add(this.btnGenerateReport);
            this.groupDashboard.Label = "Dashboard Tools";
            this.groupDashboard.Name = "groupDashboard";
            // 
            // btnRefreshDashboard
            // 
            this.btnRefreshDashboard.Description = "Refresh Dashboard";
            this.btnRefreshDashboard.Label = "Refresh Dashboard";
            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
            this.btnRefreshDashboard.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnRefreshDashboard_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Label = "Generare Raport";
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGenerateReport_Click);
            // 
            // CostAnalysisRibbon
            // 
            this.Name = "CostAnalysisRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Tabs.Add(this.tab2);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CostAnalysisRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.groupDashboard.ResumeLayout(false);
            this.groupDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab2;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel tabCostAnalysis;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupDashboard;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnRefreshDashboard;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGenerateReport;
    }

    partial class ThisRibbonCollection
    {
        internal CostAnalysisRibbon CostAnalysisRibbon
        {
            get { return this.GetRibbon<CostAnalysisRibbon>(); }
        }
    }
}
