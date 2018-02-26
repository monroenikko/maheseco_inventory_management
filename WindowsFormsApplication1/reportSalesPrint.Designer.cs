namespace WindowsFormsApplication1
{
    partial class reportSalesPrint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reportSalesPrint));
            this.salesPrint = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SalesReport1 = new WindowsFormsApplication1.SalesReport();
            this.SuspendLayout();
            // 
            // salesPrint
            // 
            this.salesPrint.ActiveViewIndex = 0;
            this.salesPrint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesPrint.Cursor = System.Windows.Forms.Cursors.Default;
            this.salesPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesPrint.Location = new System.Drawing.Point(0, 0);
            this.salesPrint.Name = "salesPrint";
            this.salesPrint.ReportSource = this.SalesReport1;
            this.salesPrint.Size = new System.Drawing.Size(905, 465);
            this.salesPrint.TabIndex = 0;
            this.salesPrint.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // reportSalesPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 465);
            this.Controls.Add(this.salesPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reportSalesPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportSalesPrint";
            this.Load += new System.EventHandler(this.reportSalesPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer salesPrint;
        private SalesReport SalesReport1;
    }
}