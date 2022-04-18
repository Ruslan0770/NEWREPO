using System;
using System.Collections.Generic;
using System.Text;

namespace Homework18042022.Models
{
    class Company
    {
        private string _name;
        public int Limit { get; set; }
        private Employee[] _avg;

        public Company()
        {
            _avg = new Employee[0];
        }

        public void AddEmployee(Employee avg)
        {
            if (_avg.Length < Limit)
            {
                Array.Resize(ref _avg, _avg.Length + 1);
                _avg[_avg.Length - 1] = avg;
                return;
            }
            Console.WriteLine("yER DOLUB");
        }
        public Employee[] GetEmployees() => _avg;
        public string Name {
            get => _name;
            set
            {
                bool check = true;
                while (check)
                {
                        bool checksymbol = false;
                        bool checkdigit = false;
                        bool checkspacebar = false;
                        bool checkupper = false;
                    if (char.IsUpper(value[0]))
                    {
                        checkupper = true;
                        foreach (char item in value)
                        {
                            if (char.IsDigit(item)) 
                            {
                                checkdigit = true;
                            }
                           else if (char.IsSymbol(item))
                            {
                                checksymbol = true;
                            }
                            else if (char.IsWhiteSpace(item))
                            {
                                checkspacebar = true;
                            }
                            if (checksymbol == true && checkdigit && checkspacebar)
                            {
                                _name = value;
                                check = false;
                                break;
                            }
                            if (checkupper == false || checkdigit == false || checksymbol == false || checkspacebar == false)
                            {
                                Console.WriteLine("Adi duzgun daxil et");
                            }
                        }
                    }
                }
            }
        }
    }
}
