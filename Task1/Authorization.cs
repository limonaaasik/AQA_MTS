using System.Text.RegularExpressions;

namespace Task1
{
    internal class Authorization
    {
        public static bool CheckLogin(string login, string password, string confirmPassword)
        {
            try
            {
                if (login.Length > 20 || login == null || login.Contains(" "))
                {
                    throw new WrongLoginException("Ошибка в логине");
                }

                if (password.Length > 20 || password == null || password.Contains(" ") || !Regex.IsMatch(password, @"[0-9]") || password != confirmPassword) 
                {
                    throw new WrongPasswordException("Неверный формат пароля");
                }
            } 
            catch (WrongLoginException ex) 
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return false;
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return false;
            }
            return true;
            
        }

    }
}
