using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TerazMusisz.View
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Public interface of view

        public event Action AddToBox;
        public event Action UpdateModel;
        public event Action<int> FillTheInputs;
        public event Action<Control> Validate;
        public event Action Export;
        public event Action Import;
        public string DisplayText
        {
            set
            {
                // Tutaj masz += a nie wiem czy powinno potem w zadaniu. Raczej tak XD
                if (value != null)
                {
                    listBox1.Items.Add(value);
                }
            }
            /* get
             {
                 return test.Text;
             }*/
        }

        
        public string Name
        {
            set
            {
                if(value != "Form1")
                textBox_name.Text = value;
            }
            get => textBox_name.Text;
        }

        public string Surname
        {
            set
            {
                textBox_surname.Text = value;
            }
            get => textBox_surname.Text;
        }

        public DateTime Date
        {
            set
            {
                dateTimePicker1.Value = value;
            }
            get => dateTimePicker1.Value;
        }

        public decimal Salary
        {
            set
            {
                numericUpDown_salary.Value = value;
            }
            get => numericUpDown_salary.Value;
        }
        
        public string Job
        {
            set
            {
                comboBox_job.Text = value;
            }
            get => comboBox_job.Text;
        }

        public string Umowa
        {
            set
            {
                if (radioButton_ud.Text == value)
                {
                    radioButton_ud.Checked = true; //1
                    radioButton_uz.Checked = false;
                    radioButton_up.Checked = false;
                }
                else if (radioButton_uz.Text == value)
                {
                    radioButton_ud.Checked = false;
                    radioButton_uz.Checked = true; //1
                    radioButton_up.Checked = false;
                }
                else if (radioButton_up.Text == value)
                {
                    radioButton_ud.Checked = false;
                    radioButton_uz.Checked = false;
                    radioButton_up.Checked = true; //1
                }
            }
            get
            {
                if (radioButton_ud.Checked)
                {
                    return radioButton_ud.Text;
                }
                else if (radioButton_uz.Checked)
                {
                    return radioButton_uz.Text;
                }
                else if (radioButton_up.Checked)
                {
                    return radioButton_up.Text; 
                }
                return null;
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateModel?.Invoke();
            Validate?.Invoke(textBox_name);
            Validate?.Invoke(textBox_surname);
            Validate?.Invoke(numericUpDown_salary);
            Validate?.Invoke(comboBox_job);
            Validate?.Invoke(radioButton_uz);
            

            AddToBox?.Invoke();
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var indexInList = listBox1.SelectedIndex;
            FillTheInputs?.Invoke(indexInList);
        }

        private void export(object sender, EventArgs e)
        {
            Export?.Invoke();
        }

        private void import(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Import?.Invoke();
        }
    }
}
