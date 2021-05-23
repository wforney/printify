// <copyright file="ShippingProfileItem.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    /// <summary>
    /// The shipping profile item record.
    /// </summary>
    public record ShippingProfileItem
    {
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public decimal Cost { get; init; } = 0;

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        public string Currency { get; init; } = "USD";
    }
}
