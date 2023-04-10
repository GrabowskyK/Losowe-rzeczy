using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerazMusisz.Model;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace TerazMusisz.Presenter
{
    internal class MainPresenter
    {
        private View.Form1 _view;
        private Model.MainModel _model;
        ErrorProvider errorProvider = new ErrorProvider();

        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            _view = view;
            _model = model;

            _view.UpdateModel += UpdateModel;
            _view.AddToBox += _view_AddToBox;
            _view.FillTheInputs += _view_FillTheInputs;
            _view.Validate += _view_Validate;
            _view.Export += _view_Export;
            _view.Import += _view_Import;
        }

        private void UpdateView() => _view.DisplayText = _model.Employee.ToString();

        private void UpdateModel()
        {
            //Może nie powinno być new. Po co tworzyć za każdym razem obiekt.
            _model.Employee = new Model.EmployeeModel(_view.Name, _view.Surname,_view.Date, _view.Salary, _view.Job, _view.Umowa);//set
        }
        private void UpdateModelAfterImport(int i)
        {
            var person = _model.ListCreatedEmployer[i];
            _model.Employee = new Model.EmployeeModel(person._name, person._surname, person._date, person._salary, person._job, person._umowa);
        }
        private void _view_AddToBox()
        {
            bool x = true; 
            //Stworzyłem tablice w modelu, aby dodawanie było tylko możliwe po walidacji. Gdy tablica jest wypełniona 1.
            for(int val = 0;val < _model.Employee._IsValidArray.Length; val++)
            {
                if (_model.Employee._IsValidArray[val] == 0)
                {
                    x = false;
                    break;
                }
            }

            if(x == true) {
                _model.AddToBox(_model.Employee);//get
                UpdateView();
            }
            
        }

        private void _view_FillTheInputs(int index)
        {
            Model.EmployeeModel selectedEmployer = _model.ListCreatedEmployer.ElementAt(index) as Model.EmployeeModel;

            //MessageBox.Show(selectedEmployer._name);
            //MessageBox.Show(selectedEmployer._surname);

            _view.Name = selectedEmployer._name;
            _view.Surname = selectedEmployer._surname;
            _view.Date = selectedEmployer._date;
            _view.Salary = selectedEmployer._salary;
            _view.Job = selectedEmployer._job;
            _view.Umowa = selectedEmployer._umowa;
        }

        
        private void _view_Validate(Control textboxName)
        {
            switch (textboxName.Name)
            {
                case "textBox_name":
                    
                    if (string.IsNullOrEmpty(_model.Employee._name)) //Tutaj jeszcze powinno być jeżeli , czy . czy liczba itd.
                    {
                        errorProvider.SetError(textboxName, "Błąd");
                        _model.Employee.setArrayValue(0, 0);
                    }
                    else
                    {
                        errorProvider.SetError(textboxName, "");
                        _model.Employee.setArrayValue(0, 1);
                    }
                    break;
                case "textBox_surname":
                    if (string.IsNullOrEmpty(_model.Employee._surname)) 
                    {
                        errorProvider.SetError(textboxName, "Błąd");
                        _model.Employee.setArrayValue(1, 0);
                    }
                    else
                    {
                        errorProvider.SetError(textboxName, "");
                        _model.Employee.setArrayValue(1, 1);
                    }
                    break;
                case "numericUpDown_salary": //Tutaj domyślnie jest ustawiana wartośc 3000, więc muszę to zrobić prze view.
                    if (textboxName.Text == "")
                    {
                        errorProvider.SetError(textboxName, "Błąd");
                        _model.Employee.setArrayValue(2, 0);
                    }
                    else
                    {
                        errorProvider.SetError(textboxName, "");
                        _model.Employee.setArrayValue(2, 1);
                    }
                    break;
               case "comboBox_job":
                    if (string.IsNullOrEmpty(_model.Employee._job))
                    {
                        errorProvider.SetError(textboxName, "Błąd");
                        _model.Employee.setArrayValue(3, 0);
                    }
                    else
                    {
                        errorProvider.SetError(textboxName, "");
                        _model.Employee.setArrayValue(3, 1);
                    }
                    break;
                case "radioButton_uz":
                    if (string.IsNullOrEmpty(_model.Employee._umowa))
                    {
                        errorProvider.SetError(textboxName, "Błąd");
                        _model.Employee.setArrayValue(4, 0);
                    }
                    else
                    {
                        errorProvider.SetError(textboxName, "");
                        _model.Employee.setArrayValue(4, 1);
                    }
                    break;
            }
        }

        private void _view_Export()
        {
            _model.Export();
        }

        private void _view_Import()
        {
            _model.Import();
            for (int i = 0; i < _model.ListCreatedEmployer.Count; i++)
            {
                UpdateModelAfterImport(i);
                UpdateView();
            }
        }
    }

    }
