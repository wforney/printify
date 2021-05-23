// <copyright file="PrintProvider.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The print provider record.
    /// </summary>
    public record PrintProvider
    {
        /// <summary>
        /// Gets or sets a unique int identifier for the print provider. Each id is unique across the Printify system.
        /// </summary>
        /// <value>A unique int identifier for the print provider. Each id is unique across the Printify system.</value>
        [Key]
        public int Id { get; init; }

        /// <summary>
        /// Gets or sets the return address of the print provider.
        /// </summary>
        /// <value>The return address of the print provider.</value>
        public Location Location { get; init; } = new Location();

        /// <summary>
        /// Gets or sets the name of the print provider.
        /// </summary>
        /// <value>The name of the print provider.</value>
        [Required]
        public string Title { get; init; } = string.Empty;
    }
}
