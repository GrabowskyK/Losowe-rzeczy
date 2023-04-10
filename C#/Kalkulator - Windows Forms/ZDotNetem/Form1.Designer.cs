using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Kalkulator
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
            button_7 = new Button();
            button_8 = new Button();
            button_9 = new Button();
            button_6 = new Button();
            button_5 = new Button();
            button_4 = new Button();
            button_3 = new Button();
            button_2 = new Button();
            button_1 = new Button();
            button_point = new Button();
            button_0 = new Button();
            button_char = new Button();
            button_equal = new Button();
            button_plus = new Button();
            button_multiply = new Button();
            button_division = new Button();
            button_minus = new Button();
            button_backspace = new Button();
            button_CE = new Button();
            button_C = new Button();
            textBox_result = new TextBox();
            textBox_show = new TextBox();
            SuspendLayout();
            // 
            // button_7
            // 
            button_7.Location = new Point(13, 175);
            button_7.Name = "button_7";
            button_7.Size = new Size(87, 75);
            button_7.TabIndex = 0;
            button_7.Text = "7";
            button_7.UseVisualStyleBackColor = true;
            button_7.Click += button_Click;
            // 
            // button_8
            // 
            button_8.Location = new Point(106, 175);
            button_8.Name = "button_8";
            button_8.Size = new Size(86, 75);
            button_8.TabIndex = 1;
            button_8.Text = "8";
            button_8.UseVisualStyleBackColor = true;
            button_8.Click += button_Click;
            // 
            // button_9
            // 
            button_9.Location = new Point(198, 175);
            button_9.Name = "button_9";
            button_9.Size = new Size(88, 75);
            button_9.TabIndex = 2;
            button_9.Text = "9";
            button_9.UseVisualStyleBackColor = true;
            button_9.Click += button_Click;
            // 
            // button_6
            // 
            button_6.Location = new Point(198, 256);
            button_6.Name = "button_6";
            button_6.Size = new Size(88, 75);
            button_6.TabIndex = 5;
            button_6.Text = "6";
            button_6.UseVisualStyleBackColor = true;
            button_6.Click += button_Click;
            // 
            // button_5
            // 
            button_5.Location = new Point(106, 256);
            button_5.Name = "button_5";
            button_5.Size = new Size(86, 75);
            button_5.TabIndex = 4;
            button_5.Text = "5";
            button_5.UseVisualStyleBackColor = true;
            button_5.Click += button_Click;
            // 
            // button_4
            // 
            button_4.Location = new Point(13, 256);
            button_4.Name = "button_4";
            button_4.Size = new Size(87, 75);
            button_4.TabIndex = 3;
            button_4.Text = "4";
            button_4.UseVisualStyleBackColor = true;
            button_4.Click += button_Click;
            // 
            // button_3
            // 
            button_3.Location = new Point(198, 337);
            button_3.Name = "button_3";
            button_3.Size = new Size(88, 75);
            button_3.TabIndex = 8;
            button_3.Text = "3";
            button_3.UseVisualStyleBackColor = true;
            button_3.Click += button_Click;
            // 
            // button_2
            // 
            button_2.Location = new Point(106, 337);
            button_2.Name = "button_2";
            button_2.Size = new Size(86, 75);
            button_2.TabIndex = 7;
            button_2.Text = "2";
            button_2.UseVisualStyleBackColor = true;
            button_2.Click += button_Click;
            // 
            // button_1
            // 
            button_1.Location = new Point(13, 337);
            button_1.Name = "button_1";
            button_1.Size = new Size(87, 75);
            button_1.TabIndex = 6;
            button_1.Text = "1";
            button_1.UseVisualStyleBackColor = true;
            button_1.Click += button_Click;
            // 
            // button_point
            // 
            button_point.Location = new Point(198, 418);
            button_point.Name = "button_point";
            button_point.Size = new Size(88, 75);
            button_point.TabIndex = 11;
            button_point.Text = ",";
            button_point.UseVisualStyleBackColor = true;
            button_point.Click += button_point_Click;
            // 
            // button_0
            // 
            button_0.Location = new Point(106, 418);
            button_0.Name = "button_0";
            button_0.Size = new Size(86, 75);
            button_0.TabIndex = 10;
            button_0.Text = "0";
            button_0.UseVisualStyleBackColor = true;
            button_0.Click += button_Click;
            // 
            // button_char
            // 
            button_char.Location = new Point(13, 418);
            button_char.Name = "button_char";
            button_char.Size = new Size(87, 75);
            button_char.TabIndex = 9;
            button_char.Text = "+/-";
            button_char.UseVisualStyleBackColor = true;
            button_char.Click += button_char_Click;
            // 
            // button_equal
            // 
            button_equal.Location = new Point(292, 418);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(88, 75);
            button_equal.TabIndex = 15;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = true;
            button_equal.Click += button_Click_character;
            // 
            // button_plus
            // 
            button_plus.Location = new Point(292, 337);
            button_plus.Name = "button_plus";
            button_plus.Size = new Size(88, 75);
            button_plus.TabIndex = 14;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = true;
            button_plus.Click += button_Click_character;
            // 
            // button_multiply
            // 
            button_multiply.Location = new Point(292, 176);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(88, 75);
            button_multiply.TabIndex = 13;
            button_multiply.Text = "*";
            button_multiply.UseVisualStyleBackColor = true;
            button_multiply.Click += button_Click_character;
            // 
            // button_division
            // 
            button_division.Location = new Point(292, 95);
            button_division.Name = "button_division";
            button_division.Size = new Size(88, 75);
            button_division.TabIndex = 12;
            button_division.Text = "/";
            button_division.UseVisualStyleBackColor = true;
            button_division.Click += button_Click_character;
            // 
            // button_minus
            // 
            button_minus.Location = new Point(292, 257);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(88, 75);
            button_minus.TabIndex = 16;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += button_Click_character;
            // 
            // button_backspace
            // 
            button_backspace.Location = new Point(198, 95);
            button_backspace.Name = "button_backspace";
            button_backspace.Size = new Size(88, 75);
            button_backspace.TabIndex = 19;
            button_backspace.Text = "backspace";
            button_backspace.UseVisualStyleBackColor = true;
            button_backspace.Click += button_backspace_Click;
            // 
            // button_CE
            // 
            button_CE.Location = new Point(106, 95);
            button_CE.Name = "button_CE";
            button_CE.Size = new Size(86, 75);
            button_CE.TabIndex = 18;
            button_CE.Text = "CE";
            button_CE.UseVisualStyleBackColor = true;
            button_CE.Click += button_CE_Click;
            // 
            // button_C
            // 
            button_C.Location = new Point(13, 95);
            button_C.Name = "button_C";
            button_C.Size = new Size(87, 75);
            button_C.TabIndex = 17;
            button_C.Text = "C";
            button_C.UseVisualStyleBackColor = true;
            button_C.Click += button_C_Click;
            // 
            // textBox_result
            // 
            textBox_result.Location = new Point(13, 66);
            textBox_result.Name = "textBox_result";
            textBox_result.Size = new Size(367, 23);
            textBox_result.TabIndex = 20;
            textBox_result.TextAlign = HorizontalAlignment.Right;
            textBox_result.TextChanged += textBox_result_TextChanged;
            // 
            // textBox_show
            // 
            textBox_show.Location = new Point(13, 37);
            textBox_show.Name = "textBox_show";
            textBox_show.Size = new Size(100, 23);
            textBox_show.TabIndex = 21;
            textBox_show.TextChanged += textBox_show_TextChanged;
            // 
            // Kalkulator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 517);
            Controls.Add(textBox_show);
            Controls.Add(textBox_result);
            Controls.Add(button_backspace);
            Controls.Add(button_CE);
            Controls.Add(button_C);
            Controls.Add(button_minus);
            Controls.Add(button_equal);
            Controls.Add(button_plus);
            Controls.Add(button_multiply);
            Controls.Add(button_division);
            Controls.Add(button_point);
            Controls.Add(button_0);
            Controls.Add(button_char);
            Controls.Add(button_3);
            Controls.Add(button_2);
            Controls.Add(button_1);
            Controls.Add(button_6);
            Controls.Add(button_5);
            Controls.Add(button_4);
            Controls.Add(button_9);
            Controls.Add(button_8);
            Controls.Add(button_7);
            Name = "Kalkulator";
            Text = "Kalkulator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_7;
        private Button button_8;
        private Button button_9;
        private Button button_6;
        private Button button_5;
        private Button button_4;
        private Button button_3;
        private Button button_2;
        private Button button_1;
        private Button button_point;
        private Button button_0;
        private Button button_char;
        private Button button_equal;
        private Button button_plus;
        private Button button_multiply;
        private Button button_division;
        private Button button_minus;
        private Button button_backspace;
        private Button button_CE;
        private Button button_C;
        private TextBox textBox_result;
        private TextBox textBox_show;
    }
}