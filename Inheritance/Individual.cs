public class Individual : Client
{
    public string Firstname;
    public string Lastname;
    
    public Individual(int id) : base(id)    // запись : base(id) - Нужно вызвать конструктор родительского класса
    {
        Console.WriteLine("Individual Base HashCode: " + base.GetHashCode());
    }
}