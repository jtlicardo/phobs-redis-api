namespace PhobsRedisApi.XmlRpc
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PCPropertyAvailabilityRQ
    {

        private PCPropertyAvailabilityRQAuth authField;

        private string[] propertyIdsField;

        private PCPropertyAvailabilityRQUnitFilter unitFilterField;

        private string langField;

        /// <remarks/>
        public PCPropertyAvailabilityRQAuth Auth
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
        [System.Xml.Serialization.XmlArrayItemAttribute("PropertyId", IsNullable = false)]
        public string[] PropertyIds
        {
            get
            {
                return this.propertyIdsField;
            }
            set
            {
                this.propertyIdsField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilter UnitFilter
        {
            get
            {
                return this.unitFilterField;
            }
            set
            {
                this.unitFilterField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQAuth
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
    public partial class PCPropertyAvailabilityRQUnitFilter
    {

        private System.DateTime dateField;

        private byte nightsField;

        private string[] rateListField;

        private string[] unitListField;

        private string unitGroupField;

        private PCPropertyAvailabilityRQUnitFilterPersons personsField;

        private bool priceBreakdownField;

        private PCPropertyAvailabilityRQUnitFilterLoyalty loyaltyField;

        private PCPropertyAvailabilityRQUnitFilterGiftVoucher giftVoucherField;

        private string[] accessCodesField;

        private string[] labelsField;

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
        public byte Nights
        {
            get
            {
                return this.nightsField;
            }
            set
            {
                this.nightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RateId", IsNullable = false)]
        public string[] RateList
        {
            get
            {
                return this.rateListField;
            }
            set
            {
                this.rateListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("UnitId", IsNullable = false)]
        public string[] UnitList
        {
            get
            {
                return this.unitListField;
            }
            set
            {
                this.unitListField = value;
            }
        }

        /// <remarks/>
        public string UnitGroup
        {
            get
            {
                return this.unitGroupField;
            }
            set
            {
                this.unitGroupField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterPersons Persons
        {
            get
            {
                return this.personsField;
            }
            set
            {
                this.personsField = value;
            }
        }

        /// <remarks/>
        public bool PriceBreakdown
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

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterLoyalty Loyalty
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

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterGiftVoucher GiftVoucher
        {
            get
            {
                return this.giftVoucherField;
            }
            set
            {
                this.giftVoucherField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AccessCode", IsNullable = false)]
        public string[] AccessCodes
        {
            get
            {
                return this.accessCodesField;
            }
            set
            {
                this.accessCodesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Label", IsNullable = false)]
        public string[] Labels
        {
            get
            {
                return this.labelsField;
            }
            set
            {
                this.labelsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterPersons
    {

        private byte adultsField;

        private byte chdGroup1Field;

        private byte chdGroup2Field;

        private byte petsField;

        private PCPropertyAvailabilityRQUnitFilterPersonsChildren childrenField;

        /// <remarks/>
        public byte Adults
        {
            get
            {
                return this.adultsField;
            }
            set
            {
                this.adultsField = value;
            }
        }

        /// <remarks/>
        public byte ChdGroup1
        {
            get
            {
                return this.chdGroup1Field;
            }
            set
            {
                this.chdGroup1Field = value;
            }
        }

        /// <remarks/>
        public byte ChdGroup2
        {
            get
            {
                return this.chdGroup2Field;
            }
            set
            {
                this.chdGroup2Field = value;
            }
        }

        /// <remarks/>
        public byte Pets
        {
            get
            {
                return this.petsField;
            }
            set
            {
                this.petsField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterPersonsChildren Children
        {
            get
            {
                return this.childrenField;
            }
            set
            {
                this.childrenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterPersonsChildren
    {

        private byte ageField;

        /// <remarks/>
        public byte Age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterLoyalty
    {

        private byte maxFreeNightsField;

        private string loyaltyIdField;

        private string pointsAvailableField;

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
        public string LoyaltyId
        {
            get
            {
                return this.loyaltyIdField;
            }
            set
            {
                this.loyaltyIdField = value;
            }
        }

        /// <remarks/>
        public string PointsAvailable
        {
            get
            {
                return this.pointsAvailableField;
            }
            set
            {
                this.pointsAvailableField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterGiftVoucher
    {

        private string giftVoucherIdField;

        private string promotionIdField;

        private string giftVoucherTypeField;

        private PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValue giftVoucherValueField;

        private PCPropertyAvailabilityRQUnitFilterGiftVoucherProduct[] giftVoucherProductsField;

        /// <remarks/>
        public string GiftVoucherId
        {
            get
            {
                return this.giftVoucherIdField;
            }
            set
            {
                this.giftVoucherIdField = value;
            }
        }

        /// <remarks/>
        public string PromotionId
        {
            get
            {
                return this.promotionIdField;
            }
            set
            {
                this.promotionIdField = value;
            }
        }

        /// <remarks/>
        public string GiftVoucherType
        {
            get
            {
                return this.giftVoucherTypeField;
            }
            set
            {
                this.giftVoucherTypeField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValue GiftVoucherValue
        {
            get
            {
                return this.giftVoucherValueField;
            }
            set
            {
                this.giftVoucherValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Product", IsNullable = false)]
        public PCPropertyAvailabilityRQUnitFilterGiftVoucherProduct[] GiftVoucherProducts
        {
            get
            {
                return this.giftVoucherProductsField;
            }
            set
            {
                this.giftVoucherProductsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValue
    {

        private PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValueValue valueField;

        private string typeField;

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValueValue Value
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValueValue
    {

        private string currencyField;

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
    public partial class PCPropertyAvailabilityRQUnitFilterGiftVoucherProduct
    {

        private string nameField;

        private PCPropertyAvailabilityRQUnitFilterGiftVoucherProductValue valueField;

        private string productIdField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public PCPropertyAvailabilityRQUnitFilterGiftVoucherProductValue Value
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PCPropertyAvailabilityRQUnitFilterGiftVoucherProductValue
    {

        private string currencyField;

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


}
