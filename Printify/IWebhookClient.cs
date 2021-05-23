// <copyright file="IWebhookClient.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using Printify.Models.Webhooks;

    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The Webhook client interface.
    /// <seealso href="https://developers.printify.com/#webhooks" />
    /// </summary>
    /// <remarks>
    /// <para>
    /// You can use webhook subscriptions to receive notifications about particular events in a
    /// shop. After you've subscribed to a webhook, you can let your app execute code immediately
    /// after specific events occur in shops that have your app connected, instead of having to make
    /// API calls periodically to check their status. For example, you can rely on webhooks to
    /// trigger an action in your app when a merchant creates a new product in a store. By using
    /// webhooks subscriptions you can make fewer API calls overall, which makes sure that your apps
    /// are more efficient and update quickly. For more information what actually gets sent by a
    /// webhook check Event properties and Resource data examples.
    /// </para>
    /// <para>
    /// <strong>Securing your Webhooks</strong><br /> Once your server is configured to receive
    /// payloads, it'll listen for any payload sent to the endpoint you configured. For security
    /// reasons, you probably want to limit requests to those coming from Printify.
    /// </para>
    /// <para>
    /// There are a few ways to go about this - for example, you could opt to whitelist requests
    /// from Printify's IP address - but a far easier method is to set up a secret token and
    /// validate the information.
    /// </para>
    /// </remarks>
    public interface IWebhookClient
    {
        /// <summary>
        /// Creates the webhook.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="webhookRequest">The webhook request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;System.Nullable&lt;Webhook&gt;&gt;.</returns>
        Task<Webhook?> CreateWebhook(int shopId, CreateWebhookRequest webhookRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the webhook.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="webhookId">The webhook identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task DeleteWebhook(int shopId, int webhookId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the webhook.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="webhookId">The webhook identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;System.Nullable&lt;Webhook&gt;&gt;.</returns>
        Task<Webhook?> GetWebhook(int shopId, string webhookId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the webhooks.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;List&lt;Webhook&gt;&gt;.</returns>
        Task<List<Webhook>> GetWebhooks(int shopId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies the Webhook.
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="webhookId">The Webhook identifier.</param>
        /// <param name="modifyWebhookRequest">The modify Webhook request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;System.Nullable&lt;Webhook&gt;&gt;.</returns>
        Task<Webhook?> ModifyWebhook(int shopId, int webhookId, ModifyWebhookRequest modifyWebhookRequest, CancellationToken cancellationToken = default);
    }
}
