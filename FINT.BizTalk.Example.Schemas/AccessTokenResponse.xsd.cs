namespace FINT.BizTalk.Example.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FINT.BizTalk.Example.Schemas.AccessTokenResponse",@"AccessToken")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "access_token", XPath = @"/*[local-name()='AccessToken' and namespace-uri()='http://FINT.BizTalk.Example.Schemas.AccessTokenResponse']/*[local-name()='access_token' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AccessToken"})]
    public sealed class AccessTokenResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://FINT.BizTalk.Example.Schemas.AccessTokenResponse"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://FINT.BizTalk.Example.Schemas.AccessTokenResponse"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AccessToken"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='AccessToken' and namespace-uri()='http://FINT.BizTalk.Example.Schemas.AccessTokenResponse']/*[local-name()='access_token' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""access_token"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""token_type"" type=""xs:string"" />
        <xs:element minOccurs=""0"" name=""expires_in"" type=""xs:unsignedShort"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AccessTokenResponse() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AccessToken";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
