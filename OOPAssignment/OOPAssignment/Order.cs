using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//============================================================
//Student Number : S10175825D, S10175359D
//Student Name   : Jeff Lee  , Eugene Tan
//Module  Group  : IT06
//============================================================
namespace OOPAssignment
{
    class Order
    {
        static public int OrderCount = 1;
        public string OrderNo { get; set; }
        public DateTime OrderDateTime { get; set; }
        public double Amount { get; set; }
        public string status { get; set; }
        private List<Ticket> TicketList = new List<Ticket>();

        public Order()
        {
            OrderNo = Convert.ToString(OrderCount);
            OrderCount++;
        }
        public void AddTicket(Ticket t)
        { TicketList.Add(t); }
        public List<Ticket>GetTicketList()
        { return TicketList; }
    }
}
