
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public class Condition: ISaveble<Condition>{

    public Condition(int id, string reason, string allowedTime, DateTime date, bool status)
    {
        ID = id;
        Reason = reason;
        AllowedTime = allowedTime;
        Date = date;
        Status = status;
    }

    public int ID {  get; set; }

    public string Reason { get; set; }

    public string AllowedTime { get; set; }

    public DateTime Date { get; set; }

    public bool Status { get; set; }

    public Condition CreateFromJson(string objectInfo)
    {
        throw new NotImplementedException();
    }

    public string DecodeToJson()
    {
        throw new NotImplementedException();
    }
}