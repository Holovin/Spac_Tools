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
    public class Network : INetworkPlugin {
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
        private CookieContainer cookieContainer;


        public ProgressMessageHandler ProgressMessageHandler { get; set; }
        
        public string RecivedData { get; private set; }
        
        public HttpStatusCode RecivedHttpCode { get; private set; }
        
        public Uri RecivedUri { get; private set; }

        public Network(string useragent) {
            cookieContainer = new CookieContainer();

            httpClientHandler = new HttpClientHandler {
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 3,
                UseCookies = true,
                CookieContainer = cookieContainer,
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
        
        public void SetRequestTimeout(int minutes) {
            httpClient.Timeout = TimeSpan.FromMinutes(minutes);
        }

        public void ClearCookies() {
            // TODO: Find best way? 
            cookieContainer = new CookieContainer();
        }

        public string GetCookieByName(Uri uri, string name) {
            foreach (var c in from Cookie c in cookieContainer.GetCookies(uri) where c.Name == name select c) {
                return c.Value;
            }

            return string.Empty;
        }
        
        public async Task Get(string url) {
            using (var response = await httpClient.GetAsync(url).ConfigureAwait(false)) {
                await ProcessRequest(response);
            }
        }
       
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