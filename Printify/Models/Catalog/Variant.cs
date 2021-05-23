// <copyright file="Variant.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Catalog
{
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// The variant record.
	/// </summary>
	public record Variant
	{
		/// <summary>
		/// Gets or sets a unique int identifier for the blueprint variant. Each id is unique across
		/// the Printify system.
		/// </summary>
		/// <value>
		/// A unique int identifier for the blueprint variant. Each id is unique across the Printify system.
		/// </value>
		[Key]
		public int Id { get; init; }

		/// <summary>
		/// Gets or sets the read only values describing blueprint variant options. There can be up
		/// to 3 options for a blueprint.
		/// </summary>
		/// <value>The read only values describing blueprint variant options.</value>
		public VariantOptions Options { get; init; } = new VariantOptions();

		/// <summary>
		/// Gets the available printable areas for a blueprint.
		/// </summary>
		/// <value>The available printable areas for a blueprint.</value>
		public List<Placeholder> Placeholders { get; } = new List<Placeholder>();

		/// <summary>
		/// Gets or sets the name of the variant.
		/// </summary>
		/// <value>The name of the variant.</value>
		[Required]
		public string Title { get; init; } = string.Empty;
	}
}
