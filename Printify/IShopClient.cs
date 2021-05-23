// <copyright file="IShopClient.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
	using Printify.Models.Shops;

	using System.Collections.Generic;
	using System.Threading;
	using System.Threading.Tasks;

	/// <summary>
	/// The shop client interface.
	/// <seealso href="https://developers.printify.com/#shops"/>
	/// </summary>
	/// <remarks>
	/// All product creation and order submission in a Printify Merchant's account happens through a
	/// shop. Merchant's can have multiple shops in one Printify account. Each of these shops can be
	/// connected to different sales channels and each has independent products, orders, and analytics.
	/// </remarks>
	public interface IShopClient
    {
        /// <summary>
        /// <para>Disconnects the shop.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>DELETE: /v1/shops/{shop_id}/connection.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <example>
        /// [ <br /> { <br /> "id": 5432, <br /> "title": "My new store", <br /> "sales_channel":
        /// "My Sales Channel" <br /> }, <br /> { <br /> "id": 9876, <br /> "title": "My other new
        /// store", <br /> "sales_channel": "disconnected" <br /> } <br />]
        /// </example>
        Task DisconnectShop(int shopId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Retrieve list of shops in a Printify account.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET: /v1/shops.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A list of shops in a Printify account.</returns>
        /// <example>{}</example>
        Task<List<Shop>?> GetShops(CancellationToken cancellationToken = default);
    }
}
