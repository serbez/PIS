
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Police : User<Police>{

    public Police(int id, string name, string surname, string lastName, string login, string password, string phoneNumber, IDCard iDCard, string personalPoliceNumber)
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
        this.PersonalPoliceNumber = personalPoliceNumber;
    }

    public string PersonalPoliceNumber;

    public override string DecodeToJson()
    {
        throw new NotImplementedException();
    }
}