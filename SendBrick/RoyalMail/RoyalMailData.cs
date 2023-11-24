using System;
using System.Collections.Generic;
using System.Text;
using CM.SendBrick.Library.Core;
using CM.SendBrick.Library.Data;

namespace CM.SendBrick.Library.RoyalMail
{
    /// <summary>
    /// Class storing the data sent to the Post Office API.
    /// </summary>
    public class RoyalMailData : IOrderData, ICloneable
    {
        #region Variables
        // control variables
        private int orderNumber;
        private SystemTypes.SourceSystemType sourceSystem;
        private SystemTypes.PostageSystemType postalSystem;

        // Define the classes that build up the parts of this class.
        private Shipper shipper;    // class
        private Destination destination; // class
        private ShipmentInformation shipmentInformation; // class
        private CustomsInformation customsInformation; //class

        private List<Packages> PackagesList = new List<Packages>();
        private List<Items> ItemsList = new List<Items>();
        private Int32 currentPackage;
        private Int32 currentItem;
        #endregion

        #region Constructors
        /// <summary>
        /// Basic constructor, does nothing further.
        /// </summary>
        public RoyalMailData()
        {
            // Basic constructor.
        }

        /// <summary>
        /// Constructs a partial PostOfficeData object from a load of variables. Items and Packages need adding separately.
        /// </summary>
        /// <param name="inpShipperAddressId">System ID for the shipper's address</param>
        /// <param name="inpShipperReference">Shipper's refernce code, line 1</param>
        /// <param name="inpShipperReference2">Shipper's refernce code, line 2</param>
        /// <param name="inpShipperDepartment">Department code in the shipper's organisation</param>
        /// <param name="inpShipperCompanyName">Name of the shipping company</param>
        /// <param name="inpShipperContactName">Name of the shipper's contact</param>
        /// <param name="inpShipperAddressLine1">Address shipping from, line 1</param>
        /// <param name="inpShipperAddressLine2">Address shipping from, line 2</param>
        /// <param name="inpShipperAddressLine3">Address shipping from, line 3</param>
        /// <param name="inpShipperTown">Address shipping from, town</param>
        /// <param name="inpShipperCounty">Address shipping from, county</param>
        /// <param name="inpShipperCountryCode">Address shipping from, country</param>
        /// <param name="inpShipperPostcode">Address shipping from, postcode</param>
        /// <param name="inpShipperPhoneNumber">Shipping company's phone number</param>
        /// <param name="inpShipperEmailAddress">Shipping company's e-mail address</param>
        /// <param name="inpShipperVatNumber">Shipping company's VAT number</param>
        /// <param name="inpDesitinationAddressId"></param>
        /// <param name="inpDesitinationCompanyName"></param>
        /// <param name="inpDesitinationContactName"></param>
        /// <param name="inpDesitinationAddressLine1"></param>
        /// <param name="inpDesitinationAddressLine2"></param>
        /// <param name="inpDesitinationAddressLine3"></param>
        /// <param name="inpDesitinationTown"></param>
        /// <param name="inpDesitinationCounty"></param>
        /// <param name="inpDesitinationCountryCode"></param>
        /// <param name="inpDesitinationPostcode"></param>
        /// <param name="inpDesitinationPhoneNumber"></param>
        /// <param name="inpDesitinationEmailAddress"></param>
        /// <param name="inpDesitinationVatNumber"></param>
        /// <param name="inpShipInfShipmentDate"></param>
        /// <param name="inpShipInfServiceCode"></param>
        /// <param name="inpShipInfTotalPackages"></param>
        /// <param name="inpShipInfTotalWeight"></param>
        /// <param name="inpShipInfWeightUnitOfMeasure"></param>
        /// <param name="inpShipInfProduct"></param>
        /// <param name="inpShipInfDescriptionOfGoods"></param>
        /// <param name="inpShipInfReasonForExport"></param>
        /// <param name="inpShipInfValueData"></param>
        /// <param name="inpShipInfCurrency"></param>
        /// <param name="inpShipInfIncoterms"></param>
        /// <param name="inpShipInfLabelFormat"></param>
        /// <param name="inpShipInfSilentPrintProfile"></param>
        /// <param name="inpShipInfShipmentAction"></param>
        /// <param name="inpServOptPostingLocation"></param>
        /// <param name="inpServOptServiceLevel"></param>
        /// <param name="inpServOptServiceFormat"></param>
        /// <param name="inpServOptSafeplace"></param>
        /// <param name="inpServOptSaturdayGuaranteed"></param>
        /// <param name="inpServOptConsequentialLoss"></param>
        /// <param name="inpServOptLocalCollect"></param>
        /// <param name="inpServOptTrackingNotifications"></param>
        /// <param name="inpServOptRecordedSignedFor"></param>
        /// <param name="inpCustomsInfoPreRegistrationNumber"></param>
        /// <param name="inpCustomsInfoPreRegistrationType"></param>
        /// <param name="inpCustomsInfoShippingCharges"></param>
        /// <param name="inpCustomsInfoOtherCharges"></param>
        /// <param name="inpCustomsInfoQuotedLandedCost"></param>
        /// <param name="inpCustomsInfoInvoiceNumber"></param>
        /// <param name="inpCustomsInfoInvoiceDate"></param>
        /// <param name="inpCustomsInfoExportLicence"></param>
        /// <param name="inpCustomsInfoAddresseeIdentificationReferenceNumber"></param>
        public RoyalMailData(string inpShipperAddressId,
            string inpShipperReference,
            string inpShipperReference2,
            int inpShipperDepartment,
            string inpShipperCompanyName,
            string inpShipperContactName,
            string inpShipperAddressLine1,
            string inpShipperAddressLine2,
            string inpShipperAddressLine3,
            string inpShipperTown,
            string inpShipperCounty,
            string inpShipperCountryCode,
            string inpShipperPostcode,
            string inpShipperPhoneNumber,
            string inpShipperEmailAddress,
            string inpShipperVatNumber,
            string inpDesitinationAddressId,
            string inpDesitinationCompanyName,
            string inpDesitinationContactName,
            string inpDesitinationAddressLine1,
            string inpDesitinationAddressLine2,
            string inpDesitinationAddressLine3,
            string inpDesitinationTown,
            string inpDesitinationCounty,
            string inpDesitinationCountryCode,
            string inpDesitinationPostcode,
            string inpDesitinationPhoneNumber,
            string inpDesitinationEmailAddress,
            string inpDesitinationVatNumber,
            DateTime inpShipInfShipmentDate,
            string inpShipInfServiceCode,
            string inpShipInfWeightUnitOfMeasure,
            string inpShipInfProduct,
            string inpShipInfDescriptionOfGoods,
            string inpShipInfReasonForExport,
            double inpShipInfValueData,
            string inpShipInfCurrency,
            string inpShipInfIncoterms,
            string inpShipInfLabelFormat,
            string inpShipInfSilentPrintProfile,
            string inpShipInfShipmentAction,
            string inpServOptPostingLocation,
            string inpServOptServiceLevel,
            string inpServOptServiceFormat,
            string inpServOptSafeplace,
            bool inpServOptSaturdayGuaranteed,
            string inpServOptConsequentialLoss,
            bool inpServOptLocalCollect,
            string inpServOptTrackingNotifications,
            bool inpServOptRecordedSignedFor,
            string inpCustomsInfoPreRegistrationNumber,
            string inpCustomsInfoPreRegistrationType,
            double inpCustomsInfoShippingCharges,
            double inpCustomsInfoOtherCharges,
            double inpCustomsInfoQuotedLandedCost,
            Int64 inpCustomsInfoInvoiceNumber,
            DateTime inpCustomsInfoInvoiceDate,
            bool inpCustomsInfoExportLicence,
            Int64 inpCustomsInfoAddresseeIdentificationReferenceNumber
            ) : this()
        {
            try
            {
                AddShipper(inpShipperAddressId,
                            inpShipperReference,
                            inpShipperReference2,
                            inpShipperDepartment,
                            inpShipperCompanyName,
                            inpShipperContactName,
                            inpShipperAddressLine1,
                            inpShipperAddressLine2,
                            inpShipperAddressLine3,
                            inpShipperTown,
                            inpShipperCounty,
                            inpShipperCountryCode,
                            inpShipperPostcode,
                            inpShipperPhoneNumber,
                            inpShipperEmailAddress,
                            inpShipperVatNumber);

                AddDestination(inpDesitinationAddressId,
                            inpDesitinationCompanyName,
                            inpDesitinationContactName,
                            inpDesitinationAddressLine1,
                            inpDesitinationAddressLine2,
                            inpDesitinationAddressLine3,
                            inpDesitinationTown,
                            inpDesitinationCounty,
                            inpDesitinationCountryCode,
                            inpDesitinationPostcode,
                            inpDesitinationPhoneNumber,
                            inpDesitinationEmailAddress,
                            inpDesitinationVatNumber);

                AddShipmentInformation(inpShipInfShipmentDate,
                            inpShipInfServiceCode,
                            inpShipInfWeightUnitOfMeasure,
                            inpShipInfProduct,
                            inpShipInfDescriptionOfGoods,
                            inpShipInfReasonForExport,
                            inpShipInfValueData,
                            inpShipInfCurrency,
                            inpShipInfIncoterms,
                            inpShipInfLabelFormat,
                            inpShipInfSilentPrintProfile,
                            inpShipInfShipmentAction);

                AddServiceOption(inpServOptPostingLocation,
                            inpServOptServiceLevel,
                            inpServOptServiceFormat,
                            inpServOptSafeplace,
                            inpServOptSaturdayGuaranteed,
                            inpServOptConsequentialLoss,
                            inpServOptLocalCollect,
                            inpServOptTrackingNotifications,
                            inpServOptRecordedSignedFor);

                AddCustomsInformation(inpCustomsInfoPreRegistrationNumber,
                            inpCustomsInfoPreRegistrationType,
                            inpCustomsInfoShippingCharges,
                            inpCustomsInfoOtherCharges,
                            inpCustomsInfoQuotedLandedCost,
                            inpCustomsInfoInvoiceNumber,
                            inpCustomsInfoInvoiceDate,
                            inpCustomsInfoExportLicence,
                            inpCustomsInfoAddresseeIdentificationReferenceNumber);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Creates a populated PostOfficeData object from a TransferOrderData object.
        /// </summary>
        /// <param name="inpTransferOrder">TransferOrderData object to build the data from</param>
        public RoyalMailData(IOrderData inpTransferOrder) : this()
        {
            try
            {
                if (inpTransferOrder == null)
                {
                    throw new ArgumentNullException(nameof(inpTransferOrder), "Null object passed to " + nameof(inpTransferOrder));
                }
                else
                {
                    AddShipper(inpTransferOrder.SupplierId,
                                inpTransferOrder.SupplierReference1,
                                   inpTransferOrder.SupplierReference2,
                                   inpTransferOrder.Department,
                                   inpTransferOrder.SupplierBusinessName,
                                   inpTransferOrder.SupplierContactName,
                                   inpTransferOrder.SupplierAddressLine1,
                                   inpTransferOrder.SupplierAddressLine2,
                                   inpTransferOrder.SupplierAddressLine3,
                                   inpTransferOrder.SupplierAddressTown,
                                   inpTransferOrder.SupplierAddressCounty,
                                   inpTransferOrder.SupplierCountryCode,
                                   inpTransferOrder.SupplierAddressPostcode,
                                   inpTransferOrder.SupplierPhoneNumber,
                                   inpTransferOrder.SupplierEmailAddress,
                                   inpTransferOrder.SupplierVatNumber);

                    AddDestination(inpTransferOrder.CustomerId,
                                   inpTransferOrder.CustomerBusinessName,
                                   inpTransferOrder.CustomerContactName,
                                   inpTransferOrder.CustomerAddressLine1,
                                   inpTransferOrder.CustomerAddressLine2,
                                   inpTransferOrder.CustomerAddressLine3,
                                   inpTransferOrder.CustomerAddressTown,
                                   inpTransferOrder.CustomerAddressCounty,
                                   inpTransferOrder.CustomerCountryCode,
                                   inpTransferOrder.CustomerAddressPostcode,
                                   inpTransferOrder.CustomerPhoneNumber,
                                   inpTransferOrder.CustomerEmailAddress,
                                   inpTransferOrder.CustomerVatNumber);

                    AddShipmentInformation(inpTransferOrder.PostingDate,
                                   inpTransferOrder.PostageType,
                                   inpTransferOrder.PostingWeightUOM,
                                   inpTransferOrder.CustomsProduct,
                                   inpTransferOrder.CustomsDescriptionOfGoods,
                                   inpTransferOrder.CustomsReasonForExport,
                                   inpTransferOrder.CustomsValue,
                                   inpTransferOrder.CustomsCurrency,
                                   inpTransferOrder.CustomsIncoterms,
                                   inpTransferOrder.CustomsLabelFormat,
                                   inpTransferOrder.CustomsSilentPrintProfile,
                                   inpTransferOrder.CustomsShipmentAction);

                    AddServiceOption(inpTransferOrder.PostingLocation,
                                   inpTransferOrder.PostingServiceLevel,
                                   inpTransferOrder.PostingServiceFormat,
                                   inpTransferOrder.CustomerSafeplace,
                                   inpTransferOrder.PostingSaturdayGuaranteed,
                                   inpTransferOrder.PostingConsequentialLoss,
                                   inpTransferOrder.PostingLocalCollect,
                                   inpTransferOrder.PostingTrackingNotifications,
                                   inpTransferOrder.PostingRecordedSignedFor);

                    AddCustomsInformation(inpTransferOrder.CustomsPreRegistrationNumber,
                                   inpTransferOrder.CustomsPreRegistrationType,
                                   inpTransferOrder.CustomsShippingCharges,
                                   inpTransferOrder.CustomsOtherCharges,
                                   inpTransferOrder.CustomsQuotedLandedCost,
                                   Convert.ToInt64(inpTransferOrder.CustomsInvoiceNumber),
                                   inpTransferOrder.CustomsInvoiceDate,
                                   inpTransferOrder.CustomsExportLicence,
                                   inpTransferOrder.AddresseeIdentificationReferenceNumber
                                   );

                    if (inpTransferOrder.FindFirstParcel())
                    {
                        do
                        {
                            AddParcel(inpTransferOrder.ParcelInstance,
                                inpTransferOrder.ParcelId,
                                inpTransferOrder.ParcelWeight,
                                inpTransferOrder.ParcelLength,
                                inpTransferOrder.ParcelWidth,
                                inpTransferOrder.ParcelHeight);
                        } while (inpTransferOrder.FindNextParcel());
                    }

                    if (inpTransferOrder.FindFirstItem())
                    {
                        do
                        {
                            AddItem(inpTransferOrder.ItemId,
                                inpTransferOrder.ItemQuantity,
                                inpTransferOrder.ItemParcelInstance,
                                inpTransferOrder.ItemDescription,
                                inpTransferOrder.ItemValue,
                                inpTransferOrder.ItemWeight,
                                inpTransferOrder.ItemHsCode,
                                inpTransferOrder.ItemSkuCode,
                                inpTransferOrder.ItemCountryOfOrigin,
                                inpTransferOrder.ItemImageUrl);
                        } while (inpTransferOrder.FindNextItem());
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Creates a populated PostOfficeData object from a TransferOrderData object.
        /// </summary>
        /// <param name="inpJSON">JSON as a string to unpack.</param>
        public RoyalMailData(String inpJSON)
        {
            // Basic constructor.
        }
        #endregion

        #region ControlProperties
        public int OrderNumber
        {
            get
            {
                return orderNumber;
            }
        }
        public SystemTypes.PostageSystemType PostalSystem
        {
            get
            {
                return postalSystem;
            }
        }
        public SystemTypes.SourceSystemType SourceSystem
        {
            get
            {
                return sourceSystem;
            }
        }
        #endregion

        #region SupplierProperties
        public string SupplierId
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.AddressId;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.AddressId = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierBusinessName
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.CompanyName;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.CompanyName = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierContactName
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.ContactName;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.ContactName = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public int Department
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.ShipperDepartment;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.ShipperDepartment = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierAddressLine1
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.AddressLine1;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.AddressLine1 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierAddressLine2
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.AddressLine2;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.AddressLine2 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierAddressLine3
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.AddressLine3;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.AddressLine3 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierAddressLine4
        {
            get
            {
                try
                {
                    return "";
                }
                catch
                {
                    throw;
                }
            }
            set
            {
            }
        }
        public string SupplierAddressPostcode
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.Postcode;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.Postcode = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierAddressTown
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.Town;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.Town = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierAddressCounty
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.County;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.County = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierCountryCode
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.ShipperCountryCode;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.ShipperCountryCode = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierPhoneNumber
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.PhoneNumber;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.PhoneNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierEmailAddress
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.EmailAddress;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.EmailAddress = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierReference1
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.ShipperReference;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.ShipperReference = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierReference2
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.ShipperReference2;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.ShipperReference2 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string SupplierVatNumber
        {
            get
            {
                try
                {
                    if (shipper != null)
                    {
                        return shipper.VatNumber;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipper data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipper == null)
                    {
                        shipper = new Shipper();
                    }
                    shipper.VatNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion
        #region DestinationProperties
        public string CustomerId
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.AddressId;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.AddressId = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerContactName
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.ContactName;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.ContactName = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerBusinessName
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.CompanyName;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    //if (destination == null)
                    //{
                    //    destination = new Destination();
                    //}
                    //    destination.CompanyName = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerAddressLine1
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.AddressLine1;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.AddressLine1 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerAddressLine2
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.AddressLine2;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.AddressLine2 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerAddressLine3
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.AddressLine3;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.AddressLine3 = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerAddressLine4
        {
            get
            {
                try
                {
                    return "";
                }
                catch
                {
                    throw;
                }
            }
            set { }
        }
        public string CustomerAddressTown
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.Town;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.Town = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerAddressCounty
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.County;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.County = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerAddressPostcode
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.Postcode;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.Postcode = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerCountryCode
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.CountryCode;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.CountryCode = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerPhoneNumber
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.PhoneNumber;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.PhoneNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerEmailAddress
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.EmailAddress;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.EmailAddress = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerVatNumber
        {
            get
            {
                try
                {
                    if (destination != null)
                    {
                        return destination.VatNumber;
                    }
                    else
                    {
                        throw new NullReferenceException("No destination data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (destination == null)
                    {
                        destination = new Destination();
                    }
                    destination.VatNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion
        #region CustomsProperties
        public bool CustomsExportLicence
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.ExportLicence;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.ExportLicence = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsInvoiceNumber
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.InvoiceNumber.ToString();
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.InvoiceNumber = Convert.ToInt32(value);
                }
                catch
                {
                    throw;
                }
            }
        }
        public double CustomsOtherCharges
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.OtherCharges;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.OtherCharges = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsPreRegistrationNumber
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.PreRegistrationNumber;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.PreRegistrationNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsPreRegistrationType
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.PreRegistrationType;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.PreRegistrationType = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public double CustomsQuotedLandedCost
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.QuotedLandedCost;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.QuotedLandedCost = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public double CustomsShippingCharges
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.ShippingCharges;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.ShippingCharges = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public Int64 AddresseeIdentificationReferenceNumber
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.AddresseeIdentificationReferenceNumber;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.AddresseeIdentificationReferenceNumber = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion
        #region ShipmentInformationProperties
        public string CustomsCurrency
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.Currency;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.Currency = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsDescriptionOfGoods
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.DescriptionOfGoods;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.DescriptionOfGoods = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsIncoterms
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.Incoterms;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.Incoterms = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public DateTime CustomsInvoiceDate
        {
            get
            {
                try
                {
                    if (customsInformation != null)
                    {
                        return customsInformation.InvoiceDate;
                    }
                    else
                    {
                        throw new NullReferenceException("No customs information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (customsInformation == null)
                    {
                        customsInformation = new CustomsInformation();
                    }
                    customsInformation.InvoiceDate = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsLabelFormat
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.LabelFormat;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.LabelFormat = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsProduct
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.Product;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.Product = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsReasonForExport
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.ReasonForExport;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.ReasonForExport = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsShipmentAction
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.ShipmentAction;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.ShipmentAction = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomsSilentPrintProfile
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.SilentPrintProfile;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.SilentPrintProfile = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public double CustomsValue
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.Value;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.Value = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public DateTime PostingDate
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.ShipmentDate;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.ShipmentDate = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public int PostingTotalPackages
        {
            get
            {
                try
                {
                    return PackagesList.Count;
                }
                catch
                {
                    throw;
                }
            }
        }
        public double PostingTotalWeight
        {
            get
            {
                try
                {
                    double totalWeight = 0;
                    foreach (Packages pack in PackagesList)
                    {
                        totalWeight += pack.Weight;
                    }
                    return totalWeight;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string PostingWeightUOM
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.WeightUnitOfMeasure;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.WeightUnitOfMeasure = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion
        #region ServiceOptionProperties
        public string PostageType
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.ServiceCode;
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    shipmentInformation.ServiceCode = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string PostingServiceFormat
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        if (shipmentInformation.serviceOptions != null)
                        {
                            return shipmentInformation.serviceOptions.ServiceFormat;
                        }
                        else
                        {
                            throw new NullReferenceException("No service options data available");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.ServiceFormat = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string PostingServiceLevel
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        if (shipmentInformation.serviceOptions != null)
                        {
                            return shipmentInformation.serviceOptions.ServiceLevel;
                        }
                        else
                        {
                            throw new NullReferenceException("No service options data available");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.ServiceLevel = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string CustomerSafeplace
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        if (shipmentInformation.serviceOptions != null)
                        {
                            return shipmentInformation.serviceOptions.Safeplace;
                        }
                        else
                        {
                            throw new NullReferenceException("No service options data available");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("No shipment information data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.Safeplace = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string PostingConsequentialLoss
        {
            get
            {
                try
                {
                    if (shipmentInformation.serviceOptions != null)
                    {
                        return shipmentInformation.serviceOptions.ConsequentialLoss;
                    }
                    else
                    {
                        throw new NullReferenceException("No service options data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.ConsequentialLoss = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public bool PostingLocalCollect
        {
            get
            {
                try
                {
                    if (shipmentInformation.serviceOptions != null)
                    {
                        return shipmentInformation.serviceOptions.LocalCollect;
                    }
                    else
                    {
                        throw new NullReferenceException("No service options data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.LocalCollect = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string PostingLocation
        {
            get
            {
                try
                {
                    if (shipmentInformation.serviceOptions != null)
                    {
                        return shipmentInformation.serviceOptions.PostingLocation;
                    }
                    else
                    {
                        throw new NullReferenceException("No service option data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.PostingLocation = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public bool PostingRecordedSignedFor
        {
            get
            {
                try
                {
                    if (shipmentInformation != null)
                    {
                        return shipmentInformation.serviceOptions.RecordedSignedFor;
                    }
                    else
                    {
                        throw new NullReferenceException("No service options data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.RecordedSignedFor = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public bool PostingSaturdayGuaranteed
        {
            get
            {
                try
                {
                    if (shipmentInformation.serviceOptions != null)
                    {
                        return shipmentInformation.serviceOptions.SaturdayGuaranteed;
                    }
                    else
                    {
                        throw new NullReferenceException("No service options data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.SaturdayGuaranteed = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public string PostingTrackingNotifications
        {
            get
            {
                try
                {
                    if (shipmentInformation.serviceOptions != null)
                    {
                        return shipmentInformation.serviceOptions.TrackingNotifications;
                    }
                    else
                    {
                        throw new NullReferenceException("No service options data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (shipmentInformation == null)
                    {
                        shipmentInformation = new ShipmentInformation();
                    }
                    if (shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    shipmentInformation.serviceOptions.TrackingNotifications = value;
                }
                catch
                {
                    throw;
                }
            }
        }
        public int TotalItemCount
        {
            get
            {
                try
                {
                    if (ItemsList != null)
                    {
                        return ItemsList.Count;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data available");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion
        #region ItemProperties
        public string ItemId
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].ItemId;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].ItemId = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public string ItemDescription
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].Description;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {

                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].Description = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public int ItemParcelInstance
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].PackageOccurrence;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].PackageOccurrence = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public int ItemQuantity
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].Quantity;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {

                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].Quantity = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public double ItemValue
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].Value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {

                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].Value = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public double ItemWeight
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].Weight;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].Weight = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public string ItemCountryOfOrigin
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].CountryOfOrigin;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {

                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].CountryOfOrigin = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public string ItemHsCode
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].HsCode;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {

                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].HsCode = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public string ItemSkuCode
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].SkuCode;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {

                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].SkuCode = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public string ItemImageUrl
        {
            get
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        return ItemsList[currentItem].ImageUrl;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (ItemsList[currentItem] != null)
                    {
                        ItemsList[currentItem].ImageUrl = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No item data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion
        #region ParcelProperties
        public string ParcelId
        {
            get
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        return PackagesList[currentPackage].PackagingId;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        PackagesList[currentPackage].PackagingId = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public int ParcelInstance
        {
            get
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        return PackagesList[currentPackage].PackageOccurrence;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        PackagesList[currentPackage].PackageOccurrence = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public double ParcelWeight
        {
            get
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        return PackagesList[currentPackage].Weight;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        PackagesList[currentPackage].Weight = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public int ParcelHeight
        {
            get
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        return PackagesList[currentPackage].Height;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        PackagesList[currentPackage].Height = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public int ParcelLength
        {
            get
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        return PackagesList[currentPackage].Length;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        PackagesList[currentPackage].Length = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        public int ParcelWidth
        {
            get
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        return PackagesList[currentPackage].Width;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
            set
            {
                try
                {
                    if (PackagesList[currentPackage] != null)
                    {
                        PackagesList[currentPackage].Width = value;
                    }
                    else
                    {
                        throw new NullReferenceException("No package data selected");
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        #endregion

        #region ParcelMaintenanceMethods
        /// <summary>
        /// Create a blank Package sub-class.
        /// </summary>
        public void AddParcel()
        {
            try
            {
                PackagesList.Add(new Packages());
                currentPackage = this.PackagesList.Count - 1;
            }
            catch
            {
                throw;
            }
        }
        public void AddParcel(int inpParcelInstance,
                      string inpParcelId)
        {
            try
            {
                AddParcel();
                PackagesList[currentPackage].PackageOccurrence = inpParcelInstance;
                PackagesList[currentPackage].PackagingId = inpParcelId;
            }
            catch
            {
                throw;
            }
        }
        public void AddParcel(int inpParcelInstance,
                              string inpParcelId,
                              double inpParcelWeight)
        {
            try
            {
                AddParcel(inpParcelInstance, inpParcelId);
                PackagesList[currentPackage].Weight = inpParcelWeight;
            }
            catch
            {
                throw;
            }
        }
        public void AddParcel(int inpParcelInstance,
                              string inpParcelId,
                              double inpParcelWeight,
                              int inpParcelLength,
                              int inpParcelWidth,
                              int inpParcelHeight)
        {
            try
            {
                this.PackagesList.Add(new Packages(inpParcelInstance,
                                                   inpParcelId,
                                                   inpParcelWeight,
                                                   inpParcelLength,
                                                   inpParcelWidth,
                                                   inpParcelHeight));
                this.currentPackage = this.PackagesList.Count - 1;
            }
            catch
            {
                throw;
            }
        }
        public bool FindFirstParcel()
        {
            try
            {
                return SubclassNavigation.FindFirstRecord<Packages>(ref currentPackage, ref PackagesList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindLastParcel()
        {
            try
            {
                return SubclassNavigation.FindLastRecord<Packages>(ref currentPackage, ref PackagesList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindNextParcel()
        {
            try
            {
                return SubclassNavigation.FindNextRecord<Packages>(ref currentPackage, ref PackagesList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindPrevParcel()
        {
            try
            {
                return SubclassNavigation.FindPrevRecord<Packages>(ref currentPackage, ref PackagesList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindSpecificParcel(int inpParcelIndex)
        {
            try
            {
                return SubclassNavigation.FindSpecificRecord<Packages>(inpParcelIndex, ref currentPackage, ref PackagesList);
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region ItemMaintenanceMethods
        public void AddItem()
        {
            try
            {
                this.ItemsList.Add(new Items());
                this.currentItem = this.ItemsList.Count - 1;
            }
            catch
            {
                throw;
            }
        }
        public void AddItem(string inpPurchaseId,
                            int inpQuantity)
        {
            try
            {
                AddItem();
                ItemsList[currentItem].ItemId = inpPurchaseId;
                ItemsList[currentItem].Quantity = inpQuantity;
            }
            catch
            {
                throw;
            }
        }
        public void AddItem(string inpItemId,
                            int inpItemQuantity,
                            int inpParcelInstance)
        {
            try
            {
                AddItem(inpItemId, inpItemQuantity);
                ItemsList[currentItem].PackageOccurrence = inpParcelInstance;
            }
            catch
            {
                throw;
            }
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight)

        {
            try
            {
                AddItem(inpItemId, inpItemQuantity, inpParcelInstance);
                ItemsList[currentItem].Description = inpItemDescription;
                ItemsList[currentItem].Value = inpItemValue;
                ItemsList[currentItem].Weight = inpItemWeight;
            }
            catch
            {
                throw;
            }
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode)
        {
            try
            {
                AddItem(inpItemId, inpItemQuantity, inpParcelInstance, inpItemDescription, inpItemValue, inpItemWeight);
                ItemsList[currentItem].HsCode = inpItemHsCode;
                ItemsList[currentItem].SkuCode = inpItemSkuCode;
            }
            catch
            {
                throw;
            }
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode,
                     string inpItemCountryOfOrigin)
        {
            try
            {
                AddItem(inpItemId,
                             inpItemQuantity,
                             inpParcelInstance,
                             inpItemDescription,
                             inpItemValue,
                             inpItemWeight,
                             inpItemHsCode,
                             inpItemSkuCode);
                ItemsList[currentItem].CountryOfOrigin = inpItemCountryOfOrigin;
            }
            catch
            {
                throw;
            }
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode,
                     string inpItemCountryOfOrigin,
                     string inpItemImageUrl)
        {
            try
            {
                this.ItemsList.Add(new Items(inpItemId,
                     inpItemQuantity,
                     inpItemDescription,
                     inpItemValue,
                     inpItemWeight,
                     inpParcelInstance,
                     inpItemHsCode,
                     inpItemSkuCode,
                     inpItemCountryOfOrigin,
                     inpItemImageUrl));
                this.currentItem = this.ItemsList.Count - 1;
            }
            catch
            {
                throw;
            }
        }
        public bool FindFirstItem()
        {
            try
            {
                return SubclassNavigation.FindFirstRecord<Items>(ref currentItem, ref ItemsList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindLastItem()
        {
            try
            {
                return SubclassNavigation.FindLastRecord<Items>(ref currentItem, ref ItemsList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindNextItem()
        {
            try
            {
                return SubclassNavigation.FindNextRecord<Items>(ref currentItem, ref ItemsList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindPrevItem()
        {
            try
            {
                return SubclassNavigation.FindPrevRecord<Items>(ref currentItem, ref ItemsList);
            }
            catch
            {
                throw;
            }
        }
        public bool FindSpecificItem(int inpItemIndex)
        {
            try
            {
                return SubclassNavigation.FindSpecificRecord<Items>(inpItemIndex, ref currentItem, ref ItemsList);
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region ShipperMaintenaceMethods
        /// <summary>
        /// Add a blank shipper section to the class.
        /// </summary>
        public void AddShipper()
        {
            //Check uniqueness
            if (this.shipper == null)
            {
                try
                {
                    this.shipper = new Shipper();
                }
                catch (Exception e)
                {
                    throw new Exception($"An error has occured in '{nameof(AddShipper)}': " + e.Message, e);
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.shipper), $"'{nameof(this.shipper)}' already exist. Cannot add again.");
            }
        }
        /// <summary>
        /// Add a shipper section to the class and populatae the values.
        /// </summary>
        /// <param name="inpAddressId"></param>
        /// <param name="inpShipperReference"></param>
        /// <param name="inpShipperReference2"></param>
        /// <param name="inpShipperDepartment"></param>
        /// <param name="inpCompanyName"></param>
        /// <param name="inpContactName"></param>
        /// <param name="inpAddressLine1"></param>
        /// <param name="inpAddressLine2"></param>
        /// <param name="inpAddressLine3"></param>
        /// <param name="inpTown"></param>
        /// <param name="inpCounty"></param>
        /// <param name="inpCountryCode"></param>
        /// <param name="inpPostcode"></param>
        /// <param name="inpPhoneNumber"></param>
        /// <param name="inpEmailAddress"></param>
        /// <param name="inpVatNumber"></param>
        public void AddShipper(string inpAddressId,
            string inpShipperReference,
            string inpShipperReference2,
            int inpShipperDepartment,
            string inpCompanyName,
            string inpContactName,
            string inpAddressLine1,
            string inpAddressLine2,
            string inpAddressLine3,
            string inpTown,
            string inpCounty,
            string inpCountryCode,
            string inpPostcode,
            string inpPhoneNumber,
            string inpEmailAddress,
            string inpVatNumber)
        {
            //Check uniqueness
            if (this.shipper == null)
            {
                try
                {
                    this.shipper = new Shipper(inpAddressId,
                                    inpShipperReference,
                                    inpShipperReference2,
                                    inpShipperDepartment,
                                    inpCompanyName,
                                    inpContactName,
                                    inpAddressLine1,
                                    inpAddressLine2,
                                    inpAddressLine3,
                                    inpTown,
                                    inpCounty,
                                    inpCountryCode,
                                    inpPostcode,
                                    inpPhoneNumber,
                                    inpEmailAddress,
                                    inpVatNumber);
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.shipper), $"'{nameof(this.shipper)}' already exist. Cannot add again.");
            }
        }
        #endregion
        #region DesitinationMaintenaceMethods
        /// <summary>
        /// Add a blank Destination class to the order.
        /// </summary>
        public void AddDestination()
        {
            //Check uniqueness
            if (this.destination == null)
            {
                try
                {
                    this.destination = new Destination();
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.destination), $"'{nameof(this.destination)}' already exist. Cannot add again.");
            }
        }
        /// <summary>
        /// Add a Destination class and populate it's values.
        /// </summary>
        /// <param name="inpAddressId"></param>
        /// <param name="inpCompanyName"></param>
        /// <param name="inpContactName"></param>
        /// <param name="inpAddressLine1"></param>
        /// <param name="inpAddressLine2"></param>
        /// <param name="inpAddressLine3"></param>
        /// <param name="inpTown"></param>
        /// <param name="inpCounty"></param>
        /// <param name="inpCountryCode"></param>
        /// <param name="inpPostcode"></param>
        /// <param name="inpPhoneNumber"></param>
        /// <param name="inpEmailAddress"></param>
        /// <param name="inpVatNumber"></param>
        public void AddDestination(string inpAddressId,
            string inpCompanyName,
            string inpContactName,
            string inpAddressLine1,
            string inpAddressLine2,
            string inpAddressLine3,
            string inpTown,
            string inpCounty,
            string inpCountryCode,
            string inpPostcode,
            string inpPhoneNumber,
            string inpEmailAddress,
            string inpVatNumber)
        {
            //Check uniqueness
            if (this.destination == null)
            {
                try
                {
                    this.destination = new Destination(inpAddressId,
                        inpCompanyName,
                        inpContactName,
                        inpAddressLine1,
                        inpAddressLine2,
                        inpAddressLine3,
                        inpTown,
                        inpCounty,
                        inpCountryCode,
                        inpPostcode,
                        inpPhoneNumber,
                        inpEmailAddress,
                        inpVatNumber);
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.destination), $"'{nameof(this.destination)}' already exist. Cannot add again.");
            }
        }
        #endregion
        #region ShipmentInformationMaintenanceMethods
        /// <summary>
        /// Add a blank Shipment Information class to the order.
        /// </summary>
        public void AddShipmentInformation()
        {
            //Check uniqueness
            if (this.shipmentInformation == null)
            {
                try
                {
                    this.shipmentInformation = new ShipmentInformation();
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.shipmentInformation), $"'{nameof(this.shipmentInformation)}' already exist. Cannot add again.");
            }
        }
        /// <summary>
        /// Add a Shipment Information class and populate it.
        /// </summary>
        /// <param name="shipmentDate"></param>
        /// <param name="serviceCode"></param>
        // /// <param name="totalPackages"></param>
        // /// <param name="totalWeight"></param>
        /// <param name="weightUnitOfMeasure"></param>
        /// <param name="product"></param>
        /// <param name="descriptionOfGoods"></param>
        /// <param name="reasonForExport"></param>
        /// <param name="valueData"></param>
        /// <param name="currency"></param>
        /// <param name="incoterms"></param>
        /// <param name="labelFormat"></param>
        /// <param name="silentPrintProfile"></param>
        /// <param name="shipmentAction"></param>
        public void AddShipmentInformation(DateTime shipmentDate,
            string serviceCode,
            //int totalPackages,
            //double totalWeight,
            string weightUnitOfMeasure,
            string product,
            string descriptionOfGoods,
            string reasonForExport,
            double valueData,
            string currency,
            string incoterms,
            string labelFormat,
            string silentPrintProfile,
            string shipmentAction)
        {
            //Check uniqueness
            if (this.shipmentInformation == null)
            {
                try
                {
                    this.shipmentInformation = new ShipmentInformation(shipmentDate,
                        serviceCode,
                        //totalPackages,
                        //totalWeight,
                        weightUnitOfMeasure,
                        product,
                        descriptionOfGoods,
                        reasonForExport,
                        valueData,
                        currency,
                        incoterms,
                        labelFormat,
                        silentPrintProfile,
                        shipmentAction);
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.shipmentInformation), $"'{nameof(this.shipmentInformation)}' already exist. Cannot add again.");
            }
        }
        #endregion
        #region ServiceOptionMaintenanceMethods
        /// <summary>
        /// Add a blank Service Options class to the order.
        /// </summary>
        public void AddServiceOption()
        {
            try
            {
                if (this.shipmentInformation == null)
                {
                    AddShipmentInformation();
                }
                if (this.shipmentInformation != null)
                {
                    if (this.shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions();
                    }
                    else
                    {
                        throw new DuplicateWaitObjectException(nameof(this.shipmentInformation.serviceOptions), $"'{nameof(this.shipmentInformation.serviceOptions)}' already exist. Cannot add again.");
                    }
                }
                else
                {
                    throw new MissingMemberException(nameof(this.shipmentInformation), $"'{nameof(this.shipmentInformation)}' failed to create.");
                }
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// Add a Service Options class and populate it.
        /// </summary>
        /// <param name="postingLocation"></param>
        /// <param name="serviceLevel"></param>
        /// <param name="serviceFormat"></param>
        /// <param name="safeplace"></param>
        /// <param name="saturdayGuaranteed"></param>
        /// <param name="consequentialLoss"></param>
        /// <param name="localCollect"></param>
        /// <param name="trackingNotifications"></param>
        /// <param name="recordedSignedFor"></param>
        public void AddServiceOption(string postingLocation,
             string serviceLevel,
             string serviceFormat,
             string safeplace,
             bool saturdayGuaranteed,
             string consequentialLoss,
             bool localCollect,
             string trackingNotifications,
             bool recordedSignedFor)
        {
            try
            {
                if (this.shipmentInformation == null)
                {
                    AddShipmentInformation();
                }
                if (this.shipmentInformation != null)
                {
                    if (this.shipmentInformation.serviceOptions == null)
                    {
                        shipmentInformation.serviceOptions = new ServiceOptions(postingLocation,
                                serviceLevel,
                                serviceFormat,
                                safeplace,
                                saturdayGuaranteed,
                                consequentialLoss,
                                localCollect,
                                trackingNotifications,
                                recordedSignedFor);
                    }
                    else
                    {
                        throw new DuplicateWaitObjectException(nameof(this.shipmentInformation.serviceOptions), $"'{nameof(this.shipmentInformation.serviceOptions)}' already exist. Cannot add again.");
                    }
                }
                else
                {
                    throw new MissingMemberException(nameof(this.shipmentInformation), $"'{nameof(this.shipmentInformation)}' failed to create.");
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
        #region CustomsInformationMaintenaceMethods
        /// <summary>
        /// Add a blank Customs Information class to the order.
        /// </summary>
        public void AddCustomsInformation()
        {
            //Check uniqueness
            if (this.customsInformation == null)
            {
                try
                {
                    this.customsInformation = new CustomsInformation();
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.customsInformation), $"'{nameof(this.customsInformation)}' already exist. Cannot add again.");
            }
        }
        /// <summary>
        /// Add a Customs Information class to the order and populate it.
        /// </summary>
        /// <param name="preRegistrationNumber"></param>
        /// <param name="preRegistrationType"></param>
        /// <param name="shippingCharges"></param>
        /// <param name="otherCharges"></param>
        /// <param name="quotedLandedCost"></param>
        /// <param name="invoiceNumber"></param>
        /// <param name="invoiceDate"></param>
        /// <param name="exportLicence"></param>
        /// <param name="addresseeIdentificationReferenceNumber"></param>
        public void AddCustomsInformation(string preRegistrationNumber,
            string preRegistrationType,
            double shippingCharges,
            double otherCharges,
            double quotedLandedCost,
            Int64 invoiceNumber,
            DateTime invoiceDate,
            bool exportLicence,
            Int64 addresseeIdentificationReferenceNumber)
        {
            //Check uniqueness
            if (this.customsInformation == null)
            {
                try
                {
                    this.customsInformation = new CustomsInformation(preRegistrationNumber,
                        preRegistrationType,
                        shippingCharges,
                        otherCharges,
                        quotedLandedCost,
                        invoiceNumber,
                        invoiceDate,
                        exportLicence,
                        addresseeIdentificationReferenceNumber);
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                throw new DuplicateWaitObjectException(nameof(this.customsInformation), $"'{nameof(this.customsInformation)}' already exist. Cannot add again.");
            }
        }
        #endregion

        #region CopyingMethods
        public object Clone()
        {
            try
            {
                RoyalMailData clonePostOfficeData = new RoyalMailData();
                if (this.shipper != null)
                {
                    clonePostOfficeData.AddShipper(
                        this.shipper.AddressId,
                        this.shipper.ShipperReference,
                        this.shipper.ShipperReference2,
                        this.shipper.ShipperDepartment,
                        this.shipper.CompanyName,
                        this.shipper.ContactName,
                        this.shipper.AddressLine1,
                        this.shipper.AddressLine2,
                        this.shipper.AddressLine3,
                        this.shipper.Town,
                        this.shipper.County,
                        this.shipper.ShipperCountryCode,
                        this.shipper.Postcode,
                        this.shipper.PhoneNumber,
                        this.shipper.EmailAddress,
                        this.shipper.VatNumber);
                }
                if (this.destination != null)
                {
                    clonePostOfficeData.AddDestination(
                        this.destination.AddressId,
                        this.destination.CompanyName,
                        this.destination.ContactName,
                        this.destination.AddressLine1,
                        this.destination.AddressLine2,
                        this.destination.AddressLine3,
                        this.destination.Town,
                        this.destination.County,
                        this.destination.CountryCode,
                        this.destination.Postcode,
                        this.destination.PhoneNumber,
                        this.destination.EmailAddress,
                        this.destination.VatNumber);
                }
                if (this.shipmentInformation != null)
                {
                    clonePostOfficeData.AddShipmentInformation(
                        this.shipmentInformation.ShipmentDate,
                        this.shipmentInformation.ServiceCode,
                        // this.shipmentInformation.TotalPackages,
                        // this.shipmentInformation.TotalWeight,
                        this.shipmentInformation.WeightUnitOfMeasure,
                        this.shipmentInformation.Product,
                        this.shipmentInformation.DescriptionOfGoods,
                        this.shipmentInformation.ReasonForExport,
                        this.shipmentInformation.Value,
                        this.shipmentInformation.Currency,
                        this.shipmentInformation.Incoterms,
                        this.shipmentInformation.LabelFormat,
                        this.shipmentInformation.SilentPrintProfile,
                        this.shipmentInformation.ShipmentAction);
                }
                if (this.shipmentInformation.serviceOptions != null)
                {
                    clonePostOfficeData.AddServiceOption(
                            this.shipmentInformation.serviceOptions.PostingLocation,
                            this.shipmentInformation.serviceOptions.ServiceLevel,
                            this.shipmentInformation.serviceOptions.ServiceFormat,
                            this.shipmentInformation.serviceOptions.Safeplace,
                            this.shipmentInformation.serviceOptions.SaturdayGuaranteed,
                            this.shipmentInformation.serviceOptions.ConsequentialLoss,
                            this.shipmentInformation.serviceOptions.LocalCollect,
                            this.shipmentInformation.serviceOptions.TrackingNotifications,
                            this.shipmentInformation.serviceOptions.RecordedSignedFor);
                }
                if (this.PackagesList != null)
                {
                    if (this.PackagesList.Count > 0)
                    {
                        foreach (Packages packageEntry in this.PackagesList)
                        {
                            clonePostOfficeData.AddParcel(
                                packageEntry.PackageOccurrence,
                                packageEntry.PackagingId,
                                packageEntry.Weight,
                                packageEntry.Length,
                                packageEntry.Width,
                                packageEntry.Height);
                        }
                    }
                }
                if (this.ItemsList != null)
                {
                    if (this.ItemsList.Count > 0)
                    {
                        foreach (Items itemEntry in this.ItemsList)
                        {
                            clonePostOfficeData.AddItem(
                                itemEntry.ItemId,
                                itemEntry.Quantity,
                                itemEntry.PackageOccurrence,
                                itemEntry.Description,
                                itemEntry.Value,
                                itemEntry.Weight,
                                itemEntry.HsCode,
                                itemEntry.SkuCode,
                                itemEntry.CountryOfOrigin,
                                itemEntry.ImageUrl);
                        }
                    }
                }
                if (this.customsInformation != null)
                {
                    clonePostOfficeData.AddCustomsInformation(
                        this.customsInformation.PreRegistrationNumber,
                        this.customsInformation.PreRegistrationType,
                        this.customsInformation.ShippingCharges,
                        this.customsInformation.OtherCharges,
                        this.customsInformation.QuotedLandedCost,
                        this.customsInformation.InvoiceNumber,
                        this.customsInformation.InvoiceDate,
                        this.customsInformation.ExportLicence,
                        this.customsInformation.AddresseeIdentificationReferenceNumber);
                }
                return clonePostOfficeData;
            }
            catch
            {
                throw;
            }
        }
        #endregion

        public class Shipper
        {
            #region Fields
            private string addressId;
            private string shipperReference;
            private string shipperReference2;
            private int shipperDepartment;
            private string companyName;
            private string contactName;
            private string addressLine1;
            private string addressLine2;
            private string addressLine3;
            private string town;
            private string county;
            private string countryCode;
            private string postcode;
            private string phoneNumber;
            private string emailAddress;
            private string vatNumber;
            #endregion

            #region Properties
            public string AddressId
            {
                get
                {
                    return this.addressId;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentNullException($"'{nameof(this.addressId)}' cannot be null.", "inpAddressId");
                    }
                    else
                    {
                        this.addressId = value;
                    }
                }
            }
            public string ShipperReference
            {
                get
                {
                    return this.shipperReference;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.shipperReference)}' cannot be null.", nameof(this.shipperReference));
                    }
                    else
                    {
                        this.shipperReference = value;
                    }
                }
            }
            public string ShipperReference2
            {
                get
                {
                    return this.shipperReference2;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.shipperReference2)}' cannot be null.", nameof(this.shipperReference2));
                    }
                    else
                    {
                        this.shipperReference2 = value;
                    }
                }
            }
            public int ShipperDepartment
            {
                get
                {
                    return this.shipperDepartment;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.shipperDepartment)}' cannot be zero.", nameof(this.shipperDepartment));
                    }
                    else
                    {
                        this.shipperDepartment = value;
                    }
                }
            }
            public string CompanyName
            {
                get
                {
                    return this.companyName;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.companyName)}' cannot be null.", nameof(this.companyName));
                    }
                    else
                    {
                        this.companyName = value;
                    }
                }
            }
            public string ContactName
            {
                get
                {
                    return this.contactName;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.contactName)}' cannot be null.", nameof(this.contactName));
                    }
                    {
                        this.contactName = value;
                    }
                }
            }
            public string AddressLine1
            {
                get
                {
                    return this.addressLine1;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.addressLine1)}' cannot be null.", nameof(this.addressLine1));
                    }
                    else
                    {
                        this.addressLine1 = value;
                    }
                }
            }
            public string AddressLine2
            {
                get
                {
                    return this.addressLine2;
                }
                set
                {
                    this.addressLine2 = value;
                }
            }
            public string AddressLine3
            {
                get
                {
                    return this.addressLine3;
                }
                set
                {
                    this.addressLine3 = value;
                }
            }
            public string Town
            {
                get
                {
                    return this.town;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.town)}' cannot be null.", nameof(this.town));
                    }
                    else
                    {
                        this.town = value;
                    }
                }
            }
            public string County
            {
                get
                {
                    return this.county;
                }
                set
                {
                    this.county = value;
                }
            }
            public string ShipperCountryCode
            {
                get
                {
                    return this.countryCode;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.countryCode)}' cannot be null.", nameof(this.countryCode));
                    }
                    else
                    {
                        this.countryCode = value;
                    }
                }
            }
            public string Postcode
            {
                get
                {
                    return this.postcode;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.postcode)}' cannot be null.", nameof(this.postcode));
                    }
                    else
                    {
                        this.postcode = value;
                    }
                }
            }
            public string PhoneNumber
            {
                get
                {
                    return this.phoneNumber;
                }
                set
                {
                    this.phoneNumber = value;
                }
            }
            public string EmailAddress
            {
                get
                {
                    return this.emailAddress;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.emailAddress)}' cannot be null.", nameof(this.emailAddress));
                    }
                    else
                    {
                        this.emailAddress = value;
                    }
                }
            }
            public string VatNumber
            {
                get
                {
                    return this.vatNumber;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.vatNumber)}' cannot be null.", nameof(this.vatNumber));
                    }
                    else
                    {
                        this.vatNumber = value;
                    }
                }
            }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public Shipper()
            {
                try
                {
                    this.addressId = "";
                    this.shipperReference = "";
                    this.shipperReference2 = "";
                    this.shipperDepartment = 0;
                    this.companyName = "";
                    this.contactName = "";
                    this.addressLine1 = "";
                    this.addressLine3 = "";
                    this.town = "";
                    this.county = "";
                    this.countryCode = "";
                    this.postcode = "";
                    this.phoneNumber = "";
                    this.emailAddress = "";
                    this.vatNumber = "";
                }
                catch
                {
                    throw;
                }
            }
            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpAddressId"></param>
            /// <param name="inpShipperReference"></param>
            /// <param name="inpShipperReference2"></param>
            /// <param name="inpShipperDepartment"></param>
            /// <param name="inpCompanyName"></param>
            /// <param name="inpContactName"></param>
            /// <param name="inpAddressLine1"></param>
            /// <param name="inpAddressLine2"></param>
            /// <param name="inpAddressLine3"></param>
            /// <param name="inpTown"></param>
            /// <param name="inpCounty"></param>
            /// <param name="inpCountryCode"></param>
            /// <param name="inpPostcode"></param>
            /// <param name="inpPhoneNumber"></param>
            /// <param name="invpEmailAddress"></param>
            /// <param name="inpVatNumber"></param>
            public Shipper(string inpAddressId,
                string inpShipperReference,
                string inpShipperReference2,
                int inpShipperDepartment,
                string inpCompanyName,
                string inpContactName,
                string inpAddressLine1,
                string inpAddressLine2,
                string inpAddressLine3,
                string inpTown,
                string inpCounty,
                string inpCountryCode,
                string inpPostcode,
                string inpPhoneNumber,
                string invpEmailAddress,
                string inpVatNumber) : this()
            {
                try
                {
                    this.AddressId = inpAddressId;
                    this.ShipperReference = inpShipperReference;
                    this.ShipperReference2 = inpShipperReference2;
                    this.ShipperDepartment = inpShipperDepartment;
                    this.CompanyName = inpCompanyName;
                    this.ContactName = inpContactName;
                    this.AddressLine1 = inpAddressLine1;
                    this.AddressLine2 = inpAddressLine2;
                    this.AddressLine3 = inpAddressLine3;
                    this.Town = inpTown;
                    this.County = inpCounty;
                    this.ShipperCountryCode = inpCountryCode;
                    this.Postcode = inpPostcode;
                    this.PhoneNumber = inpPhoneNumber;
                    this.EmailAddress = invpEmailAddress;
                    this.VatNumber = inpVatNumber;
                }
                catch
                {
                    throw;
                }
            }
            #endregion

        }

        public class Destination
        {
            #region Fields
            private string addressId;
            private string companyName;
            private string contactName;
            private string addressLine1;
            private string addressLine2;
            private string addressLine3;
            private string town;
            private string county;
            private string countryCode;
            private string postcode;
            private string phoneNumber;
            private string emailAddress;
            private string vatNumber;
            #endregion

            #region Properties
            public string AddressId
            {
                get
                {
                    return this.addressId;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.addressId)}' cannot be null.", "inpAddressId");
                    }
                    else
                    {
                        this.addressId = value;
                    }
                }
            }
            public string CompanyName
            {
                get
                {
                    return this.companyName;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.companyName)}' cannot be null.", "companyName");
                    }
                    else
                    {
                        this.companyName = value;
                    }
                }
            }
            public string ContactName
            {
                get
                {
                    return this.contactName;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.contactName)}' cannot be null.", nameof(this.contactName));
                    }
                    else
                    {
                        this.contactName = value;
                    }
                }
            }
            public string AddressLine1
            {
                get
                {
                    return this.addressLine1;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.addressLine1)}' cannot be null.", nameof(this.addressLine1));
                    }
                    else
                    {
                        this.addressLine1 = value;
                    }
                }
            }
            public string AddressLine2
            {
                get
                {
                    return this.addressLine2;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.addressLine2)}' cannot be null.", nameof(this.addressLine2));
                    }
                    else
                    {
                        this.addressLine2 = value;
                    }
                }
            }
            public string AddressLine3
            {
                get
                {
                    return this.addressLine3;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.addressLine3)}' cannot be null.", nameof(this.addressLine3));
                    }
                    else
                    {
                        this.addressLine3 = value;
                    }
                }
            }
            public string Town
            {
                get
                {
                    return this.town;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.town)}' cannot be null.", nameof(this.town));
                    }
                    else
                    {
                        this.town = value;
                    }
                }
            }
            public string County
            {
                get
                {
                    return this.county;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.county)}' cannot be null.", nameof(this.county));
                    }
                    else
                    {
                        this.county = value;
                    }
                }
            }
            public string CountryCode
            {
                get
                {
                    return this.countryCode;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.countryCode)}' cannot be null.", nameof(this.countryCode));
                    }
                    else
                    {
                        this.countryCode = value;
                    }
                }
            }
            public string Postcode
            {
                get
                {
                    return this.postcode;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.postcode)}' cannot be null.", nameof(this.postcode));
                    }
                    else
                    {
                        this.postcode = value;
                    }
                }
            }
            public string PhoneNumber
            {
                get
                {
                    return this.phoneNumber;
                }
                set
                {
                    this.phoneNumber = value;
                }
            }
            public string EmailAddress
            {
                get
                {
                    return this.emailAddress;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.emailAddress)}' cannot be null.", nameof(this.emailAddress));
                    }
                    else
                    {
                        this.emailAddress = value;
                    }
                }
            }
            public string VatNumber
            {
                get
                {
                    return this.vatNumber;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.vatNumber)}' cannot be null.", nameof(this.vatNumber));
                    }
                    else
                    {
                        this.vatNumber = value;
                    }
                }
            }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public Destination()
            {
                try
                {
                    this.addressId = "";
                    this.companyName = "";
                    this.contactName = "";
                    this.addressLine1 = "";
                    this.addressLine2 = "";
                    this.addressLine3 = "";
                    this.town = "";
                    this.county = "";
                    this.countryCode = "";
                    this.postcode = "";
                    this.phoneNumber = "";
                    this.emailAddress = "";
                    this.vatNumber = "";
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpAddressId"></param>
            /// <param name="inpCompanyName"></param>
            /// <param name="inpContactName"></param>
            /// <param name="inpAddressLine1"></param>
            /// <param name="inpAddressLine2"></param>
            /// <param name="inpAddressLine3"></param>
            /// <param name="inpTown"></param>
            /// <param name="inpCounty"></param>
            /// <param name="inpCountryCode"></param>
            /// <param name="inpPostcode"></param>
            /// <param name="inpPhoneNumber"></param>
            /// <param name="inpEmailAddress"></param>
            /// <param name="inpVatNumber"></param>
            public Destination(string inpAddressId,
                string inpCompanyName,
                string inpContactName,
                string inpAddressLine1,
                string inpAddressLine2,
                string inpAddressLine3,
                string inpTown,
                string inpCounty,
                string inpCountryCode,
                string inpPostcode,
                string inpPhoneNumber,
                string inpEmailAddress,
                string inpVatNumber) : this()
            {
                try
                {
                    this.AddressId = inpAddressId;
                    this.CompanyName = inpCompanyName;
                    this.ContactName = inpContactName;
                    this.AddressLine1 = inpAddressLine1;
                    this.AddressLine2 = inpAddressLine2;
                    this.AddressLine3 = inpAddressLine3;
                    this.Town = inpTown;
                    this.County = inpCounty;
                    this.CountryCode = inpCountryCode;
                    this.Postcode = inpPostcode;
                    this.PhoneNumber = inpPhoneNumber;
                    this.EmailAddress = inpEmailAddress;
                    this.VatNumber = inpVatNumber;
                }
                catch
                {
                    throw;
                }
            }
            #endregion

        }

        public class ShipmentInformation
        {
            #region Field
            private DateTime shipmentDate;
            private string serviceCode;
            //private int totalPackages;
            //private double totalWeight;
            private string weightUnitOfMeasure;
            private string product;
            private string descriptionOfGoods;
            private string reasonForExport;
            private double valueData;
            private string currency;
            private string incoterms;
            private string labelFormat;
            private string silentPrintProfile;
            private string shipmentAction;
            #endregion

            #region ClassFields
            public ServiceOptions serviceOptions; //class field
            #endregion

            #region Properties
            public DateTime ShipmentDate
            {
                get
                {
                    return this.shipmentDate;
                }
                set
                {
                    this.shipmentDate = value;
                }
            }
            public string ServiceCode
            {
                get
                {
                    return this.serviceCode;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.serviceCode)}' cannot be null.", nameof(this.serviceCode));
                    }
                    else
                    {
                        this.serviceCode = value;
                    }
                }
            }
            //public int TotalPackages
            //{
            //    get
            //    {
            //        return this.totalPackages;
            //    }
            //    set
            //    {
            //        if (value == 0)
            //        {
            //            throw new ArgumentException($"'{nameof(this.totalPackages)}' cannot be null.", nameof(this.totalPackages));
            //        }
            //        else
            //        {
            //            this.totalPackages = value;
            //        }
            //    }
            //}
            //public double TotalWeight
            //{
            //    get
            //    {
            //        return this.totalWeight;
            //    }
            //    set
            //    {
            //        if (value == 0)
            //        {
            //            throw new ArgumentException($"'{nameof(this.totalWeight)}' cannot be null.", nameof(this.totalWeight));
            //        }
            //        else
            //        {
            //            this.totalWeight = value;
            //        }
            //    }
            //}
            public string WeightUnitOfMeasure
            {
                get
                {
                    return this.weightUnitOfMeasure;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.weightUnitOfMeasure)}' cannot be null.", nameof(this.weightUnitOfMeasure));
                    }
                    else
                    {
                        this.weightUnitOfMeasure = value;
                    }
                }
            }
            public string Product
            {
                get
                {
                    return this.product;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.product)}' cannot be null.", nameof(this.product));
                    }
                    else
                    {
                        this.product = value;
                    }
                }
            }
            public string DescriptionOfGoods
            {
                get
                {
                    return this.descriptionOfGoods;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.descriptionOfGoods)}' cannot be null.", nameof(this.descriptionOfGoods));
                    }
                    else
                    {
                        this.descriptionOfGoods = value;
                    }
                }
            }
            public string ReasonForExport
            {
                get
                {
                    return this.reasonForExport;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.reasonForExport)}' cannot be null.", nameof(this.reasonForExport));
                    }
                    else
                    {
                        this.reasonForExport = value;
                    }
                }
            }
            public double Value
            {
                get
                {
                    return this.valueData;
                }
                set
                {
                    this.valueData = value;
                }
            }
            public string Currency
            {
                get
                {
                    return this.currency;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.currency)}' cannot be null.", nameof(this.currency));
                    }
                    else
                    {
                        this.currency = value;
                    }
                }
            }
            public string Incoterms
            {
                get
                {
                    return this.incoterms;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.incoterms)}' cannot be null.", nameof(this.incoterms));
                    }
                    else
                    {
                        this.incoterms = value;
                    }
                }
            }
            public string LabelFormat
            {
                get
                {
                    return this.labelFormat;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.labelFormat)}' cannot be null.", nameof(this.labelFormat));
                    }
                    else
                    {
                        this.labelFormat = value;
                    }
                }
            }
            public string SilentPrintProfile
            {
                get
                {
                    return this.silentPrintProfile;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.silentPrintProfile)}' cannot be null.", nameof(this.silentPrintProfile));
                    }
                    else
                    {
                        this.silentPrintProfile = value;
                    }
                }
            }
            public string ShipmentAction
            {
                get
                {
                    return this.shipmentAction;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.shipmentAction)}' cannot be null.", nameof(this.shipmentAction));
                    }
                    else
                    {
                        this.shipmentAction = value;
                    }
                }
            }
            #endregion

            #region SubClassCreation
            //    /// <summary>
            //    /// Create a blank ServiceOptions sub-class entry.
            //    /// </summary>
            //    public void AddServiceOption()
            //    {
            //        if (this.serviceOptions == null)
            //        {
            //            try
            //            {
            //                this.serviceOptions = new ServiceOptions();
            //            }
            //            catch
            //            {
            //                throw;
            //            }
            //        }
            //        else
            //        {
            //            throw new DuplicateWaitObjectException(nameof(this.serviceOptions), $"'{nameof(this.serviceOptions)}' already exist. Cannot add again.");
            //        }
            //    }
            //    /// <summary>
            //    /// Create a ServiceOptions sub-class entry and populate it.
            //    /// </summary>
            //    /// <param name="postingLocation"></param>
            //    /// <param name="serviceLevel"></param>
            //    /// <param name="serviceFormat"></param>
            //    /// <param name="safeplace"></param>
            //    /// <param name="saturdayGuaranteed"></param>
            //    /// <param name="consequentialLoss"></param>
            //    /// <param name="localCollect"></param>
            //    /// <param name="trackingNotifications"></param>
            //    /// <param name="recordedSignedFor"></param>
            //    public void AddServiceOption(string postingLocation,
            //        string serviceLevel,
            //        string serviceFormat,
            //        string safeplace,
            //        bool saturdayGuaranteed,
            //        string consequentialLoss,
            //        bool localCollect,
            //        string trackingNotifications,
            //        bool recordedSignedFor)
            //    {
            //        if (this.serviceOptions == null)
            //        {
            //            try
            //            {
            //                this.serviceOptions = new ServiceOptions(postingLocation,
            //                    serviceLevel,
            //                    serviceFormat,
            //                    safeplace,
            //                    saturdayGuaranteed,
            //                    consequentialLoss,
            //                    localCollect,
            //                    trackingNotifications,
            //                    recordedSignedFor);
            //            }
            //            catch
            //            {
            //                throw;
            //            }
            //        }
            //        else
            //        {
            //            throw new DuplicateWaitObjectException(nameof(this.serviceOptions), $"'{nameof(this.serviceOptions)}' already exist. Cannot add again.");
            //        }
            //    }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public ShipmentInformation()
            {
                try
                {
                    //this.PackagesList.Add(new Packages());
                    //this.ItemsList = Add(new ItemsList());

                    this.shipmentDate = DateTime.Today;
                    this.serviceCode = "";
                    //this.totalPackages = 0;
                    //this.totalWeight = 0;
                    this.weightUnitOfMeasure = "";
                    this.product = "";
                    this.descriptionOfGoods = "";
                    this.reasonForExport = "Sale of Goods";
                    this.valueData = 0;
                    this.currency = "";
                    this.incoterms = "";
                    this.labelFormat = "";
                    this.silentPrintProfile = "";
                    this.shipmentAction = "";
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpShipmentDate"></param>
            /// <param name="inpServiceCode"></param>
            /// <param name="inpTotalPackages"></param>
            /// <param name="inpTotalWeight"></param>
            /// <param name="inpWeightUOM"></param>
            /// <param name="inpProduct"></param>
            /// <param name="inpDescriptionOfGoods"></param>
            /// <param name="inpReasonForExport"></param>
            /// <param name="inpValueData"></param>
            /// <param name="inpCurrency"></param>
            /// <param name="inpIncoterms"></param>
            /// <param name="inpLabelFormat"></param>
            /// <param name="inpSilentPrintProfile"></param>
            /// <param name="inpShipmentAction"></param>
            public ShipmentInformation(DateTime inpShipmentDate,
                string inpServiceCode,
                //int inpTotalPackages,
                //double inpTotalWeight,
                string inpWeightUOM,
                string inpProduct,
                string inpDescriptionOfGoods,
                string inpReasonForExport,
                double inpValueData,
                string inpCurrency,
                string inpIncoterms,
                string inpLabelFormat,
                string inpSilentPrintProfile,
                string inpShipmentAction) : this()
            {
                try
                {
                    this.ShipmentDate = inpShipmentDate;
                    this.ServiceCode = inpServiceCode;
                    //this.TotalPackages = inpTotalPackages;
                    //this.TotalWeight = inpTotalWeight;
                    this.WeightUnitOfMeasure = inpWeightUOM;
                    this.Product = inpProduct;
                    this.DescriptionOfGoods = inpDescriptionOfGoods;
                    this.ReasonForExport = inpReasonForExport;
                    this.Value = inpValueData;
                    this.Currency = inpCurrency;
                    this.Incoterms = inpIncoterms;
                    this.LabelFormat = inpLabelFormat;
                    this.SilentPrintProfile = inpSilentPrintProfile;
                    this.ShipmentAction = inpShipmentAction;
                }
                catch
                {
                    throw;
                }
            }
            #endregion
        }

        public class ServiceOptions
        {
            #region Fields
            private string postingLocation;
            private string serviceLevel;
            private string serviceFormat;
            private string safeplace;
            private bool saturdayGuaranteed;
            private string consequentialLoss;
            private bool localCollect;
            private string trackingNotifications;
            private bool recordedSignedFor;
            #endregion

            #region Properties
            public string PostingLocation
            {
                get
                {
                    return this.postingLocation;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.postingLocation)}' cannot be null.", nameof(this.postingLocation));
                    }
                    else
                    {
                        this.postingLocation = value;
                    }
                }
            }
            public string ServiceLevel
            {
                get
                {
                    return this.serviceLevel;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.serviceLevel)}' cannot be null.", nameof(this.serviceLevel));
                    }
                    else
                    {
                        this.serviceLevel = value;
                    }
                }
            }
            public string ServiceFormat
            {
                get
                {
                    return this.serviceFormat;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.serviceFormat)}' cannot be null.", nameof(this.serviceFormat));
                    }
                    else
                    {
                        this.serviceFormat = value;
                    }
                }
            }
            public string Safeplace
            {
                get
                {
                    return this.safeplace;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.safeplace)}' cannot be null.", nameof(this.safeplace));
                    }
                    else
                    {
                        this.safeplace = value;
                    }
                }
            }
            public bool SaturdayGuaranteed
            {
                get
                {
                    return this.saturdayGuaranteed;
                }
                set
                {
                    this.saturdayGuaranteed = value;
                }
            }
            public string ConsequentialLoss
            {
                get
                {
                    return this.consequentialLoss;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.consequentialLoss)}' cannot be null.", nameof(this.consequentialLoss));
                    }
                    else
                    {
                        this.consequentialLoss = value;
                    }
                }
            }
            public bool LocalCollect
            {
                get
                {
                    return this.localCollect;
                }
                set
                {
                    this.localCollect = value;
                }
            }
            public string TrackingNotifications
            {
                get
                {
                    return this.trackingNotifications;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.trackingNotifications)}' cannot be null.", nameof(this.trackingNotifications));
                    }
                    else
                    {
                        this.trackingNotifications = value;
                    }
                }
            }
            public bool RecordedSignedFor
            {
                get
                {
                    return this.recordedSignedFor;

                }
                set
                {
                    this.recordedSignedFor = value;
                }
            }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public ServiceOptions()
            {
                try
                {
                    this.postingLocation = "";
                    this.serviceLevel = "";
                    this.serviceFormat = "";
                    this.safeplace = "";
                    this.saturdayGuaranteed = false;
                    this.consequentialLoss = "";
                    this.localCollect = false;
                    this.trackingNotifications = "";
                    this.recordedSignedFor = false;
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpPostingLocation"></param>
            /// <param name="inpServiceLevel"></param>
            /// <param name="inpServiceFormat"></param>
            /// <param name="inpSafeplace"></param>
            /// <param name="inpSaturdayGuaranteed"></param>
            /// <param name="inpConsequentialLoss"></param>
            /// <param name="inpLocalCollect"></param>
            /// <param name="inpTrackingNotifications"></param>
            /// <param name="inpRecordedSignedFor"></param>
            public ServiceOptions(string inpPostingLocation,
                string inpServiceLevel,
                string inpServiceFormat,
                string inpSafeplace,
                bool inpSaturdayGuaranteed,
                string inpConsequentialLoss,
                bool inpLocalCollect,
                string inpTrackingNotifications,
                bool inpRecordedSignedFor) : this()
            {
                try
                {
                    this.PostingLocation = inpPostingLocation;
                    this.ServiceLevel = inpServiceLevel;
                    this.ServiceFormat = inpServiceFormat;
                    this.Safeplace = inpSafeplace;
                    this.SaturdayGuaranteed = inpSaturdayGuaranteed;
                    this.ConsequentialLoss = inpConsequentialLoss;
                    this.LocalCollect = inpLocalCollect;
                    this.TrackingNotifications = inpTrackingNotifications;
                    this.RecordedSignedFor = inpRecordedSignedFor;
                }
                catch
                {
                    throw;
                }
            }
            #endregion
        }

        public class Packages
        {
            #region Fields
            private int packageOccurrence;
            private string packagingId;
            private double weight;
            private int length;
            private int width;
            private int height;
            #endregion

            #region Properties
            public int PackageOccurrence
            {
                get
                {
                    return this.packageOccurrence;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.packageOccurrence)}' cannot be null.", nameof(this.packageOccurrence));
                    }
                    else
                    {
                        this.packageOccurrence = value;
                    }
                }
            }
            public string PackagingId
            {
                get
                {
                    return this.packagingId;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.packagingId)}' cannot be null.", nameof(this.packagingId));
                    }
                    else
                    {
                        this.packagingId = value;
                    }
                }
            }
            public double Weight
            {
                get
                {
                    return this.weight;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.weight)}' cannot be null.", nameof(this.weight));
                    }
                    else
                    {
                        this.weight = value;
                    }
                }
            }
            public int Length
            {
                get
                {
                    return this.length;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.length)}' cannot be null.", nameof(this.length));
                    }
                    else
                    {
                        this.length = value;
                    }
                }
            }
            public int Width
            {
                get
                {
                    return this.width;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.width)}' cannot be null.", nameof(this.width));
                    }
                    else
                    {
                        this.width = value;
                    }
                }
            }
            public int Height
            {
                get
                {
                    return this.height;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.height)}' cannot be null.", nameof(this.height));
                    }
                    else
                    {
                        this.height = value;
                    }
                }
            }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public Packages()
            {
                try
                {
                    this.packageOccurrence = 0;
                    this.packagingId = "";
                    this.weight = 0;
                    this.length = 0;
                    this.width = 0;
                    this.height = 0;
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpPackageOccurrence"></param>
            /// <param name="inpPackagingId"></param>
            /// <param name="inpWeight"></param>
            /// <param name="inpLength"></param>
            /// <param name="inpWidth"></param>
            /// <param name="inpHeight"></param>
            public Packages(int inpPackageOccurrence,
                string inpPackagingId,
                double inpWeight,
                int inpLength,
                int inpWidth,
                int inpHeight) : this()
            {
                try
                {
                    this.PackageOccurrence = inpPackageOccurrence;
                    this.PackagingId = inpPackagingId;
                    this.Weight = inpWeight;
                    this.Length = inpLength;
                    this.Width = inpWidth;
                    this.Height = inpHeight;
                }
                catch
                {
                    throw;
                }
            }
            #endregion
        }

        public class Items
        {
            #region Fields
            private string itemId;
            private int quantity;
            private string description;
            private double valueData;
            private double weight;
            private int packageOccurrence;
            private string hsCode;
            private string skuCode;
            private string countryOfOrigin;
            private string imageUrl;
            #endregion

            #region Properties
            public string ItemId
            {
                get
                {
                    return this.itemId;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.itemId)}' cannot be null.", nameof(this.itemId));
                    }
                    else
                    {
                        this.itemId = value;
                    }
                }
            }
            public int Quantity
            {
                get
                {
                    return this.quantity;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.quantity)}' cannot be null.", nameof(this.quantity));
                    }
                    else
                    {
                        this.quantity = value;
                    }
                }
            }
            public string Description
            {
                get
                {
                    return this.description;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.description)}' cannot be null.", nameof(this.description));
                    }
                    else
                    {
                        this.description = value;
                    }
                }
            }
            public double Value
            {
                get
                {
                    return this.valueData;
                }
                set
                {
                    this.valueData = value;
                }
            }
            public double Weight
            {
                get
                {
                    return this.weight;
                }
                set
                {
                    this.weight = value;
                }
            }
            public int PackageOccurrence
            {
                get
                {
                    return this.packageOccurrence;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.packageOccurrence)}' cannot be null.", nameof(this.packageOccurrence));
                    }
                    else
                    {
                        this.packageOccurrence = value;
                    }
                }
            }
            public string HsCode
            {
                get
                {
                    return this.hsCode;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.hsCode)}' cannot be null.", nameof(this.hsCode));
                    }
                    else
                    {
                        this.hsCode = value;
                    }
                }
            }
            public string SkuCode
            {
                get
                {
                    return this.skuCode;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.skuCode)}' cannot be null.", nameof(this.skuCode));
                    }
                    else
                    {
                        this.skuCode = value;
                    }
                }
            }
            public string CountryOfOrigin
            {
                get
                {
                    return this.countryOfOrigin;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.countryOfOrigin)}' cannot be null.", nameof(this.countryOfOrigin));
                    }
                    else
                    {
                        this.countryOfOrigin = value;
                    }
                }
            }
            public string ImageUrl
            {
                get
                {
                    return this.imageUrl;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException($"'{nameof(this.imageUrl)}' cannot be null.", nameof(this.imageUrl));
                    }
                    else
                    {
                        this.imageUrl = value;
                    }
                }
            }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public Items()
            {
                try
                {
                    this.itemId = "";
                    this.quantity = 0;
                    this.description = "";
                    this.valueData = 0;
                    this.weight = 0;
                    this.packageOccurrence = 0;
                    this.hsCode = "";
                    this.skuCode = "";
                    this.countryOfOrigin = "";
                    this.imageUrl = "";
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpItemId"></param>
            /// <param name="inpQuantity"></param>
            /// <param name="inpDescription"></param>
            /// <param name="inpValueData"></param>
            /// <param name="inpWeight"></param>
            /// <param name="inpPackageOccurrence"></param>
            /// <param name="inpHsCode"></param>
            /// <param name="inpSkuCode"></param>
            /// <param name="inpCountryOfOrigin"></param>
            /// <param name="inpImageUrl"></param>
            public Items(string inpItemId,
                int inpQuantity,
                string inpDescription,
                double inpValueData,
                double inpWeight,
                int inpPackageOccurrence,
                string inpHsCode,
                string inpSkuCode,
                string inpCountryOfOrigin,
                string inpImageUrl) : this()
            {
                try
                {
                    this.ItemId = inpItemId;
                    this.Quantity = inpQuantity;
                    this.Description = inpDescription;
                    this.Value = inpValueData;
                    this.Weight = inpWeight;
                    this.PackageOccurrence = inpPackageOccurrence;
                    this.HsCode = inpHsCode;
                    this.SkuCode = inpSkuCode;
                    this.CountryOfOrigin = inpCountryOfOrigin;
                    this.ImageUrl = inpImageUrl;
                }
                catch
                {
                    throw;
                }
            }
            #endregion
        }

        public class CustomsInformation
        {
            #region Fields
            private string preRegistrationNumber;
            private string preRegistrationType;
            private double shippingCharges;
            private double otherCharges;
            private double quotedLandedCost;
            private Int64 invoiceNumber;
            private DateTime invoiceDate;
            private bool exportLicence;
            private Int64 addresseeIdentificationReferenceNumber;
            #endregion

            #region Properties
            public string PreRegistrationNumber
            {
                get
                {
                    return this.preRegistrationNumber;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.preRegistrationNumber)}' cannot be null.", nameof(this.preRegistrationNumber));
                    }
                    else
                    {
                        this.preRegistrationNumber = value;
                    }
                }
            }
            public string PreRegistrationType
            {
                get
                {
                    return this.preRegistrationType;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException($"'{nameof(this.preRegistrationType)}' cannot be null.", nameof(this.preRegistrationType));
                    }
                    else
                    {
                        this.preRegistrationType = value;
                    }
                }
            }
            public double ShippingCharges
            {
                get
                {
                    return this.shippingCharges;
                }
                set
                {
                    this.shippingCharges = value;
                }
            }
            public double OtherCharges
            {
                get
                {
                    return this.otherCharges;
                }
                set
                {
                    this.otherCharges = value;
                }
            }
            public double QuotedLandedCost
            {
                get
                {
                    return this.quotedLandedCost;
                }
                set
                {
                    this.quotedLandedCost = value;
                }
            }
            public Int64 InvoiceNumber
            {
                get
                {
                    return this.invoiceNumber;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.invoiceNumber)}' cannot be null.", nameof(this.invoiceNumber));
                    }
                    else
                    {
                        this.invoiceNumber = value;
                    }
                }
            }
            public DateTime InvoiceDate
            {
                get
                {
                    return this.invoiceDate;
                }
                set
                {
                    this.invoiceDate = value;
                }
            }
            public bool ExportLicence
            {
                get
                {
                    return this.exportLicence;
                }
                set
                {
                    this.exportLicence = value;
                }
            }
            public Int64 AddresseeIdentificationReferenceNumber
            {
                get
                {
                    return this.addresseeIdentificationReferenceNumber;
                }
                set
                {
                    if (value == 0)
                    {
                        throw new ArgumentException($"'{nameof(this.addresseeIdentificationReferenceNumber)}' cannot be null.", nameof(this.addresseeIdentificationReferenceNumber));
                    }
                    else
                    {
                        this.addresseeIdentificationReferenceNumber = value;
                    }
                }
            }
            #endregion

            #region Constructors
            /// <summary>
            /// Blank constructor.
            /// </summary>
            public CustomsInformation()
            {
                try
                {
                    this.preRegistrationNumber = "";
                    this.preRegistrationType = "";
                    this.shippingCharges = 0;
                    this.otherCharges = 0;
                    this.quotedLandedCost = 0;
                    this.invoiceNumber = 0;
                    this.invoiceDate = DateTime.Today;
                    this.exportLicence = false;
                    this.addresseeIdentificationReferenceNumber = 0;
                }
                catch
                {
                    throw;
                }
            }

            /// <summary>
            /// Create class and populate it.
            /// </summary>
            /// <param name="inpPreRegistrationNumber"></param>
            /// <param name="inpPreRegistrationType"></param>
            /// <param name="inpShippingCharges"></param>
            /// <param name="inpOtherCharges"></param>
            /// <param name="inpQuotedLandedCost"></param>
            /// <param name="inpInvoiceNumber"></param>
            /// <param name="inpInvoiceDate"></param>
            /// <param name="inpExportLicence"></param>
            /// <param name="inpAddresseeIdentificationReferenceNumber"></param>
            public CustomsInformation(string inpPreRegistrationNumber,
                string inpPreRegistrationType,
                double inpShippingCharges,
                double inpOtherCharges,
                double inpQuotedLandedCost,
                Int64 inpInvoiceNumber,
                DateTime inpInvoiceDate,
                bool inpExportLicence,
                Int64 inpAddresseeIdentificationReferenceNumber) : this()
            {
                try
                {
                    this.PreRegistrationNumber = inpPreRegistrationNumber;
                    this.PreRegistrationType = inpPreRegistrationType;
                    this.ShippingCharges = inpShippingCharges;
                    this.OtherCharges = inpOtherCharges;
                    this.QuotedLandedCost = inpQuotedLandedCost;
                    this.InvoiceNumber = inpInvoiceNumber;
                    this.InvoiceDate = inpInvoiceDate;
                    this.ExportLicence = inpExportLicence;
                    this.AddresseeIdentificationReferenceNumber = inpAddresseeIdentificationReferenceNumber;
                }
                catch
                {
                    throw;
                }
            }
            #endregion
        }
    }
}
