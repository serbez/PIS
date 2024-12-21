
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface ISaveble<T> {

    string DecodeToJson();
    T CreateFromJson(string objectInfo);

}