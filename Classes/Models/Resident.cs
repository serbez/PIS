
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Resident : User<Resident>{

    public Resident(int id, string name, string surname, string lastName, string login, string password, string phoneNumber, IDCard iDCard)
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

    private List<Bid> Bids;
    //TODO Setter and Getter
    public ECard ECard {  get; set; }

    public override string DecodeToJson()
    {
        throw new NotImplementedException();
    }
}