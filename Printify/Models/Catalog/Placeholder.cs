// <copyright file="Placeholder.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Catalog
{
	/// <summary>
	/// The placeholder record.
	/// </summary>
	public record Placeholder
	{
		/// <summary>
		/// Gets or sets the integer value for printable area height in pixels.
		/// </summary>
		/// <value>The integer value for printable area height in pixels.</value>
		public int Height { get; init; }

		/// <summary>
		/// Gets or sets the available printable areas for a blueprint fulfilled by a specific print provider.
		/// </summary>
		/// <value>
		/// The available printable areas for a blueprint fulfilled by a specific print provider.
		/// </value>
		public string Position { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the integer value for printable area width in pixels.
		/// </summary>
		/// <value>The integer value for printable area width in pixels.</value>
		public int Width { get; init; }
	}
}
