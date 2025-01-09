using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace zdarzenia
{
    internal class Program
    {
        public enum Role
        {
            Administrator,
            Manager,
            User
        }

        public class User
        {
            public string Username { get; set; }
            public List<Role> Roles { get; set; }
            public User(string username)
            {
                Roles = new List<Role>();
                Username = username;
            }

            public void AddRole(Role role)
            {
                if (!Roles.Contains(role))
                {
                    Roles.Add(role);
                }
            }
        }

        public class RBAC
        {
            private readonly Dictionary<Role, List<string>> _rolePermissions;


            public RBAC()
            {
                _rolePermissions = new Dictionary<Role, List<string>>
                {
                    { Role.Administrator, new List<string>{ "Read", "Write", "Delete" }},
                    { Role.Manager, new List<string>{ "Read", "Write" }},
                    { Role.User, new List<string>{ "Read" } }
                };
            }

            public bool HasPermission(User user, string permission)
            {
                foreach (var role in user.Roles)
                {
                    if (_rolePermissions.ContainsKey(role) && _rolePermissions[role].Contains(permission))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public class PasswordManager
        {
            private const string _passwordFilePath = "userPasswords.txt";
            public static event Action<string, bool> PasswordVerified;

            static PasswordManager()
            {
                if (!File.Exists(_passwordFilePath))
                {
                    File.Create(_passwordFilePath).Dispose();
                }
            }

            public static void SavePassword(string username, string password)
            {
                if (File.ReadAllLines(_passwordFilePath).Any(line => line.Split(",")[0] == username)) 
                {
                    Console.WriteLine($"Użytkownik {username} już istnieje w systemie");
                    return;
                }
                string hashedPassword = HashPassword(password);
                File.AppendAllText(_passwordFilePath, $"{username}, {hashedPassword}\n");
                Console.WriteLine($"Użytkownik o nazwie {username} został zapisany");
            }
            private static string HashPassword(string password)
            {
                using(var sha256 = SHA256.Create())
                {
                    var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    return Convert.ToBase64String(bytes);
                }
            }
            public static bool VerifyPassword(string username, string password)
            {
                string hashedPassword = HashPassword(password);
                foreach(var line in File.ReadLines(_passwordFilePath))
                {
                    var parts = line.Split(",");
                    if (parts[0] == username && parts[1] == hashedPassword)
                    {
                        PasswordVerified?.Invoke(username, true);
                        return true;
                    }
                }
                PasswordVerified?.Invoke(username, false);
                return false;
            }
        }

        static void Main(string[] args)
        {
            PasswordManager.PasswordVerified += (username, sucess) => Console.WriteLine($"Logowanie użytkownika {username}: {(sucess ? "udane" : "nieudane")}");
            PasswordManager.SavePassword("Admin", "adminPassword");

            Console.WriteLine("\nwprowadz nazwe użytkownika: ");
            string username = Console.ReadLine();


            Console.WriteLine("Wprowadz haslo: ");
            string password = Console.ReadLine();

            if(PasswordManager.VerifyPassword(username, password))
            {
                Console.WriteLine("Niepoprawna nazwa użytkownika lub hasla");
                return;
            }

            var user = new User(username);
            if(username == "Administrator")
            {
                user.AddRole(Role.Administrator);
            }

            var rbac = new RBAC();
            Console.WriteLine("\n")
        }
    }
}

