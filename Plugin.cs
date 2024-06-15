using System.Diagnostics.CodeAnalysis;
using Dalamud.Interface.Colors;
using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
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
        PluginLog.Info("Plugin started.");
        PluginInterface.UiBuilder.Draw += UiBuilderOnDraw;
    }

    [PluginService]
    private static DalamudPluginInterface PluginInterface { get; set; } = null!;
    
    [PluginService]
    private static IPluginLog PluginLog { get; set; } = null!;

    private static void UiBuilderOnDraw()
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
}