namespace WinFormsApp1.Model
{
    public class Bid
    {

        public Bid(){
        }

        public string Id { get; set; }

        public string Phone { get; set; }

        public string Reason { get; set; }

        public BidStatus Status { get; set; }
    }
}
