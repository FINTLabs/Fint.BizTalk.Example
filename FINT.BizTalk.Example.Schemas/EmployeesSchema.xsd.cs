namespace FINT.BizTalk.Example.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://FINT.BizTalk.Example.Schemas.EmployeesSchema",@"Employees")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Employees"})]
    public sealed class EmployeesSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://FINT.BizTalk.Example.Schemas.EmployeesSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Employees"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""_embedded"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""_entries"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""ansattnummer"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""identifikatorverdi"" type=""xs:unsignedInt"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ansettelsesperiode"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""slutt"" type=""xs:dateTime"" />
                          <xs:element minOccurs=""0"" name=""start"" type=""xs:dateTime"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""brukernavn"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""gyldighetsperiode"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""slutt"" type=""xs:dateTime"" />
                                <xs:element minOccurs=""0"" name=""start"" type=""xs:dateTime"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""identifikatorverdi"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""kontaktinformasjon"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""epostadresse"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""mobiltelefonnummer"" type=""xs:unsignedInt"" />
                          <xs:element minOccurs=""0"" name=""nettsted"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""sip"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""telefonnummer"" type=""xs:unsignedInt"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""systemId"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""identifikatorverdi"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""_links"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""person"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""personalressurskategori"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""arbeidsforhold"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""self"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""_links"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""self"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""href"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""total_items"" type=""xs:unsignedByte"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EmployeesSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Employees";
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
