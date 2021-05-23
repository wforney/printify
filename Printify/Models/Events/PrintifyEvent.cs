// <copyright file="PrintifyEvent.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Events
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The event record.
    /// </summary>
    public record PrintifyEvent
    {
        /// <summary>
        /// Gets or sets the created at.
        /// </summary>
        /// <value>The created at.</value>
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; init; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public Guid Id { get; init; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        /// <value>The resource.</value>
        public Resource Resource { get; init; } = new Resource();

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; init; } = string.Empty;
    }
}
