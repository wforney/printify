// <copyright file="Image.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Uploads
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The image record.
    /// </summary>
    public record Image
    {
        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        /// <remarks>The file name of the image.</remarks>
        [JsonPropertyName("file_name")]
        public string FileName { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>The height.</value>
        /// <remarks>The height of the image in pixels.</remarks>
        public int Height { get; init; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <remarks>
        /// A unique string identifier for the image. Each id is unique across the Printify system.
        /// </remarks>
        public string Id { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the type of the MIME.
        /// </summary>
        /// <value>The type of the MIME.</value>
        /// <remarks>The media type of the image file.</remarks>
        [JsonPropertyName("mime_type")]
        public string MimeType { get; init; } = string.Empty;

        /// <summary>
        /// Gets or sets the preview URL.
        /// </summary>
        /// <value>The preview URL.</value>
        /// <remarks>A url to preview the image.</remarks>
        [JsonPropertyName("preview_url")]
        public Uri PreviewUrl { get; init; } = new Uri("");

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        /// <remarks>The file size of the image in bytes.</remarks>
        public long Size { get; init; }

        /// <summary>
        /// Gets or sets the upload time.
        /// </summary>
        /// <value>The upload time.</value>
        /// <remarks>The date and time the image was uploaded in ISO date format.</remarks>
        [JsonPropertyName("upload_time")]
        public DateTimeOffset UploadTime { get; init; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>The width.</value>
        /// <remarks>The width of the image in pixels.</remarks>
        public int Width { get; init; }
    }
}
