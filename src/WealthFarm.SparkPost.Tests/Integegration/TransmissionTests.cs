using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace WealthFarm.SparkPost.Tests.Integegration
{
    public class TransmissionTests : BaseTest
    {
        [Fact]
        public async Task CreateTransmission()
        {
            var transmission = new Transmission
            {
                Description = "A test transmission",
                Content = new TemplateContent
                {
                    TemplateId = "test-email"
                }
            };

            var recipients = new List<Recipient>
            {
                new Recipient
                {
                    Address = new Address
                    {
                        Name = "Bugs Bunny",
                        Email = Email
                    }
                }
            };

            transmission.WithRecipients(recipients);

            var result = await Client.CreateTransmission(transmission);
            
            result.Id.Should().NotBeNullOrEmpty();
            result.TotalAcceptedRecipients.Should().Be(1);
            result.TotalRejectedRecipients.Should().Be(0);
        }
    }
}
