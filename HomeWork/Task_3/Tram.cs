namespace HomeWork.Task_3
{
    internal class Tram : Transport
    {
        public Tram()
        {
        }
        public Tram(string purposeOfStation, int number, string departureTime, int seatCount)
        {
            this.PurposeOfStation = purposeOfStation;
            this.Number = number;
            this.DepartureTime = departureTime;
            this.SeatCount = seatCount;
        }
        public override string TransportType()
        {
            return "Rail";
        }
    }
}
