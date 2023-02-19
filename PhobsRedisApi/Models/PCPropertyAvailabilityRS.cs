namespace PhobsRedisApi.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.phobs.net/phobs/webconnect/2018/", IsNullable = false)]
    public partial class PCPropertyAvailabilityRS
    {

        private PCPropertyAvailabilityRSAvailabilityList availabilityListField;

        private string sessionIDField;

        private PCPropertyAvailabilityRSResponseType responseTypeField;

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityList AvailabilityList
        {
            get
            {
                return this.availabilityListField;
            }
            set
            {
                this.availabilityListField = value;
            }
        }

        /// <remarks/>
        public string SessionID
        {
            get
            {
                return this.sessionIDField;
            }
            set
            {
                this.sessionIDField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRSResponseType ResponseType
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
    public partial class PCPropertyAvailabilityRSAvailabilityList
    {

        private PCPropertyAvailabilityRSAvailabilityListProperty propertyField;

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListProperty Property
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
    public partial class PCPropertyAvailabilityRSAvailabilityListProperty
    {

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlan[] ratePlansField;

        private string propertyIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RatePlan", IsNullable = false)]
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlan[] RatePlans
        {
            get
            {
                return this.ratePlansField;
            }
            set
            {
                this.ratePlansField = value;
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
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlan
    {

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnit[] unitsField;

        private string rateIdField;

        private string accessCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Unit", IsNullable = false)]
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnit[] Units
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
        public string RateId
        {
            get
            {
                return this.rateIdField;
            }
            set
            {
                this.rateIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string AccessCode
        {
            get
            {
                return this.accessCodeField;
            }
            set
            {
                this.accessCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnit
    {

        private int maxFreeNightsField;

        private bool maxFreeNightsFieldSpecified;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRate rateField;

        private string unitIdField;

        private int occupancyField;

        private int occupancyMinField;

        private int occupancyMaxField;

        /// <remarks/>
        public int MaxFreeNights
        {
            get
            {
                return this.maxFreeNightsField;
            }
            set
            {
                this.maxFreeNightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxFreeNightsSpecified
        {
            get
            {
                return this.maxFreeNightsFieldSpecified;
            }
            set
            {
                this.maxFreeNightsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRate Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Occupancy
        {
            get
            {
                return this.occupancyField;
            }
            set
            {
                this.occupancyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int OccupancyMin
        {
            get
            {
                return this.occupancyMinField;
            }
            set
            {
                this.occupancyMinField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int OccupancyMax
        {
            get
            {
                return this.occupancyMaxField;
            }
            set
            {
                this.occupancyMaxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRate
    {

        private string boardField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePrice priceField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRateStayTotal stayTotalField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceOriginal priceOriginalField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDay[] priceBreakdownField;

        /// <remarks/>
        public string Board
        {
            get
            {
                return this.boardField;
            }
            set
            {
                this.boardField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePrice Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRateStayTotal StayTotal
        {
            get
            {
                return this.stayTotalField;
            }
            set
            {
                this.stayTotalField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceOriginal PriceOriginal
        {
            get
            {
                return this.priceOriginalField;
            }
            set
            {
                this.priceOriginalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PriceDay", IsNullable = false)]
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDay[] PriceBreakdown
        {
            get
            {
                return this.priceBreakdownField;
            }
            set
            {
                this.priceBreakdownField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePrice
    {

        private string currencyField;

        private string priceTypeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRateStayTotal
    {

        private string currencyField;

        private string priceTypeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceOriginal
    {

        private string currencyField;

        private string priceTypeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDay
    {

        private System.DateTime dateField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDayPrice priceField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDayLoyalty loyaltyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDayPrice Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDayLoyalty Loyalty
        {
            get
            {
                return this.loyaltyField;
            }
            set
            {
                this.loyaltyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDayPrice
    {

        private string currencyField;

        private int valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public int Value
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlanUnitRatePriceDayLoyalty
    {

        private bool loyFreeDaysApplyField;

        private int loyPriceField;

        private int pointsUsedField;

        /// <remarks/>
        public bool LoyFreeDaysApply
        {
            get
            {
                return this.loyFreeDaysApplyField;
            }
            set
            {
                this.loyFreeDaysApplyField = value;
            }
        }

        /// <remarks/>
        public int LoyPrice
        {
            get
            {
                return this.loyPriceField;
            }
            set
            {
                this.loyPriceField = value;
            }
        }

        /// <remarks/>
        public int PointsUsed
        {
            get
            {
                return this.pointsUsedField;
            }
            set
            {
                this.pointsUsedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.phobs.net/phobs/webconnect/2018/")]
    public partial class PCPropertyAvailabilityRSResponseType
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