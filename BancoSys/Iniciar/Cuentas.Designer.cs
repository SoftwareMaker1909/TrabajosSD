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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eliminarbtn = new System.Windows.Forms.Button();
            this.Actualizarbtn = new System.Windows.Forms.Button();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // eliminarbtn
            // 
            this.eliminarbtn.Location = new System.Drawing.Point(970, 248);
            this.eliminarbtn.Name = "eliminarbtn";
            this.eliminarbtn.Size = new System.Drawing.Size(109, 36);
            this.eliminarbtn.TabIndex = 9;
            this.eliminarbtn.Text = "Eliminar";
            this.eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // Actualizarbtn
            // 
            this.Actualizarbtn.Location = new System.Drawing.Point(385, 248);
            this.Actualizarbtn.Name = "Actualizarbtn";
            this.Actualizarbtn.Size = new System.Drawing.Size(109, 36);
            this.Actualizarbtn.TabIndex = 8;
            this.Actualizarbtn.Text = "Actualizar";
            this.Actualizarbtn.UseVisualStyleBackColor = true;
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Location = new System.Drawing.Point(681, 248);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(109, 36);
            this.Buscarbtn.TabIndex = 7;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.Location = new System.Drawing.Point(63, 248);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(109, 36);
            this.Agregarbtn.TabIndex = 6;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(347, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "CLIENTE";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(669, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "No Cuenta";
            // 
            // Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.eliminarbtn);
            this.Controls.Add(this.Actualizarbtn);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuentas";
            this.Text = "Cuentas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button eliminarbtn;
        private System.Windows.Forms.Button Actualizarbtn;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}