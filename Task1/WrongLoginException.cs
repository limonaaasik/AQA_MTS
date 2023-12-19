namespace Task1
{
    internal class WrongLoginException : Exception
    {
        public WrongLoginException(string message) : base(message) { }
    }
}
