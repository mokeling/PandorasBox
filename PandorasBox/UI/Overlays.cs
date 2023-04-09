using Dalamud.Interface.Windowing;
using ImGuiNET;
using PandorasBox.Features;

namespace PandorasBox.UI
{
    internal class Overlays : Window
    {
        Feature Feature;
        public Overlays(Feature t) : base($"###Overlay{t.Name}", ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoScrollbar
                    | ImGuiWindowFlags.AlwaysAutoResize | ImGuiWindowFlags.NoNavFocus
                    | ImGuiWindowFlags.AlwaysUseWindowPadding | ImGuiWindowFlags.NoTitleBar | ImGuiWindowFlags.NoSavedSettings)
        {
            Feature = t;
            IsOpen = true;
            ShowCloseButton = false;
            RespectCloseHotkey = false;
            this.SizeConstraints = new WindowSizeConstraints()
            {
                MaximumSize = new System.Numerics.Vector2(0, 0),
            };
        }

        public override void Draw() => Feature.Draw();

        public override bool DrawConditions() => Feature.Enabled;
    }
}
