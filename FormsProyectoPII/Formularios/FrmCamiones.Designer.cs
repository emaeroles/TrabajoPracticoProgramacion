
namespace FormsProyectoPII
{
    partial class FrmCamiones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCamiones = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbCamiones = new System.Windows.Forms.GroupBox();
            this.dgvCamiones = new System.Windows.Forms.DataGridView();
            this.pCamiones = new System.Windows.Forms.Panel();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCamionero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSituado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCamiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).BeginInit();
            this.pCamiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCamiones
            // 
            this.lblCamiones.AutoSize = true;
            this.lblCamiones.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamiones.ForeColor = System.Drawing.Color.White;
            this.lblCamiones.Location = new System.Drawing.Point(55, 30);
            this.lblCamiones.Name = "lblCamiones";
            this.lblCamiones.Size = new System.Drawing.Size(104, 25);
            this.lblCamiones.TabIndex = 5;
            this.lblCamiones.Text = "Camiones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(90, 330);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(90, 35);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(290, 330);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(490, 330);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbCamiones
            // 
            this.gbCamiones.Controls.Add(this.dgvCamiones);
            this.gbCamiones.Controls.Add(this.btnEliminar);
            this.gbCamiones.Controls.Add(this.btnModificar);
            this.gbCamiones.Controls.Add(this.btnNuevo);
            this.gbCamiones.Controls.Add(this.lblCamiones);
            this.gbCamiones.Location = new System.Drawing.Point(65, 65);
            this.gbCamiones.Name = "gbCamiones";
            this.gbCamiones.Size = new System.Drawing.Size(670, 390);
            this.gbCamiones.TabIndex = 5;
            this.gbCamiones.TabStop = false;
            // 
            // dgvCamiones
            // 
            this.dgvCamiones.AllowUserToAddRows = false;
            this.dgvCamiones.AllowUserToDeleteRows = false;
            this.dgvCamiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.dgvCamiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCamiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCamiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColMarca,
            this.ColPatente,
            this.ColCamionero,
            this.ColEstado,
            this.ColPeso,
            this.ColSituado});
            this.dgvCamiones.Location = new System.Drawing.Point(55, 75);
            this.dgvCamiones.Name = "dgvCamiones";
            this.dgvCamiones.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCamiones.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCamiones.RowTemplate.Height = 25;
            this.dgvCamiones.Size = new System.Drawing.Size(570, 225);
            this.dgvCamiones.TabIndex = 1;
            // 
            // pCamiones
            // 
            this.pCamiones.Controls.Add(this.gbCamiones);
            this.pCamiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCamiones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pCamiones.Location = new System.Drawing.Point(0, 0);
            this.pCamiones.Name = "pCamiones";
            this.pCamiones.Size = new System.Drawing.Size(800, 520);
            this.pCamiones.TabIndex = 5;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColMarca
            // 
            this.ColMarca.HeaderText = "Marca";
            this.ColMarca.Name = "ColMarca";
            this.ColMarca.ReadOnly = true;
            this.ColMarca.Width = 120;
            // 
            // ColPatente
            // 
            this.ColPatente.HeaderText = "Patente";
            this.ColPatente.Name = "ColPatente";
            this.ColPatente.ReadOnly = true;
            // 
            // ColCamionero
            // 
            this.ColCamionero.HeaderText = "Camionero";
            this.ColCamionero.Name = "ColCamionero";
            this.ColCamionero.ReadOnly = true;
            this.ColCamionero.Width = 90;
            // 
            // ColEstado
            // 
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // ColPeso
            // 
            this.ColPeso.HeaderText = "Peso Max.";
            this.ColPeso.Name = "ColPeso";
            this.ColPeso.ReadOnly = true;
            // 
            // ColSituado
            // 
            this.ColSituado.HeaderText = "Situado";
            this.ColSituado.Name = "ColSituado";
            this.ColSituado.ReadOnly = true;
            this.ColSituado.Visible = false;
            // 
            // FrmCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.pCamiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCamiones";
            this.Text = "Camiones";
            this.Load += new System.EventHandler(this.frmCamiones_Load);
            this.gbCamiones.ResumeLayout(false);
            this.gbCamiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCamiones)).EndInit();
            this.pCamiones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCamiones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbCamiones;
        private System.Windows.Forms.Panel pCamiones;
        private System.Windows.Forms.DataGridView dgvCamiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCamionero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSituado;
    }
}