
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConditionRepository : Repository<Condition>
{
    public ConditionRepository(string path) : base(path)
    {
    }

    public override bool AddObjectToRepository(Condition saveableObject)
    {
        throw new NotImplementedException();
    }

    public override Condition GetObjectFromRepository(int id)
    {
        throw new NotImplementedException();
    }
}