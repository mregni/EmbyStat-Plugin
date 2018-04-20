using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Model.Tasks;

namespace Plugin.Tasks
{
    public class SendDataTask : IScheduledTask
    {
        public Task Execute(CancellationToken cancellationToken, IProgress<double> progress)
        {
            
        }

        public IEnumerable<TaskTriggerInfo> GetDefaultTriggers()
        {
            
        }

        public string Name => "Send extra data";
        public string Key => "EbmyStatSendExtraDataTask";
        public string Description => "Send extra data to your EmbyStat server";
        public string Category => "EmbyStat";
    }
}
