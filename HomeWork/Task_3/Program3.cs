namespace HomeWork.Task_3
{
    internal class Program3
    {
        static void Main(string[] args) 
        {
            Bus bus = new Bus("Минск, Малиновка-4", 32, "22:10", 17);
            bus.Print();

            Transport[] transportArray = new Transport[3];
            transportArray[0] = new Bus("Минск, Парк Дружбы народов", 897, "14:03", 35);
            transportArray[1] = new Tram("Минск, Минское море", 6, "10:27", 14);
            transportArray[2] = new Trolleybus("Минск, Уручье", 127, "20:51", 63);

            Transport temp;
            for (int i = 0; i < transportArray.Length - 1; i++)
            {
                for (int j = i + 1; j < transportArray.Length; j++)
                {
                    if (transportArray[i].SeatCount > transportArray[j].SeatCount)
                    {
                        temp = transportArray[i];
                        transportArray[i] = transportArray[j];
                        transportArray[j] = temp;
                    }
                }
            }
            
            foreach (Transport i in transportArray)
            {
                i.Print();
            };

            Console.Write("Введите пункт назначения: ");
            string? purposeStationInput = Console.ReadLine();

            Transport comparePurposeStation = null;
            bool found = false;
            foreach (Transport i in transportArray)
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

            // Определяем метод для преобразования стринги в TimeOnly
            TimeOnly ConvertToTimeOnly(string timeString)
            {
                string[] timeArray = timeString.Split(":");
                int hours = Convert.ToInt32(timeArray[0]);
                int minutes = Convert.ToInt32(timeArray[1]);
                TimeOnly timeOnly = new TimeOnly(hours, minutes);
                return timeOnly;
            }



            Console.Write("Введите время отправление (формат ЧЧ:ММ): ");
            string? departureTimeInput = Console.ReadLine();
            TimeOnly inputTime = ConvertToTimeOnly(departureTimeInput);

            for (int i = 0; i < transportArray.Length; i++)
            {
                TimeOnly transportTime = ConvertToTimeOnly(transportArray[i].DepartureTime);
                if (inputTime < transportTime)
                {
                    transportArray[i].Print();
                }
            }

        }
        

    }
}
