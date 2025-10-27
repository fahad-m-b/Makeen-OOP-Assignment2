using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2.Modul
{
    public enum TicketType
    {
        Regular,
        VIP,
        BackStage
    }
    public class Ticket_Booking
    {
        public Ticket_Booking(string eventName, string seatNumber, TicketType type)
        {
            EventName = eventName;
            SeatNumber = seatNumber;
            Type = type;
        }

        public string EventName { get; set; }
        public string SeatNumber { get; set; }
        public TicketType Type { get; set; }

        public override string ToString()
        {
            return $"Event: {EventName}\nSeat: {SeatNumber}\nType: {Type}\n----------";
        }

    }
    public class TicketSystem
    {
        private List<Ticket_Booking> tickets = new List<Ticket_Booking>();

        public void AddTicket(Ticket_Booking ticket)
        {
            tickets.Add(ticket);
        }
        public Ticket_Booking this[string seatNumber]
        {
            get
            {
                foreach(var ticket in tickets)
                {
                    if(ticket.SeatNumber == seatNumber)
                    {
                        return ticket;
                    }
                }
                return null;
            }
            
        }
        public Dictionary<TicketType, int> CountTicketByType()
        {
            Dictionary<TicketType,int> counts = new Dictionary<TicketType, int>();
            foreach(TicketType type in Enum.GetValues(typeof(TicketType)))
            {
                counts[type] = 0;
            }
            foreach(var ticket in tickets)
            {
                counts[ticket.Type]++;
            }
            return counts;
        }
    }
}
