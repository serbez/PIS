
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ECard 
{

    public ECard(
        int id,
        string surname,
        string name,
        string middleName,
        DateTime dateOfBirth,
        bool sex,
        string citizenship,
        string documentType,
        string issuingAuthority,
        DateTime dateOfIssue,
        string series,
        int number
    )
    {
        Id = id;
        Surname = surname;
        Name = name;
        MiddleName = middleName;
        DateOfBirth = dateOfBirth;
        Sex = sex;
        Citizenship = citizenship;
        DocumentType = documentType;
        IssuingAuthority = issuingAuthority;
        DateOfIssue = dateOfIssue;
        Series = series;
        Number = number;
    }

    public int Id { get; set; }

    public string Surname { get; set; }

    public string Name { get; set; }

    public string MiddleName { get; set; }

    public DateTime DateOfBirth { get; set; }

    public bool Sex { get; set; }

    public string Citizenship { get; set; }

    public string DocumentType { get; set; }

    public string IssuingAuthority { get; set; }

    public DateTime DateOfIssue { get; set; }

    public string Series { get; set; }

    public int Number { get; set; }

}