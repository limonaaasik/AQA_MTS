public class Corporate : Client // ���������, ��� Corporate - ��� �������� ����� �� Client ������ "Corporate : Client"
{
    public string INN;
    public string UNP;

    public Corporate(int id) : base(id)
    {
        Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
    }
}