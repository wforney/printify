// <copyright file="VariantOptions.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    /// <summary>
    /// The variant options record.
    /// </summary>
    public record VariantOptions
    {
        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        /// <value>The color.</value>
        public string Color { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        public string Size { get; init; } = string.Empty;
    }
}
