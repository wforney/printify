namespace Printify.Models.Products
{
    /// <summary>
    /// The publishing properties record.
    /// </summary>
    /// <remarks>
    /// The "publish" button in the Printify app only locks the product on the Printify app and
    /// triggers the product:publish:started event if you are subscribed to it, see See Product
    /// events for reference. To publish a product, you need to create it manually on your store
    /// from the data you can obtain from the product resource or develop a system to automate that.
    /// Once done, you can use the Publish succeeded endpoint or Publish failed endpoint to unlock
    /// the product.
    /// </remarks>
    public record PublishingProperties
    {
        /// <summary>
        /// Gets a value indicating whether the description will be updated by the sales channel.
        /// </summary>
        /// <value>
        /// <c>true</c> if the description will be updated by the sales channel; otherwise, <c>false</c>.
        /// </value>
        public bool Description { get; init; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the images will be published by the sales channel.
        /// </summary>
        /// <value>
        /// <c>true</c> if the images will be published by the sales channel; otherwise, <c>false</c>.
        /// </value>
        public bool Images { get; init; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the tags will be updated by the sales channel.
        /// </summary>
        /// <value><c>true</c> if the tags will be updated by the sales channel; otherwise, <c>false</c>.</value>
        public bool Tags { get; init; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the title will be updated by the sales channel.
        /// </summary>
        /// <value><c>true</c> if the title will be updated by the sales channel; otherwise, <c>false</c>.</value>
        public bool Title { get; init; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the variants will be published by the sales channel.
        /// </summary>
        /// <value>
        /// <c>true</c> if the variants will be published by the sales channel; otherwise, <c>false</c>.
        /// </value>
        public bool Variants { get; init; } = true;
    }
}
