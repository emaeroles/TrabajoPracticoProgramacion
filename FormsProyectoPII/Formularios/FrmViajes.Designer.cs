
namespace FormsProyectoPII
{
    partial class FrmViajes
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
            this.lblViajes = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIdCamion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbViajes = new System.Windows.Forms.GroupBox();
            this.pViajes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.gbViajes.SuspendLayout();
            this.pViajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViajes
            // 
            this.lblViajes.AutoSize = true;
            this.lblViajes.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViajes.ForeColor = System.Drawing.Color.White;
            this.lblViajes.Location = new System.Drawing.Point(55, 30);
            this.lblViajes.Name = "lblViajes";
            this.lblViajes.Size = new System.Drawing.Size(68, 25);
            this.lblViajes.TabIndex = 0;
            this.lblViajes.Text = "Viajes";
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
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.dgvViajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColIdCamion,
            this.ColOrigen,
            this.ColDestino});
            this.dgvViajes.Location = new System.Drawing.Point(55, 75);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvViajes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvViajes.RowTemplate.Height = 25;
            this.dgvViajes.Size = new System.Drawing.Size(570, 225);
            this.dgvViajes.TabIndex = 1;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColIdCamion
            // 
            this.ColIdCamion.HeaderText = "IdCamion";
            this.ColIdCamion.Name = "ColIdCamion";
            this.ColIdCamion.ReadOnly = true;
            // 
            // ColOrigen
            // 
            this.ColOrigen.HeaderText = "Origen";
            this.ColOrigen.Name = "ColOrigen";
            this.ColOrigen.ReadOnly = true;
            this.ColOrigen.Width = 155;
            // 
            // ColDestino
            // 
            this.ColDestino.HeaderText = "Destino";
            this.ColDestino.Name = "ColDestino";
            this.ColDestino.ReadOnly = true;
            this.ColDestino.Width = 155;
            // 
            // gbViajes
            // 
            this.gbViajes.Controls.Add(this.dgvViajes);
            this.gbViajes.Controls.Add(this.btnEliminar);
            this.gbViajes.Controls.Add(this.btnModificar);
            this.gbViajes.Controls.Add(this.btnNuevo);
            this.gbViajes.Controls.Add(this.lblViajes);
            this.gbViajes.Location = new System.Drawing.Point(65, 65);
            this.gbViajes.Name = "gbViajes";
            this.gbViajes.Size = new System.Drawing.Size(670, 390);
            this.gbViajes.TabIndex = 0;
            this.gbViajes.TabStop = false;
            // 
            // pViajes
            // 
            this.pViajes.Controls.Add(this.gbViajes);
            this.pViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pViajes.Location = new System.Drawing.Point(0, 0);
            this.pViajes.Name = "pViajes";
            this.pViajes.Size = new System.Drawing.Size(800, 520);
            this.pViajes.TabIndex = 0;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.pViajes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmViajes";
            this.Text = "frmViajes";
            this.Load += new System.EventHandler(this.frmViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.gbViajes.ResumeLayout(false);
            this.gbViajes.PerformLayout();
            this.pViajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblViajes;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.GroupBox gbViajes;
        private System.Windows.Forms.Panel pViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCamion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDestino;
    }
}