namespace PhobsRedisApi.XmlRpc
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListProperty
    {

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlans ratePlansField;

        private string propertyIdField;

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlans RatePlans
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlans
    {

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlan ratePlanField;

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlan RatePlan
        {
            get
            {
                return this.ratePlanField;
            }
            set
            {
                this.ratePlanField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlan
    {

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnits unitsField;

        private string rateIdField;

        private string accessCodeField;

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnits Units
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnits
    {

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnit unitField;

        /// <remarks/>
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnit Unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnit
    {

        private byte maxFreeNightsField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRate rateField;

        private string unitIdField;

        private byte occupancyField;

        private byte occupancyMinField;

        private byte occupancyMaxField;

        /// <remarks/>
        public byte MaxFreeNights
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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRate Rate
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
        public byte Occupancy
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
        public byte OccupancyMin
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
        public byte OccupancyMax
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRate
    {

        private string boardField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePrice priceField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRateStayTotal stayTotalField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceOriginal priceOriginalField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDay[] priceBreakdownField;

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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePrice Price
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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRateStayTotal StayTotal
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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceOriginal PriceOriginal
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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDay[] PriceBreakdown
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePrice
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRateStayTotal
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceOriginal
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDay
    {

        private System.DateTime dateField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDayPrice priceField;

        private PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDayLoyalty loyaltyField;

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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDayPrice Price
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
        public PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDayLoyalty Loyalty
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDayPrice
    {

        private string currencyField;

        private byte valueField;

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
        public byte Value
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRSAvailabilityListPropertyRatePlansRatePlanUnitsUnitRatePriceDayLoyalty
    {

        private bool loyFreeDaysApplyField;

        private byte loyPriceField;

        private byte pointsUsedField;

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
        public byte LoyPrice
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
        public byte PointsUsed
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
