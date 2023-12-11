﻿namespace HomeWork.Task_3
{
    internal class Bus : Transport
    {
        public Bus(string purposeOfStation, int number, string departureTime, int seatCount)
        {
            this.PurposeOfStation = purposeOfStation;
            this.Number = number;
            this.DepartureTime = departureTime;
            this.SeatCount = seatCount;
        }
        public void Print()
        {
            Console.WriteLine($"{Number}, {PurposeOfStation}, {DepartureTime}, {SeatCount}");
        }

        public override string TransportType()
        {
            return "Road";
        }

    }
}
