using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Microsoft.BizTalk.Adapter.Behaviors
{
    public class FintRestSecurityBehavior : IClientMessageInspector, IEndpointBehavior
    {
        // Some constants  
        private static string SalesforceAuthEndpoint = "https://namidp01.rogfk.no/nidp/oauth/nam/token";

        // Configuration Properties  
        private string _username;
        private string _password;
        private string _consumerKey;
        private string _consumerSecret;
        private int _sessionTimeout;

        // Private Properties  
        private FintOAuthToken _token;
        private DateTime _tokenExpiryTime;

        public FintRestSecurityBehavior(
            string username,
            string password,
            string consumerKey,
            string consumerSecret,
            int sessionTimeout)
        {
            _username = username;
            _password = password;
            _consumerKey = consumerKey;
            _consumerSecret = consumerSecret;
            _sessionTimeout = sessionTimeout;
        }

        private void FetchOAuthToken()
        {
            if ((_tokenExpiryTime == null) || (_tokenExpiryTime.CompareTo(DateTime.Now) <= 0))
            {
                var body = new StringBuilder();
                body.Append("grant_type=password&")
                    .Append("client_id=" + _consumerKey + "&")
                    .Append("client_secret=" + _consumerSecret + "&")
                    .Append("username=" + _username + "&")
                    .Append("password=" + _password);

                string result;

                try
                {
                    result = HttpPost(SalesforceAuthEndpoint, body.ToString());
                }
                catch (WebException)
                {
                    // do something  
                    return;
                }

                // Convert the JSON response into a token object  
                var ser = new JavaScriptSerializer();
                _token = ser.Deserialize<FintOAuthToken>(result);
                _tokenExpiryTime = DateTime.Now.AddSeconds(_sessionTimeout);
            }
        }

        public string HttpPost(string URI, string Parameters)
        {
            var req = WebRequest.Create(URI);
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";

            // Add parameters to post  
            byte[] data = Encoding.ASCII.GetBytes(Parameters);
            req.ContentLength = data.Length;
            var os = req.GetRequestStream();
            os.Write(data, 0, data.Length);
            os.Close();

            // Do the post and get the response.  
            System.Net.WebResponse resp = null;
            resp = req.GetResponse();

            var sr = new StreamReader(resp.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
        #region IClientMessageInspector

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            // do nothing  
        }
        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            // We are going to send a request  
            // Overview:  
            // This behavior will do the following:  
            // (1) Fetch Token, if required  
            // (2) Add the token to the message  
            // (3) Insert an Http Accept header so we get XML data in response, instead of JSON, which is default  
            //  
            // (1) Authentication  
            // (2) The token is added to the HTTP Authorization Header   
            // (3) Add the Accept Header  
            //  

            HttpRequestMessageProperty httpRequest = null;

            if (request.Properties.ContainsKey(HttpRequestMessageProperty.Name))
            {
                httpRequest = request.Properties[HttpRequestMessageProperty.Name] as HttpRequestMessageProperty;
            }

            if (httpRequest == null)
            {
                // NOTE: Ideally, we shouldn’t get here for WebHttp  
                httpRequest = new HttpRequestMessageProperty()
                {
                    Method = "GET",
                    SuppressEntityBody = true
                };
                request.Properties.Add(HttpRequestMessageProperty.Name, httpRequest);
            }

            WebHeaderCollection headers = httpRequest.Headers;
            FetchOAuthToken();

            headers.Add(HttpRequestHeader.Authorization, "Bearer " + _token.access_token);
            
            return null;
        }

        #endregion IClientMessageInspector

        #region IEndpointBehavior

        public void AddBindingParameters(ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            // do nothing  
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(this);
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            // do nothing  
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            // do nothing  
        }

        #endregion IEndpointBehavior
    }
}
