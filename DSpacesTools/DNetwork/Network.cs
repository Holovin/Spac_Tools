using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Handlers;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using IPlugin;

namespace DNetwork {
    public class Network : IBasePlugin {
        public string Name => "Network";

        public string Author => "DJ_miXxXer";

        public string Description => "Base plugin for network";

        public string InnerName => "base.network";

        public string Link => "http://spaces.ru";

        public int Version => 1;

        /// <summary>
        /// Core component for network access
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Settings part for HttpClient
        /// </summary>
        private readonly HttpClientHandler _httpClientHandler;

        /// <summary>
        /// Cookies for HttpClient (external for access)
        /// </summary>
        private CookieContainer CookieContainer => _httpClientHandler.CookieContainer;

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

        public Network(string useragent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/48.0.2564.116") {
            _httpClientHandler = new HttpClientHandler {
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 3,
                UseCookies = true,
                CookieContainer = new CookieContainer(),
                Credentials = CredentialCache.DefaultCredentials,
                UseDefaultCredentials = true
            };

            ProgressMessageHandler = new ProgressMessageHandler();

            _httpClient = HttpClientFactory.Create(_httpClientHandler, ProgressMessageHandler);
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(useragent);
            _httpClient.Timeout = TimeSpan.FromMinutes(1);

            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            _httpClient.DefaultRequestHeaders.ExpectContinue = false;

            RecivedData = string.Empty;
            RecivedHttpCode = HttpStatusCode.Forbidden;
            RecivedUri = new Uri("http://localhost/");
        }

        /// <summary>
        /// Set httpClient timeout property
        /// </summary>
        /// <param name="minutes">Time in minutes</param>
        public void SetRequestTimeout(int minutes) {
            _httpClient.Timeout = TimeSpan.FromMinutes(minutes);
        }

        /// <summary>
        /// Remove all cookies in CookieContainer
        /// </summary>
        public void ClearCookies() {
            //foreach (Cookie cookie in cookieContainer.GetCookies(uri)) {
            //    cookie.Expired = true;
            //}

            _httpClientHandler.CookieContainer = new CookieContainer();
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

        public string GetUrlValueByParam(string param) {
            if (RecivedUri.Query.Length < 2) {
                return string.Empty;
            }

            // From 1st symbol for remove "?" at zero position    
            var url = RecivedUri.Query.Substring(1).Split('&');
           
            foreach (var temp in url.Where(item => item.Length != 0).Select(item => item.Split('=')).Where(temp => temp[0] == param)) {
                return temp[1];
            }

            return string.Empty;
        }

        /// <summary>
        /// Send http GET request
        /// </summary>
        /// <param name="url">Request url</param>
        /// <returns>No return value</returns>
        public async Task<string> Get(string url) {
            using (var response = await _httpClient.GetAsync(url).ConfigureAwait(false)) {
                return await ProcessRequest(response).ConfigureAwait(false);
            }
        }        

        /// <summary>
        /// Send http POST request
        /// </summary>
        /// <param name="url">Request url</param>
        /// <param name="postParams">List with key=value post params</param>
        /// <returns>No return value</returns>
        public async Task<string> Post(string url, List<KeyValuePair<string, string>> postParams) {
            using (var postHeaders = new FormUrlEncodedContent(postParams))
            using (var response = await _httpClient.PostAsync(url, postHeaders).ConfigureAwait(false)) {
                return await ProcessRequest(response).ConfigureAwait(false);
            }
        }


        /// <summary>
        /// Common handler data after http GET/POST requst
        /// </summary>
        /// <param name="response">Response data from HttpClient</param>
        /// <returns>No return value</returns>
        private async Task<string> ProcessRequest(HttpResponseMessage response) {
            using (var stream = new StreamReader(await response.Content.ReadAsStreamAsync().ConfigureAwait(false))) {
                RecivedData = await stream.ReadToEndAsync().ConfigureAwait(false);
                RecivedHttpCode = response.StatusCode;
                RecivedUri = response.RequestMessage.RequestUri;
            }

            return RecivedData;
        }
    }
}