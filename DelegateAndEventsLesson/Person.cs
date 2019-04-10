using System;

namespace DelegateAndEventsLesson
{
    public delegate void PropertyeventHandler();
    class Person : IPropertychanged
    {
        private string _name;
        private string _surname;

        public event PropertyeventHandler Propertychanged;
        
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
            Propertychanged = IdentityUpdate;
            IdentityDate();
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
                if (_surname == value)
                {
                    Propertychanged();
                }
            }
        }


        public void IdentityUpdate()
        {
            Console.WriteLine($"*******************\n" +
                $"Смена девичьей фамилии на \n" +
                $"Имя: {_name}\nФамилия:{_surname}");

        }

        public void IdentityDate()
        {
            Console.WriteLine($"Имя: {_name}\nФамилия:{_surname}");

        }
    }
}
