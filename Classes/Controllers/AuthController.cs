
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AuthController {


    private AuthService AuthService;

    public AuthController(AuthService AuthService ) {
        AuthService = AuthService;
    }

    /// <summary>
    /// @param newUser 
    /// @return
    /// </summary>
    public Task<bool> CheckUserService<UserType>(User<UserType> newUser) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param user 
    /// @return
    /// </summary>
    public Task<bool> LoginService<UserType>(User<UserType> user) {
        // TODO implement here
        return null;
    }

    public Task<bool> RegisterService<UserType>(User<UserType> user)
    {
        return null;
    }

}