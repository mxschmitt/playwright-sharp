/*
 * MIT License
 *
 * Copyright (c) Microsoft Corporation.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 *
 *
 * ------------------------------------------------------------------------------ 
 * <auto-generated> 
 * This code was generated by a tool at:
 * /utils/doclint/generateDotnetApi.js
 * 
 * Changes to this file may cause incorrect behavior and will be lost if 
 * the code is regenerated. 
 * </auto-generated> 
 * ------------------------------------------------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace PlaywrightSharp
{
    /// <summary>
    /// <para>
    /// Whenever a network route is set up with <see cref="IPage.RouteAsync"/> or <see cref="IBrowserContext.RouteAsync"/>,
    /// the <c>Route</c> object allows to handle the route.
    /// </para>
    /// </summary>
    public partial interface IRoute
    {
        /// <summary><para>Aborts the route's request.</para></summary>
        /// <param name="errorCode">
        /// Optional error code. Defaults to <c>failed</c>, could be one of the following:
        /// <list type="bullet">
        /// <item><description><c>'aborted'</c> - An operation was aborted (due to user action)</description></item>
        /// <item><description>
        /// <c>'accessdenied'</c> - Permission to access a resource, other than the network,
        /// was denied
        /// </description></item>
        /// <item><description>
        /// <c>'addressunreachable'</c> - The IP address is unreachable. This usually means
        /// that there is no route to the specified host or network.
        /// </description></item>
        /// <item><description><c>'blockedbyclient'</c> - The client chose to block the request.</description></item>
        /// <item><description>
        /// <c>'blockedbyresponse'</c> - The request failed because the response was delivered
        /// along with requirements which are not met ('X-Frame-Options' and 'Content-Security-Policy'
        /// ancestor checks, for instance).
        /// </description></item>
        /// <item><description>
        /// <c>'connectionaborted'</c> - A connection timed out as a result of not receiving
        /// an ACK for data sent.
        /// </description></item>
        /// <item><description><c>'connectionclosed'</c> - A connection was closed (corresponding to a TCP FIN).</description></item>
        /// <item><description><c>'connectionfailed'</c> - A connection attempt failed.</description></item>
        /// <item><description><c>'connectionrefused'</c> - A connection attempt was refused.</description></item>
        /// <item><description><c>'connectionreset'</c> - A connection was reset (corresponding to a TCP RST).</description></item>
        /// <item><description><c>'internetdisconnected'</c> - The Internet connection has been lost.</description></item>
        /// <item><description><c>'namenotresolved'</c> - The host name could not be resolved.</description></item>
        /// <item><description><c>'timedout'</c> - An operation timed out.</description></item>
        /// <item><description><c>'failed'</c> - A generic failure occurred.</description></item>
        /// </list>
        /// </param>
        Task AbortAsync(string errorCode = default);

        /// <summary><para>Continues route's request with optional overrides.</para></summary>
        /// <param name="headers">If set changes the request HTTP headers. Header values will be converted to a string.</param>
        /// <param name="method">If set changes the request method (e.g. GET or POST)</param>
        /// <param name="postData">If set changes the post data of request</param>
        /// <param name="url">If set changes the request URL. New URL must have same protocol as original one.</param>
        Task ResumeAsync(IEnumerable<KeyValuePair<string, string>> headers = default, string method = default, byte[] postData = default, string url = default);

        /// <summary>
        /// <para>Fulfills route's request with given response.</para>
        /// <para>An example of fulfilling all requests with 404 responses:</para>
        /// <para>An example of serving static file:</para>
        /// </summary>
        /// <param name="body">Optional response body as text.</param>
        /// <param name="bodyBytes">Optional response body as raw bytes.</param>
        /// <param name="contentType">If set, equals to setting <c>Content-Type</c> response header.</param>
        /// <param name="headers">Response headers. Header values will be converted to a string.</param>
        /// <param name="path">
        /// File path to respond with. The content type will be inferred from file extension.
        /// If <c>path</c> is a relative path, then it is resolved relative to the current working
        /// directory.
        /// </param>
        /// <param name="status">Response status code, defaults to <c>200</c>.</param>
        Task FulfillAsync(string body = default, byte[] bodyBytes = default, string contentType = default, IEnumerable<KeyValuePair<string, string>> headers = default, string path = default, int? status = default);

        /// <summary><para>A request to be routed.</para></summary>
        IRequest Request { get; }
    }
}
