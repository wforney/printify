// <copyright file="Blueprint.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Catalog
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// The blueprint record.
	/// </summary>
	public record Blueprint
	{
		/// <summary>
		/// Gets or sets the brand of the blueprint (i.e. the name of the blank product's manufacturer).
		/// </summary>
		/// <value>The brand of the blueprint (i.e. the name of the blank product's manufacturer).</value>
		[Required]
		public string Brand { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets a unique int identifier for the blueprint. Each id is unique across the
		/// Printify system.
		/// </summary>
		/// <value>
		/// A unique int identifier for the blueprint. Each id is unique across the Printify system.
		/// </value>
		[Key]
		public int Id { get; init; }

		/// <summary>
		/// Gets the links to the title image wrappers displayed on the catalog.
		/// </summary>
		/// <value>The links to the title image wrappers displayed on the catalog.</value>
		public List<Uri> Images { get; } = new List<Uri>();

		/// <summary>
		/// Gets or sets the specific model of the blueprint's brand (i.e. the unique identifier of
		/// the blank product's model or style).
		/// </summary>
		/// <value>
		/// The specific model of the blueprint's brand (i.e. the unique identifier of the blank
		/// product's model or style).
		/// </value>
		[Required]
		public string Model { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the name of the blueprint.
		/// </summary>
		/// <value>The name of the blueprint.</value>
		[Required]
		public string Title { get; init; } = string.Empty;
	}
}
