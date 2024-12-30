using System.Collections.Generic;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    public class BidController
    {
        private BidService _bidService;

        public BidController()
        {
            _bidService = new BidService();
        }

        public void DeleteBid(string bidId)
        {
            _bidService.DeleteBidFromRepository(bidId); 
        }

        public List<Bid> GetBidsFromService()
        {
            return _bidService.GetAllBidsFromRepository(); 
        }

        public List<Bid> GetBidsFromService1()
        {
            return _bidService.GetAllBids(); 
        }

        public string Operation1()
        {
            return _bidService.GetNextId(); 
        }

        public void CreateBid(Bid bid)
        {
            _bidService.AddBidToRepository(bid);
        }
        public void UpdateBidStatus(string bidId, BidStatus newStatus)
        {
            _bidService.EditBid(bidId, newStatus); 
        }
    }
}