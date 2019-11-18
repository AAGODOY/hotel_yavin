namespace Hotel_Yavin
{
    partial class ReporteBitacora
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
            this.cryrep_bitacora = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpt_informBitacora = new Hotel_Yavin.InformeBitacora();
            this.HelpProviderHG = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // cryrep_bitacora
            // 
            this.cryrep_bitacora.ActiveViewIndex = 0;
            this.cryrep_bitacora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryrep_bitacora.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryrep_bitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpProviderHG.SetHelpKeyword(this.cryrep_bitacora, "ReporteBitacora.htm#cryrep_bitacora");
            this.HelpProviderHG.SetHelpNavigator(this.cryrep_bitacora, System.Windows.Forms.HelpNavigator.Topic);
            this.cryrep_bitacora.Location = new System.Drawing.Point(0, 0);
            this.cryrep_bitacora.Name = "cryrep_bitacora";
            this.cryrep_bitacora.ReportSource = this.rpt_informBitacora;
            this.HelpProviderHG.SetShowHelp(this.cryrep_bitacora, true);
            this.cryrep_bitacora.Size = new System.Drawing.Size(1102, 476);
            this.cryrep_bitacora.TabIndex = 0;
            // 
            // HelpProviderHG
            // 
            this.HelpProviderHG.HelpNamespace = "Hotel_Yavin_manual.chm";
            // 
            // ReporteBitacora
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 476);
            this.Controls.Add(this.cryrep_bitacora);
            this.HelpProviderHG.SetHelpKeyword(this, "ReporteBitacora.htm");
            this.HelpProviderHG.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.Name = "ReporteBitacora";
            this.HelpProviderHG.SetShowHelp(this, true);
            this.Text = "Reporte Bitácora";
            this.Load += new System.EventHandler(this.ReporteBitacora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryrep_bitacora;
        private InformeBitacora rpt_informBitacora;
        private System.Windows.Forms.HelpProvider HelpProviderHG;
    }
}