
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BidController {

    public BidService BidService;

    /// <summary>
    /// @param BidService
    /// </summary>
    public BidController(BidService BidService) {
        this.BidService = BidService;
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<List<Bid>> GetBidsFromService() {
        // TODO implement here
        return null;
    }

    public void Operation1() {
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<bool> CreateBid() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<bool> DeleteBid() {
        // TODO implement here
        return null;
    }

}