// <copyright file="ApiClient.Orders.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using Microsoft.Extensions.Logging;

    using Printify.Models.Orders;

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class ApiClient : IOrderClient
    {
        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<ShippingCosts?> CalculateShippingCost(int shopId, Order order, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/shops/{shopId}/orders/shipping.json", shopId);
            var response = await httpClient.PostAsync($"shops/{shopId}/orders/shipping.json", new StringContent(string.Empty), cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ShippingCosts>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<Order?> CancelOrder(int shopId, int orderId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/shops/{shopId}/orders/{orderId}/cancel.json", shopId, orderId);
            var response = await httpClient.PostAsync($"shops/{shopId}/orders/{orderId}/cancel.json", new StringContent(string.Empty), cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Order>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<Order?> GetOrder(int shopId, int orderId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/shops/{shopId}/orders/{orderId}.json", shopId, orderId);
            var json = await httpClient.GetStringAsync($"shops/{shopId}/orders/{orderId}.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<Order>(json, jsonSerializerOptions);
        }

        /// <inheritdoc />
        public Task<List<Order>> GetOrders(int shopId, CancellationToken cancellationToken = default) => GetOrders(shopId, null, null, null, cancellationToken);

        /// <inheritdoc />
        public Task<List<Order>> GetOrders(int shopId, int? limit = null, CancellationToken cancellationToken = default) => GetOrders(shopId, limit, null, null, cancellationToken);

        /// <inheritdoc />
        public Task<List<Order>> GetOrders(int shopId, int? limit = null, int? page = null, CancellationToken cancellationToken = default) => GetOrders(shopId, limit, page, null, cancellationToken);

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<List<Order>> GetOrders(int shopId, int? limit = null, int? page = null, string? status = null, CancellationToken cancellationToken = default)
        {
            if (limit > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(limit), "limit cannot be more than 100.");
            }

            logger.LogInformation("GET: /v1/shops/{shopId}/orders.json?limit={limit}&page={page}&status={status}", shopId, limit, page, status);

            var url = $"shops/{shopId}/orders.json";
            if (limit != 10)
            {
                url += $"?limit={limit}";
                if (page is not null)
                {
                    url += $"&page={page}";
                }

                if (status is not null)
                {
                    url += $"&status={status}";
                }
            }
            else
            {
                if (page is not null)
                {
                    url += $"?page={page}";
                    if (status is not null)
                    {
                        url += $"&status={status}";
                    }
                }
                else
                {
                    if (status is not null)
                    {
                        url += $"?status={status}";
                    }
                }
            }

            var json = await httpClient.GetStringAsync(url, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<List<Order>>(json, jsonSerializerOptions) ?? new List<Order>();
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<Order?> SendOrderToProduction(int shopId, int orderId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/shops/{shopId}/orders/{orderId}/send_to_production.json", shopId, orderId);
            var response = await httpClient.PostAsync($"shops/{shopId}/orders/{orderId}/send_to_production.json", new StringContent(string.Empty), cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Order>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<string> SubmitOrder(int shopId, Order order, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/shops/{shopId}/orders.json", shopId);
            var response = await httpClient.PostAsJsonAsync($"shops/{shopId}/orders.json", order, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
