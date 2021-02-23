
namespace AplicacionListadoCoche
{
    partial class GUIAdicionarCoches
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
            this.pnlFechaCreacion = new System.Windows.Forms.Panel();
            this.dateTPFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroAir = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumeroAir = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnAgragarFinal = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnAgrePosi = new System.Windows.Forms.Button();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.pnlFechaCreacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFechaCreacion
            // 
            this.pnlFechaCreacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFechaCreacion.Controls.Add(this.dateTPFecha);
            this.pnlFechaCreacion.Controls.Add(this.txtNumeroAir);
            this.pnlFechaCreacion.Controls.Add(this.txtModelo);
            this.pnlFechaCreacion.Controls.Add(this.txtMarca);
            this.pnlFechaCreacion.Controls.Add(this.lblFecha);
            this.pnlFechaCreacion.Controls.Add(this.lblNumeroAir);
            this.pnlFechaCreacion.Controls.Add(this.lblModelo);
            this.pnlFechaCreacion.Controls.Add(this.lblMarca);
            this.pnlFechaCreacion.Location = new System.Drawing.Point(12, 12);
            this.pnlFechaCreacion.Name = "pnlFechaCreacion";
            this.pnlFechaCreacion.Size = new System.Drawing.Size(646, 181);
            this.pnlFechaCreacion.TabIndex = 0;
            // 
            // dateTPFecha
            // 
            this.dateTPFecha.Location = new System.Drawing.Point(436, 67);
            this.dateTPFecha.Name = "dateTPFecha";
            this.dateTPFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTPFecha.TabIndex = 8;
            this.dateTPFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtNumeroAir
            // 
            this.txtNumeroAir.Location = new System.Drawing.Point(133, 124);
            this.txtNumeroAir.Name = "txtNumeroAir";
            this.txtNumeroAir.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroAir.TabIndex = 6;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(80, 70);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(244, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(75, 25);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(249, 20);
            this.txtMarca.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(345, 70);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha Creación:";
            // 
            // lblNumeroAir
            // 
            this.lblNumeroAir.AutoSize = true;
            this.lblNumeroAir.Location = new System.Drawing.Point(26, 127);
            this.lblNumeroAir.Name = "lblNumeroAir";
            this.lblNumeroAir.Size = new System.Drawing.Size(101, 13);
            this.lblNumeroAir.TabIndex = 2;
            this.lblNumeroAir.Text = "Numero de AirBags:";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(26, 73);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 13);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo :";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(26, 28);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(43, 13);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca :";
            this.lblMarca.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgragarFinal
            // 
            this.btnAgragarFinal.Location = new System.Drawing.Point(159, 222);
            this.btnAgragarFinal.Name = "btnAgragarFinal";
            this.btnAgragarFinal.Size = new System.Drawing.Size(120, 23);
            this.btnAgragarFinal.TabIndex = 2;
            this.btnAgragarFinal.Text = "Agregar Final";
            this.btnAgragarFinal.UseVisualStyleBackColor = true;
            this.btnAgragarFinal.Click += new System.EventHandler(this.btnAgragarFinal_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(12, 222);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(114, 23);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Agregar Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAgrePosi
            // 
            this.btnAgrePosi.Location = new System.Drawing.Point(302, 222);
            this.btnAgrePosi.Name = "btnAgrePosi";
            this.btnAgrePosi.Size = new System.Drawing.Size(142, 23);
            this.btnAgrePosi.TabIndex = 4;
            this.btnAgrePosi.Text = "Agregar En la Posición :";
            this.btnAgrePosi.UseVisualStyleBackColor = true;
            this.btnAgrePosi.Click += new System.EventHandler(this.btnAgrePosi_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(450, 224);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(63, 20);
            this.txtPosicion.TabIndex = 6;
            // 
            // GUIAdicionarCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(671, 262);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.btnAgrePosi);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnAgragarFinal);
            this.Controls.Add(this.pnlFechaCreacion);
            this.Name = "GUIAdicionarCoches";
            this.Text = "Concesionario agregar coches";
            this.pnlFechaCreacion.ResumeLayout(false);
            this.pnlFechaCreacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFechaCreacion;
        private System.Windows.Forms.TextBox txtNumeroAir;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumeroAir;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnAgragarFinal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnAgrePosi;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.DateTimePicker dateTPFecha;
    }
}