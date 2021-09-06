using Dalamud.Logging;
using Dalamud.Plugin;

namespace MinimalPlugin
{
    /// <inheritdoc />
    public class Plugin: IDalamudPlugin
    {
        /// <summary>
        /// Minimal plugin.
        /// </summary>
        public Plugin()
        {
            PluginLog.Log("Plugin started.");
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }

        /// <inheritdoc />
        public string Name => "MinimalPlugin";
    }
}