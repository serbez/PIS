using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AuthService
    {
        private const string FilePath = "users.csv";

        private bool CheckUserInRepository(string phone)
        {
            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                return lines.Any(line => line.Split(',')[0].Equals(phone, StringComparison.OrdinalIgnoreCase));
            }
            return false;
        }
        public string LoginUser(string phone, string pass)
        {
            if (CheckUserInRepository(phone))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts[0].Equals(phone, StringComparison.OrdinalIgnoreCase) && parts[1] == pass)
                    {
                        return "Успешная авторизация";
                    }
                }
            }
            return "Неправильный телефон или пароль";
        }
        public string AddUserToRepository(string name, string surname, string lastName, string password, string phone,
                                      string documentNumber, string nationality, bool sex, string placeOfBirth,
                                      string codeOfState, string issuingAuthority, string placeOfResidence,
                                      DateTime dateOfBirth, DateTime dateOfIssue, DateTime dateOfExpiry,
                                      string country, string documentType)
        {
            if (CheckUserInRepository(phone))
            {
                return "Пользователь с таким номером телефона уже существует.";
            }

            IDCard idCard = new IDCard(0, documentNumber, nationality, sex, placeOfBirth,
                                        codeOfState, issuingAuthority, placeOfResidence,
                                        dateOfBirth, dateOfIssue, dateOfExpiry, country, documentType);

            Resident user = new Resident(0, name, surname, lastName, password, phone, idCard);

            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{phone},{password},{name},{surname},{lastName},{idCard.DocumentNumber},{idCard.Nationality},{idCard.Sex},{idCard.PlaceOfBirth},{idCard.CodeOfState},{idCard.IssuingAuthority},{idCard.PlaceOfResidence},{idCard.DateOfBirth},{idCard.DateOfIssue},{idCard.DateOfExpiry},{idCard.Country},{idCard.DocumentType}");
            }

            return "Данные успешно сохранены"; 
        }
    }
}
