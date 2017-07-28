using System;
using System.Net.Http;
using System.Threading;

namespace WealthFarm.SparkPost
{
    public class Request
    {
        public HttpMethod Method { get; set; }
        public Uri Uri { get; set; }
        public object Content { get; set; }
        public CancellationToken CancellationToken { get; set; }
        public HttpCompletionOption CompletionOption { get; set; }
    }
}
