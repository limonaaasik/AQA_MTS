namespace HomeWork.Task_3
{
    internal class Program3
    {
        static void Main(string[] args) 
        {
            Bus bus = new Bus("Минск, Малиновка-4", 32, "22:10", 17);
            bus.Print();

            Transport[] transport = new Transport[3];
            transport[0] = new Bus("Минск, Парк Дружбы народов", 897, "14:03", 35);
            transport[1] = new Tram("Минск, Минское море", 6, "10:27", 14);
            transport[2] = new Trolleybus("Минск, Уручье", 127, "20:51", 63);
        }
    }
}
