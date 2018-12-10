using BRIGHTSIDE_IDEA_POS;

namespace WindowsFormsApplication1
{
    partial class returnedMedReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(returnedMedReport));
            this.RMR = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.returnedMedicine1 = new WindowsFormsApplication1.returnedMedicine();
            this.SuspendLayout();
            // 
            // RMR
            // 
            this.RMR.ActiveViewIndex = 0;
            this.RMR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RMR.Cursor = System.Windows.Forms.Cursors.Default;
            this.RMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RMR.Location = new System.Drawing.Point(0, 0);
            this.RMR.Name = "RMR";
            this.RMR.ReportSource = this.returnedMedicine1;
            this.RMR.Size = new System.Drawing.Size(865, 563);
            this.RMR.TabIndex = 0;
            this.RMR.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // returnedMedReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 563);
            this.Controls.Add(this.RMR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "returnedMedReport";
            this.Text = "returnedMedReport";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer RMR;
        private BRIGHTSIDE_IDEA_POS.returnedMedicine returnedMedicine1;
    }

    internal class returnedMedicine : BRIGHTSIDE_IDEA_POS.returnedMedicine
    {
    }
}