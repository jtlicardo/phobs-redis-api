using Microsoft.AspNetCore.Mvc;
using PhobsRedisApi.XmlRpc;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace PhobsRedisApi.Controllers
{

    public class PARequest
    {
        public string[] PropertyIds { get; set; }
        public PCPropertyAvailabilityRQUnitFilter UnitFilter { get; set; }
        public string Lang { get; set; }
    }


    [Route("[controller]")]
    [ApiController]
    public class PropertyAvailabilityController : ControllerBase
    {
        private readonly IConfiguration _config;

        public PropertyAvailabilityController(IConfiguration config)
        {
            _config = config;
        }

        [HttpPost]
        async public Task<ActionResult<PCPropertyAvailabilityRS>> PropertyAvailability([FromBody] PARequest request)
        {
            string phobsUrl = _config["PhobsUrl"];

            PCPropertyAvailabilityRQ requestObj = new PCPropertyAvailabilityRQ()
            {
                Auth = new PCPropertyAvailabilityRQAuth()
                {
                    Username = _config["PhobsUsername"],
                    Password = _config["PhobsPassword"],
                    SiteId = _config["PhobsSiteId"]
                },
                PropertyIds = request.PropertyIds,
                UnitFilter = new PCPropertyAvailabilityRQUnitFilter()
                {
                    Date = request.UnitFilter.Date,
                    Nights = request.UnitFilter.Nights,
                    RateList = request.UnitFilter.RateList,
                    UnitList = request.UnitFilter.UnitList,
                    UnitGroup = request.UnitFilter.UnitGroup,
                    Persons = new PCPropertyAvailabilityRQUnitFilterPersons()
                    {
                        Adults = request.UnitFilter.Persons.Adults,
                        ChdGroup1 = request.UnitFilter.Persons.ChdGroup1,
                        ChdGroup2 = request.UnitFilter.Persons.ChdGroup2,
                        Pets = request.UnitFilter.Persons.Pets,
                        Children = new PCPropertyAvailabilityRQUnitFilterPersonsChildren()
                        {
                            Age = request.UnitFilter.Persons.Children.Age
                        },
                    },
                    PriceBreakdown = request.UnitFilter.PriceBreakdown,
                    Loyalty = new PCPropertyAvailabilityRQUnitFilterLoyalty()
                    {
                        MaxFreeNights = request.UnitFilter.Loyalty.MaxFreeNights,
                        LoyaltyId = request.UnitFilter.Loyalty.LoyaltyId,
                        PointsAvailable = request.UnitFilter.Loyalty.PointsAvailable
                    },
                    GiftVoucher = new PCPropertyAvailabilityRQUnitFilterGiftVoucher()
                    {
                        GiftVoucherId = request.UnitFilter.GiftVoucher.GiftVoucherId,
                        PromotionId = request.UnitFilter.GiftVoucher.PromotionId,
                        GiftVoucherType = request.UnitFilter.GiftVoucher.GiftVoucherType,
                        GiftVoucherValue = new PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValue()
                        {
                            Value = new PCPropertyAvailabilityRQUnitFilterGiftVoucherGiftVoucherValueValue()
                            {
                                Currency = request.UnitFilter.GiftVoucher.GiftVoucherValue.Value.Currency,
                                Value = request.UnitFilter.GiftVoucher.GiftVoucherValue.Value.Value,
                            },
                            Type = request.UnitFilter.GiftVoucher.GiftVoucherValue.Type
                        },
                        GiftVoucherProducts = request.UnitFilter.GiftVoucher.GiftVoucherProducts
                            .Select(x => new PCPropertyAvailabilityRQUnitFilterGiftVoucherProduct
                            {
                                Name = x.Name,
                                Value = new PCPropertyAvailabilityRQUnitFilterGiftVoucherProductValue()
                                {
                                    Currency = x.Value.Currency,
                                    Value = x.Value.Value
                                },
                                ProductId = x.ProductId
                            }).ToArray()
                    },
                    AccessCodes = request.UnitFilter.AccessCodes,
                    Labels = request.UnitFilter.Labels
                },
                Lang = request.Lang,
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(phobsUrl);

                XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
                namespaces.Add("", "");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(PCPropertyAvailabilityRQ));

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    xmlSerializer.Serialize(memoryStream, requestObj, namespaces);

                    StringContent content = new StringContent(Encoding.UTF8.GetString(memoryStream.ToArray()), Encoding.UTF8, "text/xml");
                    Console.WriteLine("\nREQUEST\n" + await content.ReadAsStringAsync());

                    HttpResponseMessage response = await client.PostAsync(phobsUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("\nRESPONSE\n" + responseData);
                        return Ok(responseData);
                    }
                    else
                    {
                        return BadRequest(response.StatusCode + " " + response.ReasonPhrase);
                    }
                }
            }
        }
    }
}
