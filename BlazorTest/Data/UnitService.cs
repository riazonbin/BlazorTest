namespace BlazorTest.Data
{
    public class UnitService
    {
        private static readonly string[] Summaries = new[]
        {
        "Brad", "John", "Ivan", "Negro", "Timur", "Danil", "Timurkin", "Andrew", "Jack", "Tom"
        };

        public Task<Unit[]> GetUnitAsync()
        {
            Random random = new Random();

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Unit
            {
                Name = Summaries[random.Next(Summaries.Length)],
                SurName = Summaries[random.Next(Summaries.Length)],
                Age = random.Next(0, 100)
            }).ToArray()); ;
        }
    }
}