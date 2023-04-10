using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices;

namespace TerazMusisz.Model
{

    [Serializable]
    [XmlRoot("EmployeeModel")]
    public class EmployeeModel
    {
        [XmlElement("_name")]
        public string _name { get; set; }
        [XmlElement("_surname")]
        public string _surname { get; set; }
        [XmlElement("_date")]
        public DateTime _date { get; set; }
        [XmlElement("_salary")]
        public decimal _salary { get; set; }
        [XmlElement("_job")]
        public string _job { get; set; }
        [XmlElement("_umowa")]
        public string _umowa { get; set; }
        //Dlugosc tablicy w zaleznosci od liczby inputow
        [XmlIgnore]
        public int[] _IsValidArray = new int[] { 0, 0, 0, 0, 0 }; //Czy wszystkie inputy zostały dobrze wprowadzone (walidacja)

        public EmployeeModel() { }

        public EmployeeModel(string name, string surname, DateTime date, decimal salary, string job, string umowa)
        {
            this._name = name;
            this._surname = surname;
            this._date = date;
            this._salary = salary;
            this._job = job;
            this._umowa = umowa;
        }

        public void setArrayValue(int index, int value) //0 - false, 1 - true
        {
            _IsValidArray[index] = value;
        }

        public override string ToString()
        {
            return $"{_name}, {_surname}, {_date}, {_salary} PLN, {_job}, {_umowa}";
        }


    }
}
