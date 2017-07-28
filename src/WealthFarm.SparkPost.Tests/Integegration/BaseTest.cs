using System;

namespace WealthFarm.SparkPost.Tests.Integegration
{
    public abstract class BaseTest
    {
        protected BaseTest()
        {
            Client = new Client(new Configuration
            {
                ApiKey = Environment.GetEnvironmentVariable("SPARKPOST_TEST_KEY")
            });
        }

        public IClient Client { get; }
    }
}