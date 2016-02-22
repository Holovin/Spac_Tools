using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Net.Http.Handlers;
using System.Threading.Tasks;

namespace IPlugin {
    public interface INetworkPlugin : IBasePlugin {
        /// <summary>
        /// Store text answer from last query
        /// </summary>
        string RecivedData { get; }

        /// <summary>
        /// Store http code answer from last query
        /// </summary>
        HttpStatusCode RecivedHttpCode { get; }

        /// <summary>
        /// Store http uri from last query
        /// </summary>
        Uri RecivedUri { get; }

        /// <summary>
        /// Progress for progressbars (add delegate with += operator to HttpSendProgress/HttpReciveProgress to watching)
        /// </summary>
        ProgressMessageHandler ProgressMessageHandler { get; set; }

        /// <summary>
        /// Send http GET request
        /// </summary>
        /// <param name="url">Request url</param>
        /// <returns>No return value</returns>
        Task Get(string url);

        /// <summary>
        /// Send http POST request
        /// </summary>
        /// <param name="url">Request url</param>
        /// <param name="postParams">List with key=value post params</param>
        /// <returns>No return value</returns>
        Task Post(string url, List<KeyValuePair<string, string>> postParams);

        /// <summary>
        /// Set httpClient timeout property
        /// </summary>
        /// <param name="minutes">Time in minutes</param>
        void SetRequestTimeout(int minutes);

        /// <summary>
        /// Remove all cookies in CookieContainer
        /// </summary>
        void ClearCookies();

        /// <summary>
        /// Gives string cookie value
        /// </summary>
        /// <param name="uri">Host for GetCookies</param>
        /// <param name="name">Cookie name</param>
        /// <returns>Cookie value or string.Empty if nothing fonud</returns>
        string GetCookieByName(Uri uri, string name);
    }
}