
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class User<UserType> : ISaveble<UserType>{

    private int _id;
    private string _name;
    private string _surname;
    private string _lastName;
    private string _login;
    private string _password;
    private string _phoneNumber;
    private IDCard _IDCard;

    public User(int id, string name, string surname, string lastName, string login, string password, string phoneNumber, IDCard iDCard)
    {
        _id = id;
        _name = name;
        _surname = surname;
        _lastName = lastName;
        _login = login;
        _password = password;
        _phoneNumber = phoneNumber;
        _IDCard = iDCard;
    }

    public int id
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

    public string Login
    {
        get { return _login; }
        set { _login = value; }
    }

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }

    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set { _phoneNumber = value; }
    }

    public IDCard IDCard
    {
        get { return _IDCard; }
        set { _IDCard = value; }
    }

    public static UserType CreateFromJson(string objectInfo)
    {
        UserType User = JsonConvert.DeserializeObject<UserType>(objectInfo);
        return User;
    }
    public abstract string DecodeToJson();
}