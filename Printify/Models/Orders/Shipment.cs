// <copyright file="Shipment.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The shipment record.
    /// </summary>
    public record Shipment
    {
        /// <summary>
        /// Gets or sets the carrier.
        /// </summary>
        /// <value>The carrier.</value>
        /// <remarks>Name of the shipping courier used to deliver the order to its recipient.</remarks>
        public string Carrier { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the delivered at.
        /// </summary>
        /// <value>The delivered at.</value>
        /// <remarks>The date and time the order was delivered. It is stored in ISO date format.</remarks>
        [JsonPropertyName("delivered_at")]
        public DateTimeOffset DeliveredAt { get; init; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        /// <remarks>
        /// A unique string tracking number from the shipping courier used to track the status of
        /// the shipment.
        /// </remarks>
        public string Number { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        /// <remarks>
        /// A unique string tracking link from the shipping courier used to track the status of the shipment.
        /// </remarks>
        public Uri Url { get; init; } = new Uri("");
    }
}
