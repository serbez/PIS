using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AuthRepository<UserType> : Repository<UserType>
    where UserType : User<UserType>, ISaveble<UserType>
{
    public AuthRepository(string path) : base(path)
    {
        this.path = path;
    }

    public override bool AddObjectToRepository(UserType saveableObject)
    {
        try
        {
            File.WriteAllText(this.path + saveableObject.id + ".txt", saveableObject.DecodeToJson());
        }
        catch 
        { 
            return false;
        }
        return true;
    }

    public override UserType GetObjectFromRepository(int id)
    {
        return User<UserType>.CreateFromJson(File.ReadAllText(this.path + id.ToString() + ".txt"));
    }
}