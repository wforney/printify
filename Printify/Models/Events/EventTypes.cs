// <copyright file="EventTypes.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify.Models.Events
{
    /// <summary>
    /// The event types class.
    /// </summary>
    public static class EventTypes
    {
        /// <summary>
        /// The order was created.
        /// </summary>
        public const string OrderCreated = "order:created";

        /// <summary>
        /// The order was sent to production.
        /// </summary>
        public const string OrderSentToProduction = "order:sent-to-production";

        /// <summary>
        /// Some/all items have been fulfilled.
        /// </summary>
        public const string OrderShipmentCreated = "order:shipment:created";

        /// <summary>
        /// Some/all items have been delivered.
        /// </summary>
        public const string OrderShipmentDelivered = "order:shipment:delivered";

        /// <summary>
        /// The order's status was updated.
        /// </summary>
        public const string OrderUpdated = "order:updated";

        /// <summary>
        /// The product was deleted.
        /// </summary>
        public const string ProductDeleted = "product:deleted";

        /// <summary>
        /// The product publishing was started.
        /// </summary>
        public const string ProductPublishStarted = "product:publish:started";

        /// <summary>
        /// The shop was disconnected.
        /// </summary>
        public const string ShopDisconnected = "shop:disconnected";
    }
}
