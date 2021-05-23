// <copyright file="WebhookRequest.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Webhooks
{
    using System;

    /// <summary>
    /// The create Webhook request record.
    /// </summary>
    public record CreateWebhookRequest
    {
        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        /// <value>The topic.</value>
        public string Topic { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; init; } = new Uri("");
    }
}
