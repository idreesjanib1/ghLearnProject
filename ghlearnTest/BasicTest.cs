namespace ghlearnTest
{
    public class BasicTest
    {
        [Fact(DisplayName = "test method 1")]
        public void Test1()
        {
            string[] Summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };
            Assert.NotEmpty(Summaries);

        }
        [Fact(DisplayName = "test method 2")]
        public void Test2()
        {
            var random = new Random();
            int temperatureC = random.Next(-20, 55);
            int temperatureF = 32 + (int)(temperatureC / 0.5556);
            Assert.InRange(temperatureC, -20, 55);
            Assert.InRange(temperatureF, 14, 131);
        }
    }
}
