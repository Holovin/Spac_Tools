using System;

namespace SharedComponents {
    public enum SessionState {
        Empty,
        Anonymous,
        Valid,
        Invalid,
    }

    public class SessionModel {
        public const int SidSize = 16;
        public const int CkSize = 4;
        public const string CookieUserLogin = "name";
        public const string CookieUserId = "user_id";

        public string Login {
            get; protected set;
        }

        /// <summary>
        /// User id
        /// </summary>
        public string UserId {
            get; protected set;
        }

        /// <summary>
        /// Authorization code
        /// </summary>
        public string Sid {
            get; protected set;
        }

        /// <summary>
        /// Check key (last 4 digits of sid)
        /// </summary>
        public string Ck => Sid.Length == SidSize ? Sid.Substring(SidSize - CkSize - 1, CkSize) : string.Empty;

        /// <summary>
        /// Session state
        /// </summary>
        public SessionState State {
            get; protected set;
        }

        /// <summary>
        /// Creation time
        /// </summary>
        public DateTime CreationTime {
            get; protected set;
        }

        /// <summary>
        /// Last valid network connection time
        /// </summary>
        public DateTime LastCheckTime {
            get; protected set;
        }
    }
}
