using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class AuthController
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }
        public string LoginService(string phone, string pass)
        {
            return _authService.LoginUser(phone, pass);
        }
        public string CheckUserService(string name, string surname, string lastName, string password, string phone,
                                  string documentNumber, string nationality, bool sex, string placeOfBirth,
                                  string codeOfState, string issuingAuthority, string placeOfResidence,
                                  DateTime dateOfBirth, DateTime dateOfIssue, DateTime dateOfExpiry,
                                  string country, string documentType)
        {
            return _authService.AddUserToRepository(name, surname, lastName, password, phone,
                                                documentNumber, nationality, sex, placeOfBirth,
                                                codeOfState, issuingAuthority, placeOfResidence,
                                                dateOfBirth, dateOfIssue, dateOfExpiry,
                                                country, documentType);
        }
    }
}
