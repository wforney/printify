// <copyright file="IOrderClient.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using Printify.Models.Orders;

    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The order client interface.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Printify API lets your application manage orders in a Merchants shop. You can submit orders
    /// for existing products in a merchant's shop or you can create new products with every order
    /// as in the case with merchandise created with customizable user-generated content.
    /// </para>
    /// <para>
    /// Ordering existing products or creating products with orders will require different line item
    /// entries so that should be kept in mind.
    /// </para>
    /// </remarks>
    /// <seealso href="https://developers.printify.com/#orders" />
    public interface IOrderClient
    {
        /// <summary>
        /// Calculates the shipping cost.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="order">The order.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The shipping costs.</returns>
        Task<ShippingCosts?> CalculateShippingCost(int shopId, Order order, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels the order.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;Order&gt;.</returns>
        /// <remarks>
        /// This request will only be accepted if the order to be canceled has the status "on-hold"
        /// or "payment-not-received".
        /// </remarks>
        Task<Order?> CancelOrder(int shopId, int orderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the order.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;System.Nullable&lt;Order&gt;&gt;.</returns>
        Task<Order?> GetOrder(int shopId, int orderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;List&lt;Order&gt;&gt;.</returns>
        Task<List<Order>> GetOrders(int shopId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="limit">The results per page (default: 10, maximum: 10).</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;List&lt;Order&gt;&gt;.</returns>
        Task<List<Order>> GetOrders(int shopId, int? limit = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="limit">The results per page (default: 10, maximum: 10).</param>
        /// <param name="page">Paginate through list of results.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;List&lt;Order&gt;&gt;.</returns>
        Task<List<Order>> GetOrders(int shopId, int? limit = null, int? page = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the orders.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="limit">The results per page (default: 10, maximum: 10).</param>
        /// <param name="page">Paginate through list of results.</param>
        /// <param name="status">Filter results by order status.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;List&lt;Order&gt;&gt;.</returns>
        Task<List<Order>> GetOrders(int shopId, int? limit = null, int? page = null, string? status = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Sends an existing order to production.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;Order&gt;.</returns>
        Task<Order?> SendOrderToProduction(int shopId, int orderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Submits the order.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="order">The order.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;System.String&gt;.</returns>
        Task<string> SubmitOrder(int shopId, Order order, CancellationToken cancellationToken = default);
    }
}
