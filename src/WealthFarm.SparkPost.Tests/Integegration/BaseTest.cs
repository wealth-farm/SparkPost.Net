using System;
using System.Net;

namespace WealthFarm.SparkPost.Tests.Integegration
{
    public abstract class BaseTest
    {
        protected BaseTest(IWebProxy proxy = null)
        {
            Client = new Client(new Configuration
            {
                ApiKey = Environment.GetEnvironmentVariable("SPARKPOST_TEST_KEY"),
                Proxy = proxy
            });

            Email = Environment.GetEnvironmentVariable("SPARKPOST_TEST_EMAIL");
        }

        public IClient Client { get; }
        public string Email { get; }
    }
}