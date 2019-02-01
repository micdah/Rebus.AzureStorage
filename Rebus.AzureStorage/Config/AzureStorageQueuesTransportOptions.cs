﻿using System;
using Rebus.Bus;

namespace Rebus.Config
{
    /// <summary>
    /// Options to configure behavior of Rebus' Azure Storage Queues transport
    /// </summary>
    public class AzureStorageQueuesTransportOptions
    {
        /// <summary>
        /// Configures whether Azure Storage Queues' built-in support for deferred messages should be used.
        /// Defaults to <code>true</code>. When set to <code>false</code>, please remember to register
        /// a timeout manager, or configure another endpoint as a timeout manager, if you intend to
        /// <see cref="IBus.Defer"/> or <see cref="IBus.DeferLocal"/> messages.
        /// </summary>
        public bool UseNativeDeferredMessages { get; set; } = true;

        /// <summary>
        /// Configures how many messages to prefetch. Valid values are null, 0, ... 32
        /// </summary>
        public int? Prefetch { get; set; } = null;

        /// <summary>
        /// Optional. Specifies the new visibility timeout value, in seconds, relative to server time. The default value is 5 minutes.
        /// A specified value must be larger than or equal to 1 second, and cannot be larger than 7 days, or larger than 2 hours on REST protocol versions prior to version 2011-08-18. The
        /// visibility timeout of a message can be set to a value later than the expiry time.
        /// </summary>
        /// <remarks>
        /// See https://docs.microsoft.com/en-us/rest/api/storageservices/get-messages for more
        /// </remarks>
        public TimeSpan InitialVisibilityDelay { get; set; } = TimeSpan.FromMinutes(5);
    }
}