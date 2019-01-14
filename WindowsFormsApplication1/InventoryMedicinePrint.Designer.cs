using BRIGHTSIDE_IDEA_POS;

namespace WindowsFormsApplication1
{
    partial class InventoryMedicinePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMedicinePrint));
            this.IMP_crystalreport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.InventoryMedicine1 = new WindowsFormsApplication1.InventoryMedicine();
            this.SuspendLayout();
            // 
            // IMP_crystalreport
            // 
            this.IMP_crystalreport.ActiveViewIndex = 0;
            this.IMP_crystalreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMP_crystalreport.Cursor = System.Windows.Forms.Cursors.Default;
            this.IMP_crystalreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMP_crystalreport.Location = new System.Drawing.Point(0, 0);
            this.IMP_crystalreport.Name = "IMP_crystalreport";
            this.IMP_crystalreport.ReportSource = this.InventoryMedicine1;
            this.IMP_crystalreport.Size = new System.Drawing.Size(1059, 556);
            this.IMP_crystalreport.TabIndex = 0;
            this.IMP_crystalreport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // InventoryMedicinePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 556);
            this.Controls.Add(this.IMP_crystalreport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryMedicinePrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryMedicinePrint";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer IMP_crystalreport;
        private InventoryMedicine InventoryMedicine1;
    }

    internal class InventoryMedicine : BRIGHTSIDE_IDEA_POS.InventoryMedicine
    {
    }
}