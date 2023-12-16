namespace NivelEstudiosSql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
     

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DG = new System.Windows.Forms.DataGridView();
            this.Empleado_idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEscuela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Broadway", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla De Nivel De Estudios";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DG
            // 
            this.DG.AllowUserToDeleteRows = false;
            this.DG.AllowUserToResizeColumns = false;
            this.DG.AllowUserToResizeRows = false;
            this.DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Empleado_idEmpleado,
            this.Grado,
            this.Titulado,
            this.Fecha_Egreso,
            this.NombreEscuela,
            this.Especialidad});
            this.DG.Location = new System.Drawing.Point(12, 213);
            this.DG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DG.Name = "DG";
            this.DG.RowHeadersWidth = 51;
            this.DG.RowTemplate.Height = 24;
            this.DG.Size = new System.Drawing.Size(1280, 531);
            this.DG.TabIndex = 6;
            this.toolTip1.SetToolTip(this.DG, "Es necesario hacer seleccion del asterisco en donde se requieren cambios");
            this.DG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_CellClick);
            // 
            // Empleado_idEmpleado
            // 
            this.Empleado_idEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Empleado_idEmpleado.HeaderText = "idEmpleado";
            this.Empleado_idEmpleado.MinimumWidth = 10;
            this.Empleado_idEmpleado.Name = "Empleado_idEmpleado";
            // 
            // Grado
            // 
            this.Grado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Grado.HeaderText = "Grado";
            this.Grado.MinimumWidth = 6;
            this.Grado.Name = "Grado";
            // 
            // Titulado
            // 
            this.Titulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulado.HeaderText = "Titulado";
            this.Titulado.MinimumWidth = 6;
            this.Titulado.Name = "Titulado";
            // 
            // Fecha_Egreso
            // 
            this.Fecha_Egreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha_Egreso.HeaderText = "Fecha_Egreso";
            this.Fecha_Egreso.MinimumWidth = 6;
            this.Fecha_Egreso.Name = "Fecha_Egreso";
            this.Fecha_Egreso.ReadOnly = true;
            // 
            // NombreEscuela
            // 
            this.NombreEscuela.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreEscuela.HeaderText = "NombreEscuela";
            this.NombreEscuela.MinimumWidth = 6;
            this.NombreEscuela.Name = "NombreEscuela";
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.MinimumWidth = 6;
            this.Especialidad.Name = "Especialidad";
            // 
            // BtnSelect
            // 
            this.BtnSelect.AutoSize = true;
            this.BtnSelect.BackgroundImage = global::NivelEstudiosSql.Properties.Resources.tumblr_o7nijqvcpg1sipz2so1_500;
            this.BtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSelect.Location = new System.Drawing.Point(718, 164);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(227, 33);
            this.BtnSelect.TabIndex = 4;
            this.BtnSelect.Text = "Mostrar Datos De La Tabla";
            this.toolTip1.SetToolTip(this.BtnSelect, "Muestra los datos dentro de la tabla NivelEstudios de la base de datos");
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackgroundImage = global::NivelEstudiosSql.Properties.Resources.tumblr_o7nijqvcpg1sipz2so1_500;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(1064, 164);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(227, 33);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Eliminar Datos De La Tabla";
            this.toolTip1.SetToolTip(this.BtnDelete, "Seleccionar la columna de donde se desea eliminar datos ");
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.BackgroundImage = global::NivelEstudiosSql.Properties.Resources.tumblr_o7nijqvcpg1sipz2so1_500;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Location = new System.Drawing.Point(385, 164);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(227, 33);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Actualizar Datos De La Tabla";
            this.toolTip1.SetToolTip(this.BtnUpdate, "Permite Actualizar datos dentro de la tabla NivelEstudios en la base de datos");
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.AutoSize = true;
            this.BtnInsert.BackgroundImage = global::NivelEstudiosSql.Properties.Resources.tumblr_o7nijqvcpg1sipz2so1_500;
            this.BtnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInsert.Location = new System.Drawing.Point(45, 164);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(227, 33);
            this.BtnInsert.TabIndex = 1;
            this.BtnInsert.Text = "Insertar Datos De La Tabla";
            this.toolTip1.SetToolTip(this.BtnInsert, "Seleccionar la columna donde se ingresaron los datos que se desean añadir");
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1303, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DG);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.DataGridView DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado_idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEscuela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

