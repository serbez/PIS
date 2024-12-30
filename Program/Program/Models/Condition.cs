using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Condition
    {
        public int ID { get; }
        public string Reason { get; set; }
        public string AllowedTime { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }

        public Condition(int id, string reason, string allowedTime, string date, string status)
        {
            ID = id;
            Reason = reason;
            AllowedTime = allowedTime;
            Date = date;
            Status = status;
        }
    }
}
