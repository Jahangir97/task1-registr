using System;

namespace Registr
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Admin admin = new Admin(username, password, true, "Section A");
            Console.WriteLine($"\nSuper admin: {admin.IsSuperAdmin}\nSection: {admin.Section}");
        }
    }
}
