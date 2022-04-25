using System.Diagnostics.CodeAnalysis;
using Dalamud.Interface.Colors;
using Dalamud.IoC;
using Dalamud.Logging;
using Dalamud.Plugin;
using ImGuiNET;

namespace MinimalPlugin;

/// <inheritdoc />
[SuppressMessage("Usage", "CA1816:Dispose methods should call SuppressFinalize")]
public class Plugin: IDalamudPlugin
{
    /// <summary>
    /// Minimal plugin.
    /// </summary>
    public Plugin()
    {
        PluginLog.Log("Plugin started.");
        PluginInterface.UiBuilder.Draw += UiBuilderOnDraw;
    }

    [PluginService]
    private static DalamudPluginInterface PluginInterface { get; set; } = null!;

    private void UiBuilderOnDraw()
    {
        ImGui.PushStyleColor(ImGuiCol.WindowBg, ImGuiColors.ParsedBlue);
        ImGui.Begin("Window");
        ImGui.Text("Test Window");
        ImGui.End();
        ImGui.PopStyleColor();
    }

    /// <inheritdoc />
    public void Dispose()
    {
        PluginInterface.UiBuilder.Draw -= UiBuilderOnDraw;
    }

    /// <inheritdoc />
    public string Name => "MinimalPlugin";
}