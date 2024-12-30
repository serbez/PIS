using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WinFormsApp1.Model;

namespace WinFormsApp1
{
    internal class BidService
    {
        private const string FilePath = "Bid.csv";

        public List<Bid> LoadBids()
        {
            var bids = new List<Bid>();
            if (!File.Exists(FilePath))
            {
                return bids; 
            }

            var lines = File.ReadAllLines(FilePath).Skip(1);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    bids.Add(new Bid
                    {
                        Id = parts[0],
                        Phone = parts[1],
                        Reason = parts[2],
                        Status = Enum.TryParse(parts[3], out BidStatus status) ? status : BidStatus.Rejected
                    });
                }
            }

            return bids;
        }

        public List<Bid> GetAllBidsFromRepository()
        {
            return GetInProcessBids();
        }

        public void AddBidToRepository(Bid bid)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{bid.Id},{bid.Phone},{bid.Reason},{bid.Status}");
            }
        }

        public string GetNextId()
        {
            if (!File.Exists(FilePath))
            {
                return "1"; 
            }

            var lines = File.ReadAllLines(FilePath);
            if (lines.Length == 1) 
            {
                return "1";
            }

            var lastLine = lines.Last();
            var lastId = lastLine.Split(',')[0];
            return (int.Parse(lastId) + 1).ToString(); 
        }

        public void DeleteBidFromRepository(string bidId)
        {
            var bids = GetAllBidsFromRepository();
            var bidToDelete = bids.FirstOrDefault(bid => bid.Id == bidId);

            if (bidToDelete != null && bidToDelete.Status == BidStatus.InProcess)
            {
                var updatedBids = bids.Where(bid => bid.Id != bidId).ToList();

                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    writer.WriteLine("Id,Phone,Reason,Status"); 
                    foreach (var bid in updatedBids)
                    {
                        writer.WriteLine($"{bid.Id},{bid.Phone},{bid.Reason},{bid.Status}");
                    }
                }
            }
            else
            {
                if (bidToDelete == null)
                {
                    Console.WriteLine("Заявка с указанным ID не найдена.");
                }
                else
                {
                    Console.WriteLine("Заявка не может быть удалена, так как она не в статусе 'InProcess'.");
                }
            }
        }
        public List<Bid> GetInProcessBids()
        {
            return LoadBids().Where(bid => bid.Status == BidStatus.InProcess).ToList(); 
        }
        public void EditBid(string bidId, BidStatus newStatus)
        {
            var bids = LoadBids(); 

            var bidToEdit = bids.FirstOrDefault(bid => bid.Id == bidId); 
            if (bidToEdit != null)
            {
                bidToEdit.Status = newStatus; 

                using (StreamWriter writer = new StreamWriter(FilePath, false))
                {
                    writer.WriteLine("Id,Phone,Reason,Status");
                    foreach (var bid in bids)
                    {
                        writer.WriteLine($"{bid.Id},{bid.Phone},{bid.Reason},{bid.Status}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Заявка с указанным ID не найдена.");
            }
        }

        public List<Bid> GetAllBids()
        {
            return LoadBids(); 
        }
    }
}