using System.Collections.Generic;
using System.Threading.Tasks;
using Network;

namespace SharedComponents {
    public class SessionManager {
        public List<Session> Sessions { get; private set; }

        public SessionManager() {
            Sessions = new List<Session>();
            AddAnonymousUser();
        }

        public async Task<DMessage> Add(string sid) {
            var network = new HttpNetwork();
            var session = new Session(network);

            var result = await session.Create(sid).ConfigureAwait(false);

            if (!result.GetSuccess()) {
                return result;
            }

            RemoveDuplicates(session);
            Sessions.Add(session);

            return new DMessage(MessageType.Success, Success.Default);
        }

        public DMessage RemoveById(int id) {
            if (Sessions[id].State == Session.SessionState.Anonymous) {
                return new DMessage(MessageType.Error, Error.SessionForbiddenRemove);
            }

            Sessions.RemoveAt(id);
            return new DMessage(MessageType.Success, Success.Default);
        }

        public bool RemoveByName(string login) {
            return Sessions.RemoveAll(item => item.Login == login) > 0;
        }

        private bool AddAnonymousUser() {
            var network = new HttpNetwork();
            var session = new Session(network);

            if (!session.CreateAnon()) {
                return false;
            }

            Sessions.Add(session);
            return true;
        }

        private void RemoveDuplicates(Session newSession) {
            Sessions.RemoveAll(item => item.UserId == newSession.UserId);
        }
    }
}
