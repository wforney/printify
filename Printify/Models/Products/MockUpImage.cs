namespace Printify.Models.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The mock-up image record.
    /// </summary>
    public class MockUpImage
    {
        /// <summary>
        /// Gets or sets the is default.
        /// </summary>
        /// <value>The is default.</value>
        /// <remarks>
        /// Used by the sales channel. If set to true, The specific mockup is the title image. Can
        /// be used to decide the first image displayed when a product's page is accessed.
        /// </remarks>
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; init; }

        /// <summary>
        /// Gets or sets the camera position of a mockup (i.e. what part of the product is being displayed).
        /// </summary>
        /// <value>The position.</value>
        public string Position { get; init; } = string.Empty;

        /// <summary>
        /// Gets the source URL of a mock-up image.
        /// </summary>
        /// <value>The source URL of a mock-up image.</value>
        public Uri Src { get; init; } = new Uri("");

        /// <summary>
        /// Gets the variant identifiers for variants illustrated by the mock-up image.
        /// </summary>
        /// <value>The variant identifiers for variants illustrated by the mock-up image.</value>
        [JsonPropertyName("variant_ids")]
        public List<int> VariantIds { get; } = new List<int>();
    }
}
