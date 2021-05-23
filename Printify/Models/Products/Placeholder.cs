namespace Printify.Models.Products
{
    using System.Collections.Generic;

    /// <summary>
    /// The placeholder class.
    /// </summary>
    public class Placeholder
    {
        /// <summary>
        /// Gets the images.
        /// </summary>
        /// <value>The images.</value>
        /// <remarks>Array of images. See image properties for reference.</remarks>
        public List<Image> Images { get; } = new List<Image>();

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The position.</value>
        /// <remarks>
        /// See blueprint placeholder properties from the catalog endpoint for reference on how to
        /// get positions.
        /// </remarks>
        public string Position { get; set; } = string.Empty;
    }
}
