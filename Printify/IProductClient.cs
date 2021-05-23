namespace Printify
{
    using Printify.Models.Products;

    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The product client interface.
    /// <seealso href="https://developers.printify.com/#products"/>
    /// </summary>
    /// <remarks>
    /// The Product resource lets you list, create, update, delete and publish products to a store.
    /// </remarks>
    public interface IProductClient
    {
        /// <summary>
        /// <para>Create a new product.</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>POST /v1/shops/{shop_id}/products.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="product">The product.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task CreateProduct(int shopId, Product product, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Delete a product</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>DELETE /v1/shops/{shop_id}/products/{product_id}.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task DeleteProduct(int shopId, int productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Retrieve a product</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>GET /v1/shops/{shop_id}/products/{product_id}.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task&lt;System.Nullable&lt;Product&gt;&gt;.</returns>
        Task<Product?> GetProduct(int shopId, int productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para style="margin-right: 0px;" dir="ltr">Retrieve a list of all products</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para style="margin-right: 0px;" dir="ltr">
        /// GET /v1/shops/{shop_id}/products.json <br />
        /// </para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="limit">The number of items per page (optional, maximum 100).</param>
        /// <param name="page">The index of the page to return (optional).</param>
        /// <param name="cancellationToken">The cancellation token (optional).</param>
        /// <returns>Task&lt;List&lt;Product&gt;&gt;.</returns>
        Task<List<Product>> GetProducts(int shopId, int limit = 10, int? page = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Publish a product</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>POST /v1/shops/{shop_id}/products/{product_id}/publish.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task PublishProduct(int shopId, int productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Set product publish status to failed</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>POST /v1/shops/{shop_id}/products/{product_id}/publishing_failed.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task SetProductPublishStatusFailure(int shopId, int productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Set product publish status to succeeded</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>POST /v1/shops/{shop_id}/products/{product_id}/publishing_succeeded.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task SetProductPublishStatusSuccess(int shopId, int productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Notify that a product has been unpublished</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>POST /v1/shops/{shop_id}/products/{product_id}/unpublish.json <br /></para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task Unpublish(int shopId, int productId, CancellationToken cancellationToken = default);

        /// <summary>
        /// <para>Update a product</para>
        /// <blockquote style="margin-right: 0px;" dir="ltr">
        /// <para>PUT /v1/shops/{shop_id}/products/{product_id}.json</para>
        /// </blockquote>
        /// </summary>
        /// <param name="shopId">The shop identifier.</param>
        /// <param name="product">The product.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>Task.</returns>
        Task UpdateProduct(int shopId, Product product, CancellationToken cancellationToken = default);
    }
}
