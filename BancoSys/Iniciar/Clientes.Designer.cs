namespace Iniciar
{
    partial class Clientes
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
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.Actualizarbtn = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbdirrecion = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbgenero = new System.Windows.Forms.ComboBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbnocliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(167, 366);
            this.Agregarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(82, 29);
            this.Agregarbtn.TabIndex = 2;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Location = new System.Drawing.Point(290, 24);
            this.Buscarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(82, 20);
            this.Buscarbtn.TabIndex = 3;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // Actualizarbtn
            // 
            this.Actualizarbtn.Enabled = false;
            this.Actualizarbtn.Location = new System.Drawing.Point(253, 366);
            this.Actualizarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizarbtn.Name = "Actualizarbtn";
            this.Actualizarbtn.Size = new System.Drawing.Size(82, 29);
            this.Actualizarbtn.TabIndex = 4;
            this.Actualizarbtn.Text = "Actualizar";
            this.Actualizarbtn.UseVisualStyleBackColor = true;
            this.Actualizarbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Enabled = false;
            this.eliminarbtn.Location = new System.Drawing.Point(339, 366);
            this.eliminarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(82, 29);
            this.eliminarbtn.TabIndex = 5;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(136, 85);
            this.tbnombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(120, 20);
            this.tbnombre.TabIndex = 6;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(604, 86);
            this.tbtelefono.Margin = new System.Windows.Forms.Padding(2);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(120, 20);
            this.tbtelefono.TabIndex = 7;
            this.tbtelefono.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbdirrecion
            // 
            this.tbdirrecion.Location = new System.Drawing.Point(480, 86);
            this.tbdirrecion.Margin = new System.Windows.Forms.Padding(2);
            this.tbdirrecion.Name = "tbdirrecion";
            this.tbdirrecion.Size = new System.Drawing.Size(120, 20);
            this.tbdirrecion.TabIndex = 9;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(260, 85);
            this.tbapellido.Margin = new System.Windows.Forms.Padding(2);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(120, 20);
            this.tbapellido.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TELEFONO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "GENERO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "APELLIDO";
            // 
            // cbgenero
            // 
            this.cbgenero.FormattingEnabled = true;
            this.cbgenero.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cbgenero.Location = new System.Drawing.Point(384, 85);
            this.cbgenero.Margin = new System.Windows.Forms.Padding(2);
            this.cbgenero.Name = "cbgenero";
            this.cbgenero.Size = new System.Drawing.Size(92, 21);
            this.cbgenero.TabIndex = 16;
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(76, 24);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(196, 20);
            this.tbsearch.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Busqueda";
            // 
            // tbnocliente
            // 
            this.tbnocliente.Location = new System.Drawing.Point(12, 86);
            this.tbnocliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbnocliente.Name = "tbnocliente";
            this.tbnocliente.ReadOnly = true;
            this.tbnocliente.Size = new System.Drawing.Size(120, 20);
            this.tbnocliente.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "No Cliente";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(426, 366);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 29);
            this.btnlimpiar.TabIndex = 26;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 111);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(716, 249);
            this.dgvDatos.TabIndex = 27;
            this.dgvDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDatos_MouseDoubleClick_1);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 404);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbnocliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.cbgenero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbdirrecion);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.Actualizarbtn);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.Agregarbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Button Actualizarbtn;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbdirrecion;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbgenero;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbnocliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}