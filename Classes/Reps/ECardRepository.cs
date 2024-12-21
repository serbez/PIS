
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ECardRepository : Repository<ECard>
{
    public ECardRepository(string path) : base(path)
    {
        this.path = path;
    }

    public override bool AddObjectToRepository(ECard saveableObject)
    {
        throw new NotImplementedException();
    }

    public override ECard GetObjectFromRepository(int id)
    {
        throw new NotImplementedException();
    }
}