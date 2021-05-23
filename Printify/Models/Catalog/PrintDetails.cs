// <copyright file="PrintDetails.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models
{
    /// <summary>
    /// The print details class.
    /// </summary>
    public class PrintDetails
    {
        /// <summary>
        /// Gets or sets the type of side print.
        /// </summary>
        /// <value>The print on side.</value>
        /// <example>
        /// "regular" for extending print area to the sides of canvas.
        /// "mirror" to keep original print area and mirror it to the sides.
        /// </example>
        public string? PrintOnSide { get; set; }

        /// <summary>
        /// Gets or sets the type of the separator.
        /// </summary>
        /// <value>The type of the separator.</value>
        /// <example>
        /// "Numbers" numeric separators.
        /// "Lines" for single bar separators.
        /// "None" to specify that no separators be used.
        /// </example>
        /// <remarks>
        /// Required with "separator_color" and specific to clock type blueprints.
        /// </remarks>
        public string? SeparatorType { get; set; }

        /// <summary>
        /// Gets or sets the color of the separator.
        /// </summary>
        /// <value>The valid string hexadecimal color code of the separator.</value>
        /// <example>#f100ff</example>
        /// <remarks>
        /// Required with "separator_type" and specific to clock type blueprints.
        /// </remarks>
        public string? SeparatorColor { get; set; }
    }
}
