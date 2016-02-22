using System.Collections.Generic;

namespace IPlugin
{
    /// <summary>
    /// Interface for custom plugins
    /// </summary>
    public interface ISpacesPlugin: IBasePlugin
    {        
        /// <summary>
        /// Requires list, format {InnerName; MinVersion}
        /// </summary>
        Dictionary<string, int> Requires { get; }

        /// <summary>
        /// Run GUI with plugin init
        /// </summary>
        /// <param name="o">Any needed params</param>
        void Run(params object[] o);

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
