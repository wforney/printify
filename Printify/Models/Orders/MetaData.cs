// <copyright file="MetaData.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The metadata record.
    /// </summary>
    public record MetaData
    {
        /// <summary>
        /// Gets or sets the type of the order.
        /// </summary>
        /// <value>The type of the order.</value>
        /// <remarks>Describes the order type, can be external, manual, or sample.</remarks>
        [JsonPropertyName("order_type")]
        public string OrderType { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the shop fulfilled at.
        /// </summary>
        /// <value>The shop fulfilled at.</value>
        /// <remarks>The date and time the order was fulfilled. It is stored in ISO date format.</remarks>
        [JsonPropertyName("shop_fulfilled_at")]
        public DateTimeOffset ShopFulfilledAt { get; init; }

        /// <summary>
        /// Gets or sets the shop order identifier.
        /// </summary>
        /// <value>The shop order identifier.</value>
        /// <remarks>A unique integer identifier for the order in the external sales channel.</remarks>
        [JsonPropertyName("shop_order_id")]
        public int ShopOrderId { get; init; }

        /// <summary>
        /// Gets or sets the shop order label.
        /// </summary>
        /// <value>The shop order label.</value>
        /// <remarks>A unique string identifier for the order in the external sales channel.</remarks>
        [JsonPropertyName("shop_order_label")]
        public string ShopOrderLabel { get; init; } = string.Empty;
    }
}
