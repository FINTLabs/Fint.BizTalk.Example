using System;
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
    /// <summary>
    /// Se https://docs.microsoft.com/en-us/biztalk/core/step-3d-enabling-biztalk-server-to-send-and-receive-messages-from-salesforce
    /// </summary>
    public class FintRestBehaviorElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(FintRestSecurityBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new FintRestSecurityBehavior(Username, Password, ConsumerKey, ConsumerSecret, SessionTimeout);
        }

        [ConfigurationProperty("username", IsRequired = true)]
        public string Username
        {
            get { return (string)this["username"]; }
            set { this["username"] = value; }
        }

        [ConfigurationProperty("password", IsRequired = true)]
        public string Password
        {
            get { return (string)this["password"]; }
            set { this["password"] = value; }
        }

        [ConfigurationProperty("consumerKey", IsRequired = true)]
        public string ConsumerKey
        {
            get { return (string)this["consumerKey"]; }
            set { this["consumerKey"] = value; }
        }

        [ConfigurationProperty("consumerSecret", IsRequired = true)]
        public string ConsumerSecret
        {
            get { return (string)this["consumerSecret"]; }
            set { this["consumerSecret"] = value; }
        }

        [ConfigurationProperty("sessionTimeout", IsRequired = false, DefaultValue = 300)]
        public int SessionTimeout
        {
            get { return (int)this["sessionTimeout"]; }
            set { this["sessionTimeout"] = value; }
        }
    }
}
