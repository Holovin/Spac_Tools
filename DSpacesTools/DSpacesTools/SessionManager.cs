﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMessages;
using DNetwork;
using DSpacesAPI;
using Type = DMessages.Type;

namespace DSpacesTools {
    public class SessionManager {
        public List<Session> Sessions { get; private set; }

        public SessionManager() {
            Sessions = new List<Session>();
            AddAnonymousUser();
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

        public async Task<Message> Add(string sid) {
            var network = new Network();
            var session = new Session(network);

            var result = await session.Create(sid);

            if (!result.GetSuccess()) {
                return result;
            }

            RemoveDuplicates(session);
            Sessions.Add(session);
            
            return new Message(Type.Success, Success.Default);
        }

        private void RemoveDuplicates(Session newSession) {
            var userId = newSession.UserId;
            Sessions.RemoveAll(item => item.UserId == newSession.UserId);
        }

        public Message RemoveById(int id) {
            if (Sessions[id].State == SessionState.Anonymous) {
                return new Message(Type.Error, Error.SessionForbiddenRemove);
            }

            Sessions.RemoveAt(id);
            return new Message(Type.Success, Success.Default);
        }

        public bool RemoveByName(string login) {
            return Sessions.RemoveAll(item => item.Login == login) > 0;
        }
    }
}