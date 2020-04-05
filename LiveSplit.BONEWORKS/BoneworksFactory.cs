using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.BONEWORKS
{
    class BoneworksFactory : IComponentFactory
    {
        public string ComponentName => "BONEWORKS Autosplitter";

        public string Description => "Autosplitter for BONEWORKS";

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => ComponentName;

        public string XMLURL => "";

        public string UpdateURL => "";

        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public IComponent Create(LiveSplitState state){ return new BoneworksComponent(state); }
    }
}
