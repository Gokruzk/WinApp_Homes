﻿namespace WinApp_Homes
{
    partial class ModificarInmuebleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.LblDesc = new System.Windows.Forms.Label();
            this.LblUbi = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.CbxTipo = new System.Windows.Forms.ComboBox();
            this.LblTipo = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataSetVenta1 = new WinApp_Homes.DataSetVenta();
            this.CbxUbi = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 78);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "MODIFICACIÓN DE UN INMUEBLE";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.textBox1.Location = new System.Drawing.Point(543, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Campo de búsqueda";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Codigo",
            "Nombre Inmueble"});
            this.comboBox1.Location = new System.Drawing.Point(211, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(89, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblCodigo.Location = new System.Drawing.Point(245, 173);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(0, 18);
            this.LblCodigo.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtNombre.Location = new System.Drawing.Point(204, 222);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(258, 26);
            this.TxtNombre.TabIndex = 34;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(89, 224);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 18);
            this.LblNombre.TabIndex = 33;
            this.LblNombre.Text = "Nombre:";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtDesc.Location = new System.Drawing.Point(488, 222);
            this.TxtDesc.Multiline = true;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(300, 133);
            this.TxtDesc.TabIndex = 32;
            // 
            // LblDesc
            // 
            this.LblDesc.AutoSize = true;
            this.LblDesc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDesc.ForeColor = System.Drawing.Color.White;
            this.LblDesc.Location = new System.Drawing.Point(586, 173);
            this.LblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDesc.Name = "LblDesc";
            this.LblDesc.Size = new System.Drawing.Size(109, 18);
            this.LblDesc.TabIndex = 31;
            this.LblDesc.Text = "Descripción:";
            // 
            // LblUbi
            // 
            this.LblUbi.AutoSize = true;
            this.LblUbi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUbi.ForeColor = System.Drawing.Color.White;
            this.LblUbi.Location = new System.Drawing.Point(89, 336);
            this.LblUbi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUbi.Name = "LblUbi";
            this.LblUbi.Size = new System.Drawing.Size(93, 18);
            this.LblUbi.TabIndex = 29;
            this.LblUbi.Text = "Ubicación:";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TxtPrecio.Location = new System.Drawing.Point(204, 296);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(258, 26);
            this.TxtPrecio.TabIndex = 28;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.White;
            this.LblPrecio.Location = new System.Drawing.Point(89, 298);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(60, 18);
            this.LblPrecio.TabIndex = 27;
            this.LblPrecio.Text = "Precio";
            // 
            // CbxTipo
            // 
            this.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CbxTipo.FormattingEnabled = true;
            this.CbxTipo.Items.AddRange(new object[] {
            "CASA",
            "DEPARTAMENTO",
            "OFICINA"});
            this.CbxTipo.Location = new System.Drawing.Point(205, 258);
            this.CbxTipo.Name = "CbxTipo";
            this.CbxTipo.Size = new System.Drawing.Size(258, 26);
            this.CbxTipo.TabIndex = 26;
            this.CbxTipo.SelectionChangeCommitted += new System.EventHandler(this.CbxTipo_SelectionChangeCommitted);
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipo.ForeColor = System.Drawing.Color.White;
            this.LblTipo.Location = new System.Drawing.Point(89, 260);
            this.LblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(42, 18);
            this.LblTipo.TabIndex = 35;
            this.LblTipo.Text = "Tipo";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(73)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(169)))), ((int)(((byte)(143)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.Black;
            this.BtnGuardar.Location = new System.Drawing.Point(283, 449);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(155, 43);
            this.BtnGuardar.TabIndex = 36;
            this.BtnGuardar.Text = "ACEPTAR CAMBIOS";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(3)))), ((int)(((byte)(31)))));
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(496, 449);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(155, 43);
            this.BtnEliminar.TabIndex = 37;
            this.BtnEliminar.Text = "DESCARTAR CAMBIOS";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dataSetVenta1
            // 
            this.dataSetVenta1.DataSetName = "DataSetVenta";
            this.dataSetVenta1.EnforceConstraints = false;
            this.dataSetVenta1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CbxUbi
            // 
            this.CbxUbi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CbxUbi.FormattingEnabled = true;
            this.CbxUbi.Items.AddRange(new object[] {
            "Ambato",
            "Atuntaqui",
            "Azogues",
            "Babahoyo",
            "Balzar",
            "Cayambe",
            "Cuenca",
            "Durán",
            "El Carmen",
            "Esmeraldas",
            "Gualaceo",
            "Guaranda",
            "Guayaquil",
            "Huaquillas",
            "Ibarra",
            "Jipijapa",
            "La Libertad",
            "La Troncal",
            "Latacunga",
            "Loja",
            "Machachi",
            "Machala",
            "Manta",
            "Milagro",
            "Montalvo",
            "Montecristi",
            "Naranjal",
            "Nueva Loja (Lago Agrio)",
            "Otavalo",
            "Pasaje",
            "Pedro Carbo",
            "Pelileo",
            "Playas",
            "Portoviejo",
            "Puerto Francisco de Orellana",
            "Puyo",
            "Quevedo",
            "Quito",
            "Riobamba",
            "Salinas",
            "San Lorenzo",
            "Santa Elena",
            "Santa Rosa",
            "Santo Domingo de los Colorados",
            "Tena",
            "Tulcán",
            "Ventanas",
            "Vinces",
            "Yaguachi",
            "Zamora"});
            this.CbxUbi.Location = new System.Drawing.Point(204, 333);
            this.CbxUbi.Margin = new System.Windows.Forms.Padding(2);
            this.CbxUbi.Name = "CbxUbi";
            this.CbxUbi.Size = new System.Drawing.Size(258, 26);
            this.CbxUbi.TabIndex = 38;
            // 
            // ModificarInmuebleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.CbxUbi);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.LblDesc);
            this.Controls.Add(this.LblUbi);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.CbxTipo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ModificarInmuebleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de un Inmueble";
            this.Load += new System.EventHandler(this.ModificarInmuebleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVenta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label LblDesc;
        private System.Windows.Forms.Label LblUbi;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.ComboBox CbxTipo;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEliminar;
        private DataSetVenta dataSetVenta1;
        private System.Windows.Forms.ComboBox CbxUbi;
    }
}