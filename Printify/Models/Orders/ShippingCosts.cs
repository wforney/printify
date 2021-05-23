// <copyright file="ShippingCosts.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
    /// <summary>
    /// The shipping costs record.
    /// </summary>
    public record ShippingCosts
    {
        /// <summary>
        /// Gets or sets the express.
        /// </summary>
        /// <value>The express.</value>
        public int Express { get; init; }

        /// <summary>
        /// Gets or sets the standard.
        /// </summary>
        /// <value>The standard.</value>
        public int Standard { get; init; }
    }
}
