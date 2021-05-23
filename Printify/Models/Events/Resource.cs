// <copyright file="Resource.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Events
{
    /// <summary>
    /// The resource record.
    /// </summary>
    public record Resource
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        /// <remarks>For more information see Resource data examples.</remarks>
        public ResourceData Data { get; init; } = new ResourceData();

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <remarks>
        /// A unique string identifier for the resource. Each id is unique across the Printify system.
        /// </remarks>
        public string Id { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        /// <remarks>Resource type, currently valid types are shop, product and order.</remarks>
        public string Type { get; init; } = string.Empty;
    }
}
