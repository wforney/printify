// <copyright file="PrintArea.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Products
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The print area record.
    /// </summary>
    public record PrintArea
    {
        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>The image URL.</value>
        [JsonPropertyName("image_url")]
        public Uri ImageUrl { get; init; } = new Uri("");

        /// <summary>
        /// Gets or sets the placeholder.
        /// </summary>
        /// <value>The placeholder.</value>
        public Placeholder Placeholder { get; init; } = new Placeholder();

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        public string Position { get; init; } = string.Empty;
    }
}
