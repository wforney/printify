namespace Printify
{
	using Microsoft.Extensions.Logging;

	using Printify.Models.Catalog;

	using System.Collections.Generic;
	using System.Diagnostics.CodeAnalysis;
	using System.Text.Json;
	using System.Threading;
	using System.Threading.Tasks;

	public partial class ApiClient : ICatalogClient
    {
        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<Blueprint?> GetBlueprint(int blueprintId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/catalog/blueprints/{blueprint_id}.json", blueprintId);
            var json = await httpClient.GetStringAsync($"catalog/blueprints/{blueprintId}.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<Blueprint>(json, jsonSerializerOptions);
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<List<Blueprint>> GetBlueprints(CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/catalog/blueprints.json");
            var json = await httpClient.GetStringAsync("catalog/blueprints.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<List<Blueprint>>(json, jsonSerializerOptions) ?? new List<Blueprint>();
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<PrintProvider?> GetPrintProvider(int printProviderId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/catalog/print_providers/{print_provider_id}.json");
            var json = await httpClient.GetStringAsync($"catalog/print_providers/{printProviderId}.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<PrintProvider>(json, jsonSerializerOptions);
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<List<PrintProvider>> GetPrintProviders(CancellationToken cancellationToken = default)
        {
            logger.LogInformation("GET: /v1/catalog/print_providers.json");
            var json = await httpClient.GetStringAsync("catalog/print_providers.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<List<PrintProvider>>(json, jsonSerializerOptions) ?? new List<PrintProvider>();
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<List<PrintProvider>> GetPrintProviders(int blueprintId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation($"GET: /v1/catalog/blueprints/{blueprintId}/print_providers.json");
            var json = await httpClient.GetStringAsync($"catalog/blueprints/{blueprintId}/print_providers.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<List<PrintProvider>>(json, jsonSerializerOptions) ?? new List<PrintProvider>();
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<Shipping?> GetShipping(int blueprintId, int printProviderId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation($"GET: /v1/catalog/blueprints/{blueprintId}/print_providers/{printProviderId}/shipping.json");
            var json = await httpClient.GetStringAsync($"catalog/blueprints/{blueprintId}/print_providers.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<Shipping>(json, jsonSerializerOptions);
        }

        /// <inheritdoc />
        [SuppressMessage("Usage", "SecurityIntelliSenseCS:MS Security rules violation", Justification = "Uri is not user input.")]
        public async Task<List<Variant>> GetVariants(int blueprintId, int printProviderId, CancellationToken cancellationToken = default)
        {
            logger.LogInformation($"GET: /v1/catalog/blueprints/{blueprintId}/print_providers/{printProviderId}/variants.json");
            var json = await httpClient.GetStringAsync($"catalog/blueprints/{blueprintId}/print_providers/{printProviderId}/variants.json", cancellationToken).ConfigureAwait(false);
            logger.LogTrace(json);
            return JsonSerializer.Deserialize<List<Variant>>(json, jsonSerializerOptions) ?? new List<Variant>();
        }
    }
}
