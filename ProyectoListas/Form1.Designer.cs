namespace ProyectoListas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmdEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.columnNombreCompleto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEstadoCivil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(66, 61);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(158, 20);
            this.txtNombreCompleto.TabIndex = 4;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(254, 60);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(94, 21);
            this.cmbGenero.TabIndex = 5;
            // 
            // cmdEstadoCivil
            // 
            this.cmdEstadoCivil.FormattingEnabled = true;
            this.cmdEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Union Libre",
            "Viudo"});
            this.cmdEstadoCivil.Location = new System.Drawing.Point(373, 61);
            this.cmdEstadoCivil.Name = "cmdEstadoCivil";
            this.cmdEstadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cmdEstadoCivil.TabIndex = 6;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(530, 62);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(66, 114);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar a la lista";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNombreCompleto,
            this.columnGenero,
            this.columnEstadoCivil,
            this.columnEdad});
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(66, 155);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(698, 211);
            this.listViewEstudiantes.TabIndex = 9;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // columnNombreCompleto
            // 
            this.columnNombreCompleto.Text = "Nombre Completo";
            // 
            // columnGenero
            // 
            this.columnGenero.Text = "Género";
            // 
            // columnEstadoCivil
            // 
            this.columnEstadoCivil.Text = "Estado Civil";
            // 
            // columnEdad
            // 
            this.columnEdad.Text = "Edad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.cmdEstadoCivil);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmdEstadoCivil;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.ColumnHeader columnNombreCompleto;
        private System.Windows.Forms.ColumnHeader columnGenero;
        private System.Windows.Forms.ColumnHeader columnEstadoCivil;
        private System.Windows.Forms.ColumnHeader columnEdad;
    }
}

