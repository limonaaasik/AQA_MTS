namespace HomeWork.Task_3
{
    internal class Trolleybus : Transport
    {
        public Trolleybus()
        {
        }
        public Trolleybus(string purposeOfStation, int number, string departureTime, int seatCount)
        {
            this.PurposeOfStation = purposeOfStation;
            this.Number = number;
            this.DepartureTime = departureTime;
            this.SeatCount = seatCount;
        }
        public override string TransportType()
        {
            return "Electric";
        }
    }
}
