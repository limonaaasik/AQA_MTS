public class Corporate : Client // ”казываем, что Corporate - это дочерний класс от Client зписью "Corporate : Client"
{
    public string INN;
    public string UNP;

    public Corporate(int id) : base(id)
    {
        Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
    }
}