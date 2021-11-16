
namespace FormsProyectoPII
{
    partial class FrmCamion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCamion));
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPesoMax = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbCamion = new System.Windows.Forms.GroupBox();
            this.lblReparacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReparacion = new System.Windows.Forms.Button();
            this.lblCamionero = new System.Windows.Forms.Label();
            this.cboCamionero = new System.Windows.Forms.ComboBox();
            this.pbCamion = new System.Windows.Forms.PictureBox();
            this.gbCamion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPatente.ForeColor = System.Drawing.Color.White;
            this.lblPatente.Location = new System.Drawing.Point(54, 84);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(65, 19);
            this.lblPatente.TabIndex = 8;
            this.lblPatente.Text = "Patente";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(65, 204);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 19);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(38, 144);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(81, 19);
            this.lblPeso.TabIndex = 8;
            this.lblPeso.Text = "Peso Max.";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(154, 80);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(136, 23);
            this.txtPatente.TabIndex = 1;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(154, 200);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(136, 23);
            this.txtMarca.TabIndex = 3;
            // 
            // txtPesoMax
            // 
            this.txtPesoMax.Location = new System.Drawing.Point(154, 140);
            this.txtPesoMax.Name = "txtPesoMax";
            this.txtPesoMax.Size = new System.Drawing.Size(136, 23);
            this.txtPesoMax.TabIndex = 2;
            this.txtPesoMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoMax_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(188, 330);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 35);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(55, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Alta Camion";
            // 
            // gbCamion
            // 
            this.gbCamion.Controls.Add(this.lblReparacion);
            this.gbCamion.Controls.Add(this.lblTitulo);
            this.gbCamion.Controls.Add(this.btnCancelar);
            this.gbCamion.Controls.Add(this.lblPatente);
            this.gbCamion.Controls.Add(this.txtPatente);
            this.gbCamion.Controls.Add(this.txtPesoMax);
            this.gbCamion.Controls.Add(this.btnAceptar);
            this.gbCamion.Controls.Add(this.txtMarca);
            this.gbCamion.Controls.Add(this.lblPeso);
            this.gbCamion.Controls.Add(this.btnReparacion);
            this.gbCamion.Controls.Add(this.lblMarca);
            this.gbCamion.Controls.Add(this.lblCamionero);
            this.gbCamion.Controls.Add(this.cboCamionero);
            this.gbCamion.Controls.Add(this.pbCamion);
            this.gbCamion.Location = new System.Drawing.Point(65, 65);
            this.gbCamion.Name = "gbCamion";
            this.gbCamion.Size = new System.Drawing.Size(670, 390);
            this.gbCamion.TabIndex = 8;
            this.gbCamion.TabStop = false;
            // 
            // lblReparacion
            // 
            this.lblReparacion.AutoSize = true;
            this.lblReparacion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReparacion.ForeColor = System.Drawing.Color.White;
            this.lblReparacion.Location = new System.Drawing.Point(447, 280);
            this.lblReparacion.Name = "lblReparacion";
            this.lblReparacion.Size = new System.Drawing.Size(119, 19);
            this.lblReparacion.TabIndex = 8;
            this.lblReparacion.Text = "En Reparación ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(421, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReparacion
            // 
            this.btnReparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnReparacion.FlatAppearance.BorderSize = 0;
            this.btnReparacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnReparacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnReparacion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReparacion.ForeColor = System.Drawing.Color.White;
            this.btnReparacion.Location = new System.Drawing.Point(457, 235);
            this.btnReparacion.Name = "btnReparacion";
            this.btnReparacion.Size = new System.Drawing.Size(90, 35);
            this.btnReparacion.TabIndex = 5;
            this.btnReparacion.Text = "Reparar";
            this.btnReparacion.UseVisualStyleBackColor = false;
            this.btnReparacion.Click += new System.EventHandler(this.btnReparacion_Click);
            // 
            // lblCamionero
            // 
            this.lblCamionero.AutoSize = true;
            this.lblCamionero.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamionero.ForeColor = System.Drawing.Color.White;
            this.lblCamionero.Location = new System.Drawing.Point(30, 264);
            this.lblCamionero.Name = "lblCamionero";
            this.lblCamionero.Size = new System.Drawing.Size(89, 19);
            this.lblCamionero.TabIndex = 8;
            this.lblCamionero.Text = "Camionero";
            // 
            // cboCamionero
            // 
            this.cboCamionero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboCamionero.FormattingEnabled = true;
            this.cboCamionero.Location = new System.Drawing.Point(154, 260);
            this.cboCamionero.Name = "cboCamionero";
            this.cboCamionero.Size = new System.Drawing.Size(136, 23);
            this.cboCamionero.TabIndex = 4;
            // 
            // pbCamion
            // 
            this.pbCamion.Image = ((System.Drawing.Image)(resources.GetObject("pbCamion.Image")));
            this.pbCamion.Location = new System.Drawing.Point(404, 30);
            this.pbCamion.Name = "pbCamion";
            this.pbCamion.Size = new System.Drawing.Size(195, 199);
            this.pbCamion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCamion.TabIndex = 8;
            this.pbCamion.TabStop = false;
            // 
            // FrmCamion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.gbCamion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCamion";
            this.Text = "Alta Camion";
            this.Load += new System.EventHandler(this.frmAltaCamion_Load);
            this.gbCamion.ResumeLayout(false);
            this.gbCamion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPesoMax;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbCamion;
        private System.Windows.Forms.Label lblCamionero;
        private System.Windows.Forms.ComboBox cboCamionero;
        private System.Windows.Forms.PictureBox pbCamion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReparacion;
        private System.Windows.Forms.Label lblReparacion;
    }
}