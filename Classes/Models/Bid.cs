
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Bid : ISaveble<Bid>{

    public Bid() {
    }

    public string Id {get; set;}

    public string PhoneNumber { get; set; }

    public string Reason { get; set; }

    public BidStatus Status { get; set; }

    public Bid CreateFromJson(string objectInfo)
    {
        throw new NotImplementedException();
    }

    public string DecodeToJson() {
        // TODO implement here
        return "";
    }
}