
namespace FormsProyectoPII
{
    partial class FrmViaje
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
            this.lblViaje = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.lblPesoRestante = new System.Windows.Forms.Label();
            this.lblCamion = new System.Windows.Forms.Label();
            this.cboCamion = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dgvCargas = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescargar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboTipoCarga = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPorcentageCarga = new System.Windows.Forms.Label();
            this.btnPartir = new System.Windows.Forms.Button();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPeso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblViaje
            // 
            this.lblViaje.AutoSize = true;
            this.lblViaje.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViaje.ForeColor = System.Drawing.Color.White;
            this.lblViaje.Location = new System.Drawing.Point(42, 36);
            this.lblViaje.Name = "lblViaje";
            this.lblViaje.Size = new System.Drawing.Size(90, 25);
            this.lblViaje.TabIndex = 0;
            this.lblViaje.Text = "Viaje Nº:";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(359, 38);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(121, 23);
            this.txtOrigen.TabIndex = 10;
            // 
            // lblPesoRestante
            // 
            this.lblPesoRestante.AutoSize = true;
            this.lblPesoRestante.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesoRestante.ForeColor = System.Drawing.Color.White;
            this.lblPesoRestante.Location = new System.Drawing.Point(283, 86);
            this.lblPesoRestante.Name = "lblPesoRestante";
            this.lblPesoRestante.Size = new System.Drawing.Size(113, 19);
            this.lblPesoRestante.TabIndex = 0;
            this.lblPesoRestante.Text = "Peso restante:";
            // 
            // lblCamion
            // 
            this.lblCamion.AutoSize = true;
            this.lblCamion.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCamion.ForeColor = System.Drawing.Color.White;
            this.lblCamion.Location = new System.Drawing.Point(42, 86);
            this.lblCamion.Name = "lblCamion";
            this.lblCamion.Size = new System.Drawing.Size(64, 19);
            this.lblCamion.TabIndex = 0;
            this.lblCamion.Text = "Camion";
            // 
            // cboCamion
            // 
            this.cboCamion.FormattingEnabled = true;
            this.cboCamion.ItemHeight = 15;
            this.cboCamion.Location = new System.Drawing.Point(112, 82);
            this.cboCamion.Name = "cboCamion";
            this.cboCamion.Size = new System.Drawing.Size(148, 23);
            this.cboCamion.TabIndex = 7;
            this.cboCamion.SelectionChangeCommitted += new System.EventHandler(this.cboCamion_SelectionChangeCommitted);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(605, 86);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(86, 19);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Disponible";
            // 
            // dgvCargas
            // 
            this.dgvCargas.AllowUserToAddRows = false;
            this.dgvCargas.AllowUserToDeleteRows = false;
            this.dgvCargas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.dgvCargas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColTipo,
            this.ColPeso,
            this.ColDescargar});
            this.dgvCargas.Location = new System.Drawing.Point(135, 170);
            this.dgvCargas.Name = "dgvCargas";
            this.dgvCargas.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCargas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCargas.RowTemplate.Height = 25;
            this.dgvCargas.Size = new System.Drawing.Size(460, 183);
            this.dgvCargas.TabIndex = 6;
            this.dgvCargas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            this.ColTipo.ReadOnly = true;
            // 
            // ColPeso
            // 
            this.ColPeso.HeaderText = "Peso";
            this.ColPeso.Name = "ColPeso";
            this.ColPeso.ReadOnly = true;
            // 
            // ColDescargar
            // 
            this.ColDescargar.HeaderText = "Descargar";
            this.ColDescargar.Name = "ColDescargar";
            this.ColDescargar.ReadOnly = true;
            this.ColDescargar.Text = "Descargar";
            this.ColDescargar.UseColumnTextForButtonValue = true;
            // 
            // cboTipoCarga
            // 
            this.cboTipoCarga.FormattingEnabled = true;
            this.cboTipoCarga.ItemHeight = 15;
            this.cboTipoCarga.Items.AddRange(new object[] {
            "Packing",
            "Caja",
            "Bidon"});
            this.cboTipoCarga.Location = new System.Drawing.Point(189, 140);
            this.cboTipoCarga.Name = "cboTipoCarga";
            this.cboTipoCarga.Size = new System.Drawing.Size(121, 23);
            this.cboTipoCarga.TabIndex = 11;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(381, 140);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(64, 23);
            this.txtPeso.TabIndex = 4;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(570, 38);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(121, 23);
            this.txtDestino.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAceptar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(93, 392);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 35);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(326, 392);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPorcentageCarga
            // 
            this.lblPorcentageCarga.AutoSize = true;
            this.lblPorcentageCarga.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentageCarga.ForeColor = System.Drawing.Color.White;
            this.lblPorcentageCarga.Location = new System.Drawing.Point(463, 86);
            this.lblPorcentageCarga.Name = "lblPorcentageCarga";
            this.lblPorcentageCarga.Size = new System.Drawing.Size(88, 19);
            this.lblPorcentageCarga.TabIndex = 0;
            this.lblPorcentageCarga.Text = "% de carga";
            // 
            // btnPartir
            // 
            this.btnPartir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnPartir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnPartir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPartir.ForeColor = System.Drawing.Color.White;
            this.btnPartir.Location = new System.Drawing.Point(559, 392);
            this.btnPartir.Name = "btnPartir";
            this.btnPartir.Size = new System.Drawing.Size(90, 35);
            this.btnPartir.TabIndex = 9;
            this.btnPartir.Text = "Partir";
            this.btnPartir.UseVisualStyleBackColor = false;
            this.btnPartir.Click += new System.EventHandler(this.btnPartir_Click);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrigen.ForeColor = System.Drawing.Color.White;
            this.lblOrigen.Location = new System.Drawing.Point(296, 42);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(57, 19);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDestino.ForeColor = System.Drawing.Color.White;
            this.lblDestino.Location = new System.Drawing.Point(500, 42);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(64, 19);
            this.lblDestino.TabIndex = 0;
            this.lblDestino.Text = "Destino";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(463, 132);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPeso);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.lblOrigen);
            this.groupBox1.Controls.Add(this.btnPartir);
            this.groupBox1.Controls.Add(this.lblPorcentageCarga);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.cboTipoCarga);
            this.groupBox1.Controls.Add(this.dgvCargas);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.cboCamion);
            this.groupBox1.Controls.Add(this.lblCamion);
            this.groupBox1.Controls.Add(this.lblPesoRestante);
            this.groupBox1.Controls.Add(this.txtOrigen);
            this.groupBox1.Controls.Add(this.lblViaje);
            this.groupBox1.Location = new System.Drawing.Point(35, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.ForeColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(326, 144);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(48, 19);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // FrmViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmViaje";
            this.Text = "Origen";
            this.Load += new System.EventHandler(this.FrmViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblViaje;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.Label lblPesoRestante;
        private System.Windows.Forms.Label lblCamion;
        private System.Windows.Forms.ComboBox cboCamion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvCargas;
        private System.Windows.Forms.ComboBox cboTipoCarga;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPorcentageCarga;
        private System.Windows.Forms.Button btnPartir;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeso;
        private System.Windows.Forms.DataGridViewButtonColumn ColDescargar;
        private System.Windows.Forms.Label lblPeso;
    }
}