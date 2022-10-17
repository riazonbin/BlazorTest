namespace BlazorTest.Data
{
    public class UnitService
    {
        private static readonly string[] firstNames = new[]
        {
        "Brad", "John", "Ivan", "Maxim", "Timur", "Danil", "Tamerlan", "Andrew", "Jack", "Tom"
        };

        private static readonly string[] lastNames = new[]
{
        "Abramov", "Kolobkov", "Sergeev", "Ivanov", "Tikhomirov", "Morozov", "Timurkin", "Kalita", "Johnov", "Brevnov"
        };

        public Task<List<Unit>> GetUnitAsync()
        {
            Random random = new Random();

            return Task.FromResult(Enumerable.Range(1, random.Next(0,6)).Select(index => new Unit
            {
                Name = firstNames[random.Next(firstNames.Length)],
                SurName = lastNames[random.Next(lastNames.Length)],
                Age = random.Next(0, 100)
            }).ToList()); ;
        }
    }
}