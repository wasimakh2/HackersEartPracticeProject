
using System;
using System.Collections.Generic;

namespace SeatingArrangment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Seat
    {
        public int SeatNumber { get; set; }
        public string SeatType { get; set; }
        public int FaceSeatNumber { get; set; }
    }
    class SeatingArrangement
    {

        public void GetSeatList()
        {
            bool SeatFlag = false;
            List<Seat> mainList = new List<Seat>();
            for (int i = 1; i <= 108; i++)
            {
                Seat seat = new Seat();
                seat.SeatNumber = i;

                mainList.Add(seat);
            }


        }
    }
}
