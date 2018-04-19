using System;
using System.Collections.Generic;
using System.Text;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Plugin
{
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        public override Guid Id => new Guid("ffa904b3-7bb1-4c23-ad5c-10a8c0f8b441");
        public static Plugin Instance { get; private set; }
        public override string Name => "EmbyStat plugin";
        public override string Description => "Get extra information and send it to your EmbyStat server";

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo() 
            };
        }
    }
}
