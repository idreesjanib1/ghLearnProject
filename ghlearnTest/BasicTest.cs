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
        Assert.Single(Summaries);
        }
    }
}
