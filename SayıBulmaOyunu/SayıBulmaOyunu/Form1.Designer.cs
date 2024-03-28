namespace SayıBulmaOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            buttonCreateNumber = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            buttonGuess = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2", "3", "4", "5" });
            comboBox1.Location = new Point(121, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // buttonCreateNumber
            // 
            buttonCreateNumber.Location = new Point(121, 65);
            buttonCreateNumber.Name = "buttonCreateNumber";
            buttonCreateNumber.Size = new Size(151, 29);
            buttonCreateNumber.TabIndex = 1;
            buttonCreateNumber.Text = "Sayı Üret";
            buttonCreateNumber.UseVisualStyleBackColor = true;
            buttonCreateNumber.Click += buttonCreateNumber_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(240, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(32, 35);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(186, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(32, 35);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(134, 28);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(32, 35);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(80, 28);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(32, 35);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(24, 28);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(32, 35);
            textBox5.TabIndex = 6;
            // 
            // buttonGuess
            // 
            buttonGuess.Location = new Point(58, 77);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(180, 33);
            buttonGuess.TabIndex = 7;
            buttonGuess.Text = "Tahmin Et";
            buttonGuess.UseVisualStyleBackColor = true;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(buttonGuess);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(32, 270);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 125);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(buttonCreateNumber);
            panel2.Location = new Point(32, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(294, 125);
            panel2.TabIndex = 9;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 84);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tekrarsız";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 54);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tekrarlı";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Basamak :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(108, 398);
            label2.Name = "label2";
            label2.Size = new Size(162, 35);
            label2.TabIndex = 10;
            label2.Text = "Burak Turan";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(65, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 96);
            panel3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 62);
            label4.Name = "label4";
            label4.Size = new Size(143, 20);
            label4.TabIndex = 12;
            label4.Text = "Kalan Hak : Tanımsız";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "3", "5", "10", "20", "50", "100" });
            comboBox2.Location = new Point(121, 15);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(55, 28);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 18);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 0;
            label3.Text = "Tanımlı Hak :";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(359, 437);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Sayı Bulma Oyunu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button buttonCreateNumber;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button buttonGuess;
        private Panel panel1;
        private Panel panel2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
    }
}