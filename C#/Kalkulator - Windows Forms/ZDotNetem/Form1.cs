using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Kalkulator : Form
    {
        char[] tab = { '-', '+', '*', '/' };

        bool startNewNumber = true;
        bool characterNew = true;
        bool wynikExist = false;
        bool help = false;
        bool reset_ = false;
        private string lastCharacter = "";
        private string lastNumber = "";
        private string result = "";
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_Click(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;
            Number_Clicked(number);
        }

        private void button_Click_character(object sender, EventArgs e)
        {
            string character = (sender as Button).Text;
            Character_Clicked(character);
        }

        private void Number_Clicked(string number)
        {
            if (reset_ == true)
            {
                reset();
            }

            if (number != "0" && textBox_result.Text == "0")
            {
                textBox_result.Text = number;
            }
            else if (startNewNumber == false)
            {
                textBox_result.Text += number;

            }
            else
            {
                textBox_result.Text = number;
                startNewNumber = false;
            }
        }
        private void Character_Clicked(string character)
        {

            if (character == "=" && textBox_show.Text == "")
            {
                MessageBox.Show("Wpisz pierw liczbe!");
            }
            else if (character == "=" && textBox_result.Text == "" && help == false)
            {
                MessageBox.Show("Nie możesz dać znaku równa się!");
            }
            else if (character == "=" && textBox_result.Text == "" && ((textBox_show.Text.EndsWith("*") || textBox_show.Text.EndsWith("/") || textBox_show.Text.EndsWith("-") || textBox_show.Text.EndsWith("+"))))
            {
                MessageBox.Show("Nie możesz dać równa się nie wpisując liczby!");
            }
            else if (characterNew == true && character != "=" && startNewNumber == false)
            {
                lastCharacter = character;
                if (textBox_show.Text != "")
                {
                    textBox_show.Text += " " + character;
                    characterNew = false;
                }
                else
                {
                    textBox_show.Text += textBox_result.Text + " " + character;
                    characterNew = false;

                }
                reset_ = false;
                textBox_result.Text = "";

            }
            else if (textBox_result.Text == "" && character != "=")
            {
                textBox_show.Text = textBox_show.Text.Remove(textBox_show.Text.Length - 1, 1) + character;
                lastCharacter = character;
            }
            else if (textBox_result.Text != "")
            {
                help = true;
                lastNumber = textBox_result.Text;
                //Dzielenie przez 0
                if (textBox_show.Text.EndsWith("/") && textBox_result.Text == "0")
                {

                    MessageBox.Show("Nie można dzielić przez 0!");
                    textBox_show.Text.Remove(textBox_show.Text.Length - 1, 1);
                    textBox_result.Text = "";
                    characterNew = false;
                }
                else
                {
                    result = textBox_show.Text + " " + textBox_result.Text;
                    wynik(result);
                    //characterNew = true;
                    if (character != "=")
                    {
                        textBox_show.Text += " " + character;
                        lastCharacter = character;
                    }
                    else
                    {
                        characterNew = true;
                        reset_ = true;
                    }
                }
            }
            else if (character == "=")
            {
                result = textBox_show.Text + " " + lastCharacter + " " + lastNumber;
                wynik(result);
                reset_ = true;
                if (character != "=")
                {
                    textBox_show.Text += " " + character;
                }
                else
                {
                    characterNew = true;
                    startNewNumber = false;
                }
            }
        }

        private void reset()
        {
            startNewNumber = true;
            characterNew = true;
            wynikExist = false;
            help = false;
            lastCharacter = "";
            lastNumber = "";
            result = "";
            textBox_show.Text = "";
            reset_ = false;
        }

        private void wynik(string result)
        {

            //Dzielenie przez 0

            textBox_result.Text = "";
            //var resultAsInt = new DataTable().Compute(result, null); //Typ int
            try
            {

                DataTable dataTable = new DataTable();
                object resultObject = dataTable.Compute(result.Replace(',', '.'), null);

                float resultAsFloat = Convert.ToSingle(resultObject);
                textBox_show.Text = resultAsFloat.ToString();
            }
            catch (Exception er)
            {
                MessageBox.Show("Błąd! Źle wprowadziłeś dane!");
            }


        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "";
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Length == 2 && textBox_result.Text.Contains("-"))
            {
                textBox_result.Text = "";
            }
            else if (textBox_result.Text.Length > 0)
                textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length - 1, 1);
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            startNewNumber = true;
            characterNew = true;
            help = false;
            wynikExist = false;
            lastCharacter = "";
            lastNumber = "";
            result = "";
            textBox_result.Text = "";
            textBox_show.Text = "";
        }

        private void button_char_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text.Contains("-") && textBox_result.Text != "")
            {
                textBox_result.Text = textBox_result.Text.Remove(0, 1);
            }
            else
            {
                textBox_result.Text = "-" + textBox_result.Text;
            }
        }

        private void textBox_result_TextChanged(object sender, EventArgs e)
        {
            if (textBox_result.Text == "00")
            {
                textBox_result.Text = "0";
            }
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            string przecinek = (sender as Button).Text;

            if (textBox_result.Text.Contains(","))
            {
                //MessageBox.Show("Nie możesz tego zrobić");
            }
            else if(textBox_result.Text != "")
            {
                textBox_result.Text += przecinek;
            }

        }

        private void textBox_show_TextChanged(object sender, EventArgs e)
        {
        }
    }
}