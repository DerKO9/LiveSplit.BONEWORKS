using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using LiveSplit.Model;
using LiveSplit.UI;
using LiveSplit.UI.Components;
using System.Diagnostics;
using SpeedrunComSharp;
using System.Threading;

namespace LiveSplit.BONEWORKS
{
    public class BoneworksComponent : IComponent
    {

        public BoneworksComponent(LiveSplitState state)
        {
            _settings = new BoneworksSettings();
            _state = state;
        }

        public string ComponentName => "BONEWORKS Autosplitter";
        public float HorizontalWidth => 0;
        public float MinimumHeight => 0;
        public float VerticalHeight => 0;
        public float MinimumWidth => 0;
        public float PaddingTop => 0;
        public float PaddingBottom => 0;
        public float PaddingLeft => 0;
        public float PaddingRight => 0;

        private BoneworksSettings _settings;

        private LiveSplitState _state;

        public IDictionary<string, Action> ContextMenuControls => throw new NotImplementedException();

        public void Dispose() { }
        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, System.Drawing.Region clipRegion) { }
        public void DrawVertical(Graphics g, LiveSplitState state, float width, System.Drawing.Region clipRegion) { }
        public XmlNode GetSettings(XmlDocument document) { return _settings.UpdateSettings(document); }
        public Control GetSettingsControl(LayoutMode mode) { return _settings; }
        public void SetSettings(XmlNode settings) { }
        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) 
        {
            
        }
    }
}
