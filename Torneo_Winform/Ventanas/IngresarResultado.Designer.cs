﻿namespace WindowsFormsApp
{
    partial class IngresarResultado
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
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.texId = new System.Windows.Forms.TextBox();
            this.textGolEqui1 = new System.Windows.Forms.TextBox();
            this.textGolEqui2 = new System.Windows.Forms.TextBox();
            this.textClima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbxPartidos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(69, 383);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(132, 37);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // texId
            // 
            this.texId.Location = new System.Drawing.Point(81, 23);
            this.texId.Name = "texId";
            this.texId.Size = new System.Drawing.Size(100, 20);
            this.texId.TabIndex = 2;
            // 
            // textGolEqui1
            // 
            this.textGolEqui1.Location = new System.Drawing.Point(84, 127);
            this.textGolEqui1.Name = "textGolEqui1";
            this.textGolEqui1.Size = new System.Drawing.Size(100, 20);
            this.textGolEqui1.TabIndex = 4;
            // 
            // textGolEqui2
            // 
            this.textGolEqui2.Location = new System.Drawing.Point(324, 127);
            this.textGolEqui2.Name = "textGolEqui2";
            this.textGolEqui2.Size = new System.Drawing.Size(100, 20);
            this.textGolEqui2.TabIndex = 5;
            // 
            // textClima
            // 
            this.textClima.Location = new System.Drawing.Point(388, 30);
            this.textClima.Name = "textClima";
            this.textClima.Size = new System.Drawing.Size(100, 20);
            this.textClima.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Partido *";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Goles Equipo 1 *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Goles Equipo 2 *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Clima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descripción";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(81, 232);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(451, 96);
            this.richTextBoxDescripcion.TabIndex = 15;
            this.richTextBoxDescripcion.Text = "";
            // 
            // cbxPartidos
            // 
            this.cbxPartidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPartidos.FormattingEnabled = true;
            this.cbxPartidos.Location = new System.Drawing.Point(81, 67);
            this.cbxPartidos.Name = "cbxPartidos";
            this.cbxPartidos.Size = new System.Drawing.Size(170, 21);
            this.cbxPartidos.TabIndex = 16;
            // 
            // IngresarResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.cbxPartidos);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textClima);
            this.Controls.Add(this.textGolEqui2);
            this.Controls.Add(this.textGolEqui1);
            this.Controls.Add(this.texId);
            this.Controls.Add(this.BtnIngresar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngresarResultado";
            this.Text = "IngresarResultado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IngresarResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.TextBox texId;
        private System.Windows.Forms.TextBox textGolEqui1;
        private System.Windows.Forms.TextBox textGolEqui2;
        private System.Windows.Forms.TextBox textClima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.ComboBox cbxPartidos;
    }
}