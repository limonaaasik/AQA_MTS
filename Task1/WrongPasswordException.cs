namespace Task1
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message) { }
    }
}
