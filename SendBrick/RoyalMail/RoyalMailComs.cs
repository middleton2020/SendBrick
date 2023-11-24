using System;
using System.Collections.Generic;
using System.Text;
using CM.JsonTools;
using CM.SendBrick.Library.Data;

namespace CM.SendBrick.Library.RoyalMail
{
    public class RoyalMailComs : JsonWriterTools
    {
        #region OutputMessageBody
        /// <summary>
        /// Output a correctly formatted mesage body.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        public static string MakeMessageBody(IOrderData inpSourceData)
        {
            try
            {
                // Royal Mail uses JSON output.
                return MakeJson(inpSourceData);
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region JSONOutput
        /// <summary>
        /// Output the data in the Royal Mail class as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        public static string MakeJson(IOrderData inpSourceData)
        {
            string payload;
            try
            {
                payload = "{";
                payload += AddJson("Shipper", MakeShipperJson(inpSourceData));
                payload += AddJson("Destination", MakeDestinationJson(inpSourceData));
                payload += AddJson("ShipmentInformation", MakeShipmentInformationJson(inpSourceData));
                payload += AddLastJson("CustomsInformation", MakeCustomsInformationJson(inpSourceData));
                payload += "}";
            }
            catch
            {
                throw;
            }

            return payload;
        }

        /// <summary>
        /// Output the data from the shipper sub-class as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakeShipperJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "{";
                payload += AddProperty("AddressId", inpSourceData.SupplierId);
                payload += AddProperty("ShipperReference", inpSourceData.SupplierReference1);
                payload += AddProperty("ShipperReference2", inpSourceData.SupplierReference2);
                payload += AddProperty("ShipperDepartment", inpSourceData.Department.ToString());
                payload += AddProperty("CompanyName", inpSourceData.SupplierBusinessName);
                payload += AddProperty("ContactName", inpSourceData.SupplierContactName);
                payload += AddProperty("AddressLine1", inpSourceData.SupplierAddressLine1);
                payload += AddProperty("AddressLine2", inpSourceData.SupplierAddressLine2);
                payload += AddProperty("AddressLine3", inpSourceData.SupplierAddressLine3);
                payload += AddProperty("Town", inpSourceData.SupplierAddressTown);
                payload += AddProperty("County", inpSourceData.SupplierAddressCounty);
                payload += AddProperty("CountryCode", inpSourceData.SupplierCountryCode);
                payload += AddProperty("Postcode", inpSourceData.SupplierAddressPostcode);
                payload += AddProperty("PhoneNumber", inpSourceData.SupplierPhoneNumber);
                payload += AddProperty("EmailAddress", inpSourceData.SupplierEmailAddress);
                payload += AddLastProperty("VatNumber", inpSourceData.SupplierVatNumber);
                payload += "}";

                return payload;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Output the data from the customer sub-class as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakeDestinationJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "{";
                payload += AddProperty("AddressId", inpSourceData.CustomerId);
                payload += AddProperty("CompanyName", inpSourceData.CustomerBusinessName);
                payload += AddProperty("ContactName", inpSourceData.CustomerContactName);
                payload += AddProperty("AddressLine1", inpSourceData.CustomerAddressLine1);
                payload += AddProperty("AddressLine2", inpSourceData.CustomerAddressLine2);
                payload += AddProperty("AddressLine3", inpSourceData.CustomerAddressLine3);
                payload += AddProperty("Town", inpSourceData.CustomerAddressTown);
                payload += AddProperty("County", inpSourceData.CustomerAddressCounty);
                payload += AddProperty("CountryCode", inpSourceData.CustomerCountryCode);
                payload += AddProperty("Postcode", inpSourceData.CustomerAddressPostcode);
                payload += AddProperty("PhoneNumber", inpSourceData.CustomerPhoneNumber);
                payload += AddProperty("EmailAddress", inpSourceData.CustomerEmailAddress);
                payload += AddLastProperty("VatNumber", inpSourceData.CustomerVatNumber);
                payload += "}";
                return payload;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Output the data from the shipment information sub-class as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakeShipmentInformationJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "{";
                payload += AddProperty("ShipmentDate", inpSourceData.PostingDate);
                payload += AddProperty("ServiceCode", inpSourceData.PostageType);
                payload += AddJson("ServiceOptions", MakeServiceOptionsJson(inpSourceData));
                payload += AddProperty("TotalPackages", inpSourceData.PostingTotalPackages);
                payload += AddProperty("TotalWeight", inpSourceData.PostingTotalWeight);
                payload += AddProperty("WeightUnitOfMeasure", inpSourceData.PostingWeightUOM);
                payload += AddProperty("Product", inpSourceData.CustomsProduct);
                payload += AddProperty("DescriptionOfGoods", inpSourceData.CustomsDescriptionOfGoods);
                payload += AddProperty("ReasonForExport", inpSourceData.CustomsReasonForExport);
                payload += AddProperty("Value", inpSourceData.CustomsValue);
                payload += AddProperty("Currency", inpSourceData.CustomsCurrency);
                payload += AddProperty("Incoterms", inpSourceData.CustomsIncoterms);
                payload += AddProperty("LabelFormat", inpSourceData.CustomsLabelFormat);
                payload += AddProperty("SilentPrintProfile", inpSourceData.CustomsSilentPrintProfile);
                payload += AddProperty("ShipmentAction", inpSourceData.CustomsShipmentAction);

                string packagePayload = MakePackagesJson(inpSourceData);
                payload += AddJson("Packages", packagePayload);

                string itemPayload = MakeItemsJson(inpSourceData);
                payload += AddLastJson("Items", itemPayload);
                payload += "}";

                return payload;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Output the data from the service options sub-class as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakeServiceOptionsJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "{";
                payload += AddProperty("PostingLocation", inpSourceData.PostingLocation);
                payload += AddProperty("ServiceLevel", inpSourceData.PostingServiceLevel);
                payload += AddProperty("ServiceFormat", inpSourceData.PostingServiceFormat);
                payload += AddProperty("Safeplace", inpSourceData.CustomerSafeplace);
                payload += AddProperty("SaturdayGuaranteed", inpSourceData.PostingSaturdayGuaranteed);
                payload += AddProperty("ConsequentialLoss", inpSourceData.PostingConsequentialLoss);
                payload += AddProperty("LocalCollect", inpSourceData.PostingLocalCollect);
                payload += AddProperty("TrackingNotifications", inpSourceData.PostingTrackingNotifications);
                payload += AddLastProperty("RecordedSignedFor", inpSourceData.PostingRecordedSignedFor);
                payload += "}";

                return payload;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Output the data from the customs information sub-class as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakeCustomsInformationJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "{";
                payload += AddProperty("PreRegistrationNumber", inpSourceData.CustomsPreRegistrationNumber);
                payload += AddProperty("PreRegistrationType", inpSourceData.CustomsPreRegistrationType);
                payload += AddProperty("ShippingCharges", inpSourceData.CustomsShippingCharges.ToString("N2"));
                payload += AddProperty("OtherCharges", inpSourceData.CustomsOtherCharges.ToString("N2"));
                payload += AddProperty("QuotedLandedCost", inpSourceData.CustomsQuotedLandedCost.ToString("N2"));
                payload += AddProperty("InvoiceNumber", inpSourceData.CustomsInvoiceNumber.ToString());
                payload += AddProperty("InvoiceDate", inpSourceData.CustomsInvoiceDate);
                payload += AddProperty("ExportLicence", inpSourceData.CustomsExportLicence);
                payload += AddLastProperty("AddresseeIdentificationReferenceNumber", inpSourceData.AddresseeIdentificationReferenceNumber.ToString());
                payload += "}";

                return payload;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Output the data from all the packages sub-classes as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakePackagesJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "";

                if (inpSourceData.FindFirstParcel())
                {
                    do
                    {
                        payload += ",{";
                        payload += AddProperty("PackageOccurrence", inpSourceData.ParcelInstance);
                        payload += AddProperty("PackagingId", inpSourceData.ParcelId);
                        payload += AddProperty("Weight", inpSourceData.ParcelWeight);
                        payload += AddProperty("Length", inpSourceData.ParcelLength);
                        payload += AddProperty("Width", inpSourceData.ParcelWidth);
                        payload += AddLastProperty("Height", inpSourceData.ParcelHeight);
                        payload += "}";
                    } while (inpSourceData.FindNextParcel());
                }

                // Add the array markers around the parcels.
                if (payload.Length > 0)
                {
                    // Strip out the leading comma.
                    payload = payload.Substring(1);
                    payload = "[" + payload + "]";
                }
                return payload;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Output the data from all the items sub-classes as a JSON.
        /// </summary>
        /// <param name="inpSourceData">A data object holdinng all the data used to build the JSON.</param>
        /// <returns>String containing the formatted JSON</returns>
        private static string MakeItemsJson(IOrderData inpSourceData)
        {
            try
            {
                string payload = "";

                if (inpSourceData.FindFirstItem())
                {
                    do
                    {
                        payload += ",{";
                        payload += AddProperty("ItemId", inpSourceData.ItemId);
                        payload += AddProperty("Quantity", inpSourceData.ItemQuantity);
                        payload += AddProperty("Description", inpSourceData.ItemDescription);
                        payload += AddProperty("Value", inpSourceData.ItemValue);
                        payload += AddProperty("Weight", inpSourceData.ItemWeight, 1);
                        payload += AddProperty("PackageOccurrence", inpSourceData.ItemParcelInstance);
                        payload += AddProperty("HsCode", inpSourceData.ItemHsCode.ToString());
                        payload += AddProperty("SkuCode", inpSourceData.ItemSkuCode);
                        payload += AddProperty("CountryOfOrigin", inpSourceData.ItemCountryOfOrigin);
                        payload += AddLastProperty("ImageUrl", inpSourceData.ItemImageUrl);
                        payload += "}";
                    } while (inpSourceData.FindNextItem());
                }

                // Add the array markers around the items.
                if (payload.Length > 0)
                {
                    // Strip out the leading comma.
                    payload = payload.Substring(1);
                    payload = "[" + payload + "]";
                }
                return payload;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region InputMethods
        ////public void ReadJson(string inpJSON)
        ////{
        ////    try
        ////    {

        ////    }
        ////    catch
        ////    {
        ////        throw;
        ////    }
        ////}
        #endregion

    }
}
