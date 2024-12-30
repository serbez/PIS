using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public abstract class User
    {
        private int _id;
        private string _name;
        private string _surname;
        private string _lastName;
        private string _password;
        private string _phoneNumber;
        private IDCard _IDCard;

        public User(int id, string name, string surname, string lastName, string password, string phone, IDCard iDCard)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _lastName = lastName;
            _password = password;
            _phoneNumber = phone;
            _IDCard = iDCard;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Phone
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public IDCard IDCard
        {
            get { return _IDCard; }
            set { _IDCard = value; }
        }
    }
}
