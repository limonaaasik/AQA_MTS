namespace Task1
{
    internal class Authorization
    {
        public static string EnterAuthorization(string login, string password, string confirmPassword)
        {
            try
            {
                login.Length > 20 && login.Contains(" ");
            }
        }
    }
}
