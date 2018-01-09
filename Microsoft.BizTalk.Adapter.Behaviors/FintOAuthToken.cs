using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;
using System.Xml;
using System.Net;
using System.IO;
using System.ServiceModel.Configuration;
using System.Configuration;
using System.Web.Script.Serialization; 

namespace Microsoft.BizTalk.Adapter.Behaviors
{
    public class FintOAuthToken
    {
        public string expires_in { get; set; }
        public string token_type { get; set; }
        public string access_token { get; set; }
    }
}