// <copyright file="Shipping.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The shipping record.
    /// </summary>
    public record Shipping
    {
        /// <summary>
        /// Gets or sets the standard shipping timeframe for a blueprint from a specific print provider.
        /// </summary>
        /// <value>The standard shipping timeframe for a blueprint from a specific print provider.</value>
        public ShippingHandlingTime HandlingTime { get; init; } = new ShippingHandlingTime();

        /// <summary>
        /// Gets the list of shipping locations and flat shipping costs for all variants of a
        /// blueprint from a specific print provider. See profile properties for reference.
        /// </summary>
        /// <value>
        /// The list of shipping locations and flat shipping costs for all variants of a blueprint
        /// from a specific print provider. See profile properties for reference.
        /// </value>
        public List<ShippingProfile> Profiles { get; } = new List<ShippingProfile>();
    }
}
