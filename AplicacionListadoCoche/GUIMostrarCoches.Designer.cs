
namespace AplicacionListadoCoche
{
    partial class GUIMostrarCoches
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadecreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarPri = new System.Windows.Forms.Button();
            this.btnElimnarUlti = new System.Windows.Forms.Button();
            this.btnElimPosicion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(36, 211);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(98, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Coches";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(226, 211);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // grilla
            // 
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grilla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Marca,
            this.Modelo,
            this.numero,
            this.fechadecreacion,
            this.Eliminar,
            this.Actualizar});
            this.grilla.Location = new System.Drawing.Point(36, 40);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(467, 155);
            this.grilla.TabIndex = 6;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickEnBotton);
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 25;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "grilla_CellContentClick()";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero de AirBags";
            this.numero.Name = "numero";
            // 
            // fechadecreacion
            // 
            this.fechadecreacion.HeaderText = "Fecha de Creación";
            this.fechadecreacion.Name = "fechadecreacion";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "X";
            this.Eliminar.Width = 60;
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "Actualizar";
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Text = "(/)";
            this.Actualizar.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(556, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // btnEliminarPri
            // 
            this.btnEliminarPri.Location = new System.Drawing.Point(49, 264);
            this.btnEliminarPri.Name = "btnEliminarPri";
            this.btnEliminarPri.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPri.TabIndex = 8;
            this.btnEliminarPri.Text = "Primero";
            this.btnEliminarPri.UseVisualStyleBackColor = true;
            this.btnEliminarPri.Click += new System.EventHandler(this.btnEliminarPri_Click);
            // 
            // btnElimnarUlti
            // 
            this.btnElimnarUlti.Location = new System.Drawing.Point(226, 264);
            this.btnElimnarUlti.Name = "btnElimnarUlti";
            this.btnElimnarUlti.Size = new System.Drawing.Size(75, 23);
            this.btnElimnarUlti.TabIndex = 9;
            this.btnElimnarUlti.Text = "Ultimo";
            this.btnElimnarUlti.UseVisualStyleBackColor = true;
            this.btnElimnarUlti.Click += new System.EventHandler(this.btnElimnarUlti_Click);
            // 
            // btnElimPosicion
            // 
            this.btnElimPosicion.Location = new System.Drawing.Point(368, 260);
            this.btnElimPosicion.Name = "btnElimPosicion";
            this.btnElimPosicion.Size = new System.Drawing.Size(62, 27);
            this.btnElimPosicion.TabIndex = 10;
            this.btnElimPosicion.Text = "Posición : ";
            this.btnElimPosicion.UseVisualStyleBackColor = true;
            this.btnElimPosicion.Click += new System.EventHandler(this.btnElimPosicion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Eliminar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(452, 264);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(79, 20);
            this.txtPosicion.TabIndex = 12;
            // 
            // GUIMostrarCoches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(556, 301);
            this.Controls.Add(this.txtPosicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnElimPosicion);
            this.Controls.Add(this.btnElimnarUlti);
            this.Controls.Add(this.btnEliminarPri);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUIMostrarCoches";
            this.Text = "GUIMostrarCoches";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Button btnEliminarPri;
        private System.Windows.Forms.Button btnElimnarUlti;
        private System.Windows.Forms.Button btnElimPosicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadecreacion;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
    }
}