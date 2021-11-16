
namespace FormsProyectoPII
{
    partial class FrmReportes
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
            this.lblAcercaDe = new System.Windows.Forms.Label();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAcercaDe
            // 
            this.lblAcercaDe.AutoSize = true;
            this.lblAcercaDe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcercaDe.ForeColor = System.Drawing.Color.White;
            this.lblAcercaDe.Location = new System.Drawing.Point(143, 250);
            this.lblAcercaDe.Name = "lblAcercaDe";
            this.lblAcercaDe.Size = new System.Drawing.Size(490, 50);
            this.lblAcercaDe.TabIndex = 4;
            this.lblAcercaDe.Text = "Por razones de público conocimiento los reportes están \r\nen un proyecto aparte de" +
    " WinForm .NET Framework 4.7.2\r\n";
            this.lblAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.lblAcercaDe);
            this.gbPrincipal.ForeColor = System.Drawing.Color.White;
            this.gbPrincipal.Location = new System.Drawing.Point(12, 3);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(776, 505);
            this.gbPrincipal.TabIndex = 7;
            this.gbPrincipal.TabStop = false;
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.gbPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAcercaDe;
        private System.Windows.Forms.GroupBox gbPrincipal;
    }
}