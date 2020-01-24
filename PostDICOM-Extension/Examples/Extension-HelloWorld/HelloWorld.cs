using PostDicomPlugin;
using PostDicomPlugin.Objects;
using System;

namespace Extension_HelloWorld
{
    public class HelloWorld : pdPlugin
    {
        public override void Initialize()
        {
            base.Initialize();
            PluginId = Guid.Parse("38145f18-3ea8-11ea-b77f-2e728ce88125");//Create new Guid for your project
        }

        public override void MessageReceivedFromUI(object rmo, pdSession session, string content)
        {
            base.MessageReceivedFromUI(rmo, session, content);
            SendMessageToUI(rmo, "Hello from server. ClientMessage: " + content);
        }
    }
}
