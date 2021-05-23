// <copyright file="ApiClient.cs" company="improvGroup, LLC">
//     Copyright © 2021 improvGroup, LLC. All Rights Reserved.
// </copyright>

namespace Printify
{
    using System;

    /// <summary>
    /// <para>The API client interface.</para>
    /// <list type="bullet">
    /// <item>All requests are done via HTTPs. Requests via insecure HTTP are not supported.</item>
    /// <item>
    /// Printify API works with UTF-8 encoded data. Please make sure everything you send over in API
    /// calls also uses UTF-8.
    /// </item>
    /// <item>
    /// All data received from API and submitted to API is JSON, so the content type should be: application/json;charset=utf-8
    /// </item>
    /// <item>Date/time values returned by Printify API are in UTC unless stated otherwise.</item>
    /// <item>The base URL for all endpoints is <a href="https://api.printify.com/v1/">https://api.printify.com/v1/</a>.</item>
    /// <item>{variable} in the URLs means you should substitute it with the proper variable value.</item>
    /// </list>
    /// </summary>
    public interface IApiClient
    {
        /// <summary>
        /// Gets or sets the authentication token.
        /// </summary>
        /// <value>The authentication token.</value>
        /// <exception cref="ArgumentNullException">authenticationToken or value</exception>
        string AuthenticationToken { set; }
    }
}
