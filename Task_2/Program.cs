using Task_2;
using static System.Net.Mime.MediaTypeNames;

List<Client> clients = new List<Client>()
{
    new Client(0, 2022, 3, 12),
    new Client(1, 2024, 12, 16),
    new Client(2, 2012, 5, 32),
    new Client(3, 2003, 8, 12),
    new Client(4, 2010, 10, 97),
    new Client(5, 2010, 1, 50),
};

int minDuration = clients.Min(client => client.trainingDuration);
var result = clients.Where(client => client.trainingDuration == minDuration).Select(client =>
new
{
    client.trainingDuration,
    client.year,
    client.month
}).Last();

Console.WriteLine($"Минимальная продолжительность занятий: {result.trainingDuration}, Год: {result.year}, Месяц: {result.month}");



