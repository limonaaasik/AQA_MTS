﻿namespace HomeWork.Task_3
{
    internal abstract class Transport
    {
        public string PurposeOfStation { get; set; }    // Пункт назначения
        public int Number { get; set; } // Номер
        public string DepartureTime { get; set; }   // Время отправления
        public int SeatCount { get; set; }  // Число мест
        public abstract string TransportType();
        public void Print() //метод, который нельзя переопределить
        {
            Console.WriteLine($"Номер: {Number}, Пункт назначения: {PurposeOfStation}, Время отправления: {DepartureTime}, Число мест: {SeatCount}");
        }
    }
}
