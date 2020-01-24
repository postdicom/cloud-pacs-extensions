using PostDicomPlugin;
using PostDicomPlugin.Objects;
using System;

namespace Extension_Template
{
    public class Extension : pdPlugin
    {
        public override void Initialize()
        {
            base.Initialize();
            PluginId = Guid.Parse("8f974cb1-8415-4ac2-90eb-ebb081fba0bd");//Create new Guid for your project
        }

        public override void MessageReceivedFromUI(object rmo, pdSession session, string content)
        {
            base.MessageReceivedFromUI(rmo, session, content);
        }
    }
}
