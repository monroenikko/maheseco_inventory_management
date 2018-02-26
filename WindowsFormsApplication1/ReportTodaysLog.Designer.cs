namespace WindowsFormsApplication1
{
    partial class ReportTodaysLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTodaysLog));
            this.cashiers_log = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TodaysLog1 = new WindowsFormsApplication1.TodaysLog();
            this.SuspendLayout();
            // 
            // cashiers_log
            // 
            this.cashiers_log.ActiveViewIndex = 0;
            this.cashiers_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashiers_log.Cursor = System.Windows.Forms.Cursors.Default;
            this.cashiers_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashiers_log.Location = new System.Drawing.Point(0, 0);
            this.cashiers_log.Name = "cashiers_log";
            this.cashiers_log.ReportSource = this.TodaysLog1;
            this.cashiers_log.Size = new System.Drawing.Size(921, 512);
            this.cashiers_log.TabIndex = 0;
            this.cashiers_log.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportTodaysLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 512);
            this.Controls.Add(this.cashiers_log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportTodaysLog";
            this.Text = "ReportTodaysLog";
            this.Load += new System.EventHandler(this.ReportTodaysLog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cashiers_log;
        private TodaysLog TodaysLog1;
    }
}