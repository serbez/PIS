
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class IDCard : ISaveble<IDCard>{

    public IDCard(
        int id,
        string documentNumber,
        string nationality,
        bool sex,
        string placeOfBirth,
        string codeOfState,
        string issuingAuthority,
        string placeOfResidence,
        DateTime dateOfBirth,
        DateTime dateOfIssue,
        DateTime dateOfExpiry,
        string country,
        string documentType
    )
    {
        Id = id;
        DocumentNumber = documentNumber;
        Nationality = nationality;
        Sex = sex;
        PlaceOfBirth = placeOfBirth;
        CodeOfState = codeOfState;
        IssuingAuthority = issuingAuthority;
        PlaceOfResidence = placeOfResidence;
        DateOfBirth = dateOfBirth;
        DateOfIssue = dateOfIssue;
        DateOfExpiry = dateOfExpiry;
        Country = country;
        DocumentType = documentType;
    }

    public int Id { get; set; }

    public string DocumentNumber { get; set; }

    public string Nationality {  get; set; }

    public bool Sex { get; set; }

    public string PlaceOfBirth { get; set; }

    public string CodeOfState { get; set; }

    public string IssuingAuthority { get; set; }

    public string PlaceOfResidence { get; set; }

    public DateTime DateOfBirth { get; set; }

    public DateTime DateOfIssue { get; set; }

    public DateTime DateOfExpiry { get; set; }

    public string Country { get; set; }

    public string DocumentType { get; set; }

    public IDCard CreateFromJson(string objectInfo)
    {
        throw new NotImplementedException();
    }

    public string DecodeToJson()
    {
        throw new NotImplementedException();
    }
}