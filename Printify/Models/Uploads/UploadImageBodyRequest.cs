// <copyright file="UploadImageBodyRequest.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Uploads
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The upload image body request record.
    /// </summary>
    public record UploadImageBodyRequest
    {
        /// <summary>
        /// Gets or sets the contents.
        /// </summary>
        /// <value>The contents.</value>
        public string Contents { get; init; } = "base-64-encoded-content";

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        [JsonPropertyName("file_name")]
        public string FileName { get; init; } = string.Empty;
    }
}
