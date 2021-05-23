namespace Printify
{
	using Microsoft.Extensions.Logging;

	using Printify.Models.Shops;

	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Text.Json;
	using System.Threading;
	using System.Threading.Tasks;

	public partial class ApiClient : IShopClient
    {
        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task DisconnectShop(int shopId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("DELETE: ~/shops/{shopId}/connection.json", shopId);
            var response = await httpClient.DeleteAsync($"shops/{shopId}/connection.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(response.ReasonPhrase);
            response.EnsureSuccessStatusCode();
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<List<Shop>?> GetShops(CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: ~/shops.json");
            var json = await httpClient.GetStringAsync("shops.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<List<Shop>>(json, jsonSerializerOptions);
        }
    }
}
