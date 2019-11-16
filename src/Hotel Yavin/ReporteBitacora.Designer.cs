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
            this.SuspendLayout();
            // 
            // cryrep_bitacora
            // 
            this.cryrep_bitacora.ActiveViewIndex = 0;
            this.cryrep_bitacora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryrep_bitacora.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryrep_bitacora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryrep_bitacora.Location = new System.Drawing.Point(0, 0);
            this.cryrep_bitacora.Name = "cryrep_bitacora";
            this.cryrep_bitacora.ReportSource = this.rpt_informBitacora;
            this.cryrep_bitacora.Size = new System.Drawing.Size(1102, 476);
            this.cryrep_bitacora.TabIndex = 0;
            // 
            // ReporteBitacora
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 476);
            this.Controls.Add(this.cryrep_bitacora);
            this.Name = "ReporteBitacora";
            this.Text = "Reporte Bitácora";
            this.Load += new System.EventHandler(this.ReporteBitacora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryrep_bitacora;
        private InformeBitacora rpt_informBitacora;
    }
}