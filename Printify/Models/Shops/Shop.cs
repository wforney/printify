// <copyright file="Shop.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The shop record.
    /// </summary>
    public record Shop
    {
        /// <summary>
        /// Gets or sets a unique int identifier for the shop. Each id is unique across the Printify system.
        /// </summary>
        /// <value>
        /// A unique int identifier for the shop. Each id is unique across the Printify system.
        /// </value>
        [Key]
        public int Id { get; init; }

        /// <summary>
        /// Gets or sets the name of the shop.
        /// </summary>
        /// <value>The name of the shop.</value>
        [Required]
        public string Title { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of the associated sales channel. If none are connected it defaults
        /// to "disconnected".
        /// </summary>
        /// <value>
        /// The name of the associated sales channel. If none are connected it defaults to "disconnected".
        /// </value>
        [Required]
        public string SalesChannel { get; init; } = string.Empty;
    }
}
