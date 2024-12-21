
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class BidRepository : Repository<Bid>
{
    public BidRepository(string path) : base(path)
    {
        this.path = path;
    }

    public override bool AddObjectToRepository(Bid saveableObject)
    {
        throw new NotImplementedException();
    }

    public override Bid GetObjectFromRepository(int id)
    {
        throw new NotImplementedException();
    }
}