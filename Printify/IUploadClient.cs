// <copyright file="IUploadClient.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using Printify.Models.Uploads;

    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The upload client interface.
    /// <seealso href="https://developers.printify.com/#uploads"/>
    /// </summary>
    /// <remarks>
    /// Artwork added to a Printify Product can be saved in the Media library to be reused on
    /// additional products. You can use this API to directly add files to the media library, and
    /// later use image IDs when creating or modifying products.
    /// </remarks>
    public interface IUploadClient
    {
        /// <summary>
        /// Archives the uploaded image with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task ArchiveUploadedImage(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the uploaded image for the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task<Image?> GetUploadedImage(string id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the uploads.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task<PagedImages?> GetUploads(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the uploads.
        /// </summary>
        /// <param name="page">The page.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task<PagedImages?> GetUploads(int? page = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the uploads.
        /// </summary>
        /// <param name="limit">The limit.</param>
        /// <param name="page">The page.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task<PagedImages?> GetUploads(int? limit = null, int? page = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Uploads the image from the specified URL.
        /// </summary>
        /// <param name="uploadImageQueryStringRequest">The upload image query string request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The image.</returns>
        Task<Image?> UploadImage(UploadImageQueryStringRequest uploadImageQueryStringRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// Uploads the image from the base-64 encoded content.
        /// </summary>
        /// <param name="uploadImageBodyRequest">The upload image body request.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The image.</returns>
        Task<Image?> UploadImage(UploadImageBodyRequest uploadImageBodyRequest, CancellationToken cancellationToken = default);
    }
}
