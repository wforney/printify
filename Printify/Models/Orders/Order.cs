// <copyright file="Order.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
	using Printify.Models.Catalog;

	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

	/// <summary>
	/// The order class.
	/// </summary>
	public class Order
    {
        /// <summary>
        /// Gets or sets the delivery details of the order's recipient.
        /// </summary>
        /// <value>The delivery details of the order's recipient.</value>
        [Required]
        [JsonPropertyName("address_to")]
        public Location AddressTo { get; init; } = new Location();

        /// <summary>
        /// Gets or sets the date and time the order was created.
        /// </summary>
        /// <value>The date and time the order was created.</value>
        /// <remarks>It is stored in ISO date format.</remarks>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;

        /// <summary>
        /// Gets or sets the date and time the order was fulfilled.
        /// </summary>
        /// <value>The date and time the order was fulfilled.</value>
        /// <remarks>It is stored in ISO date format.</remarks>
        [JsonPropertyName("fulfilled_at")]
        public DateTimeOffset? FulFilledAt { get; init; }

        /// <summary>
        /// Gets or sets a unique string identifier for the order. Each id is unique across the
        /// Printify system.
        /// </summary>
        /// <value>The unique string identifier for the order.</value>
        [Key]
        [Required]
        public string Id { get; init; } = string.Empty;

        /// <summary>
        /// Gets the list of all line items in the order. See line item properties for reference.
        /// </summary>
        /// <value>The list of all line items in the order.</value>
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; } = new List<LineItem>();

        /// <summary>
        /// Gets or sets the other data about the order. See metadata properties for reference.
        /// </summary>
        /// <value>The other data about the order.</value>
        [JsonPropertyName("metadata")]
        public MetaData MetaData { get; init; } = new MetaData();

        /// <summary>
        /// Gets or sets the date and time the order was sent to production.
        /// </summary>
        /// <value>The date and time the order was sent to production.</value>
        /// <remarks>It is stored in ISO date format.</remarks>
        [JsonPropertyName("sent_to_production_at")]
        public DateTimeOffset? SentToProductionAt { get; init; }

        /// <summary>
        /// Gets the shipments.
        /// </summary>
        /// <value>The shipments.</value>
        /// <remarks>
        /// Tracking details of the order after fulfillment. See shipment properties for reference.
        /// </remarks>
        public List<Shipment> Shipments { get; } = new List<Shipment>();

        /// <summary>
        /// Gets or sets the shipping method.
        /// </summary>
        /// <value>The shipping method.</value>
        /// <remarks>
        /// Method of shipping selected for the order, "1" is for standard shipping and "2" is for
        /// express shipping.
        /// </remarks>
        [JsonPropertyName("shipping_method")]
        [Required]
        public int ShippingMethod { get; init; } = 1;

        /// <summary>
        /// Gets or sets the production status.
        /// </summary>
        /// <value>The production status.</value>
        /// <remarks>
        /// Production status of the entire order in string format, it can be any of the following:
        /// pending, on-hold, checking-quality, quality-declined, quality-approved,
        /// ready-for-production, sending-to-production, in-production, cancelled, fulfilled,
        /// partially-fulfilled, payment-not-received, callback-received, or has-issues.
        /// </remarks>
        public string Status { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the retail price in cents.
        /// </summary>
        /// <value>The retail price in cents.</value>
        [JsonPropertyName("total_price")]
        public int TotalPrice { get; init; }

        /// <summary>
        /// Gets or sets the shipping price in cents.
        /// </summary>
        /// <value>The shipping price in cents.</value>
        [JsonPropertyName("total_shipping")]
        public int TotalShipping { get; init; }

        /// <summary>
        /// Gets or sets the tax cost in cents.
        /// </summary>
        /// <value>The tax cost in cents.</value>
        [JsonPropertyName("total_tax")]
        public int TotalTax { get; init; }
    }
}
