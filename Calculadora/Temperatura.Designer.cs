namespace Calculadora
{
    partial class Temperatura
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
            this.radioButtonCelsius1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFahrenheit1 = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin1 = new System.Windows.Forms.RadioButton();
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConversao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonFahrenheit2 = new System.Windows.Forms.RadioButton();
            this.radioButtonKelvin2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCelsius2 = new System.Windows.Forms.RadioButton();
            this.buttonCoverter = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonCelsius1
            // 
            this.radioButtonCelsius1.AutoSize = true;
            this.radioButtonCelsius1.Location = new System.Drawing.Point(16, 20);
            this.radioButtonCelsius1.Name = "radioButtonCelsius1";
            this.radioButtonCelsius1.Size = new System.Drawing.Size(116, 24);
            this.radioButtonCelsius1.TabIndex = 0;
            this.radioButtonCelsius1.TabStop = true;
            this.radioButtonCelsius1.Text = "Celsius (ºC)";
            this.radioButtonCelsius1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFahrenheit1);
            this.groupBox1.Controls.Add(this.radioButtonKelvin1);
            this.groupBox1.Controls.Add(this.radioButtonCelsius1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Converter de:";
            // 
            // radioButtonFahrenheit1
            // 
            this.radioButtonFahrenheit1.AutoSize = true;
            this.radioButtonFahrenheit1.Location = new System.Drawing.Point(243, 20);
            this.radioButtonFahrenheit1.Name = "radioButtonFahrenheit1";
            this.radioButtonFahrenheit1.Size = new System.Drawing.Size(135, 24);
            this.radioButtonFahrenheit1.TabIndex = 2;
            this.radioButtonFahrenheit1.TabStop = true;
            this.radioButtonFahrenheit1.Text = "Fahrenheit (F)";
            this.radioButtonFahrenheit1.UseVisualStyleBackColor = true;
            // 
            // radioButtonKelvin1
            // 
            this.radioButtonKelvin1.AutoSize = true;
            this.radioButtonKelvin1.Location = new System.Drawing.Point(138, 20);
            this.radioButtonKelvin1.Name = "radioButtonKelvin1";
            this.radioButtonKelvin1.Size = new System.Drawing.Size(99, 24);
            this.radioButtonKelvin1.TabIndex = 1;
            this.radioButtonKelvin1.TabStop = true;
            this.radioButtonKelvin1.Text = "Kelvin (K)";
            this.radioButtonKelvin1.UseVisualStyleBackColor = true;
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemperatura.Location = new System.Drawing.Point(16, 49);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(192, 26);
            this.textBoxTemperatura.TabIndex = 2;
            this.textBoxTemperatura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperatura";
            // 
            // labelConversao
            // 
            this.labelConversao.Location = new System.Drawing.Point(12, 297);
            this.labelConversao.Name = "labelConversao";
            this.labelConversao.Size = new System.Drawing.Size(60, 29);
            this.labelConversao.TabIndex = 6;
            this.labelConversao.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonFahrenheit2);
            this.groupBox2.Controls.Add(this.radioButtonKelvin2);
            this.groupBox2.Controls.Add(this.radioButtonCelsius2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 51);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converter para:";
            // 
            // radioButtonFahrenheit2
            // 
            this.radioButtonFahrenheit2.AutoSize = true;
            this.radioButtonFahrenheit2.Location = new System.Drawing.Point(243, 21);
            this.radioButtonFahrenheit2.Name = "radioButtonFahrenheit2";
            this.radioButtonFahrenheit2.Size = new System.Drawing.Size(135, 24);
            this.radioButtonFahrenheit2.TabIndex = 2;
            this.radioButtonFahrenheit2.TabStop = true;
            this.radioButtonFahrenheit2.Text = "Fahrenheit (F)";
            this.radioButtonFahrenheit2.UseVisualStyleBackColor = true;
            // 
            // radioButtonKelvin2
            // 
            this.radioButtonKelvin2.AutoSize = true;
            this.radioButtonKelvin2.Location = new System.Drawing.Point(138, 21);
            this.radioButtonKelvin2.Name = "radioButtonKelvin2";
            this.radioButtonKelvin2.Size = new System.Drawing.Size(99, 24);
            this.radioButtonKelvin2.TabIndex = 1;
            this.radioButtonKelvin2.TabStop = true;
            this.radioButtonKelvin2.Text = "Kelvin (K)";
            this.radioButtonKelvin2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCelsius2
            // 
            this.radioButtonCelsius2.AutoSize = true;
            this.radioButtonCelsius2.Location = new System.Drawing.Point(16, 21);
            this.radioButtonCelsius2.Name = "radioButtonCelsius2";
            this.radioButtonCelsius2.Size = new System.Drawing.Size(116, 24);
            this.radioButtonCelsius2.TabIndex = 0;
            this.radioButtonCelsius2.TabStop = true;
            this.radioButtonCelsius2.Text = "Celsius (ºC)";
            this.radioButtonCelsius2.UseVisualStyleBackColor = true;
            // 
            // buttonCoverter
            // 
            this.buttonCoverter.BackColor = System.Drawing.Color.DarkGray;
            this.buttonCoverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCoverter.Location = new System.Drawing.Point(16, 249);
            this.buttonCoverter.Name = "buttonCoverter";
            this.buttonCoverter.Size = new System.Drawing.Size(96, 45);
            this.buttonCoverter.TabIndex = 5;
            this.buttonCoverter.Text = "Converter";
            this.buttonCoverter.UseVisualStyleBackColor = false;
            this.buttonCoverter.Click += new System.EventHandler(this.buttonCoverter_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(130, 249);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(96, 45);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Temperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(547, 351);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCoverter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelConversao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTemperatura);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Temperatura";
            this.Text = "Conversor Temperatura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonCelsius1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit1;
        private System.Windows.Forms.RadioButton radioButtonKelvin1;
        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConversao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonFahrenheit2;
        private System.Windows.Forms.RadioButton radioButtonKelvin2;
        private System.Windows.Forms.RadioButton radioButtonCelsius2;
        private System.Windows.Forms.Button buttonCoverter;
        private System.Windows.Forms.Button buttonClear;
    }
}