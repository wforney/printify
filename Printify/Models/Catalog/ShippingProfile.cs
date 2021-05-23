// <copyright file="ShippingProfile.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The shipping profile record.
    /// </summary>
    public record ShippingProfile
    {
        /// <summary>
        /// Gets the currency and flat cost of shipping for all other line items of the specific blueprint and print provider in the same order.
        /// </summary>
        /// <value>The currency and flat cost of shipping for all other line items of the specific blueprint and print provider in the same order.</value>
        public List<ShippingProfileItem> AdditionalItems { get; } = new List<ShippingProfileItem>();

        /// <summary>
        /// Gets the countries or delivery locations the shipping profile applies to.
        /// </summary>
        /// <value>The countries or delivery locations the shipping profile applies to.</value>
        public List<string> Countries { get; } = new List<string> { "US" };

        /// <summary>
        /// Gets or sets the currency and flat cost of shipping for a line item if identified as the first item in an order.
        /// </summary>
        /// <value>The currency and flat cost of shipping for a line item if identified as the first item in an order.</value>
        public ShippingProfileItem FirstItem { get; init; } = new ShippingProfileItem();

        /// <summary>
        /// Gets the identifiers of all blueprint variants the specific profile is associated to in an array.
        /// </summary>
        /// <value>The identifiers of all blueprint variants the specific profile is associated to in an array.</value>
        public List<int> VariantIds { get; } = new List<int>();
    }
}
