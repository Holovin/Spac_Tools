using System;
using System.Collections.Generic;

namespace SharedComponents {
    /// <summary>
    /// Interface for custom plugins
    /// </summary>
    public interface ISpacesPlugin: IBasePlugin {
        /// <summary>
        /// Requires list, format {InnerName; MinVersion, MaxVersion}
        /// </summary>
        Dictionary<string, List<int>> Requires { get; }

        /// <summary>
        /// Run GUI with plugin init
        /// </summary>
        /// <param name="formClosedEventHandler">Event which need trigger after close plugin form</param>
        /// <param name="sessions">List of active sessions (can be empty)</param>
        /// <param name="o">[reserved]</param>
        void Run(EventHandler formClosedEventHandler, List<Session> sessions, params object[] o);

        /// <summary>
        /// Refresh data in plugin when its running
        /// </summary>
        /// <param name="o">Any needed params</param>
        /// <returns>True if update success</returns>
        bool RefreshData(params object[] o);

        /// <summary>
        /// Close plugin window
        /// </summary>
        /// <param name="hardExit">If true program will be closed immediately</param>
        void Stop(bool hardExit = false);
    }
}
