// <copyright file="UploadImageQueryStringRequest.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Uploads
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The upload image query string request record.
    /// </summary>
    public record UploadImageQueryStringRequest
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [JsonPropertyName("file_name")]
        public string FileName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>The URL.</value>
        public Uri Url { get; init; } = new Uri("");
    }
}
