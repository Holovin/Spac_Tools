using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Handlers;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using IPlugin;

namespace DNetwork {
    public class Network : IBasePlugin {
        public string Name => "Base.Network";

        public string Author => "DJ_miXxXer";

        public string Description => "Base plugin for network";

        public string InnerName => "network";

        public string Link => "http://spaces.ru";

        public int Version => 1;

        /// <summary>
        /// Core component for network access
        /// </summary>
        private HttpClient httpClient;

        /// <summary>
        /// Settings part for HttpClient
        /// </summary>
        private HttpClientHandler httpClientHandler;

        /// <summary>
        /// Cookies for HttpClient (external for access)
        /// </summary>
        private CookieContainer CookieContainer => httpClientHandler.CookieContainer;

        /// <summary>
        /// Progress for progressbars (add delegate with += operator to HttpSendProgress/HttpReciveProgress to watching)
        /// </summary>
        public ProgressMessageHandler ProgressMessageHandler { get; set; }

        /// <summary>
        /// Store text answer from last query
        /// </summary>
        public string RecivedData { get; private set; }

        /// <summary>
        /// Store http code answer from last query
        /// </summary>
        public HttpStatusCode RecivedHttpCode { get; private set; }

        /// <summary>
        /// Store http uri from last query
        /// </summary>
        public Uri RecivedUri { get; private set; }

        public string test = " ";

        public Network(string useragent) {
            httpClientHandler = new HttpClientHandler {
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 3,
                UseCookies = true,
                CookieContainer = new CookieContainer(),
                Credentials = CredentialCache.DefaultCredentials,
                UseDefaultCredentials = true
            };

            ProgressMessageHandler = new ProgressMessageHandler();

            httpClient = HttpClientFactory.Create(httpClientHandler, ProgressMessageHandler);
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(useragent);
            httpClient.Timeout = TimeSpan.FromMinutes(1);

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            httpClient.DefaultRequestHeaders.ExpectContinue = false;
        }

        /// <summary>
        /// Set httpClient timeout property
        /// </summary>
        /// <param name="minutes">Time in minutes</param>
        public void SetRequestTimeout(int minutes) {
            httpClient.Timeout = TimeSpan.FromMinutes(minutes);
        }

        /// <summary>
        /// Remove all cookies in CookieContainer
        /// </summary>
        /// <param name="uri">Domain for remove</param>
        public void ClearCookies() {
            //foreach (Cookie cookie in cookieContainer.GetCookies(uri)) {
            //    cookie.Expired = true;
            //}

            httpClientHandler.CookieContainer = new CookieContainer();
        }

        /// <summary>
        /// Gives string cookie value
        /// </summary>
        /// <param name="uri">Host for GetCookies</param>
        /// <param name="name">Cookie name</param>
        /// <returns>Cookie value or string.Empty if nothing fonud</returns>
        public string GetCookieByName(Uri uri, string name) {
            foreach (var c in from Cookie c in CookieContainer.GetCookies(uri) where c.Name == name select c) {
                return c.Value;
            }

            return string.Empty;
        }

        /// <summary>
        /// Send http GET request
        /// </summary>
        /// <param name="url">Request url</param>
        /// <returns>No return value</returns>
        public async Task Get(string url) {
            using (var response = await httpClient.GetAsync(url).ConfigureAwait(false)) {
                await ProcessRequest(response);
            }
        }        

        /// <summary>
        /// Send http POST request
        /// </summary>
        /// <param name="url">Request url</param>
        /// <param name="postParams">List with key=value post params</param>
        /// <returns>No return value</returns>
        public async Task Post(string url, List<KeyValuePair<string, string>> postParams) {
            using (var postHeaders = new FormUrlEncodedContent(postParams))
            using (var response = await httpClient.PostAsync(url, postHeaders).ConfigureAwait(false)) {
                await ProcessRequest(response);
            }
        }


        /// <summary>
        /// Common handler data after http GET/POST requst
        /// </summary>
        /// <param name="response">Response data from HttpClient</param>
        /// <returns>No return value</returns>
        private async Task ProcessRequest(HttpResponseMessage response) {
            using (var stream = new StreamReader(await response.Content.ReadAsStreamAsync())) {
                RecivedData = stream.ReadToEnd();
                RecivedHttpCode = response.StatusCode;

                // TODO: check this
                RecivedUri = response.Headers.Location;
            }
        }
    }
}