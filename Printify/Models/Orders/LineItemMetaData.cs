// <copyright file="LineItemMetaData.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The line item metadata record.
    /// </summary>
    public record LineItemMetaData
    {
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        /// <remarks>
        /// Location of print provider handling fulfillment.
        /// </remarks>
        public string Country { get; init; } = "United States";

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        /// <remarks>
        /// Retail price in cents, integer value.
        /// </remarks>
        public int Price { get; init; }

        /// <summary>
        /// Gets or sets the sku.
        /// </summary>
        /// <value>The sku.</value>
        /// <remarks>
        /// A unique string identifier for the product variant.
        /// </remarks>
        public string Sku { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        /// <remarks>
        /// The name of the product.
        /// </remarks>
        public string Title { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the variant label.
        /// </summary>
        /// <value>The variant label.</value>
        /// <remarks>
        /// Name of the product variant.
        /// </remarks>
        [JsonPropertyName("variant_label")]
        public string VariantLabel { get; init; } = string.Empty;
    }
}
