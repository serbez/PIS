using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public class Police : User
    {
        public string PersonalPoliceNumber { get; set; } 
        public Police(int id, string name, string surname, string lastName, string password, string phone, IDCard iDCard, string personalPoliceNumber)
            : base(id, name, surname, lastName, password, phone, iDCard)
        {
            PersonalPoliceNumber = personalPoliceNumber; 
        }
    
    }
}
