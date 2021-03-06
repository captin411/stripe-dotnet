namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class InvoiceListOptions : ListOptions
    {
        /// <summary>
        /// This field has been renamed to <c>CollectionMethod</c> and will be removed
        /// in a future API version.
        /// </summary>
        [Obsolete("Use CollectionMethod")]
        [JsonProperty("billing")]
        public Billing? Billing { get; set; }

        /// <summary>
        /// Either <c>charge_automatically</c>, or <c>send_invoice</c>.
        /// </summary>
        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>created</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return invoices for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>date</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [Obsolete("Use Created instead")]
        [JsonProperty("date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Date { get; set; }

        /// <summary>
        /// A filter on the list based on the object <c>due_date</c> field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("due_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> DueDate { get; set; }

        /// <summary>
        /// A filter on the list based on the object paid field.
        /// </summary>
        [JsonProperty("paid")]
        public bool? Paid { get; set; }

        /// <summary>
        /// Only return invoices for the subscription specified by this subscription ID.
        /// </summary>
        [JsonProperty("subscription")]
        public string SubscriptionId { get; set; }
    }
}
