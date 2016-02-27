using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DNetwork;

namespace DSpacesAPI {
    public class Session {
        public const int SidSize = 16;
        public const int CkSize = 4;
        public const string Protocol = "http://";
        public const string Host = "spaces.ru";
        public const string CookieUserLogin = "name";
        public const string CookieUserId = "user_id";

        public string Login { get; private set; }

        /// <summary>
        /// User id
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// Authorization code
        /// </summary>
        public string Sid { get; private set; }

        /// <summary>
        /// Check key (last 4 digits of sid)
        /// </summary>
        private string Ck => Sid.Length == SidSize ? Sid.Substring(SidSize - CkSize - 1, CkSize) : string.Empty;

        /// <summary>
        /// True if user logged ok
        /// </summary>
        public bool Valid { get; private set; }

        /// <summary>
        /// Reference to network with correct cookies for this account
        /// </summary>
        private Network Network { get; }

        public Session(Network network) {
            Network = network;
        }

        public void Reset(bool clearCookies) {
            if (clearCookies) {
                Network.ClearCookies();
            }

            Login = string.Empty;
            Id = string.Empty;
            Sid = string.Empty;
            Valid = false;
        }


        public async Task<bool> Create(string sid) {
            if (!CheckSidFormat(sid)) {
                return false;
            }

            Reset(true);

            var checkPath = "/settings/?sid=" + sid;
            await Network.Get(Protocol + Host + checkPath);

            var possibleUserId = Network.GetCookieByName(new Uri(Protocol + Host), CookieUserId);

            if (possibleUserId == string.Empty) {
                return false;
            }

            Id = possibleUserId;
            Login = await GetUserNameById(Id);

            return true;
        }

        public async Task<string> GetUserNameById(string id) {
            await Network.Get(Protocol + id + "." + Host);
            return Network.GetCookieByName(new Uri(Protocol + Host), CookieUserLogin);
        }

        private static bool CheckSidFormat(string sid) {
            int trashVar;
            return sid.Length == SidSize && !int.TryParse(sid, out trashVar);
        }

    }
}
