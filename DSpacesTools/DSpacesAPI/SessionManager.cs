using System.Collections.Generic;
using System.Threading.Tasks;
using DNetwork;
using DSpacesApi;
using SharedComponents;

namespace DSpacesAPI {
    public class SessionManager {
        public List<Session> Sessions { get; private set; }

        public SessionManager() {
            Sessions = new List<Session>();
            AddAnonymousUser();
        }

        public async Task<Message> Add(string sid) {
            var network = new Network();
            var session = new Session(network);

            var result = await session.Create(sid).ConfigureAwait(false);

            if (!result.GetSuccess()) {
                return result;
            }

            RemoveDuplicates(session);
            Sessions.Add(session);

            return new Message(MessageType.Success, Success.Default);
        }

        public Message RemoveById(int id) {
            if (Sessions[id].State == SessionState.Anonymous) {
                return new Message(MessageType.Error, Error.SessionForbiddenRemove);
            }

            Sessions.RemoveAt(id);
            return new Message(MessageType.Success, Success.Default);
        }

        public bool RemoveByName(string login) {
            return Sessions.RemoveAll(item => item.Login == login) > 0;
        }

        private bool AddAnonymousUser() {
            var network = new Network();
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
