using System;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace WealthFarm.SparkPost.Tests.Integegration
{
    public class Account : BaseTest
    {
        [Fact]
        public async Task GetAccount()
        {
            var account = await Client.GetAccountAsync();

            account.Should().NotBeNull();
            account.CompanyName.Should().NotBeNull();
            account.CountryCode.Should().NotBeNull();
            account.AnniversaryDate.Should().NotBe(DateTime.MinValue);
            account.Created.Should().NotBe(DateTime.MinValue);
            account.Updated.Should().NotBe(DateTime.MinValue);
            account.Status.Should().NotBeNullOrEmpty();
            account.StatusUpdated.Should().NotBe(DateTime.MinValue);
            account.Subscription.Should().NotBeNull();
            account.Subscription.Code.Should().NotBeNullOrEmpty();
            account.Subscription.Name.Should().NotBeNullOrEmpty();
            account.Subscription.PlanVolume.Should().BeGreaterThan(0);
        }
    }
}