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

            Transport temp;
            for (int i = 0; i < transport.Length - 1; i++)
            {
                for (int j = i + 1; j < transport.Length; j++)
                {
                    if (transport[i].SeatCount > transport[j].SeatCount)
                    {
                        temp = transport[i];
                        transport[i] = transport[j];
                        transport[j] = temp;
                    }
                }
            }
            
            foreach (Transport i in transport)
            {
                i.Print();
            };

            Console.Write("Введите пункт назначения: ");
            string? purposeStationInput = Console.ReadLine();

            Transport comparePurposeStation = null;
            bool found = false;
            foreach (Transport i in transport)
            {
                if (i.PurposeOfStation == purposeStationInput)
                {
                    i.Print();
                    found = true;
                    break;
                }
            }
            
            if (!found) 
            {
                Console.WriteLine("Пункт назначения, соответствующий заданным параметрам, не найден.");
            }

            Console.Write("Введите время отправление: ");
            string? departureTimeInput = Console.ReadLine();


        }
    }
}
