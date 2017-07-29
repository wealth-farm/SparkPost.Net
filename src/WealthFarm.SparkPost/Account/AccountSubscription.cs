using System;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost
{
    /// <summary>
    ///     Account subscription details.
    /// </summary>
    public class AccountSubscription
    {
        /// <summary>
        ///     Gets or sets the code of the plan.
        /// </summary>
        /// <value>The code of the plan.</value>
        public string Code { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name of the plan.</value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the plan volume.
        /// </summary>
        /// <value>The plan volume.</value>
        [JsonProperty("plan_volume")]
        public int PlanVolume { get; set; }

        /// <summary>
        ///     Gets or sets a value indicating whether this <see cref="T:WealthFarm.SparkPost.Subscription" /> self serve.
        /// </summary>
        /// <value><c>true</c> if self serve; otherwise, <c>false</c>.</value>
        [JsonProperty("self_serve")]
        public bool? SelfServe { get; set; }

        /// <summary>
        ///     Gets or sets the effective date.
        /// </summary>
        /// <value>The effective date.</value>
        [JsonProperty("effective_date")]
        public DateTime EffectiveDate { get; set; }
    }
}