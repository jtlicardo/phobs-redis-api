namespace PhobsRedisApi.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.phobs.net/phobs/webconnect/2018/", IsNullable = false)]
    public partial class PCAvailabilityCalendarRS
    {

        private PCAvailabilityCalendarRSProperties propertiesField;

        private PCAvailabilityCalendarRSResponseType responseTypeField;

        /// <remarks/>
        public PCAvailabilityCalendarRSProperties Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public PCAvailabilityCalendarRSResponseType ResponseType
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
    public partial class PCAvailabilityCalendarRSProperties
    {

        private PCAvailabilityCalendarRSPropertiesProperty propertyField;

        /// <remarks/>
        public PCAvailabilityCalendarRSPropertiesProperty Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCAvailabilityCalendarRSPropertiesProperty
    {

        private PCAvailabilityCalendarRSPropertiesPropertyAvailability[] availabilityCalendarField;

        private PCAvailabilityCalendarRSPropertiesPropertyUnit[] unitsField;

        private string propertyIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Availability", IsNullable = false)]
        public PCAvailabilityCalendarRSPropertiesPropertyAvailability[] AvailabilityCalendar
        {
            get
            {
                return this.availabilityCalendarField;
            }
            set
            {
                this.availabilityCalendarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Unit", IsNullable = false)]
        public PCAvailabilityCalendarRSPropertiesPropertyUnit[] Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCAvailabilityCalendarRSPropertiesPropertyAvailability
    {

        private System.DateTime dateField;

        private byte availableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCAvailabilityCalendarRSPropertiesPropertyUnit
    {

        private PCAvailabilityCalendarRSPropertiesPropertyUnitAvailability[] availabilityCalendarField;

        private string unitIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Availability", IsNullable = false)]
        public PCAvailabilityCalendarRSPropertiesPropertyUnitAvailability[] AvailabilityCalendar
        {
            get
            {
                return this.availabilityCalendarField;
            }
            set
            {
                this.availabilityCalendarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitId
        {
            get
            {
                return this.unitIdField;
            }
            set
            {
                this.unitIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCAvailabilityCalendarRSPropertiesPropertyUnitAvailability
    {

        private System.DateTime dateField;

        private byte availableField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Available
        {
            get
            {
                return this.availableField;
            }
            set
            {
                this.availableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCAvailabilityCalendarRSResponseType
    {
        public bool success => Errors == null;

        private PCAvailabilityCalendarRSResponseTypeError[] errorsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Error", IsNullable = false)]
        public PCAvailabilityCalendarRSResponseTypeError[] Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCAvailabilityCalendarRSResponseTypeError
    {

        private byte codeField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}