namespace Iniciar
{
    partial class Menu
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
            this.Clientesbtn = new System.Windows.Forms.Button();
            this.Transaccionesbtn = new System.Windows.Forms.Button();
            this.Cuentasbtn = new System.Windows.Forms.Button();
            this.cerrarbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clientesbtn
            // 
            this.Clientesbtn.Location = new System.Drawing.Point(41, 44);
            this.Clientesbtn.Name = "Clientesbtn";
            this.Clientesbtn.Size = new System.Drawing.Size(193, 89);
            this.Clientesbtn.TabIndex = 0;
            this.Clientesbtn.Text = "Clientes";
            this.Clientesbtn.UseVisualStyleBackColor = true;
            // 
            // Transaccionesbtn
            // 
            this.Transaccionesbtn.Location = new System.Drawing.Point(41, 383);
            this.Transaccionesbtn.Name = "Transaccionesbtn";
            this.Transaccionesbtn.Size = new System.Drawing.Size(193, 79);
            this.Transaccionesbtn.TabIndex = 1;
            this.Transaccionesbtn.Text = "Transacciones";
            this.Transaccionesbtn.UseVisualStyleBackColor = true;
            // 
            // Cuentasbtn
            // 
            this.Cuentasbtn.Location = new System.Drawing.Point(41, 212);
            this.Cuentasbtn.Name = "Cuentasbtn";
            this.Cuentasbtn.Size = new System.Drawing.Size(193, 83);
            this.Cuentasbtn.TabIndex = 2;
            this.Cuentasbtn.Text = "Cuentas";
            this.Cuentasbtn.UseVisualStyleBackColor = true;
            // 
            // cerrarbtn
            // 
            this.cerrarbtn.Location = new System.Drawing.Point(979, 480);
            this.cerrarbtn.Name = "cerrarbtn";
            this.cerrarbtn.Size = new System.Drawing.Size(75, 23);
            this.cerrarbtn.TabIndex = 3;
            this.cerrarbtn.Text = "Cerrar";
            this.cerrarbtn.UseVisualStyleBackColor = true;
            this.cerrarbtn.Click += new System.EventHandler(this.cerrarbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1066, 515);
            this.Controls.Add(this.cerrarbtn);
            this.Controls.Add(this.Cuentasbtn);
            this.Controls.Add(this.Transaccionesbtn);
            this.Controls.Add(this.Clientesbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clientesbtn;
        private System.Windows.Forms.Button Transaccionesbtn;
        private System.Windows.Forms.Button Cuentasbtn;
        private System.Windows.Forms.Button cerrarbtn;
    }
}