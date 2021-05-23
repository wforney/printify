// <copyright file="ShippingHandlingTime.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Catalog
{
	/// <summary>
	/// The shipping handling time class.
	/// </summary>
	public record ShippingHandlingTime
	{
		/// <summary>
		/// Gets or sets the unit.
		/// </summary>
		/// <value>The unit.</value>
		public string Unit { get; init; } = "day";

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>The value.</value>
		public int Value { get; init; } = 10;
	}
}
