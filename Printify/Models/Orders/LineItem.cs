// <copyright file="LineItem.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The line item record.
    /// </summary>
    public record LineItem
    {
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        /// <remarks>
        /// Product variant's fulfillment cost in cents, integer value.
        /// </remarks>
        public int Cost { get; init; }

        /// <summary>
        /// Gets or sets the fulfilled at.
        /// </summary>
        /// <value>The fulfilled at.</value>
        /// <remarks>
        /// The date and time the product variant was fulfilled. It is stored in ISO date format.
        /// </remarks>
        [JsonPropertyName("fulfilled_at")]
        public DateTimeOffset FulfilledAt { get; init; }

        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        /// <value>The meta data.</value>
        /// <remarks>
        /// Other details about the specific product variant. See line item metadata properties for reference.
        /// </remarks>
        [JsonPropertyName("metadata")]
        public LineItemMetaData MetaData { get; init; } = new LineItemMetaData();

        /// <summary>
        /// Gets or sets the print provider identifier.
        /// </summary>
        /// <value>The print provider identifier.</value>
        /// <remarks>
        /// A unique int identifier for the print provider. Each id is unique across the Printify system.
        /// </remarks>
        [Required]
        [JsonPropertyName("print_provider_id")]
        public int PrintProviderId { get; init; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        /// <remarks>
        /// A unique string identifier for the product. Each id is unique across the Printify system.
        /// </remarks>
        [JsonPropertyName("product_id")]
        public string ProductId { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>The quantity.</value>
        /// <remarks>
        /// Describes the number of said product ordered as an integer.
        /// </remarks>
        [Required]
        public int Quantity { get; init; }

        /// <summary>
        /// Gets or sets the sent to production at.
        /// </summary>
        /// <value>The sent to production at.</value>
        /// <remarks>
        /// The date and time the product variant was sent to production. It is stored in ISO date format.
        /// </remarks>
        [JsonPropertyName("sent_to_production_at")]
        public DateTimeOffset SentToProductionAt { get; init; }

        /// <summary>
        /// Gets or sets the shipping cost.
        /// </summary>
        /// <value>The shipping cost.</value>
        /// <remarks>
        /// Product variant's shipment cost in cents, integer value.
        /// </remarks>
        [JsonPropertyName("shipping_cost")]
        public int ShippingCost { get; init; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        /// <remarks>
        /// Specific line item fulfillment status, can be pending, cancelled, or fulfilled.
        /// </remarks>
        public string Status { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the variant identifier.
        /// </summary>
        /// <value>The variant identifier.</value>
        /// <remarks>
        /// A unique int identifier for the product variant from the blueprint. Each id is unique across the Printify system.
        /// </remarks>
        [Required]
        [JsonPropertyName("variant_id")]
        public int VariantId { get; init; }
    }
}
