using System;
using System.Windows.Forms;

namespace SharedComponents {
    /// <summary>
    /// Shared class for text GUI messages
    /// </summary>
    public enum MessageType {
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

    public enum Info {
        Default,
    }

    public class DMessage {
        private readonly MessageType _messageType;
        private readonly object _message;
        
        public int Code { get; set; }

        public DMessage(MessageType messageType, object message, int code = 0) {
            _messageType = messageType;
            _message = message;

            Code = code;
        }

        public DialogResult ShowError(MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxDefaultButton button = MessageBoxDefaultButton.Button1) {
            return GetSuccess() ? DialogResult.None : ShowMessage(buttons, button);
        }

        public DialogResult ShowMessage(MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxDefaultButton button = MessageBoxDefaultButton.Button1) {
            return MessageBox.Show(GetMessageText(), GetMessageType(), buttons, GetIcon(), button);
        }

        private MessageBoxIcon GetIcon() {
            switch (_messageType) {
                case MessageType.Default:
                    return MessageBoxIcon.None;

                case MessageType.Info:
                    return MessageBoxIcon.Information;

                case MessageType.Success:
                    return MessageBoxIcon.Asterisk;

                case MessageType.Debug:
                    return MessageBoxIcon.Exclamation;

                case MessageType.Error:
                    return MessageBoxIcon.Error;

                default:
                    return MessageBoxIcon.None;
            }
        }

        public bool GetSuccess() {
            return _messageType == MessageType.Success;
        }

        public string GetMessage() {
            return GetMessageType() + ": " + GetMessageText();
        }

        private string GetMessageText() {
            var output = string.Empty;

            switch (_messageType) {
                case MessageType.Default:
                    output += "Неизвестное событие";
                    break;

                case MessageType.Error:
                    output += GetMessageError();
                    break;

                case MessageType.Info:
                    output += GetMessageInfo();
                    break;

                case MessageType.Success:
                    output += GetMessageSuccess();
                    break;

                case MessageType.Debug:
                    output += "Отладка: ";
                    break;
            }

            return output;
        }

        private string GetMessageType() {
            switch (_messageType) {
                case MessageType.Default:
                    return "Сообщение";

                case MessageType.Info:
                    return "Информация";

                case MessageType.Success:
                    return "Успех";

                case MessageType.Debug:
                    return "Отладка";

                case MessageType.Error:
                    return "Ошибка";

                default:
                    return "Сообщение";
            }
        }

        private bool GetMessageCustom(ref string output) {
            if (!(_message is string)) {
                return false;
            }

            output += _message;
            return true;
        }

        private string GetMessageInfo() {
            var output = string.Empty;

            if (GetMessageCustom(ref output)) {
                return output;
            }

            switch ((Info)_message) {
                case Info.Default:
                default:
                output += "[Информация]";
                break;
            }

            return output;
        }

        private string GetMessageSuccess() {
            var output = string.Empty;

            if (GetMessageCustom(ref output)) {
                return output;
            }

            switch ((Success) _message) {
                case Success.Default:
                default:
                    output += "[Текст не указан]";
                    break;
            }

            return output;
        }

        private string GetMessageError() {
            var output = string.Empty;

            if (GetMessageCustom(ref output)) {
                return output;
            }

            switch ((Error) _message) {
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

            return output;
        }
    }
}
