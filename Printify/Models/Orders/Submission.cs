// <copyright file="Submission.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Orders
{
	using Printify.Models.Catalog;

	using System.Collections.Generic;
	using System.Text.Json.Serialization;

	/// <summary>
	/// <para>The order submission record.</para>
	/// </summary>
	public record Submission
    {
        /// <summary>
        /// Gets or sets the delivery details of the order's recipient.
        /// </summary>
        /// <value>The delivery details of the order's recipient.</value>
        [JsonPropertyName("address_to")]
        public Location AddressTo { get; init; } = new Location();

        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <value>The external identifier.</value>
        /// <remarks>
        /// A unique string identifier from the sales channel specifying the order name or id.
        /// </remarks>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>The label.</value>
        /// <remarks>Optional value to specify order label instead of using "external_id"</remarks>
        public string? Label { get; init; }

        /// <summary>
        /// Gets the line items.
        /// </summary>
        /// <value>The line items.</value>
        /// <remarks>
        /// <para>
        /// "line_items": [{ <br /> "product_id": "5bfd0b66a342bcc9b5563216", <br /> "variant_id":
        /// 17887, <br /> "quantity": 1 <br />}] <br /> Required for ordering existing products.
        /// Provide the product_id (Printify Product ID), variant_id (selected variant, e.g. 'White
        /// / XXL') and desired item quantity. If creating a product from the order is required,
        /// then additional attributes will need to be provided, specifically the blueprint_id and
        /// print_areas. <br />"line_items": [{ <br /> "print_provider_id": 5, <br />
        /// "blueprint_id": 9, <br /> "variant_id": 17887, <br /> "print_areas": { <br /> "front": "
        /// <a href="https://images.example.com/image.png">https://images.example.com/image.png</a>"
        /// <br /> }, <br /> "quantity": 1 <br />}] <br /> See product properties and variant
        /// properties for reference. Also, see print area properties for reference on print_areas
        /// for product creation during order submission. It is also possible to order existing
        /// products by providing the product variant's SKU alone. <br />"line_items": [{ <br />
        /// "sku": "MY-SKU", <br /> "quantity": 1 <br />}] <br /> See variant properties for reference.
        /// </para>
        /// </remarks>
        [JsonPropertyName("line_items")]
        public List<LineItem> LineItems { get; } = new List<LineItem>();

        /// <summary>
        /// Gets or sets the send shipping notification.
        /// </summary>
        /// <value>The send shipping notification.</value>
        /// <remarks>
        /// A boolean for choosing whether or not to receive email notifications after an order is shipped.
        /// </remarks>
        [JsonPropertyName("send_shipping_notification")]
        public bool SendShippingNotification { get; init; }

        /// <summary>
        /// Gets or sets the shipping method.
        /// </summary>
        /// <value>The shipping method.</value>
        /// <remarks>
        /// Required to specify what method of shipping is desired, "1" means standard shipping, "2"
        /// means express shipping. It is stored as an integer.
        /// </remarks>
        [JsonPropertyName("shipping_method")]
        public int ShippingMethod { get; init; } = 1;
    }
}
