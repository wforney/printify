// <copyright file="Option.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Products
{
    /// <summary>
    /// The product option class.
    /// </summary>
    public class Option
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; init; } = string.Empty;

        // TODO: Options are possibly not able to be strongly typed easily due to implementation. Look into this more. Docs suck.
    }
}
