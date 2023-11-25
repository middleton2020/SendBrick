using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrick.Library.Tests
{
    #region FullOrders
    static class SampleOrder1
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "bricksinbloom7308";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "Bricks In  Bloom";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "Leigha Middleton";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 7308;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "Unit 4";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "Candy Works";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "15 Parkhouse Road";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "CA3 0JU";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "Carlisle";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "Cumbria";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "GB";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "1228511030";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "bricksinbloom@bricklink.com";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "7308";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "BrickLink";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "GB123 4567 89";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "BL15748250";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "Colin Middleton";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 1234567890;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "257 Ecclesall Road";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "Sheffield";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "South Yorkshire";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "S5 7HJ";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "GB";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "7505363818";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "colin@test.com";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "Front Porch";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "GBP";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "LEGO sets";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "DDU";
            }
        }
        public static DateTime CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return Convert.ToDateTime("2022-01-16");
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "15748250";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "PDF";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "GB15748250";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "EORI";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "LEGO";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "Sale of goods";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "Process";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 10.42;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "75b59db8-3cd3-4578-888e-54be016f07cc";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.value
            get
            {
                return 112.97;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "TPLN";
            }
        }
        public static DateTime PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return Convert.ToDateTime("2022-01-16");
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "P";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "01";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 2;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 3.1;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "KG";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "Level5";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "123456789";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "EmailAndSMS";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 3;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "10782";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Hulk vs. Rhino Truck Showdown";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 17.99;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.9;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "652534";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455692";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";
            }
        }
        #endregion

        #region Item2Values
        public static string Item2Id
        {
            //Items.itemId
            get
            {
                return "76205";
            }
        }
        public static string Item2Description
        {
            //Items.description
            get
            {
                return "Gargantos Showdown";
            }
        }
        public static int Item2ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item2Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item2Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item2Weight
        {
            //Items.weight
            get
            {
                return 1.0;
            }
        }
        public static string Item2CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item2HsCode
        {
            //Items.hsCode
            get
            {
                return "652584";
            }
        }
        public static string Item2SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455682";
            }
        }
        public static string Item2ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";
            }
        }
        #endregion

        #region Item3Values
        public static string Item3Id
        {
            //Items.itemId
            get
            {
                return "76175";
            }
        }
        public static string Item3Description
        {
            //Items.description
            get
            {
                return "Attack on the Spider Lair";
            }
        }
        public static int Item3ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item3Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item3Value
        {
            //Items.valueData
            get
            {
                return 69.99;
            }
        }
        public static double Item3Weight
        {
            //Items.weight
            get
            {
                return 1.2;
            }
        }
        public static string Item3CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item3HsCode
        {
            //Items.hsCode
            get
            {
                return "659534";
            }
        }
        public static string Item3SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499692";
            }
        }
        public static string Item3ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76175-1.jpg?202009170531";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-1";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 2.2;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 15;
            }
        }
        #endregion

        #region Parcel2Values
        public static string Parcel2Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-2";
            }
        }
        public static int Parcel2Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double Parcel2Weight
        {
            //Packages.weight
            get
            {
                return 0.9;
            }
        }
        public static int Parcel2Height
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int Parcel2Length
        {
            //Packages.length
            get
            {
                return 45;
            }
        }
        public static int Parcel2Width
        {
            //Packages.width
            get
            {
                return 10;
            }
        }
        #endregion
    }

    static class SampleOrder2
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "bricksinbloom7308";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "Bricks In  Bloom";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "Leigha Middleton";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 7308;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "Unit 5";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "Candy Works";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "15 Parkhouse Road";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "CA3 0JU";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "Carlisle";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "Cumbria";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "GB";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "1228511030";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "bricksinbloom@bricklink.com";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "7308";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "BrickLink";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "GB123 4567 89";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "BL15748250";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "Colin Middleton";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 1234567890;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "257 Ecclesall Road";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "Sheffield";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "South Yorkshire";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "S5 7HJ";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "GB";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "7505363818";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "colin@test.com";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "Front Porch";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "GBP";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "LEGO sets";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "DDU";
            }
        }
        public static DateTime CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return Convert.ToDateTime("2022-01-16");
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "15748250";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "PDF";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "GB15748250";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "EORI";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "LEGO";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "Sale of goods";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "Process";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 10.42;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "75b59db8-3cd3-4578-888e-54be016f07cc";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 112.97;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "TPLN";
            }
        }
        public static DateTime PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return Convert.ToDateTime("2022-01-16");
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "P";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "01";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 2;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 3.1;
            }
        }
        public static string PostingWeightUOM0
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "KG";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "Level5";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "123456789";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "EmailAndSMS";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 3;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "10782";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Hulk vs. Rhino Truck Showdown";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 17.99;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.9;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "652534";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455692";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";
            }
        }
        #endregion

        #region Item2Values
        public static string Item2Id
        {
            //Items.itemId
            get
            {
                return "76205";
            }
        }
        public static string Item2Description
        {
            //Items.description
            get
            {
                return "Gargantos Showdown";
            }
        }
        public static int Item2ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item2Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item2Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item2Weight
        {
            //Items.weight
            get
            {
                return 1.0;
            }
        }
        public static string Item2CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item2HsCode
        {
            //Items.hsCode
            get
            {
                return "652584";
            }
        }
        public static string Item2SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455682";
            }
        }
        public static string Item2ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";
            }
        }
        #endregion

        #region Item3Values
        public static string Item3Id
        {
            //Items.itemId
            get
            {
                return "76175";
            }
        }
        public static string Item3Description
        {
            //Items.description
            get
            {
                return "Attack on the Spider Lair";
            }
        }
        public static int Item3ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item3Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item3Value
        {
            //Items.valueData
            get
            {
                return 69.99;
            }
        }
        public static double Item3Weight
        {
            //Items.weight
            get
            {
                return 1.2;
            }
        }
        public static string Item3CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item3HsCode
        {
            //Items.hsCode
            get
            {
                return "659534";
            }
        }
        public static string Item3SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499692";
            }
        }
        public static string Item3ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76175-1.jpg?202009170531";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-1";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 2.2;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 15;
            }
        }
        #endregion

        #region Parcel2Values
        public static string Parcel2Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-2";
            }
        }
        public static int Parcel2Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double Parcel2Weight
        {
            //Packages.weight
            get
            {
                return 0.9;
            }
        }
        public static int Parcel2Height
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int Parcel2Length
        {
            //Packages.length
            get
            {
                return 45;
            }
        }
        public static int Parcel2Width
        {
            //Packages.width
            get
            {
                return 10;
            }
        }
        #endregion
    }

    static class SampleOrder3
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "bricksinbloom7308";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "BrickLane";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "Leigha Middleton";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 7308;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "Unit 4";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "Candy Works";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "15 Parkhouse Road";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "CA3 0JU";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "Carlisle";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "Cumbria";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "GB";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "1228511030";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "bricksinbloom@bricklink.com";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "7308";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "BrickLink";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "GB123 4567 89";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "BL15748250";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "Bad Bob";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 1234567890;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "257 Ecclesall Road";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "Sheffield";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "South Yorkshire";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "S5 7HJ";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "GB";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "7505363818";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "colin@test.com";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "Front Porch";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "GBP";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "LEGO bricks";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "DDU";
            }
        }
        public static DateTime CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return Convert.ToDateTime("2022-01-16");
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "15748250";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "PDF";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "GB15748250";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "EORI";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "LEGO";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "Sale of goods";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "Process";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 12.44;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "75b59db8-3cd3-4578-888e-54be016f07cc";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 112.97;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "TPLN";
            }
        }
        public static DateTime PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return Convert.ToDateTime("2022-01-16");
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "P";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "01";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 2;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 3.1;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "KG";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "Level5";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "123456789";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return true;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "EmailAndSMS";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 4;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "10782";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Hulk vs. Rhino Truck Showdown";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 17.99;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.9;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "652534";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455692";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";
            }
        }
        #endregion

        #region Item2Values
        public static string Item2Id
        {
            //Items.itemId
            get
            {
                return "76205";
            }
        }
        public static string Item2Description
        {
            //Items.description
            get
            {
                return "Gargantos Showdown";
            }
        }
        public static int Item2ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 3;
            }
        }
        public static int Item2Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item2Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item2Weight
        {
            //Items.weight
            get
            {
                return 1.0;
            }
        }
        public static string Item2CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item2HsCode
        {
            //Items.hsCode
            get
            {
                return "652584";
            }
        }
        public static string Item2SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455682";
            }
        }
        public static string Item2ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";
            }
        }
        #endregion

        #region Item3Values
        public static string Item3Id
        {
            //Items.itemId
            get
            {
                return "76175";
            }
        }
        public static string Item3Description
        {
            //Items.description
            get
            {
                return "Attack on the Spider Lair";
            }
        }
        public static int Item3ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item3Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item3Value
        {
            //Items.valueData
            get
            {
                return 69.99;
            }
        }
        public static double Item3Weight
        {
            //Items.weight
            get
            {
                return 1.2;
            }
        }
        public static string Item3CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item3HsCode
        {
            //Items.hsCode
            get
            {
                return "659534";
            }
        }
        public static string Item3SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499692";
            }
        }
        public static string Item3ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76175-1.jpg?202009170531";
            }
        }
        #endregion

        #region Item4Values
        public static string Item4Id
        {
            //Items.itemId
            get
            {
                return "10783";
            }
        }
        public static string Item4Description
        {
            //Items.description
            get
            {
                return "Spider-Man at Doc Ock's Lab";
            }
        }
        public static int Item4ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item4Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item4Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item4Weight
        {
            //Items.weight
            get
            {
                return 0.6;
            }
        }
        public static string Item4CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item4HsCode
        {
            //Items.hsCode
            get
            {
                return "655534";
            }
        }
        public static string Item4SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499699";
            }
        }
        public static string Item4ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/10783-1.jpg?202109211239";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-1";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 1.8;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 15;
            }
        }
        #endregion

        #region Parcel2Values
        public static string Parcel2Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-2";
            }
        }
        public static int Parcel2Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double Parcel2Weight
        {
            //Packages.weight
            get
            {
                return 0.9;
            }
        }
        public static int Parcel2Height
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int Parcel2Length
        {
            //Packages.length
            get
            {
                return 45;
            }
        }
        public static int Parcel2Width
        {
            //Packages.width
            get
            {
                return 10;
            }
        }
        #endregion

        #region Parcel3Values
        public static string Parcel3Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-3";
            }
        }
        public static int Parcel3Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 3;
            }
        }
        public static double Parcel3Weight
        {
            //Packages.weight
            get
            {
                return 1;
            }
        }
        public static int Parcel3Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel3Length
        {
            //Packages.length
            get
            {
                return 35;
            }
        }
        public static int Parcel3Width
        {
            //Packages.width
            get
            {
                return 20;
            }
        }
        #endregion
    }

    static class SampleOrder4
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 0;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 0;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "";
            }
        }
        public static DateTime CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return Convert.ToDateTime("");
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 0.00;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "";
            }
        }
        public static DateTime PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return Convert.ToDateTime("");
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 0.00;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 0;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.00;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.00;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 0.00;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 0;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 0;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 0;
            }
        }
        #endregion
    }

    static class SampleOrder5
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 0;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 0;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "";
            }
        }
        public static DateTime CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return Convert.ToDateTime("");
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 0.00;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "";
            }
        }
        public static DateTime PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return Convert.ToDateTime("");
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 0.00;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 0;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.00;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.00;
            }
        }
        public static string ItemCountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "";
            }
        }
        public static string ItemHsCode
        {
            //Items.hsCode
            get
            {
                return "";
            }
        }
        public static string ItemSkuCode
        {
            //Items.skuCode
            get
            {
                return "";
            }
        }
        public static string ItemImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 0.00;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 0;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 0;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 0;
            }
        }
        #endregion
    }
    #endregion

    #region ParcelSamples
    /// <summary>
    /// 2, "TestParcel1", 5.1 (KG), 16 * 8 * 3
    /// </summary>
    static class SampleParcel1
    {
        public static string ParcelId
        {
            //Packages.packagingId
            get
            {
                return "TestParcel1";
            }
        }
        public static int ParcelInstance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double ParcelWeight
        {
            //Packages.weight
            get
            {
                return 5.1;
            }
        }
        public static int ParcelHeight
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int ParcelLength
        {
            //Packages.length
            get
            {
                return 16;
            }
        }
        public static int ParcelWidth
        {
            //Packages.width
            get
            {
                return 8;
            }
        }
    }

    /// <summary>
    /// 3, "TestParcel2", 1.3 (KG), 8 * 3 * 1
    /// </summary>
    static class SampleParcel2
    {
        public static string ParcelId
        {
            //Packages.packagingId
            get
            {
                return "TestParcel2";
            }
        }
        public static int ParcelInstance
        {
            //Packages.packageOccurrence
            get
            {
                return 3;
            }
        }
        public static double ParcelWeight
        {
            //Packages.weight
            get
            {
                return 1.3;
            }
        }
        public static int ParcelHeight
        {
            //Packages.height
            get
            {
                return 1;
            }
        }
        public static int ParcelLength
        {
            //Packages.length
            get
            {
                return 8;
            }
        }
        public static int ParcelWidth
        {
            //Packages.width
            get
            {
                return 3;
            }
        }
    }

    /// <summary>
    /// 6, "TestParcel3", 0.2 (KG), 5 * 5 * 2
    /// </summary>
    static class SampleParcel3
    {
        public static string ParcelId
        {
            //Packages.packagingId
            get
            {
                return "TestParcel3";
            }
        }
        public static int ParcelInstance
        {
            //Packages.packageOccurrence
            get
            {
                return 6;
            }
        }
        public static double ParcelWeight
        {
            //Packages.weight
            get
            {
                return 0.2;
            }
        }
        public static int ParcelHeight
        {
            //Packages.height
            get
            {
                return 2;
            }
        }
        public static int ParcelLength
        {
            //Packages.length
            get
            {
                return 5;
            }
        }
        public static int ParcelWidth
        {
            //Packages.width
            get
            {
                return 5;
            }
        }
    }

    /// <summary>
    /// 1, "TestParcel4", 3.2 (KG), 15 * 8 * 1
    /// </summary>
    static class SampleParcel4
    {
        public static string ParcelId
        {
            //Packages.packagingId
            get
            {
                return "TestParcel4";
            }
        }
        public static int ParcelInstance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double ParcelWeight
        {
            //Packages.weight
            get
            {
                return 3.2;
            }
        }
        public static int ParcelHeight
        {
            //Packages.height
            get
            {
                return 1;
            }
        }
        public static int ParcelLength
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int ParcelWidth
        {
            //Packages.width
            get
            {
                return 8;
            }
        }
    }

    //static class SampleParcel5
    //{
    //    public static string ParcelId
    //    {
    //        //Packages.packagingId
    //        get
    //        {
    //            return "";
    //        }
    //    }
    //    public static int ParcelInstance
    //    {
    //        //Packages.packageOccurrence
    //        get
    //        {
    //            return 0;
    //        }
    //    }
    //    public static double ParcelWeight
    //    {
    //        //Packages.weight
    //        get
    //        {
    //            return 0.00;
    //        }
    //    }
    //    public static int ParcelHeight
    //    {
    //        //Packages.height
    //        get
    //        {
    //            return 0;
    //        }
    //    }
    //    public static int ParcelLength
    //    {
    //        //Packages.length
    //        get
    //        {
    //            return 0;
    //        }
    //    }
    //    public static int ParcelWidth
    //    {
    //        //Packages.width
    //        get
    //        {
    //            return 0;
    //        }
    //    }
    //}
    #endregion

    #region ItemSamples
    static class SampleItem1
    {
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "1";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Plate 1x4";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 3;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.06;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.02;
            }
        }
        public static string ItemCountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "Denmark";
            }
        }
        public static string ItemHsCode
        {
            //Items.hsCode
            get
            {
                return "Code1";
            }
        }
        public static string ItemSkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU1";
            }
        }
        public static string ItemImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
    }

    static class SampleItem2
    {
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "5";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Turntable 2x2";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.12;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.03;
            }
        }
        public static string ItemCountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "Denmark";
            }
        }
        public static string ItemHsCode
        {
            //Items.hsCode
            get
            {
                return "Code3";
            }
        }
        public static string ItemSkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3";
            }
        }
        public static string ItemImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
    }

    static class SampleItem3
    {
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "2";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Tile 2x4";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 2;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.06;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.02;
            }
        }
        public static string ItemCountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "Denmark";
            }
        }
        public static string ItemHsCode
        {
            //Items.hsCode
            get
            {
                return "Code2";
            }
        }
        public static string ItemSkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU2";
            }
        }
        public static string ItemImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
    }

    static class SampleItem4
    {
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "3";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Round Brick 2x2";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.15;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.05;
            }
        }
        public static string ItemCountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "Denmark";
            }
        }
        public static string ItemHsCode
        {
            //Items.hsCode
            get
            {
                return "Code4";
            }
        }
        public static string ItemSkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU4";
            }
        }
        public static string ItemImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
    }

    static class SampleItem5
    {
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 0;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.00;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.00;
            }
        }
        public static string ItemCountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "";
            }
        }
        public static string ItemHsCode
        {
            //Items.hsCode
            get
            {
                return "";
            }
        }
        public static string ItemSkuCode
        {
            //Items.skuCode
            get
            {
                return "";
            }
        }
        public static string ItemImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
    }
    #endregion
}
