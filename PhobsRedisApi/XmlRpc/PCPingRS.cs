namespace PhobsRedisApi.XmlRpc
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.phobs.net/phobs/webconnect/2018/", IsNullable = false)]
    public partial class PCPingRS
    {
        
        private string echoStringField;

        private PCPingRSResponseType responseTypeField;

        /// <remarks/>
        public string EchoString
        {
            get
            {
                return this.echoStringField;
            }
            set
            {
                this.echoStringField = value;
            }
        }

        /// <remarks/>
        public PCPingRSResponseType ResponseType
        {
            get
            {
                return this.responseTypeField;
            }
            set
            {
                this.responseTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPingRSResponseType
    {

        private object successField;

        /// <remarks/>
        public object Success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }
    }


}
