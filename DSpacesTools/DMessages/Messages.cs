using System.Windows.Forms;

namespace DMessages {
    public enum Type {
        Default,
        Info,
        Success,
        Debug,
        Error
    }

    public enum Error {
        Default,
        Unknown,
        CorePlguinCheckErr,
        SessionForbiddenRemove,
        SessionWrongSid,
        SessionInvalidState,
        SessionUnsupportedForAnon,
    }

    public enum Success {
        Default,
    }

    public class Message {       
        private readonly Type type;
        private readonly object message;

        public Message(Type type, object message) {
            this.type = type;
            this.message = message;
        }

        public DialogResult ShowError(MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxDefaultButton button = MessageBoxDefaultButton.Button1) {
            return GetSuccess() ? DialogResult.None : ShowMessage(buttons, button);
        }

        public DialogResult ShowMessage(MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxDefaultButton button = MessageBoxDefaultButton.Button1) {
            return MessageBox.Show(GetMessageText(), GetMessageType(), buttons, GetIcon(), button);
        }

        private MessageBoxIcon GetIcon() {
            switch (type) {
                case Type.Default:
                    return MessageBoxIcon.None;

                case Type.Info:
                    return MessageBoxIcon.Information;

                case Type.Success:
                    return MessageBoxIcon.Asterisk;

                case Type.Debug:
                    return MessageBoxIcon.Exclamation;

                case Type.Error:
                    return MessageBoxIcon.Error;

                default:
                    return MessageBoxIcon.None;
            }
        }
    
        public bool GetSuccess() {
            return type == Type.Success;
        }

        public string GetMessage() {
            return GetMessageType() + ": " + GetMessageText();
        }

        private string GetMessageText() {
            var output = string.Empty;

            switch (type) {
                case Type.Default:
                    output += "Неизвестное событие";
                    break;

                case Type.Error:
                    output += GetMessageError();
                    break;

                case Type.Info:
                    break;

                case Type.Success:
                    output += "Успех";
                    break;

                case Type.Debug:
                    output += "Отладка: ";
                    break;

                default:
                    break;
            }

            return output;
        }

        private string GetMessageType() {
            switch (type) {
                case Type.Default:
                    return "Сообщение";

                case Type.Info:
                    return "Информация";

                case Type.Success:
                    return "Успех";

                case Type.Debug:
                    return "Отладка";

                case Type.Error:
                    return "Ошибка";

                default:
                    return "Сообщение";
            }
        }


        private string GetMessageError() {
            var output = string.Empty;

            if (!(message is Error)) {
                return string.Empty;
            }

            switch ((Error)message) {
                // Base messages
                case Error.Default:
                    output += "Ошибка";
                    break;

                case Error.Unknown:
                    output += "Неизвестная ошибка";
                    break;

                // Core/Critical errors
                case Error.CorePlguinCheckErr:
                    output += "Ошибка загрузки базовых плагинов";
                    break;

                // Session errors
                case Error.SessionForbiddenRemove:
                    output += "Нельзя удалить анонимный доступ";
                    break;

                case Error.SessionWrongSid:
                    output += "Сессия устарела, данный sid не относится ни к одному аккаунту";
                    break;

                case Error.SessionInvalidState:
                    output += "Невозможно выполнить запрос, неверное состояние сессии";
                    break;

                case Error.SessionUnsupportedForAnon:
                    output += "Операция не поддерживается для анонимного доступа";
                    break;

                default:
                    output += "[Текст ошибки не указан]";
                    break;
            }

            output += " (" + (message) + ")";
            return output;
        }
    }
}
