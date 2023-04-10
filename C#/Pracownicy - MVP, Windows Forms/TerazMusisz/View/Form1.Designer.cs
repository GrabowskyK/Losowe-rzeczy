namespace TerazMusisz.View
{
    partial class Form1
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.radioButton_uz = new System.Windows.Forms.RadioButton();
            this.radioButton_ud = new System.Windows.Forms.RadioButton();
            this.radioButton_up = new System.Windows.Forms.RadioButton();
            this.comboBox_job = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_export = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(106, 27);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(106, 53);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_surname.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(312, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 251);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nazwisko";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Dodaj osobe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDown_salary.Location = new System.Drawing.Point(106, 106);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_salary.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_salary.TabIndex = 7;
            this.numericUpDown_salary.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // radioButton_uz
            // 
            this.radioButton_uz.AutoSize = true;
            this.radioButton_uz.Location = new System.Drawing.Point(104, 180);
            this.radioButton_uz.Name = "radioButton_uz";
            this.radioButton_uz.Size = new System.Drawing.Size(103, 17);
            this.radioButton_uz.TabIndex = 8;
            this.radioButton_uz.TabStop = true;
            this.radioButton_uz.Text = "Umowa zlecenie";
            this.radioButton_uz.UseVisualStyleBackColor = true;
            // 
            // radioButton_ud
            // 
            this.radioButton_ud.AutoSize = true;
            this.radioButton_ud.Location = new System.Drawing.Point(105, 203);
            this.radioButton_ud.Name = "radioButton_ud";
            this.radioButton_ud.Size = new System.Drawing.Size(102, 17);
            this.radioButton_ud.TabIndex = 9;
            this.radioButton_ud.TabStop = true;
            this.radioButton_ud.Text = "Umowa o dzieło";
            this.radioButton_ud.UseVisualStyleBackColor = true;
            // 
            // radioButton_up
            // 
            this.radioButton_up.AutoSize = true;
            this.radioButton_up.Location = new System.Drawing.Point(105, 226);
            this.radioButton_up.Name = "radioButton_up";
            this.radioButton_up.Size = new System.Drawing.Size(100, 17);
            this.radioButton_up.TabIndex = 10;
            this.radioButton_up.TabStop = true;
            this.radioButton_up.Text = "Umowa o prace";
            this.radioButton_up.UseVisualStyleBackColor = true;
            // 
            // comboBox_job
            // 
            this.comboBox_job.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_job.FormattingEnabled = true;
            this.comboBox_job.Items.AddRange(new object[] {
            "Staż",
            "Praktykant",
            "Junior",
            "Mid",
            "Senior"});
            this.comboBox_job.Location = new System.Drawing.Point(105, 143);
            this.comboBox_job.Name = "comboBox_job";
            this.comboBox_job.Size = new System.Drawing.Size(121, 21);
            this.comboBox_job.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "data urodzenia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "pensja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "stanowisko";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Umowa";
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(60, 368);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(75, 23);
            this.button_export.TabIndex = 16;
            this.button_export.Text = "Export";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.export);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(175, 367);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(75, 23);
            this.button_import.TabIndex = 17;
            this.button_import.Text = "Import";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.import);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_job);
            this.Controls.Add(this.radioButton_up);
            this.Controls.Add(this.radioButton_ud);
            this.Controls.Add(this.radioButton_uz);
            this.Controls.Add(this.numericUpDown_salary);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.textBox_name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.RadioButton radioButton_uz;
        private System.Windows.Forms.RadioButton radioButton_ud;
        private System.Windows.Forms.RadioButton radioButton_up;
        private System.Windows.Forms.ComboBox comboBox_job;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_import;
    }
}