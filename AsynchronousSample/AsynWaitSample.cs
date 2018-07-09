using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTopicsSamples.AsynchronousSample
{
    public class AsynWaitSample
    {
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using(var streamWriter = new StreamWriter(@"download.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }

    }
}
