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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnforms = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientesbtn
            // 
            this.Clientesbtn.Location = new System.Drawing.Point(0, 35);
            this.Clientesbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Clientesbtn.Name = "Clientesbtn";
            this.Clientesbtn.Size = new System.Drawing.Size(174, 57);
            this.Clientesbtn.TabIndex = 0;
            this.Clientesbtn.Text = "Clientes";
            this.Clientesbtn.UseVisualStyleBackColor = true;
            this.Clientesbtn.Click += new System.EventHandler(this.Clientesbtn_Click);
            // 
            // Transaccionesbtn
            // 
            this.Transaccionesbtn.Location = new System.Drawing.Point(0, 218);
            this.Transaccionesbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Transaccionesbtn.Name = "Transaccionesbtn";
            this.Transaccionesbtn.Size = new System.Drawing.Size(174, 64);
            this.Transaccionesbtn.TabIndex = 1;
            this.Transaccionesbtn.Text = "Transacciones";
            this.Transaccionesbtn.UseVisualStyleBackColor = true;
            this.Transaccionesbtn.Click += new System.EventHandler(this.Transaccionesbtn_Click);
            // 
            // Cuentasbtn
            // 
            this.Cuentasbtn.Location = new System.Drawing.Point(0, 132);
            this.Cuentasbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Cuentasbtn.Name = "Cuentasbtn";
            this.Cuentasbtn.Size = new System.Drawing.Size(174, 44);
            this.Cuentasbtn.TabIndex = 2;
            this.Cuentasbtn.Text = "Cuentas";
            this.Cuentasbtn.UseVisualStyleBackColor = true;
            this.Cuentasbtn.Click += new System.EventHandler(this.Cuentasbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 327);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.Clientesbtn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Cuentasbtn);
            this.panel1.Controls.Add(this.Transaccionesbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 495);
            this.panel1.TabIndex = 3;
            // 
            // pnforms
            // 
            this.pnforms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnforms.Location = new System.Drawing.Point(174, 0);
            this.pnforms.Name = "pnforms";
            this.pnforms.Size = new System.Drawing.Size(856, 495);
            this.pnforms.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1030, 495);
            this.Controls.Add(this.pnforms);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clientesbtn;
        private System.Windows.Forms.Button Transaccionesbtn;
        private System.Windows.Forms.Button Cuentasbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnforms;
    }
}