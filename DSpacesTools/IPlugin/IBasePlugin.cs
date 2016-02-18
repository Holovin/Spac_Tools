using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlugin {
    /// <summary>
    /// Base interface for all non-core components
    /// </summary>
    public interface IBasePlugin {
        /// <summary>
        /// Name of plugin
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Inner name for check requires
        /// </summary>
        string InnerName { get; }

        /// <summary>
        /// Version number
        /// </summary>
        int Version { get; }

        /// <summary>
        /// Author name
        /// </summary>
        string Author { get; }

        /// <summary>
        /// Http link to author page
        /// </summary>
        string Link { get; }

        /// <summary>
        /// Plugin description (displays at before Run(); in parent app)
        /// </summary>
        string Description { get; }
    }
}
