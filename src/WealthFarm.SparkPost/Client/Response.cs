using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WealthFarm.SparkPost.Client
{
    public class Response
    {
        private bool _isSuccessStatusCode;

        public Response(HttpStatusCode status, HttpContent content)
        {
            int code = (int)status;
            _isSuccessStatusCode = code < 200 || code >= 400;
        }

        public HttpStatusCode StatusCode { get; private set; }
        public IEnumerable<Error> Errors { get; private set; }
        public HttpContent Content { get; private set; }

        public async Task<IContentType> ReadContentAsync<IContentType>()
        {
            if (Content == null || !_isSuccessStatusCode)
            {
                return default(IContentType);
            }

	        using (var stream = await Content.ReadAsStreamAsync())
            using (var reader = new JsonTextReader(new StreamReader(stream)))
            {
                var serializer = new JsonSerializer();
                return serializer.Deserialize<IContentType>(reader);
	        }
		}

        public void WithErrors(IEnumerable<Error> errors)
        {
            Errors = errors;
        }
	}
}
