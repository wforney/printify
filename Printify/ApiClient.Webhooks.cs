// <copyright file="ApiClient.Webhooks.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using Microsoft.Extensions.Logging;

    using Printify.Models.Webhooks;

    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class ApiClient : IWebhookClient
    {
        /// <inheritdoc />
        public async Task<Webhook?> CreateWebhook(int shopId, CreateWebhookRequest webhookRequest, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/shops/{shop_id}/webhooks.json", shopId);
            var response = await httpClient.PostAsJsonAsync($"shops/{shopId}/webhooks.json", webhookRequest, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Webhook>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task DeleteWebhook(int shopId, int webhookId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("DELETE: /v1/shops/{shopId}/webhooks/{webhookId}.json", shopId, webhookId);
            var response = await httpClient.PostAsync($"shops/{shopId}/webhooks/{webhookId}.json", new StringContent(""), cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
        }

        /// <inheritdoc />
        public async Task<Webhook?> GetWebhook(int shopId, string webhookId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/shops/{shopId}/webhooks/{webhookId}.json", shopId, webhookId);
            return await httpClient.GetFromJsonAsync<Webhook>($"shops/{shopId}/webhooks/{webhookId}.json", cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<List<Webhook>> GetWebhooks(int shopId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: v1/shops/{shopId}/webhooks.json", shopId);
            return await httpClient.GetFromJsonAsync<List<Webhook>>($"shops/{shopId}/webhooks.json", cancellationToken).ConfigureAwait(false) ?? new List<Webhook>();
        }

        /// <inheritdoc />
        public async Task<Webhook?> ModifyWebhook(int shopId, int webhookId, ModifyWebhookRequest modifyWebhookRequest, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("PUT: /v1/shops/{shopId}/webhooks/{webhookId}.json", shopId, webhookId);
            var response = await httpClient.PutAsJsonAsync($"shops/{shopId}/webhooks.json", modifyWebhookRequest, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Webhook>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }
    }
}
