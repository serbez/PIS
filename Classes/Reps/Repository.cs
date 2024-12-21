
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Repository<T>
{
    public string path {  get; set; }
    public Repository(string path) {
        path = path ?? throw new ArgumentNullException(nameof(path));
    }

    public abstract bool AddObjectToRepository(T saveableObject);

    public abstract T GetObjectFromRepository(int id);
}