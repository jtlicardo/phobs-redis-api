using PhobsRedisApi.Dtos;

namespace PhobsRedisApi.PhobsModels
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PCAvailabilityCalendarRQ
    {

        private PCAvailabilityCalendarRQAuth authField;

        private string propertyIdField;

        private PCAvailabilityCalendarRQPeriod periodField;

        private bool showUnitDetailsField;

        private string langField;

        /// <remarks/>
        public PCAvailabilityCalendarRQAuth Auth
        {
            get
            {
                return this.authField;
            }
            set
            {
                this.authField = value;
            }
        }

        /// <remarks/>
        public string PropertyId
        {
            get
            {
                return this.propertyIdField;
            }
            set
            {
                this.propertyIdField = value;
            }
        }

        /// <remarks/>
        public PCAvailabilityCalendarRQPeriod Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public bool ShowUnitDetails
        {
            get
            {
                return this.showUnitDetailsField;
            }
            set
            {
                this.showUnitDetailsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }

        public static PCAvailabilityCalendarRQ CreateObject(
            string username,
            string password,
            string siteId,
            AvailabilityCalendarDto request)
        {
            return new PCAvailabilityCalendarRQ()
            {
                Auth = new PCAvailabilityCalendarRQAuth()
                {
                    Username = username,
                    Password = password,
                    SiteId = siteId
                },
                PropertyId = request.PropertyId,
                Period = new PCAvailabilityCalendarRQPeriod()
                {
                    Start = DateTime.Parse(request.StartDate),
                    End = DateTime.Parse(request.EndDate)
                },
                ShowUnitDetails = false,
                Lang = request.Lang
            };
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCAvailabilityCalendarRQAuth
    {

        private string usernameField;

        private string passwordField;

        private string siteIdField;

        /// <remarks/>
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        /// <remarks/>
        public string SiteId
        {
            get
            {
                return this.siteIdField;
            }
            set
            {
                this.siteIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCAvailabilityCalendarRQPeriod
    {

        private System.DateTime startField;

        private System.DateTime endField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime End
        {
            get
            {
                return this.endField;
            }
            set
            {
                this.endField = value;
            }
        }
    }


}
