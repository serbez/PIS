
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AuthService {

    /// <summary>
    /// @param newUser 
    /// @return
    /// </summary>

    public Task<User<UserType>> CheckUserInRepository<UserType>(User<UserType> newUser) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param newUser 
    /// @return
    /// </summary>
    public Task<bool> AddUserToRepository<UserType>(User<UserType> newUser) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param User 
    /// @return
    /// </summary>
    public Task<User<UserType>> LoginUser<UserType>(User<UserType> User) {
        // TODO implement here
        return null;
    }

}