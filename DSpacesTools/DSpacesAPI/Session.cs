using System;
using System.Threading.Tasks;
using DNetwork;
using SharedComponents;

namespace DSpacesApi {
    public class Session: SessionModel {        
        public Network Network { get; private set; }

        public Session(Network network) {
            Network = network;
        }

        public void Reset(bool clearCookies, Network network = null) {
            if (clearCookies) {
                network?.ClearCookies();
            }

            Login = string.Empty;
            UserId = string.Empty;
            Sid = string.Empty;
            State = SessionState.Empty;
            CreationTime = DateTime.Now;
            LastCheckTime = DateTime.Now;
        }

        public async Task<Message> Create(string sid) {
            Reset(true);

            Sid = sid.Trim();

            if (!CheckSidFormat() || State != SessionState.Empty) {
                return new Message(MessageType.Error, Error.SessionWrongSid);
            }

            State = SessionState.Invalid;
            return await CheckStatus().ConfigureAwait(false);
        }

        public bool CreateAnon() {
            if (State != SessionState.Empty) {
                return false;
            }

            Reset(true);
            State = SessionState.Anonymous;
            return true;
        }

        public async Task<Message> CheckStatus() {
            switch (State) {
                case SessionState.Empty:
                    return new Message(MessageType.Error, Error.SessionInvalidState);

                case SessionState.Anonymous:
                    return new Message(MessageType.Error, Error.SessionUnsupportedForAnon);
            }

            LastCheckTime = DateTime.Now;

            var checkPath = "/settings/?sid=" + Sid;
            await Network.Get(Co.Network.Protocol + Co.Network.Host + checkPath).ConfigureAwait(false);
            var possibleUserId = Network.GetCookieByName(new Uri(Co.Network.Protocol + Co.Network.Host), CookieUserId);

            if (possibleUserId == string.Empty) {
                State = SessionState.Invalid;
                return new Message(MessageType.Error, Error.SessionWrongSid);
            }

            State = SessionState.Valid;
            UserId = possibleUserId;
            Login = await GetCurrentUserNameById().ConfigureAwait(false);

            return new Message(MessageType.Success, Success.Default);
        }

        private async Task<string> GetCurrentUserNameById() {
            if (State != SessionState.Valid) {
                return string.Empty;
            }

            await Network.Get(Co.Network.Protocol + UserId + "." + Co.Network.Host).ConfigureAwait(false);
            return Network.GetUrlValueByParam(CookieUserLogin);
        }

        private bool CheckSidFormat() {
            // TODO: regex?
            int trashVar;
            return Sid.Length == SidSize && !int.TryParse(Sid, out trashVar);
        }
    }
}
