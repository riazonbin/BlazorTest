using BlazorTest.Data;

namespace BlazorTest.Services
{
    public class UserService
    {
        private static readonly string[] firstNames = new[]
        {
        "Brad", "John", "Ivan", "Maxim", "Timur", "Danil", "Tamerlan", "Andrew", "Jack", "Tom"
        };

        private static readonly string[] lastNames = new[]
{
        "Abramov", "Kolobkov", "Sergeev", "Ivanov", "Tikhomirov", "Morozov", "Timurkin", "Kalita", "Johnov", "Brevnov"
        };

        public static List<User> GetUnit()
        {
            Random random = new Random();

            return Enumerable.Range(1, random.Next(0, 6)).Select(index => new User
            {
                Name = firstNames[random.Next(firstNames.Length)],
                SurName = lastNames[random.Next(lastNames.Length)],
                Age = random.Next(0, 100)
            }).ToList(); ;
        }
    }
}