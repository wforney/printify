// <copyright file="ModifyWebhookRequest.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Webhooks
{
    using System;

    /// <summary>
    /// The modify Webhook request record.
    /// </summary>
    public record ModifyWebhookRequest
    {
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; init; } = new Uri("");
    }
}
