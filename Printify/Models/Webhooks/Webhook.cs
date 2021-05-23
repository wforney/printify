// <copyright file="Webhook.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Webhooks
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The Webhook record.
    /// </summary>
    public record Webhook
    {
        /// <summary>
        /// Gets the unique string identifier for the webhook.
        /// </summary>
        /// <value>The identifier.</value>
        /// <remarks>Each identifier is unique across the Printify system.</remarks>
        public string Id { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the secret that will be used to sign requests for webhook.
        /// </summary>
        /// <value>The secret.</value>
        /// <remarks>See Securing your webhooks for more information.</remarks>
        public string Secret { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the identifier of the merchant's store.
        /// </summary>
        /// <value>The shop identifier.</value>
        [JsonPropertyName("shop_id")]
        public int ShopId { get; init; }

        /// <summary>
        /// Gets or sets the event that triggers the webhook.
        /// </summary>
        /// <value>The topic.</value>
        /// <remarks>See Events for reference. Can't be changed.</remarks>
        public string Topic { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the URI where the webhook subscription should send the POST request when
        /// the event occurs.
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; init; } = new Uri("");
    }
}
