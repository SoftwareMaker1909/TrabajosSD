namespace Iniciar
{
    partial class Transacciones
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
            this.btnrealizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtipotrasaccion = new System.Windows.Forms.ComboBox();
            this.cbcuenta = new System.Windows.Forms.ComboBox();
            this.tbmonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(18, 64);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(608, 214);
            this.dgvDatos.TabIndex = 0;
            // 
            // btnrealizar
            // 
            this.btnrealizar.Location = new System.Drawing.Point(435, 18);
            this.btnrealizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnrealizar.Name = "btnrealizar";
            this.btnrealizar.Size = new System.Drawing.Size(129, 31);
            this.btnrealizar.TabIndex = 1;
            this.btnrealizar.Text = "Realizar Trasaccion";
            this.btnrealizar.UseVisualStyleBackColor = true;
            this.btnrealizar.Click += new System.EventHandler(this.btnrealizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo de Trasaccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cuenta";
            // 
            // cbtipotrasaccion
            // 
            this.cbtipotrasaccion.FormattingEnabled = true;
            this.cbtipotrasaccion.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.cbtipotrasaccion.Location = new System.Drawing.Point(149, 24);
            this.cbtipotrasaccion.Margin = new System.Windows.Forms.Padding(2);
            this.cbtipotrasaccion.Name = "cbtipotrasaccion";
            this.cbtipotrasaccion.Size = new System.Drawing.Size(116, 21);
            this.cbtipotrasaccion.TabIndex = 36;
            // 
            // cbcuenta
            // 
            this.cbcuenta.FormattingEnabled = true;
            this.cbcuenta.Location = new System.Drawing.Point(13, 25);
            this.cbcuenta.Margin = new System.Windows.Forms.Padding(2);
            this.cbcuenta.Name = "cbcuenta";
            this.cbcuenta.Size = new System.Drawing.Size(116, 21);
            this.cbcuenta.TabIndex = 37;
            // 
            // tbmonto
            // 
            this.tbmonto.Location = new System.Drawing.Point(290, 26);
            this.tbmonto.Name = "tbmonto";
            this.tbmonto.Size = new System.Drawing.Size(100, 20);
            this.tbmonto.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Monto";
            // 
            // Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 289);
            this.Controls.Add(this.tbmonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbtipotrasaccion);
            this.Controls.Add(this.cbcuenta);
            this.Controls.Add(this.btnrealizar);
            this.Controls.Add(this.dgvDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Transacciones";
            this.Text = "Transacciones";
            this.Load += new System.EventHandler(this.Transacciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnrealizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtipotrasaccion;
        private System.Windows.Forms.ComboBox cbcuenta;
        private System.Windows.Forms.TextBox tbmonto;
        private System.Windows.Forms.Label label2;
    }
}