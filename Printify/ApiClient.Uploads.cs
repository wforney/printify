namespace Printify
{
    using Microsoft.Extensions.Logging;

    using Printify.Models.Uploads;

    using System.Diagnostics.CodeAnalysis;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;

    public partial class ApiClient : IUploadClient
    {
        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task ArchiveUploadedImage(string id, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/uploads/{imageId}/archive.json", id);
            var response = await httpClient.PostAsync($"uploads/{id}/archive.json", new StringContent(string.Empty), cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<Image?> GetUploadedImage(string id, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: v1/uploads/{imageId}.json", id);
            var json = await httpClient.GetStringAsync($"uploads/{id}.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<Image>(json, jsonSerializerOptions);
        }

        /// <inheritdoc />
        public Task<PagedImages?> GetUploads(CancellationToken cancellationToken = default) => GetUploads(null, null, cancellationToken);

        /// <inheritdoc />
        public Task<PagedImages?> GetUploads(int? page = null, CancellationToken cancellationToken = default) => GetUploads(null, page, cancellationToken);

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<PagedImages?> GetUploads(int? limit = null, int? page = null, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/uploads.json?limit={limit}&page={page}", limit, page);

            var url = "uploads.json";
            if (limit is not null)
            {
                url += $"?limit={limit}";
                if (page is not null)
                {
                    url += $"&page={page}";
                }
            }
            else if (page is not null)
            {
                url += $"?page={page}";
            }

            var json = await httpClient.GetStringAsync(url, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<PagedImages>(json, jsonSerializerOptions);
        }

        /// <inheritdoc />
        public async Task<Image?> UploadImage(UploadImageQueryStringRequest uploadImageQueryStringRequest, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/uploads/images.json");
            var response = await httpClient.PostAsJsonAsync("uploads/images.json", uploadImageQueryStringRequest, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Image>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<Image?> UploadImage(UploadImageBodyRequest uploadImageBodyRequest, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("POST: /v1/uploads/images.json");
            var response = await httpClient.PostAsJsonAsync("uploads/images.json", uploadImageBodyRequest, cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Image>(jsonSerializerOptions, cancellationToken).ConfigureAwait(false);
        }
    }
}
