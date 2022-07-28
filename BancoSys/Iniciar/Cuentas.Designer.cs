namespace Iniciar
{
    partial class Cuentas
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
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cbcliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbsaldo = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.Actualizarbtn = new System.Windows.Forms.Button();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbnocuenta = new System.Windows.Forms.TextBox();
            this.cbtipocuenta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(11, 92);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(558, 232);
            this.dgvDatos.TabIndex = 0;
            this.dgvDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDatos_MouseDoubleClick);
            // 
            // cbcliente
            // 
            this.cbcliente.FormattingEnabled = true;
            this.cbcliente.Location = new System.Drawing.Point(159, 67);
            this.cbcliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbcliente.Name = "cbcliente";
            this.cbcliente.Size = new System.Drawing.Size(116, 21);
            this.cbcliente.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "CLIENTE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 12;
            // 
            // tbsaldo
            // 
            this.tbsaldo.AutoSize = true;
            this.tbsaldo.Location = new System.Drawing.Point(471, 52);
            this.tbsaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tbsaldo.Name = "tbsaldo";
            this.tbsaldo.Size = new System.Drawing.Size(43, 13);
            this.tbsaldo.TabIndex = 13;
            this.tbsaldo.Text = "SALDO";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(376, 329);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 29);
            this.btnlimpiar.TabIndex = 30;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Enabled = false;
            this.eliminarbtn.Location = new System.Drawing.Point(289, 329);
            this.eliminarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(82, 29);
            this.eliminarbtn.TabIndex = 29;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            this.eliminarbtn.Click += new System.EventHandler(this.eliminarbtn_Click);
            // 
            // Actualizarbtn
            // 
            this.Actualizarbtn.Enabled = false;
            this.Actualizarbtn.Location = new System.Drawing.Point(203, 329);
            this.Actualizarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizarbtn.Name = "Actualizarbtn";
            this.Actualizarbtn.Size = new System.Drawing.Size(82, 29);
            this.Actualizarbtn.TabIndex = 28;
            this.Actualizarbtn.Text = "Actualizar";
            this.Actualizarbtn.UseVisualStyleBackColor = true;
            this.Actualizarbtn.Click += new System.EventHandler(this.Actualizarbtn_Click);
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(117, 329);
            this.Agregarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(82, 29);
            this.Agregarbtn.TabIndex = 27;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Busqueda";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(76, 6);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(196, 20);
            this.tbsearch.TabIndex = 32;
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Location = new System.Drawing.Point(290, 6);
            this.Buscarbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(82, 20);
            this.Buscarbtn.TabIndex = 31;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 52);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "No Cuenta";
            // 
            // tbnocuenta
            // 
            this.tbnocuenta.Location = new System.Drawing.Point(14, 67);
            this.tbnocuenta.Margin = new System.Windows.Forms.Padding(2);
            this.tbnocuenta.Name = "tbnocuenta";
            this.tbnocuenta.ReadOnly = true;
            this.tbnocuenta.Size = new System.Drawing.Size(120, 20);
            this.tbnocuenta.TabIndex = 34;
            // 
            // cbtipocuenta
            // 
            this.cbtipocuenta.FormattingEnabled = true;
            this.cbtipocuenta.Items.AddRange(new object[] {
            "Ahorro",
            "Corrientes"});
            this.cbtipocuenta.Location = new System.Drawing.Point(306, 66);
            this.cbtipocuenta.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipocuenta.Name = "cbtipocuenta";
            this.cbtipocuenta.Size = new System.Drawing.Size(116, 21);
            this.cbtipocuenta.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TIPO DE CUENTA";
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 374);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbnocuenta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.Actualizarbtn);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.tbsaldo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtipocuenta);
            this.Controls.Add(this.cbcliente);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            this.Load += new System.EventHandler(this.Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ComboBox cbcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbsaldo;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button Actualizarbtn;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbnocuenta;
        private System.Windows.Forms.ComboBox cbtipocuenta;
        private System.Windows.Forms.Label label3;
    }
}