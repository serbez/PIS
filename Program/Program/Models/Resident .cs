using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public class Resident : User
    {
        public Resident(int id, string name, string surname, string lastName, string password, string phone, IDCard iDCard)
            : base(id, name, surname, lastName, password, phone, iDCard)
        {
        }
    }
}
