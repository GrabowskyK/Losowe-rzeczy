using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TerazMusisz.Model
{
    internal class MainModel
    {
        
        public EmployeeModel Employee { get; set; }
        public List<EmployeeModel> ListCreatedEmployer { get; set; } = new List<EmployeeModel>();

        public MainModel()
        {

        }

        public MainModel AddToBox(EmployeeModel employee)
        {
            ListCreatedEmployer.Add(employee);
            return this;
        }

        public void Export()
        {
            try { 
            XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeeModel>));
            using (StreamWriter sw = new StreamWriter("..\\..\\dane.xml"))
            {
                serializer.Serialize(sw, ListCreatedEmployer); //indexy w lisćie
            }
            MessageBox.Show("Wyexportowanao pomyślnie!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Import() 
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeeModel>));
                using (StreamReader sr = new StreamReader("..\\..\\dane.xml"))
                {
                    ListCreatedEmployer = (List<EmployeeModel>)serializer.Deserialize(sr);  
                }
                //MessageBox.Show(ListCreatedEmployer[0].ToString());
                MessageBox.Show("Zimportowano pomyślnie!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
