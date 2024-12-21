using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Admin : User<Admin>{

    public Admin(int id, string name, string surname, string lastName, string login, string password, string phoneNumber, IDCard iDCard)
        : base(id, name, surname, lastName, login, password, phoneNumber, iDCard)
    {
        this.id = id;
        this.Name = name;
        this.Surname = surname;
        this.LastName = lastName;
        this.Login = login;
        this.Password = password;
        this.PhoneNumber = phoneNumber;
        this.IDCard = iDCard;
    }
    public override string DecodeToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}