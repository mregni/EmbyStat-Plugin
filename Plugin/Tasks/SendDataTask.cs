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
        public async Task Execute(CancellationToken cancellationToken, IProgress<double> progress)
        {
            await Task.FromResult(true);
        }

        public IEnumerable<TaskTriggerInfo> GetDefaultTriggers()
        {
            return new[]
            {
                new TaskTriggerInfo
                {
                    Type = TaskTriggerInfo.TriggerDaily
                }
            };
        }

        public string Name => "Send extra data";
        public string Key => "EbmyStatSendExtraDataTask";
        public string Description => "Send extra data to your EmbyStat server";
        public string Category => "EmbyStat";
    }
}
