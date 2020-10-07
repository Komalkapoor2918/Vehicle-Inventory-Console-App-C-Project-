using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment2
{
    class Vehicle
    {
        private string _Make;

        public string Make
        {
            get => _Make;
            private set
            {
                Regex regex = new Regex(@"^[A-Za-z ]+$");
                if (regex.IsMatch(value))
                {
                    _Make = value;
                }

                else
                {
                    Console.WriteLine("Its not valid /t Please try again!");
                }

            }
        }

        private string _Model;

        public string Model
        {
            get => _Model;
            private set
            {
                Regex regex = new Regex(@"^[A-Za-z ]+$");
                if (regex.IsMatch(value))
                {
                    _Model = value;
                }

                else
                {
                    Console.WriteLine("Its not valid /t Please try again!");
                }

            }
        }


        private int _Year;

        public int Year
        {
            get => _Year;
            set
            {
                Regex regex = new Regex(@"^[0-9]+$");
                if (regex.IsMatch(value.ToString()))
                {
                    _Year = value; 
                }
                else
                {
                    Console.WriteLine("Its not valid! /t Please Try again!");
                }
            }
        }

        public Vehicle(String Make, String Model, int Year)
        {
            Make = _Make;
            Model =_Model;
            Year =_Year;
        }


    }


}






            
        
