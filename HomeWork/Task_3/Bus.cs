namespace HomeWork.Task_3
{
    internal class Bus
    {
        public string PurposeOfStation { get; set; }
        public int Number { get; set; }
        public string DepartureTime { get; set; }
        public int SeatCount { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Number}, {PurposeOfStation}, {DepartureTime}, {SeatCount}");
        }


    }
}
