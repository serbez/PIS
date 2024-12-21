
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BidService {

    public BidRepository BidRepository;

    /// <summary>
    /// @param BidRepository
    /// </summary>
    public BidService(BidRepository BidRepository) {
        this.BidRepository = BidRepository;
        // TODO implement here
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<List<Condition>> RequestConditions() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param NewBid 
    /// @return
    /// </summary>
    public Bid AssembleBid(Bid NewBid) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param newBid 
    /// @param path 
    /// @return
    /// </summary>
    public Task<Action> AddBidToRepostirory(Bid newBid, string path) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @param Resident 
    /// @return
    /// </summary>
    public Task<Action> GetBidFromRepository(Resident Resident) {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> EditBid() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> DeleteBidFromRepository() {
        // TODO implement here
        return null;
    }

    /// <summary>
    /// @return
    /// </summary>
    public Task<Action> GetAllBidsFromRepository() {
        // TODO implement here
        return null;
    }
}