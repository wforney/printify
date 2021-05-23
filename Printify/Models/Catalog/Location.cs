// <copyright file="Location.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Catalog
{
	using System.ComponentModel.DataAnnotations;
	using System.Text.Json.Serialization;

	/// <summary>
	/// The location record.
	/// </summary>
	public record Location
	{
		/// <summary>
		/// Gets or sets the address line 1.
		/// </summary>
		/// <value>The address line 1.</value>
		public string Address1 { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the address line 2.
		/// </summary>
		/// <value>The address line 2.</value>
		public string? Address2 { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		public string City { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the company.
		/// </summary>
		/// <value>The company.</value>
		public string? Company { get; init; }

		/// <summary>
		/// Gets or sets the country.
		/// </summary>
		/// <value>The country.</value>
		public string Country { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		/// <value>The email.</value>
		[EmailAddress]
		public string? Email { get; init; }

		/// <summary>
		/// Gets or sets the first name.
		/// </summary>
		/// <value>The first name.</value>
		[JsonPropertyName("first_name")]
		public string? FirstName { get; init; }

		/// <summary>
		/// Gets or sets the last name.
		/// </summary>
		/// <value>The last name.</value>
		[JsonPropertyName("last_name")]
		public string? LastName { get; init; }

		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		/// <value>The phone.</value>
		public string? Phone { get; init; }

		/// <summary>
		/// Gets or sets the region.
		/// </summary>
		/// <value>The region.</value>
		public string Region { get; init; } = string.Empty;

		/// <summary>
		/// Gets or sets the zip code.
		/// </summary>
		/// <value>The zip code.</value>
		public string Zip { get; init; } = string.Empty;
	}
}
