using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrick.Library.RoyalMail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.SendBrick.Library.Tests;

namespace CM.SendBrick.Library.Tests
{
    [TestClass()]
    public class RoyalMailDataTests
    {
        #region ShipperTests
        /// <summary>
        /// shipper instance can be created.
        /// </summary>
        [TestMethod()]
        public void ShipperAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddShipper();

            Assert.AreEqual("", testItem.SupplierId, false);
        }

        /// <summary>
        /// Creates one and only one shipper instance.
        /// </summary>
        [TestMethod()]
        public void ShipperAddTwiceTest()
        {
            RoyalMailData testItem = null;

            try
            {
                testItem = new RoyalMailData();
                testItem.AddShipper();
                testItem.AddShipper();
            }
            catch (DuplicateWaitObjectException e)
            {
                Console.WriteLine("An error has occured: " + e.Message);
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("", testItem.SupplierId, false);
        }

        /// <summary>
        /// shipper instance is created with the correct data.
        /// </summary>
        [TestMethod()]
        public void ShipperAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddShipper(SampleOrder1.SupplierId,                // "bricksinbloom7308"
                                SampleOrder1.SupplierReference1,        // "7308"
                                SampleOrder1.SupplierReference2,        // "BrickLink"
                                SampleOrder1.Department,                // 7308
                                SampleOrder1.SupplierBusinessName,      // "Bricks In Bloom"
                                SampleOrder1.SupplierContactName,       // "Leigha Middleton"
                                SampleOrder1.SupplierAddressLine1,      // "Unit 4"
                                SampleOrder1.SupplierAddressLine2,      // "Candy Works"
                                SampleOrder1.SupplierAddressLine3,      // "15 Parkhouse Road"
                                SampleOrder1.SupplierAddressTown,       // "Carlisle"
                                SampleOrder1.SupplierAddressCounty,     // "Cumbria"
                                SampleOrder1.SupplierCountryCode,       // "GB"
                                SampleOrder1.SupplierAddressPostcode,   // "CA3 0JU"
                                SampleOrder1.SupplierPhoneNumber,       // "1228511030"
                                SampleOrder1.SupplierEmailAddress,      // "bricksinbloom@bricklink.com"
                                SampleOrder1.SupplierVatNumber);        // "GB123 4567 89"

            Assert.AreEqual(SampleOrder1.SupplierId, testItem.SupplierId, false);                           // "bricksinbloom7308"
            Assert.AreEqual(SampleOrder1.SupplierReference1, testItem.SupplierReference1, false);           // "7308"
            Assert.AreEqual(SampleOrder1.SupplierReference2, testItem.SupplierReference2, false);           // "BrickLink"
            Assert.AreEqual(SampleOrder1.Department, testItem.Department, 0);                               // 7380
            Assert.AreEqual(SampleOrder1.SupplierBusinessName, testItem.SupplierBusinessName, false);       // "Bricks In Bloom"
            Assert.AreEqual(SampleOrder1.SupplierContactName, testItem.SupplierContactName, false);         //"Leigha Middleton"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine1, testItem.SupplierAddressLine1, false);       // "Unit 4"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine2, testItem.SupplierAddressLine2, false);       // "Candy Works"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine3, testItem.SupplierAddressLine3, false);       // "15 Parkhouse Road"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine4, testItem.SupplierAddressLine4, false);       // ""
            Assert.AreEqual(SampleOrder1.SupplierAddressTown, testItem.SupplierAddressTown, false);         // "Carlisle"
            Assert.AreEqual(SampleOrder1.SupplierAddressCounty, testItem.SupplierAddressCounty, false);     // "Cumbria"
            Assert.AreEqual(SampleOrder1.SupplierCountryCode, testItem.SupplierCountryCode, false);         // "GB"
            Assert.AreEqual(SampleOrder1.SupplierAddressPostcode, testItem.SupplierAddressPostcode, false); // "CA3 0JU"
            Assert.AreEqual(SampleOrder1.SupplierPhoneNumber, testItem.SupplierPhoneNumber, false);         // "1228511030"
            Assert.AreEqual(SampleOrder1.SupplierEmailAddress, testItem.SupplierEmailAddress, false);       // "bricksinbloom@bricklink.com"
            Assert.AreEqual(SampleOrder1.SupplierVatNumber, testItem.SupplierVatNumber, false);             // "GB123 4567 89"
        }

        /// <summary>
        /// shipper instance can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void ShipperUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.SupplierId = SampleOrder1.SupplierId;                              // "bricksinbloom7308"
            testItem.SupplierReference1 = SampleOrder1.SupplierReference1;              // "7308"
            testItem.SupplierReference2 = SampleOrder1.SupplierReference2;              // "BrickLink"
            testItem.Department = SampleOrder1.Department;                              // 7308
            testItem.SupplierBusinessName = SampleOrder1.SupplierBusinessName;          // "Bricks In Bloom"
            testItem.SupplierContactName = SampleOrder1.SupplierContactName;            // "Leigha Middleton"
            testItem.SupplierAddressLine1 = SampleOrder1.SupplierAddressLine1;          // "Unit 4"
            testItem.SupplierAddressLine2 = SampleOrder1.SupplierAddressLine2;          // "Candy Works"
            testItem.SupplierAddressLine3 = SampleOrder1.SupplierAddressLine3;          // "15 Parkhouse Road"
            testItem.SupplierAddressTown = SampleOrder1.SupplierAddressTown;            // ""
            testItem.SupplierAddressCounty = SampleOrder1.SupplierAddressCounty;        // "Carlisle"
            testItem.SupplierAddressCounty = SampleOrder1.SupplierAddressCounty;        // "Cumbria"
            testItem.SupplierCountryCode = SampleOrder1.SupplierCountryCode;            // "GB"
            testItem.SupplierAddressPostcode = SampleOrder1.SupplierAddressPostcode;    // "CA3 0JU"
            testItem.SupplierPhoneNumber = SampleOrder1.SupplierPhoneNumber;            // "1228511030"
            testItem.SupplierEmailAddress = SampleOrder1.SupplierEmailAddress;          // "bricksinbloom@bricklink.com"
            testItem.SupplierVatNumber = SampleOrder1.SupplierVatNumber;                // "GB123 4567 89"

            Assert.AreEqual(SampleOrder1.SupplierId, testItem.SupplierId, false);                           // "bricksinbloom7308"
            Assert.AreEqual(SampleOrder1.SupplierReference1, testItem.SupplierReference1, false);           // "7308"
            Assert.AreEqual(SampleOrder1.SupplierReference2, testItem.SupplierReference2, false);           // "BrickLink"
            Assert.AreEqual(SampleOrder1.Department, testItem.Department, 0);                               // 7380
            Assert.AreEqual(SampleOrder1.SupplierBusinessName, testItem.SupplierBusinessName, false);       // "Bricks In Bloom"
            Assert.AreEqual(SampleOrder1.SupplierContactName, testItem.SupplierContactName, false);         // "Leigha Middleton"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine1, testItem.SupplierAddressLine1, false);       // "Unit 4"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine2, testItem.SupplierAddressLine2, false);       // "Candy Works"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine3, testItem.SupplierAddressLine3, false);       // "15 Parkhouse Road"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine4, testItem.SupplierAddressLine4, false);       // ""
            Assert.AreEqual(SampleOrder1.SupplierAddressTown, testItem.SupplierAddressTown, false);         // "Carlisle"
            Assert.AreEqual(SampleOrder1.SupplierAddressCounty, testItem.SupplierAddressCounty, false);     // "Cumbria"
            Assert.AreEqual(SampleOrder1.SupplierCountryCode, testItem.SupplierCountryCode, false);         // "GB"
            Assert.AreEqual(SampleOrder1.SupplierAddressPostcode, testItem.SupplierAddressPostcode, false); // "CA3 0JU"
            Assert.AreEqual(SampleOrder1.SupplierPhoneNumber, testItem.SupplierPhoneNumber, false);         // "1228511030"
            Assert.AreEqual(SampleOrder1.SupplierEmailAddress, testItem.SupplierEmailAddress, false);       // "bricksinbloom@bricklink.com"
            Assert.AreEqual(SampleOrder1.SupplierVatNumber, testItem.SupplierVatNumber, false);             // "GB123 4567 89"
        }
        #endregion

        #region DestinationTests
        /// <summary>
        /// destination instance can be created.
        /// </summary>
        [TestMethod()]
        public void DestinationAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddDestination();

            Assert.AreEqual("", testItem.CustomerId, false);
        }

        /// <summary>
        /// Creates one and only one destination instance.
        /// </summary>
        [TestMethod()]
        public void DestinationAddTwiceTest()
        {
            RoyalMailData testItem = null;

            try
            {
                testItem = new RoyalMailData();
                testItem.AddDestination();
                testItem.AddDestination();
            }
            catch (DuplicateWaitObjectException e)
            {
                Console.WriteLine("An error has occured: " + e.Message);
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("", testItem.CustomerId, false);
        }

        /// <summary>
        /// destination instance is created with the correct data.
        /// </summary>
        [TestMethod()]
        public void DestinationAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddDestination(SampleOrder1.CustomerId,                // "BL15748250"
                                    SampleOrder1.CustomerBusinessName,      // ""
                                    SampleOrder1.CustomerContactName,       // "Colin Middleton"
                                    SampleOrder1.CustomerAddressLine1,      // "257 Ecclesall Road"
                                    SampleOrder1.CustomerAddressLine2,      // ""
                                    SampleOrder1.CustomerAddressLine3,      // "Sheffield"
                                    SampleOrder1.CustomerAddressTown,       // "Sheffield"
                                    SampleOrder1.CustomerAddressCounty,     // "South Yorkshire"
                                    SampleOrder1.CustomerCountryCode,       // "GB"
                                    SampleOrder1.CustomerAddressPostcode,   // "S5 7HJ"
                                    SampleOrder1.CustomerPhoneNumber,       // "7505363818"
                                    SampleOrder1.CustomerEmailAddress,      // "colin@test.com"
                                    SampleOrder1.CustomerVatNumber);        // ""

            Assert.AreEqual(SampleOrder1.CustomerId, testItem.CustomerId, false);                           // "BL15748250"
            Assert.AreEqual(SampleOrder1.CustomerBusinessName, testItem.CustomerBusinessName, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerContactName, testItem.CustomerContactName, false);         // "Colin Middleton"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine1, testItem.CustomerAddressLine1, false);       // "257 Ecclesall Road"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine2, testItem.CustomerAddressLine2, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressLine3, testItem.CustomerAddressLine3, false);       // "Sheffield"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine4, testItem.CustomerAddressLine4, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressTown, testItem.CustomerAddressTown, false);         // "Sheffield"
            Assert.AreEqual(SampleOrder1.CustomerAddressCounty, testItem.CustomerAddressCounty, false);     // "South Yorkshire"
            Assert.AreEqual(SampleOrder1.CustomerCountryCode, testItem.CustomerCountryCode, false);         // "GB"
            Assert.AreEqual(SampleOrder1.CustomerAddressPostcode, testItem.CustomerAddressPostcode, false); // "S5 7HJ"
            Assert.AreEqual(SampleOrder1.CustomerPhoneNumber, testItem.CustomerPhoneNumber, false);         // "7505363818"
            Assert.AreEqual(SampleOrder1.CustomerEmailAddress, testItem.CustomerEmailAddress, false);       // "colin@test.com"
            Assert.AreEqual(SampleOrder1.CustomerVatNumber, testItem.CustomerVatNumber, false);             // ""
        }

        /// <summary>
        /// destination instance can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void DestinationUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.CustomerId = SampleOrder1.CustomerId;                              // "BL15748250"
            testItem.CustomerBusinessName = SampleOrder1.CustomerBusinessName;          // ""
            testItem.CustomerContactName = SampleOrder1.CustomerContactName;            // "Colin Middleton"
            testItem.CustomerAddressLine1 = SampleOrder1.CustomerAddressLine1;          // "257 Ecclesall Road"
            testItem.CustomerAddressLine2 = SampleOrder1.CustomerAddressLine2;          // ""
            testItem.CustomerAddressLine3 = SampleOrder1.CustomerAddressLine3;          // "Sheffield"
            testItem.CustomerAddressTown = SampleOrder1.CustomerAddressTown;            // "Sheffield"
            testItem.CustomerAddressCounty = SampleOrder1.CustomerAddressCounty;        // "South Yorkshire"
            testItem.CustomerCountryCode = SampleOrder1.CustomerCountryCode;            // "GB"
            testItem.CustomerAddressPostcode = SampleOrder1.CustomerAddressPostcode;    // "S5 7HJ"
            testItem.CustomerPhoneNumber = SampleOrder1.CustomerPhoneNumber;            // "7505363818"
            testItem.CustomerEmailAddress = SampleOrder1.CustomerEmailAddress;          // "colin@test.com"
            testItem.CustomerVatNumber = SampleOrder1.CustomerVatNumber;                // ""

            Assert.AreEqual(SampleOrder1.CustomerId, testItem.CustomerId, false);                           // "BL15748250"
            Assert.AreEqual(SampleOrder1.CustomerBusinessName, testItem.CustomerBusinessName, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerContactName, testItem.CustomerContactName, false);         // "Colin Middleton"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine1, testItem.CustomerAddressLine1, false);       // "257 Ecclesall Road"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine2, testItem.CustomerAddressLine2, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressLine3, testItem.CustomerAddressLine3, false);       // "Sheffield"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine4, testItem.CustomerAddressLine4, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressTown, testItem.CustomerAddressTown, false);         // "Sheffield"
            Assert.AreEqual(SampleOrder1.CustomerAddressCounty, testItem.CustomerAddressCounty, false);     // "South Yorkshire"
            Assert.AreEqual(SampleOrder1.CustomerCountryCode, testItem.CustomerCountryCode, false);         // "GB"
            Assert.AreEqual(SampleOrder1.CustomerAddressPostcode, testItem.CustomerAddressPostcode, false); // "S5 7HJ"
            Assert.AreEqual(SampleOrder1.CustomerPhoneNumber, testItem.CustomerPhoneNumber, false);         // "7505363818"
            Assert.AreEqual(SampleOrder1.CustomerEmailAddress, testItem.CustomerEmailAddress, false);       // "colin@test.com"
            Assert.AreEqual(SampleOrder1.CustomerVatNumber, testItem.CustomerVatNumber, false);             // ""
        }
        #endregion

        #region ShipmentInformationTests
        /// <summary>
        /// shipmentInformation instance can be created.
        /// </summary>
        [TestMethod()]
        public void ShipmentInformationAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddShipmentInformation();

            Assert.AreEqual("", testItem.CustomsDescriptionOfGoods, false);
        }

        /// <summary>
        /// Creates one and only one shipmentInformation instance.
        /// </summary>
        [TestMethod()]
        public void ShipmentInformationAddTwiceTest()
        {
            RoyalMailData testItem = null;

            try
            {
                testItem = new RoyalMailData();
                testItem.AddShipmentInformation();
                testItem.AddShipmentInformation();

            }
            catch (DuplicateWaitObjectException e)
            {
                Console.WriteLine("An error has occured: " + e.Message);
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("", testItem.CustomsDescriptionOfGoods, false);
        }

        /// <summary>
        /// shipmentInformation instance is created with the correct data.
        /// </summary>
        [TestMethod()]
        public void ShipmentInformationAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddShipmentInformation(SampleOrder1.PostingDate,               // 16/01/2022
                                            SampleOrder1.PostageType,               // "TPLN"
                                            SampleOrder1.PostingWeightUOM,          // "KG"
                                            SampleOrder1.CustomsProduct,            // "LEGO"
                                            SampleOrder1.CustomsDescriptionOfGoods, // "LEGO sets"
                                            SampleOrder1.CustomsReasonForExport,    // "Sale of goods"
                                            SampleOrder1.CustomsValue,              // 112.97
                                            SampleOrder1.CustomsCurrency,           // "GBP"
                                            SampleOrder1.CustomsIncoterms,          // "DDU"
                                            SampleOrder1.CustomsLabelFormat,        // "PDF"
                                            SampleOrder1.CustomsSilentPrintProfile, // "75b59db8-3cd3-4578-888e-54be016f07cc"
                                            SampleOrder1.CustomsShipmentAction);    // "Process"

            Assert.AreEqual(SampleOrder1.PostingDate.ToString(), testItem.PostingDate.ToString(), false);       // 16/01/2023
            Assert.AreEqual(SampleOrder1.PostageType, testItem.PostageType, false);                             // "TPLN"
            Assert.AreEqual(0, testItem.PostingTotalPackages, 0);                                               // No packages have been added
            Assert.AreEqual(0, testItem.PostingTotalWeight, 0);                                                 // No packages have been added
            Assert.AreEqual(SampleOrder1.PostingWeightUOM, testItem.PostingWeightUOM, false);                   // "KG"
            Assert.AreEqual(SampleOrder1.CustomsProduct, testItem.CustomsProduct, false);                       // "LEGO"
            Assert.AreEqual(SampleOrder1.CustomsDescriptionOfGoods, testItem.CustomsDescriptionOfGoods, false); // "LEGO sets"
            Assert.AreEqual(SampleOrder1.CustomsReasonForExport, testItem.CustomsReasonForExport, false);       // "Sale of goods"
            Assert.AreEqual(SampleOrder1.CustomsValue, testItem.CustomsValue, 0);                               // 112.97
            Assert.AreEqual(SampleOrder1.CustomsCurrency, testItem.CustomsCurrency, false);                     // "GBP"
            Assert.AreEqual(SampleOrder1.CustomsIncoterms, testItem.CustomsIncoterms, false);                   // "DDU"
            Assert.AreEqual(SampleOrder1.CustomsLabelFormat, testItem.CustomsLabelFormat, false);               // "PDF"
            Assert.AreEqual(SampleOrder1.CustomsSilentPrintProfile, testItem.CustomsSilentPrintProfile, false); // "75b59db8-3cd3-4578-888e-54be016f07cc"
            Assert.AreEqual(SampleOrder1.CustomsShipmentAction, testItem.CustomsShipmentAction, false);         // "Process"
        }

        /// <summary>
        /// shipmentInformation instance can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void ShipmentInformationUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddShipmentInformation();

            testItem.PostingDate = SampleOrder1.PostingDate;                                // 16/01/2023
            testItem.PostageType = SampleOrder1.PostageType;                                // "TPLN"
            testItem.PostingWeightUOM = SampleOrder1.PostingWeightUOM;                      // "KG"
            testItem.CustomsProduct = SampleOrder1.CustomsProduct;                          // "LEGO"
            testItem.CustomsDescriptionOfGoods = SampleOrder1.CustomsDescriptionOfGoods;    // "LEGO sets"
            testItem.CustomsReasonForExport = SampleOrder1.CustomsReasonForExport;          // "Sale of goods"
            testItem.CustomsValue = SampleOrder1.CustomsValue;                              // 112.97
            testItem.CustomsCurrency = SampleOrder1.CustomsCurrency;                        // "GBP"
            testItem.CustomsIncoterms = SampleOrder1.CustomsIncoterms;                      // "DDU"
            testItem.CustomsLabelFormat = SampleOrder1.CustomsLabelFormat;                  // "PDF"
            testItem.CustomsSilentPrintProfile = SampleOrder1.CustomsSilentPrintProfile;    // "75b59db8-3cd3-4578-888e-54be016f07cc"
            testItem.CustomsShipmentAction = SampleOrder1.CustomsShipmentAction;            // "Process"

            Assert.AreEqual(SampleOrder1.PostingDate.ToString(), testItem.PostingDate.ToString(), false);       // 16/01/2023
            Assert.AreEqual(SampleOrder1.PostageType, testItem.PostageType, false);                             // "TPLN"
            Assert.AreEqual(0, testItem.PostingTotalPackages, 0);                                               // No packages have been added
            Assert.AreEqual(0, testItem.PostingTotalWeight, 0);                                                 // No packages have been added
            Assert.AreEqual(SampleOrder1.PostingWeightUOM, testItem.PostingWeightUOM, false);                   // "KG"
            Assert.AreEqual(SampleOrder1.CustomsProduct, testItem.CustomsProduct, false);                       // "LEGO"
            Assert.AreEqual(SampleOrder1.CustomsDescriptionOfGoods, testItem.CustomsDescriptionOfGoods, false); // "LEGO sets"
            Assert.AreEqual(SampleOrder1.CustomsReasonForExport, testItem.CustomsReasonForExport, false);       // "Sale of goods"
            Assert.AreEqual(SampleOrder1.CustomsValue, testItem.CustomsValue, 0);                               // 112.97
            Assert.AreEqual(SampleOrder1.CustomsCurrency, testItem.CustomsCurrency, false);                     // "GBP"
            Assert.AreEqual(SampleOrder1.CustomsIncoterms, testItem.CustomsIncoterms, false);                   // "DDU"
            Assert.AreEqual(SampleOrder1.CustomsLabelFormat, testItem.CustomsLabelFormat, false);               // "PDF"
            Assert.AreEqual(SampleOrder1.CustomsSilentPrintProfile, testItem.CustomsSilentPrintProfile, false); // "75b59db8-3cd3-4578-888e-54be016f07cc"
            Assert.AreEqual(SampleOrder1.CustomsShipmentAction, testItem.CustomsShipmentAction, false);         // "Process"
        }
        #endregion

        #region ServiceOptionTests
        /// <summary>
        /// serviceOption instance can be created.
        /// </summary>
        [TestMethod()]
        public void ServiceOptionAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddServiceOption();

            Assert.AreEqual("", testItem.PostingServiceFormat);
        }

        /// <summary>
        /// Creates one and only one serviceOption instance.
        /// </summary>
        [TestMethod()]
        public void ServiceOptionAddTwiceTest()
        {
            RoyalMailData testItem = null;

            try
            {
                testItem = new RoyalMailData();
                testItem.AddServiceOption();
                testItem.AddServiceOption();

            }
            catch (DuplicateWaitObjectException e)
            {
                Console.WriteLine("An error has occured: " + e.Message);
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("", testItem.PostingServiceFormat);
        }

        /// <summary>
        /// serviceOption instance is created with the correct data.
        /// </summary>
        [TestMethod()]
        public void ServiceOptionAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddServiceOption(SampleOrder1.PostingLocation,             // "123456789"
                                    SampleOrder1.PostingServiceLevel,           // "01"
                                    SampleOrder1.PostingServiceFormat,          // "P"
                                    SampleOrder1.CustomerSafeplace,             // "Front Porch"
                                    SampleOrder1.PostingSaturdayGuaranteed,     // false
                                    SampleOrder1.PostingConsequentialLoss,      // "Level5"
                                    SampleOrder1.PostingLocalCollect,           // false
                                    SampleOrder1.PostingTrackingNotifications,  // "EmailAndSMS"
                                    SampleOrder1.PostingRecordedSignedFor);     // false

            Assert.AreEqual(SampleOrder1.PostingLocation, testItem.PostingLocation, false);                             // "123456789"
            Assert.AreEqual(SampleOrder1.PostingServiceLevel, testItem.PostingServiceLevel, false);                     // "01"
            Assert.AreEqual(SampleOrder1.PostingServiceFormat, testItem.PostingServiceFormat, false);                   // "P"
            Assert.AreEqual(SampleOrder1.CustomerSafeplace, testItem.CustomerSafeplace, false);                         // "Front Porch"
            Assert.AreEqual(SampleOrder1.PostingSaturdayGuaranteed, testItem.PostingSaturdayGuaranteed);                // false
            Assert.AreEqual(SampleOrder1.PostingConsequentialLoss, testItem.PostingConsequentialLoss, false);           // "Level5"
            Assert.AreEqual(SampleOrder1.PostingLocalCollect, testItem.PostingLocalCollect);                            // false
            Assert.AreEqual(SampleOrder1.PostingTrackingNotifications, testItem.PostingTrackingNotifications, false);   // "EmailAndSMS"
            Assert.AreEqual(SampleOrder1.PostingRecordedSignedFor, testItem.PostingRecordedSignedFor);                  // false
        }

        /// <summary>
        /// serviceOption instance can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void ServiceOptionUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddServiceOption();
            testItem.PostingLocation = SampleOrder1.PostingLocation;                            // "123456789";
            testItem.PostingServiceLevel = SampleOrder1.PostingServiceLevel;                    // "01";
            testItem.PostingServiceFormat = SampleOrder1.PostingServiceFormat;                  // "P";
            testItem.CustomerSafeplace = SampleOrder1.CustomerSafeplace;                        // "Front Porch";
            testItem.PostingSaturdayGuaranteed = SampleOrder1.PostingSaturdayGuaranteed;        // false;
            testItem.PostingConsequentialLoss = SampleOrder1.PostingConsequentialLoss;          // "Level5";
            testItem.PostingLocalCollect = SampleOrder1.PostingLocalCollect;                    // false;
            testItem.PostingTrackingNotifications = SampleOrder1.PostingTrackingNotifications;  // "EmailAndSMS";
            testItem.PostingRecordedSignedFor = SampleOrder1.PostingRecordedSignedFor;          // false;

            Assert.AreEqual(SampleOrder1.PostingLocation, testItem.PostingLocation, false);                             // "123456789"
            Assert.AreEqual(SampleOrder1.PostingServiceLevel, testItem.PostingServiceLevel, false);                     // "01"
            Assert.AreEqual(SampleOrder1.PostingServiceFormat, testItem.PostingServiceFormat, false);                   // "P"
            Assert.AreEqual(SampleOrder1.CustomerSafeplace, testItem.CustomerSafeplace, false);                         // "Front Porch"
            Assert.AreEqual(SampleOrder1.PostingSaturdayGuaranteed, testItem.PostingSaturdayGuaranteed);                // false
            Assert.AreEqual(SampleOrder1.PostingConsequentialLoss, testItem.PostingConsequentialLoss, false);           // "Level5"
            Assert.AreEqual(SampleOrder1.PostingLocalCollect, testItem.PostingLocalCollect);                            // false
            Assert.AreEqual(SampleOrder1.PostingTrackingNotifications, testItem.PostingTrackingNotifications, false);   // "EmailAndSMS"
            Assert.AreEqual(SampleOrder1.PostingRecordedSignedFor, testItem.PostingRecordedSignedFor);                  // false
        }
        #endregion

        #region PackageTests
        /// <summary>
        /// package instance can be created.
        /// </summary>
        [TestMethod()]
        public void PackageAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddParcel();

            Assert.AreEqual(0, testItem.ParcelLength);
        }

        /// <summary>
        /// Creates two package instances.
        /// </summary>
        [TestMethod()]
        public void PackageAddTwiceTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddParcel();
            testItem.AddParcel();

            testItem.FindFirstParcel();
            Assert.AreEqual(0, testItem.ParcelLength);
            testItem.FindSpecificParcel(1);
            Assert.AreEqual(0, testItem.ParcelLength);
        }

        /// <summary>
        /// 2 package instances are created with the correct data.
        /// </summary>
        [TestMethod()]
        public void PackageAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddParcel(1,
                "17968198-1",
                2.2,
                15,
                15,
                5);
            testItem.AddParcel(2,
                "17968198-2",
                0.9,
                45,
                10,
                3);

            testItem.FindFirstParcel();
            Assert.AreEqual(testItem.ParcelInstance, 1, 0);
            Assert.AreEqual(testItem.ParcelId, "17968198-1", true);
            Assert.AreEqual(testItem.ParcelWeight, 2.2, 0);
            Assert.AreEqual(testItem.ParcelLength, 15, 0);
            Assert.AreEqual(testItem.ParcelWidth, 15, 0);
            Assert.AreEqual(testItem.ParcelHeight, 5, 0);

            testItem.FindNextParcel();
            Assert.AreEqual(testItem.ParcelInstance, 2, 0);
            Assert.AreEqual(testItem.ParcelId, "17968198-2", true);
            Assert.AreEqual(testItem.ParcelWeight, 0.9, 0);
            Assert.AreEqual(testItem.ParcelLength, 45, 0);
            Assert.AreEqual(testItem.ParcelWidth, 10, 0);
            Assert.AreEqual(testItem.ParcelHeight, 3, 0);
        }

        /// <summary>
        /// both package instances can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void PackageUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddParcel();
            testItem.ParcelInstance = 1;
            testItem.ParcelId = "17968198-1";
            testItem.ParcelWeight = 2.2;
            testItem.ParcelLength = 15;
            testItem.ParcelWidth = 15;
            testItem.ParcelHeight = 5;

            testItem.AddParcel();
            testItem.ParcelInstance = 2;
            testItem.ParcelId = "17968198-2";
            testItem.ParcelWeight = 0.9;
            testItem.ParcelLength = 45;
            testItem.ParcelWidth = 10;
            testItem.ParcelHeight = 3;

            testItem.FindFirstParcel();
            Assert.AreEqual(testItem.ParcelInstance, 1, 0);
            Assert.AreEqual(testItem.ParcelId, "17968198-1", true);
            Assert.AreEqual(testItem.ParcelWeight, 2.2, 0);
            Assert.AreEqual(testItem.ParcelLength, 15, 0);
            Assert.AreEqual(testItem.ParcelWidth, 15, 0);
            Assert.AreEqual(testItem.ParcelHeight, 5, 0);

            testItem.FindNextParcel();
            Assert.AreEqual(testItem.ParcelInstance, 2, 0);
            Assert.AreEqual(testItem.ParcelId, "17968198-2", true);
            Assert.AreEqual(testItem.ParcelWeight, 0.9, 0);
            Assert.AreEqual(testItem.ParcelLength, 45, 0);
            Assert.AreEqual(testItem.ParcelWidth, 10, 0);
            Assert.AreEqual(testItem.ParcelHeight, 3, 0);
        }
        #endregion

        #region ItemTests
        /// <summary>
        /// item instance can be created.
        /// </summary>
        [TestMethod()]
        public void ItemAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddItem();

            Assert.AreEqual("", testItem.ItemDescription, false);
        }

        /// <summary>
        /// Creates two item instances.
        /// </summary>
        [TestMethod()]
        public void ItemAddTwiceTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddItem();
            testItem.AddItem();

            testItem.FindFirstItem();
            Assert.AreEqual("", testItem.ItemDescription, false);
            testItem.FindSpecificItem(1);
            Assert.AreEqual("", testItem.ItemDescription, false);
        }

        /// <summary>
        /// 2 item instances are created with the correct data.
        /// </summary>
        [TestMethod()]
        public void ItemAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddItem("10782",
                    1,
                    2,
                    "Hulk vs. Rhino Truck Showdown",
                    17.99,
                    0.9,
                    "652534",
                    "SKU3455692",
                    "GB",
                    "https://images.brickset.com/sets/large/10782-1.jpg?202109211242");
            testItem.AddItem("76205",
                    1,
                    1,
                    "Gargantos Showdown",
                    24.99,
                    1.0,
                    "652584",
                    "SKU3455682",
                    "GB",
                    "https://images.brickset.com/sets/images/76205-1.jpg?202109211239");

            testItem.FindFirstItem();
            Assert.AreEqual(testItem.ItemId, "10782", false);
            Assert.AreEqual(testItem.ItemQuantity, 1, 0);
            Assert.AreEqual(testItem.ItemDescription, "Hulk vs. Rhino Truck Showdown", false);
            Assert.AreEqual(testItem.ItemValue, 17.99, 0);
            Assert.AreEqual(testItem.ItemWeight, 0.9, 0);
            Assert.AreEqual(testItem.ItemParcelInstance, 2, 0);
            Assert.AreEqual(testItem.ItemHsCode, "652534", false);
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3455692", false);
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "GB", false);
            Assert.AreEqual(testItem.ItemImageUrl, "https://images.brickset.com/sets/large/10782-1.jpg?202109211242", false);

            testItem.FindNextItem();
            Assert.AreEqual(testItem.ItemId, "76205", false);
            Assert.AreEqual(testItem.ItemQuantity, 1, 0);
            Assert.AreEqual(testItem.ItemDescription, "Gargantos Showdown", false);
            Assert.AreEqual(testItem.ItemValue, 24.99, 0);
            Assert.AreEqual(testItem.ItemWeight, 1.0, 0);
            Assert.AreEqual(testItem.ItemParcelInstance, 1, 0);
            Assert.AreEqual(testItem.ItemHsCode, "652584", false);
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3455682", false);
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "GB", false);
            Assert.AreEqual(testItem.ItemImageUrl, "https://images.brickset.com/sets/images/76205-1.jpg?202109211239", false);
        }

        /// <summary>
        /// both item instances can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void ItemUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddItem();
            testItem.ItemId = "10782";
            testItem.ItemQuantity = 1;
            testItem.ItemDescription = "Hulk vs. Rhino Truck Showdown";
            testItem.ItemValue = 17.99;
            testItem.ItemWeight = 0.9;
            testItem.ItemParcelInstance = 2;
            testItem.ItemHsCode = "652534";
            testItem.ItemSkuCode = "SKU3455692";
            testItem.ItemCountryOfOrigin = "GB";
            testItem.ItemImageUrl = "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";

            testItem.AddItem();
            testItem.ItemId = "76205";
            testItem.ItemQuantity = 1;
            testItem.ItemDescription = "Gargantos Showdown";
            testItem.ItemValue = 24.99;
            testItem.ItemWeight = 1.0;
            testItem.ItemParcelInstance = 1;
            testItem.ItemHsCode = "652584";
            testItem.ItemSkuCode = "SKU3455682";
            testItem.ItemCountryOfOrigin = "GB";
            testItem.ItemImageUrl = "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";

            testItem.FindFirstItem();
            Assert.AreEqual(testItem.ItemId, "10782", false);
            Assert.AreEqual(testItem.ItemQuantity, 1, 0);
            Assert.AreEqual(testItem.ItemDescription, "Hulk vs. Rhino Truck Showdown", false);
            Assert.AreEqual(testItem.ItemValue, 17.99, 0);
            Assert.AreEqual(testItem.ItemWeight, 0.9, 0);
            Assert.AreEqual(testItem.ItemParcelInstance, 2, 0);
            Assert.AreEqual(testItem.ItemHsCode, "652534", false);
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3455692", false);
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "GB", false);
            Assert.AreEqual(testItem.ItemImageUrl, "https://images.brickset.com/sets/large/10782-1.jpg?202109211242", false);

            testItem.FindNextItem();
            Assert.AreEqual(testItem.ItemId, "76205", false);
            Assert.AreEqual(testItem.ItemQuantity, 1, 0);
            Assert.AreEqual(testItem.ItemDescription, "Gargantos Showdown", false);
            Assert.AreEqual(testItem.ItemValue, 24.99, 0);
            Assert.AreEqual(testItem.ItemWeight, 1.0, 0);
            Assert.AreEqual(testItem.ItemParcelInstance, 1, 0);
            Assert.AreEqual(testItem.ItemHsCode, "652584", false);
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3455682", false);
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "GB", false);
            Assert.AreEqual(testItem.ItemImageUrl, "https://images.brickset.com/sets/images/76205-1.jpg?202109211239", false);
        }
        #endregion

        #region CustomsInformationTests
        /// <summary>
        /// customsInformation instance can be created.
        /// </summary>
        [TestMethod()]
        public void CustomsInformationAddBlankTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            testItem.AddCustomsInformation();

            Assert.AreEqual("", testItem.CustomsPreRegistrationType, false);
        }

        /// <summary>
        /// Creates one and only one customsInformation instance.
        /// </summary>
        [TestMethod()]
        public void CustomsInformationAddTwiceTest()
        {
            RoyalMailData testItem = null;

            try
            {
                testItem = new RoyalMailData();
                testItem.AddCustomsInformation();
                testItem.AddCustomsInformation();
            }
            catch (DuplicateWaitObjectException e)
            {
                Console.WriteLine("An error has occured: " + e.Message);
            }
            catch
            {
                throw;
            }

            Assert.AreEqual("", testItem.CustomsPreRegistrationType, false);
        }

        /// <summary>
        /// customsInformation instance is created with the correct data.
        /// </summary>
        [TestMethod()]
        public void CustomsInformationAddPopulatedTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            DateTime justDate = new DateTime(2022, 01, 16);
            testItem.AddCustomsInformation("GB15748250",
                "EORI",
                10.42,
                0.00,
                0.00,
                15748250,
                justDate,
                false,
                1234567890);

            Assert.AreEqual("GB15748250", testItem.CustomsPreRegistrationNumber, false);
            Assert.AreEqual("EORI", testItem.CustomsPreRegistrationType, false);
            Assert.AreEqual(10.42, testItem.CustomsShippingCharges, 0);
            Assert.AreEqual(0.00, testItem.CustomsOtherCharges, 0);
            Assert.AreEqual(0.00, testItem.CustomsQuotedLandedCost, 0);
            Assert.AreEqual("15748250", testItem.CustomsInvoiceNumber, false);
            Assert.AreEqual(justDate.ToString(), testItem.CustomsInvoiceDate.ToString(), false);
            Assert.IsFalse(testItem.CustomsExportLicence);
            Assert.AreEqual(1234567890, testItem.AddresseeIdentificationReferenceNumber, 0);
        }

        /// <summary>
        /// customsInformation instance can be populated with the correct data.
        /// </summary>
        [TestMethod()]
        public void CustomsInformationUpdateTest()
        {
            RoyalMailData testItem;

            testItem = new RoyalMailData();
            DateTime justDate = new DateTime(2022, 01, 16);

            testItem.AddCustomsInformation();
            testItem.CustomsPreRegistrationNumber = "GB15748250";
            testItem.CustomsPreRegistrationType = "EORI";
            testItem.CustomsShippingCharges = 10.42;
            testItem.CustomsOtherCharges = 0.00;
            testItem.CustomsQuotedLandedCost = 0.00;
            testItem.CustomsInvoiceNumber = "15748250";
            testItem.CustomsInvoiceDate = justDate;
            testItem.CustomsExportLicence = false;
            testItem.AddresseeIdentificationReferenceNumber = 1234567890;

            Assert.AreEqual("GB15748250", testItem.CustomsPreRegistrationNumber, false);
            Assert.AreEqual("EORI", testItem.CustomsPreRegistrationType, false);
            Assert.AreEqual(10.42, testItem.CustomsShippingCharges, 0);
            Assert.AreEqual(0.00, testItem.CustomsOtherCharges, 0);
            Assert.AreEqual(0.00, testItem.CustomsQuotedLandedCost, 0);
            Assert.AreEqual("15748250", testItem.CustomsInvoiceNumber, false);
            Assert.AreEqual(justDate.ToString(), testItem.CustomsInvoiceDate.ToString(), false);
            Assert.IsFalse(testItem.CustomsExportLicence);
            Assert.AreEqual(1234567890, testItem.AddresseeIdentificationReferenceNumber, 0);
        }
        #endregion

        #region PostOfficeDataTests
        /// <summary>
        /// postOfficeData instance is created with all sub classes from inputs.
        /// </summary>
        [TestMethod()]
        public void PostOfficeDataTest()
        {
            RoyalMailData testItem;

            DateTime justDate = new DateTime(2022, 01, 16);

            testItem = new RoyalMailData(SampleOrder1.SupplierId,       // "bricksinbloom7308"
                                SampleOrder1.SupplierReference1,        // "7308"
                                SampleOrder1.SupplierReference2,        // "BrickLink"
                                SampleOrder1.Department,                // 7308
                                SampleOrder1.SupplierBusinessName,      // "Bricks In Bloom"
                                SampleOrder1.SupplierContactName,       // "Leigha Middleton"
                                SampleOrder1.SupplierAddressLine1,      // "Unit 4"
                                SampleOrder1.SupplierAddressLine2,      // "Candy Works"
                                SampleOrder1.SupplierAddressLine3,      // "15 Parkhouse Road"
                                SampleOrder1.SupplierAddressTown,       // "Carlisle"
                                SampleOrder1.SupplierAddressCounty,     // "Cumbria"
                                SampleOrder1.SupplierCountryCode,       // "GB"
                                SampleOrder1.SupplierAddressPostcode,   // "CA3 0JU"
                                SampleOrder1.SupplierPhoneNumber,       // "1228511030"
                                SampleOrder1.SupplierEmailAddress,      // "bricksinbloom@bricklink.com"
                                SampleOrder1.SupplierVatNumber,         // "GB123 4567 89"
                                SampleOrder1.CustomerId,                // "BL15748250"
                                SampleOrder1.CustomerBusinessName,      // ""
                                SampleOrder1.CustomerContactName,       // "Colin Middleton"
                                SampleOrder1.CustomerAddressLine1,      // "257 Ecclesall Road"
                                SampleOrder1.CustomerAddressLine2,      // ""
                                SampleOrder1.CustomerAddressLine3,      // "Sheffield"
                                SampleOrder1.CustomerAddressTown,       // ""
                                SampleOrder1.CustomerAddressCounty,     // "South Yorkshire"
                                SampleOrder1.CustomerCountryCode,       // "GB"
                                SampleOrder1.CustomerAddressPostcode,   // "S5 7HJ"
                                SampleOrder1.CustomerPhoneNumber,       // "7505363818"
                                SampleOrder1.CustomerEmailAddress,      // "colin@test.com"
                                SampleOrder1.CustomerVatNumber,         // ""
                                SampleOrder1.PostingDate,               // 16/01/2022
                                SampleOrder1.PostageType,               // "TPLN"
                                SampleOrder1.PostingWeightUOM,          // "KG"
                                SampleOrder1.CustomsProduct,            // "LEGO"
                                SampleOrder1.CustomsDescriptionOfGoods, // "LEGO sets"
                                SampleOrder1.CustomsReasonForExport,    // "Sale of goods"
                                SampleOrder1.CustomsValue,              // 112.97
                                SampleOrder1.CustomsCurrency,           // "GBP"
                                SampleOrder1.CustomsIncoterms,          // "DDU"
                                SampleOrder1.CustomsLabelFormat,        // "PDF"
                                SampleOrder1.CustomsSilentPrintProfile, // "75b59db8-3cd3-4578-888e-54be016f07cc"
                                SampleOrder1.CustomsShipmentAction,     // "Process"
                                SampleOrder1.PostingLocation,           // "123456789"
                                SampleOrder1.PostingServiceLevel,       // "01"
                                SampleOrder1.PostingServiceFormat,      // "P"
                                SampleOrder1.CustomerSafeplace,         // "Front Porch"
                                SampleOrder1.PostingSaturdayGuaranteed, // false
                                SampleOrder1.PostingConsequentialLoss,  // "Level5"
                                SampleOrder1.PostingLocalCollect,       // false
                                SampleOrder1.PostingTrackingNotifications,  // "EmailAndSMS"
                                SampleOrder1.PostingRecordedSignedFor,  // false
            "GB15748250",
                "EORI",
                10.42,
                0.00,
                0.00,
                15748250,
                justDate,
                false,
                1234567890);

            Assert.AreEqual(SampleOrder1.SupplierId, testItem.SupplierId, false);                           // "bricksinbloom7308"
            Assert.AreEqual(SampleOrder1.SupplierReference1, testItem.SupplierReference1, false);           // "7308"
            Assert.AreEqual(SampleOrder1.SupplierReference2, testItem.SupplierReference2, false);           // "BrickLink"
            Assert.AreEqual(SampleOrder1.Department, testItem.Department, 0);                               // 7380
            Assert.AreEqual(SampleOrder1.SupplierBusinessName, testItem.SupplierBusinessName, false);       // "Bricks In Bloom"
            Assert.AreEqual(SampleOrder1.SupplierContactName, testItem.SupplierContactName, false);         //"Leigha Middleton"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine1, testItem.SupplierAddressLine1, false);       // "Unit 4"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine2, testItem.SupplierAddressLine2, false);       // "Candy Works"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine3, testItem.SupplierAddressLine3, false);       // "15 Parkhouse Road"
            Assert.AreEqual(SampleOrder1.SupplierAddressLine4, testItem.SupplierAddressLine4, false);       // ""
            Assert.AreEqual(SampleOrder1.SupplierAddressTown, testItem.SupplierAddressTown, false);         // "Carlisle"
            Assert.AreEqual(SampleOrder1.SupplierAddressCounty, testItem.SupplierAddressCounty, false);     // "Cumbria"
            Assert.AreEqual(SampleOrder1.SupplierCountryCode, testItem.SupplierCountryCode, false);         // "GB"
            Assert.AreEqual(SampleOrder1.SupplierAddressPostcode, testItem.SupplierAddressPostcode, false); // "CA3 0JU"
            Assert.AreEqual(SampleOrder1.SupplierPhoneNumber, testItem.SupplierPhoneNumber, false);         // "1228511030"
            Assert.AreEqual(SampleOrder1.SupplierEmailAddress, testItem.SupplierEmailAddress, false);       // "bricksinbloom@bricklink.com"
            Assert.AreEqual(SampleOrder1.SupplierVatNumber, testItem.SupplierVatNumber, false);             // "GB123 4567 89"

            Assert.AreEqual(SampleOrder1.CustomerId, testItem.CustomerId, false);                           // "BL15748250"
            Assert.AreEqual(SampleOrder1.CustomerBusinessName, testItem.CustomerBusinessName, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerContactName, testItem.CustomerContactName, false);         // "Colin Middleton"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine1, testItem.CustomerAddressLine1, false);       // "257 Ecclesall Road"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine2, testItem.CustomerAddressLine2, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressLine3, testItem.CustomerAddressLine3, false);       // "Sheffield"
            Assert.AreEqual(SampleOrder1.CustomerAddressLine4, testItem.CustomerAddressLine4, false);       // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressTown, testItem.CustomerAddressTown, false);         // ""
            Assert.AreEqual(SampleOrder1.CustomerAddressCounty, testItem.CustomerAddressCounty, false);     // "South Yorkshire"
            Assert.AreEqual(SampleOrder1.CustomerCountryCode, testItem.CustomerCountryCode, false);         // "GB"
            Assert.AreEqual(SampleOrder1.CustomerAddressPostcode, testItem.CustomerAddressPostcode, false); // "S5 7HJ"
            Assert.AreEqual(SampleOrder1.CustomerPhoneNumber, testItem.CustomerPhoneNumber, false);         // "7505363818"
            Assert.AreEqual(SampleOrder1.CustomerEmailAddress, testItem.CustomerEmailAddress, false);       // "colin@test.com"
            Assert.AreEqual(SampleOrder1.CustomerVatNumber, testItem.CustomerVatNumber, false);             // ""

            Assert.AreEqual(SampleOrder1.PostingDate.ToString(), testItem.PostingDate.ToString(), false);       // 16/01/2023
            Assert.AreEqual(SampleOrder1.PostageType, testItem.PostageType, false);                             // "TPLN"
            Assert.AreEqual(0, testItem.PostingTotalPackages, 0);                                               // No packages have been added
            Assert.AreEqual(0, testItem.PostingTotalWeight, 0);                                                 // No packages have been added
            Assert.AreEqual(SampleOrder1.PostingWeightUOM, testItem.PostingWeightUOM, false);                   // "KG"
            Assert.AreEqual(SampleOrder1.CustomsProduct, testItem.CustomsProduct, false);                       // "LEGO"
            Assert.AreEqual(SampleOrder1.CustomsDescriptionOfGoods, testItem.CustomsDescriptionOfGoods, false); // "LEGO sets"
            Assert.AreEqual(SampleOrder1.CustomsReasonForExport, testItem.CustomsReasonForExport, false);       // "Sale of goods"
            Assert.AreEqual(SampleOrder1.CustomsValue, testItem.CustomsValue, 0);                               // 112.97
            Assert.AreEqual(SampleOrder1.CustomsCurrency, testItem.CustomsCurrency, false);                     // "GBP"
            Assert.AreEqual(SampleOrder1.CustomsIncoterms, testItem.CustomsIncoterms, false);                   // "DDU"
            Assert.AreEqual(SampleOrder1.CustomsLabelFormat, testItem.CustomsLabelFormat, false);               // "PDF"
            Assert.AreEqual(SampleOrder1.CustomsSilentPrintProfile, testItem.CustomsSilentPrintProfile, false); // "75b59db8-3cd3-4578-888e-54be016f07cc"
            Assert.AreEqual(SampleOrder1.CustomsShipmentAction, testItem.CustomsShipmentAction, false);         // "Process"

            Assert.AreEqual(SampleOrder1.PostingLocation, testItem.PostingLocation, false);                             // "123456789"
            Assert.AreEqual(SampleOrder1.PostingServiceLevel, testItem.PostingServiceLevel, false);                     // "01"
            Assert.AreEqual(SampleOrder1.PostingServiceFormat, testItem.PostingServiceFormat, false);                   // "P"
            Assert.AreEqual(SampleOrder1.CustomerSafeplace, testItem.CustomerSafeplace, false);                         // "Front Porch"
            Assert.AreEqual(SampleOrder1.PostingSaturdayGuaranteed, testItem.PostingSaturdayGuaranteed);                // false
            Assert.AreEqual(SampleOrder1.PostingConsequentialLoss, testItem.PostingConsequentialLoss, false);           // "Level5"
            Assert.AreEqual(SampleOrder1.PostingLocalCollect, testItem.PostingLocalCollect);                            // false
            Assert.AreEqual(SampleOrder1.PostingTrackingNotifications, testItem.PostingTrackingNotifications, false);   // "EmailAndSMS"
            Assert.AreEqual(SampleOrder1.PostingRecordedSignedFor, testItem.PostingRecordedSignedFor);                  // false

            Assert.AreEqual("GB15748250", testItem.CustomsPreRegistrationNumber, false);
            Assert.AreEqual("EORI", testItem.CustomsPreRegistrationType, false);
            Assert.AreEqual(10.42, testItem.CustomsShippingCharges, 0);
            Assert.AreEqual(0.00, testItem.CustomsOtherCharges, 0);
            Assert.AreEqual(0.00, testItem.CustomsQuotedLandedCost, 0);
            Assert.AreEqual("15748250", testItem.CustomsInvoiceNumber, false);
            Assert.AreEqual(justDate.ToString(), testItem.CustomsInvoiceDate.ToString(), false);
            Assert.IsFalse(testItem.CustomsExportLicence);
            Assert.AreEqual(1234567890, testItem.AddresseeIdentificationReferenceNumber, 0);

        }

        ///// <summary>
        ///// postOfficeData instance can be created with all sub classes from an object.
        ///// </summary>
        //[TestMethod()]
        //public void PostOfficeDataTestFromObject()
        //{

        //}

        ///// <summary>
        ///// postOfficeData instance can be created with all sub classes from as JSON.
        ///// </summary>
        //[TestMethod()]
        //public void PostOfficeDataTestFromJSON()
        //{

        //}
        #endregion

        #region OutputTests
        /// <summary>
        /// A postOfficeData instance can be output as a JSON correctly.
        /// </summary>
        [TestMethod()]
        public void MakeJsonTest()
        {
            string testJson = "{";
            testJson += "\"Shipper\":";
            testJson += "{";
            testJson += "\"AddressId\":\"bricksinbloom7308\",\"ShipperReference\":\"7308\",";
            testJson += "\"ShipperReference2\":\"BrickLink\",\"ShipperDepartment\":\"7308\",";
            testJson += "\"CompanyName\":\"Bricks In  Bloom\",\"ContactName\":\"Leigha Middleton\",";
            testJson += "\"AddressLine1\":\"Unit 4\",\"AddressLine2\":\"Candy Works\",";
            testJson += "\"AddressLine3\":\"15 Parkhouse Road\",\"Town\":\"Carlisle\",";
            testJson += "\"County\":\"Cumbria\",\"CountryCode\":\"GB\",\"Postcode\":\"CA3 0JU\",";
            testJson += "\"PhoneNumber\":\"1228 511030\",\"EmailAddress\":\"bricksinbloom@bricklink.com\",";
            testJson += "\"VatNumber\":\"GB123 4567 89\"";
            testJson += "},";
            testJson += "\"Destination\":";
            testJson += "{";
            testJson += "\"AddressId\":\"BL15748250\",\"CompanyName\":\"\",";
            testJson += "\"ContactName\":\"Colin Middleton\",\"AddressLine1\":\"257 Ecclesall Road\",";
            testJson += "\"AddressLine2\":\"\",\"AddressLine3\":\"\",\"Town\":\"Sheffield\",";
            testJson += "\"County\":\"South Yorkshire\",\"CountryCode\":\"GB\",";
            testJson += "\"Postcode\":\"S5 7HJ\",\"PhoneNumber\":\"7505363818\",";
            testJson += "\"EmailAddress\":\"colin@test.com\",\"VatNumber\":\"\"";
            testJson += "},";
            testJson += "\"ShipmentInformation\":";
            testJson += "{";
            testJson += "\"ShipmentDate\":\"2022-01-16\",\"ServiceCode\":\"TPLN\",";
            testJson += "\"ServiceOptions\":";
            testJson += "{";
            testJson += "\"PostingLocation\":\"123456789\",\"ServiceLevel\":\"01\",";
            testJson += "\"ServiceFormat\":\"P\",\"Safeplace\":\"Front Porch\",";
            testJson += "\"SaturdayGuaranteed\":false,\"ConsequentialLoss\":\"Level5\",";
            testJson += "\"LocalCollect\":false,\"TrackingNotifications\":\"EmailAndSMS\",";
            testJson += "\"RecordedSignedFor\":false";
            testJson += "},";
            testJson += "\"TotalPackages\":2,\"TotalWeight\":3.1,";
            testJson += "\"WeightUnitOfMeasure\":\"KG\",\"Product\":\"LEGO\",";
            testJson += "\"DescriptionOfGoods\":\"LEGO sets\",\"ReasonForExport\":\"Sale of goods\",";
            testJson += "\"Value\":112.97,\"Currency\":\"GBP\",\"Incoterms\":\"DDU\",";
            testJson += "\"LabelFormat\":\"PDF\",\"SilentPrintProfile\":\"75b59db8-3cd3-4578-888e-54be016f07cc\",";
            testJson += "\"ShipmentAction\":\"Process\",";
            testJson += "\"Packages\":";
            testJson += "[{";
            testJson += "\"PackageOccurrence\":1,\"PackagingId\":\"17968198-1\",";
            testJson += "\"Weight\":2.2,\"Length\":15,\"Width\":15,\"Height\":5";
            testJson += "},{";
            testJson += "\"PackageOccurrence\":2,\"PackagingId\":\"17968198-2\",";
            testJson += "\"Weight\":0.9,\"Length\":45,\"Width\":10,\"Height\":3";
            testJson += "}],";
            testJson += "\"Items\":";
            testJson += "[{";
            testJson += "\"ItemId\":\"10782\",\"Quantity\":1,";
            testJson += "\"Description\":\"Hulk vs. Rhino Truck Showdown\",\"Value\":17.99,";
            testJson += "\"Weight\":0.9,\"PackageOccurrence\":2,\"HsCode\":\"652534\",";
            testJson += "\"SkuCode\":\"SKU3455692\",\"CountryOfOrigin\":\"GB\",";
            testJson += "\"ImageUrl\":\"https://images.brickset.com/sets/large/10782-1.jpg?202109211242\"";
            testJson += "},{";
            testJson += "\"ItemId\":\"76205\",\"Quantity\":1,";
            testJson += "\"Description\":\"Gargantos Showdown\",\"Value\":24.99,";
            testJson += "\"Weight\":1.0,\"PackageOccurrence\":1,\"HsCode\":\"652584\",";
            testJson += "\"SkuCode\":\"SKU3455682\",\"CountryOfOrigin\":\"GB\",";
            testJson += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76205-1.jpg?202109211239\"";
            testJson += "},{";
            testJson += "\"ItemId\":\"76175\",\"Quantity\":1,";
            testJson += "\"Description\":\"Attack on the Spider Lair\",\"Value\":69.99,";
            testJson += "\"Weight\":1.2,\"PackageOccurrence\":1,\"HsCode\":\"659534\",";
            testJson += "\"SkuCode\":\"SKU3499692\",\"CountryOfOrigin\":\"CN\",";
            testJson += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76175-1.jpg?202009170531\"";
            //testJson += "}]},";
            testJson += "}]},";
            testJson += "\"CustomsInformation\":";
            testJson += "{";
            testJson += "\"PreRegistrationNumber\":\"GB15748250\",\"PreRegistrationType\":\"EORI\",";
            testJson += "\"ShippingCharges\":\"10.42\",\"OtherCharges\":\"0.00\",";
            testJson += "\"QuotedLandedCost\":\"0.00\",\"InvoiceNumber\":\"15748250\",";
            testJson += "\"InvoiceDate\":\"2022-01-16\",\"ExportLicence\":false,";
            testJson += "\"AddresseeIdentificationReferenceNumber\":\"1234567890\"";
            testJson += "}";
            testJson += "}";

            RoyalMailData testItem;
            DateTime justDate = new DateTime(2022, 01, 16);

            testItem = new RoyalMailData();
            testItem.AddShipper(SampleOrder1.SupplierId,                // "bricksinbloom7308"
                                SampleOrder1.SupplierReference1,        // "7308"
                                SampleOrder1.SupplierReference2,        // "BrickLink"
                                SampleOrder1.Department,                // 7308
                                SampleOrder1.SupplierBusinessName,      // "Bricks In Bloom"
                                SampleOrder1.SupplierContactName,       // "Leigha Middleton"
                                SampleOrder1.SupplierAddressLine1,      // "Unit 4"
                                SampleOrder1.SupplierAddressLine2,      // "Candy Works"
                                SampleOrder1.SupplierAddressLine3,      // "15 Parkhouse Road"
                                SampleOrder1.SupplierAddressTown,       // "Carlisle"
                                SampleOrder1.SupplierAddressCounty,     // "Cumbria"
                                SampleOrder1.SupplierCountryCode,       // "GB"
                                SampleOrder1.SupplierAddressPostcode,   // "CA3 0JU"
                                SampleOrder1.SupplierPhoneNumber,       // "1228511030"
                                SampleOrder1.SupplierEmailAddress,      // "bricksinbloom@bricklink.com"
                                SampleOrder1.SupplierVatNumber);        // "GB123 4567 89"
            testItem.AddDestination(SampleOrder1.CustomerId,                // "BL15748250"
                                    SampleOrder1.CustomerBusinessName,      // ""
                                    SampleOrder1.CustomerContactName,       // "Colin Middleton"
                                    SampleOrder1.CustomerAddressLine1,      // "257 Ecclesall Road"
                                    SampleOrder1.CustomerAddressLine2,      // ""
                                    SampleOrder1.CustomerAddressLine3,      // "Sheffield"
                                    SampleOrder1.CustomerAddressTown,       // ""
                                    SampleOrder1.CustomerAddressCounty,     // "South Yorkshire"
                                    SampleOrder1.CustomerCountryCode,       // "GB"
                                    SampleOrder1.CustomerAddressPostcode,   // "S5 7HJ"
                                    SampleOrder1.CustomerPhoneNumber,       // "7505363818"
                                    SampleOrder1.CustomerEmailAddress,      // "colin@test.com"
                                    SampleOrder1.CustomerVatNumber);        // ""
            testItem.AddShipmentInformation(SampleOrder1.PostingDate,               // 16/01/2022
                                            SampleOrder1.PostageType,               // "TPLN"
                                            SampleOrder1.PostingWeightUOM,          // "KG"
                                            SampleOrder1.CustomsProduct,            // "LEGO"
                                            SampleOrder1.CustomsDescriptionOfGoods, // "LEGO sets"
                                            SampleOrder1.CustomsReasonForExport,    // "Sale of goods"
                                            SampleOrder1.CustomsValue,              // 112.97
                                            SampleOrder1.CustomsCurrency,           // "GBP"
                                            SampleOrder1.CustomsIncoterms,          // "DDU"
                                            SampleOrder1.CustomsLabelFormat,        // "PDF"
                                            SampleOrder1.CustomsSilentPrintProfile, // "75b59db8-3cd3-4578-888e-54be016f07cc"
                                            SampleOrder1.CustomsShipmentAction);    // "Process"
            testItem.AddServiceOption(SampleOrder1.PostingLocation,             // "123456789"
                                    SampleOrder1.PostingServiceLevel,           // "01"
                                    SampleOrder1.PostingServiceFormat,          // "P"
                                    SampleOrder1.CustomerSafeplace,             // "Front Porch"
                                    SampleOrder1.PostingSaturdayGuaranteed,     // false
                                    SampleOrder1.PostingConsequentialLoss,      // "Level5"
                                    SampleOrder1.PostingLocalCollect,           // false
                                    SampleOrder1.PostingTrackingNotifications,  // "EmailAndSMS"
                                    SampleOrder1.PostingRecordedSignedFor);     // false
            testItem.AddParcel(1,
                                "17968198-1",
                                2.2,
                                15,
                                15,
                                5);
            testItem.AddParcel(2,
                                "17968198-2",
                                0.9,
                                45,
                                10,
                                3);
            testItem.AddItem("10782",
                                1,
                                2,
                                "Hulk vs. Rhino Truck Showdown",
                                17.99,
                                0.9,
                                "652534",
                                "SKU3455692",
                                "GB",
                                "https://images.brickset.com/sets/large/10782-1.jpg?202109211242");
            testItem.AddItem("76205",
                                1,
                                1,
                                "Gargantos Showdown",
                                24.99,
                                1.0,
                                "652584",
                                "SKU3455682",
                                "GB",
                                "https://images.brickset.com/sets/images/76205-1.jpg?202109211239");
            testItem.AddItem("76175",
                                1,
                                1,
                                "Attack on the Spider Lair",
                                69.99,
                                1.2,
                                "659534",
                                "SKU3499692",
                                "CN",
                                "https://images.brickset.com/sets/images/76175-1.jpg?202009170531");
            testItem.AddCustomsInformation("GB15748250",
                                "EORI",
                                10.42,
                                0.00,
                                0.00,
                                15748250,
                                justDate,
                                false,
                                1234567890);
            string resultJson = RoyalMailComs.MakeMessageBody(testItem);

            Console.WriteLine(testJson);
            Console.WriteLine(resultJson);

            Assert.AreEqual(resultJson, testJson, false);
        }

        ///// <summary>
        ///// A postOfficeData indtance can be copied to a second instance and the two updated independatntly.
        ///// </summary>
        //[TestMethod()]
        //public void CloneTest()
        //{
        //    //Create the initial JSON.
        //    #region ControlJson1
        //    string testJson1 = "{";
        //    testJson1 += "\"Shipper\":";
        //    testJson1 += "{";
        //    testJson1 += "\"AddressId\":\"bricksinbloom7308\",\"ShipperReference\":\"7308\",";
        //    testJson1 += "\"ShipperReference2\":\"BrickLink\",\"ShipperDepartment\":\"7308\",";
        //    testJson1 += "\"CompanyName\":\"Bricks In  Bloom\",\"ContactName\":\"Leigha Middleton\",";
        //    testJson1 += "\"AddressLine1\":\"Unit 4\",\"AddressLine2\":\"Candy Works\",";
        //    testJson1 += "\"AddressLine3\":\"15 Parkhouse Road\",\"Town\":\"Carlisle\",";
        //    testJson1 += "\"County\":\"Cumbria\",\"CountryCode\":\"GB\",\"Postcode\":\"CA3 0JU\",";
        //    testJson1 += "\"PhoneNumber\":\"1228 511030\",\"EmailAddress\":\"bricksinbloom@bricklink.com\",";
        //    testJson1 += "\"VatNumber\":\"GB123 4567 89\"";
        //    testJson1 += "},";
        //    testJson1 += "\"Destination\":";
        //    testJson1 += "{";
        //    testJson1 += "\"AddressId\":\"BL15748250\",\"CompanyName\":\"\",";
        //    testJson1 += "\"ContactName\":\"Colin Middleton\",\"AddressLine1\":\"257 Ecclesall Road\",";
        //    testJson1 += "\"AddressLine2\":\"\",\"AddressLine3\":\"\",\"Town\":\"Sheffield\",";
        //    testJson1 += "\"County\":\"South Yorkshire\",\"CountryCode\":\"GB\",";
        //    testJson1 += "\"Postcode\":\"S5 7HJ\",\"PhoneNumber\":\"7505363818\",";
        //    testJson1 += "\"EmailAddress\":\"colin@test.com\",\"VatNumber\":\"\"";
        //    testJson1 += "},";
        //    testJson1 += "\"ShipmentInformation\":";
        //    testJson1 += "{";
        //    testJson1 += "\"ShipmentDate\":\"2022-01-16\",\"ServiceCode\":\"TPLN\",";
        //    testJson1 += "\"ServiceOptions\":";
        //    testJson1 += "{";
        //    testJson1 += "\"PostingLocation\":\"123456789\",\"ServiceLevel\":\"01\",";
        //    testJson1 += "\"ServiceFormat\":\"P\",\"Safeplace\":\"Front Porch\",";
        //    testJson1 += "\"SaturdayGuaranteed\":false,\"ConsequentialLoss\":\"Level5\",";
        //    testJson1 += "\"LocalCollect\":false,\"TrackingNotifications\":\"EmailAndSMS\",";
        //    testJson1 += "\"RecordedSignedFor\":false";
        //    testJson1 += "},";
        //    testJson1 += "\"TotalPackages\":2,\"TotalWeight\":3.1,";
        //    testJson1 += "\"WeightUnitOfMeasure\":\"KG\",\"Product\":\"LEGO\",";
        //    testJson1 += "\"DescriptionOfGoods\":\"LEGO sets\",\"ReasonForExport\":\"Sale of goods\",";
        //    testJson1 += "\"Value\":112.97,\"Currency\":\"GBP\",\"Incoterms\":\"DDU\",";
        //    testJson1 += "\"LabelFormat\":\"PDF\",\"SilentPrintProfile\":\"75b59db8-3cd3-4578-888e-54be016f07cc\",";
        //    testJson1 += "\"ShipmentAction\":\"Process\",";
        //    testJson1 += "\"Packages\":";
        //    testJson1 += "[{";
        //    testJson1 += "\"PackageOccurrence\":1,\"PackagingId\":\"17968198-1\",";
        //    testJson1 += "\"Weight\":2.2,\"Length\":15,\"Width\":15,\"Height\":5";
        //    testJson1 += "},{";
        //    testJson1 += "\"PackageOccurrence\":2,\"PackagingId\":\"17968198-2\",";
        //    testJson1 += "\"Weight\":0.9,\"Length\":45,\"Width\":10,\"Height\":3";
        //    testJson1 += "}],";
        //    testJson1 += "\"Items\":";
        //    testJson1 += "[{";
        //    testJson1 += "\"ItemId\":\"10782\",\"Quantity\":1,";
        //    testJson1 += "\"Description\":\"Hulk vs. Rhino Truck Showdown\",\"Value\":17.99,";
        //    testJson1 += "\"Weight\":0.9,\"PackageOccurrence\":2,\"HsCode\":\"652534\",";
        //    testJson1 += "\"SkuCode\":\"SKU3455692\",\"CountryOfOrigin\":\"GB\",";
        //    testJson1 += "\"ImageUrl\":\"https://images.brickset.com/sets/large/10782-1.jpg?202109211242\"";
        //    testJson1 += "},{";
        //    testJson1 += "\"ItemId\":\"76205\",\"Quantity\":1,";
        //    testJson1 += "\"Description\":\"Gargantos Showdown\",\"Value\":24.99,";
        //    testJson1 += "\"Weight\":1.0,\"PackageOccurrence\":1,\"HsCode\":\"652584\",";
        //    testJson1 += "\"SkuCode\":\"SKU3455682\",\"CountryOfOrigin\":\"GB\",";
        //    testJson1 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76205-1.jpg?202109211239\"";
        //    testJson1 += "},{";
        //    testJson1 += "\"ItemId\":\"76175\",\"Quantity\":1,";
        //    testJson1 += "\"Description\":\"Attack on the Spider Lair\",\"Value\":69.99,";
        //    testJson1 += "\"Weight\":1.2,\"PackageOccurrence\":1,\"HsCode\":\"659534\",";
        //    testJson1 += "\"SkuCode\":\"SKU3499692\",\"CountryOfOrigin\":\"CN\",";
        //    testJson1 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76175-1.jpg?202009170531\"";
        //    testJson1 += "}]},";
        //    testJson1 += "\"CustomsInformation\":";
        //    testJson1 += "{";
        //    testJson1 += "\"PreRegistrationNumber\":\"GB15748250\",\"PreRegistrationType\":\"EORI\",";
        //    testJson1 += "\"ShippingCharges\":\"10.42\",\"OtherCharges\":\"0.00\",";
        //    testJson1 += "\"QuotedLandedCost\":\"0.00\",\"InvoiceNumber\":\"15748250\",";
        //    testJson1 += "\"InvoiceDate\":\"2022-01-16\",\"ExportLicence\":false,";
        //    testJson1 += "\"AddresseeIdentificationReferenceNumber\":\"1234567890\"";
        //    testJson1 += "}";
        //    testJson1 += "}";
        //    #endregion

        //    //Create the modified initial JSON.
        //    #region ControlJson2
        //    string testJson2 = "{";
        //    testJson2 += "\"Shipper\":";
        //    testJson2 += "{";
        //    testJson2 += "\"AddressId\":\"bricksinbloom7308\",\"ShipperReference\":\"7308\",";
        //    testJson2 += "\"ShipperReference2\":\"BrickLink\",\"ShipperDepartment\":\"7308\",";
        //    testJson2 += "\"CompanyName\":\"Bricks In  Bloom\",\"ContactName\":\"Leigha Middleton\",";
        //    testJson2 += "\"AddressLine1\":\"Unit 5\",\"AddressLine2\":\"Candy Works\",";
        //    testJson2 += "\"AddressLine3\":\"15 Parkhouse Road\",\"Town\":\"Carlisle\",";
        //    testJson2 += "\"County\":\"Cumbria\",\"CountryCode\":\"GB\",\"Postcode\":\"CA3 0JU\",";
        //    testJson2 += "\"PhoneNumber\":\"1228 511030\",\"EmailAddress\":\"bricksinbloom@bricklink.com\",";
        //    testJson2 += "\"VatNumber\":\"GB123 4567 89\"";
        //    testJson2 += "},";
        //    testJson2 += "\"Destination\":";
        //    testJson2 += "{";
        //    testJson2 += "\"AddressId\":\"BL15748250\",\"CompanyName\":\"\",";
        //    testJson2 += "\"ContactName\":\"Colin Middleton\",\"AddressLine1\":\"257 Ecclesall Road\",";
        //    testJson2 += "\"AddressLine2\":\"\",\"AddressLine3\":\"\",\"Town\":\"Sheffield\",";
        //    testJson2 += "\"County\":\"South Yorkshire\",\"CountryCode\":\"GB\",";
        //    testJson2 += "\"Postcode\":\"S5 7HJ\",\"PhoneNumber\":\"7505363818\",";
        //    testJson2 += "\"EmailAddress\":\"colin@test.com\",\"VatNumber\":\"\"";
        //    testJson2 += "},";
        //    testJson2 += "\"ShipmentInformation\":";
        //    testJson2 += "{";
        //    testJson2 += "\"ShipmentDate\":\"2022-01-16\",\"ServiceCode\":\"TPLN\",";
        //    testJson2 += "\"ServiceOptions\":";
        //    testJson2 += "{";
        //    testJson2 += "\"PostingLocation\":\"123456789\",\"ServiceLevel\":\"01\",";
        //    testJson2 += "\"ServiceFormat\":\"P\",\"Safeplace\":\"Front Porch\",";
        //    testJson2 += "\"SaturdayGuaranteed\":false,\"ConsequentialLoss\":\"Level5\",";
        //    testJson2 += "\"LocalCollect\":false,\"TrackingNotifications\":\"EmailAndSMS\",";
        //    testJson2 += "\"RecordedSignedFor\":false";
        //    testJson2 += "},";
        //    testJson2 += "\"TotalPackages\":2,\"TotalWeight\":3.1,";
        //    testJson2 += "\"WeightUnitOfMeasure\":\"KG\",\"Product\":\"LEGO\",";
        //    testJson2 += "\"DescriptionOfGoods\":\"LEGO sets\",\"ReasonForExport\":\"Sale of goods\",";
        //    testJson2 += "\"Value\":112.97,\"Currency\":\"GBP\",\"Incoterms\":\"DDU\",";
        //    testJson2 += "\"LabelFormat\":\"PDF\",\"SilentPrintProfile\":\"75b59db8-3cd3-4578-888e-54be016f07cc\",";
        //    testJson2 += "\"ShipmentAction\":\"Process\",";
        //    testJson2 += "\"Packages\":";
        //    testJson2 += "[{";
        //    testJson2 += "\"PackageOccurrence\":1,\"PackagingId\":\"17968198-1\",";
        //    testJson2 += "\"Weight\":2.2,\"Length\":15,\"Width\":15,\"Height\":5";
        //    testJson2 += "},{";
        //    testJson2 += "\"PackageOccurrence\":2,\"PackagingId\":\"17968198-2\",";
        //    testJson2 += "\"Weight\":0.9,\"Length\":45,\"Width\":10,\"Height\":3";
        //    testJson2 += "}],";
        //    testJson2 += "\"Items\":";
        //    testJson2 += "[{";
        //    testJson2 += "\"ItemId\":\"10782\",\"Quantity\":1,";
        //    testJson2 += "\"Description\":\"Hulk vs. Rhino Truck Showdown\",\"Value\":17.99,";
        //    testJson2 += "\"Weight\":0.9,\"PackageOccurrence\":2,\"HsCode\":\"652534\",";
        //    testJson2 += "\"SkuCode\":\"SKU3455692\",\"CountryOfOrigin\":\"GB\",";
        //    testJson2 += "\"ImageUrl\":\"https://images.brickset.com/sets/large/10782-1.jpg?202109211242\"";
        //    testJson2 += "},{";
        //    testJson2 += "\"ItemId\":\"76205\",\"Quantity\":1,";
        //    testJson2 += "\"Description\":\"Gargantos Showdown\",\"Value\":24.99,";
        //    testJson2 += "\"Weight\":1.0,\"PackageOccurrence\":1,\"HsCode\":\"652584\",";
        //    testJson2 += "\"SkuCode\":\"SKU3455682\",\"CountryOfOrigin\":\"GB\",";
        //    testJson2 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76205-1.jpg?202109211239\"";
        //    testJson2 += "},{";
        //    testJson2 += "\"ItemId\":\"76175\",\"Quantity\":1,";
        //    testJson2 += "\"Description\":\"Attack on the Spider Lair\",\"Value\":69.99,";
        //    testJson2 += "\"Weight\":1.2,\"PackageOccurrence\":1,\"HsCode\":\"659534\",";
        //    testJson2 += "\"SkuCode\":\"SKU3499692\",\"CountryOfOrigin\":\"CN\",";
        //    testJson2 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76175-1.jpg?202009170531\"";
        //    testJson2 += "}]},";
        //    testJson2 += "\"CustomsInformation\":";
        //    testJson2 += "{";
        //    testJson2 += "\"PreRegistrationNumber\":\"GB15748250\",\"PreRegistrationType\":\"EORI\",";
        //    testJson2 += "\"ShippingCharges\":\"10.42\",\"OtherCharges\":\"0.00\",";
        //    testJson2 += "\"QuotedLandedCost\":\"0.00\",\"InvoiceNumber\":\"15748250\",";
        //    testJson2 += "\"InvoiceDate\":\"2022-01-16\",\"ExportLicence\":false,";
        //    testJson2 += "\"AddresseeIdentificationReferenceNumber\":\"1234567890\"";
        //    testJson2 += "}";
        //    testJson2 += "}";
        //    #endregion

        //    //Create the modified copy JSON.
        //    #region ControlJson3
        //    string testJson3 = "{";
        //    testJson3 += "\"Shipper\":";
        //    testJson3 += "{";
        //    testJson3 += "\"AddressId\":\"bricksinbloom7308\",\"ShipperReference\":\"7308\",";
        //    testJson3 += "\"ShipperReference2\":\"BrickLink\",\"ShipperDepartment\":\"7308\",";
        //    testJson3 += "\"CompanyName\":\"BrickLane\",\"ContactName\":\"Leigha Middleton\",";
        //    testJson3 += "\"AddressLine1\":\"Unit 4\",\"AddressLine2\":\"Candy Works\",";
        //    testJson3 += "\"AddressLine3\":\"15 Parkhouse Road\",\"Town\":\"Carlisle\",";
        //    testJson3 += "\"County\":\"Cumbria\",\"CountryCode\":\"GB\",\"Postcode\":\"CA3 0JU\",";
        //    testJson3 += "\"PhoneNumber\":\"1228 511030\",\"EmailAddress\":\"bricksinbloom@bricklink.com\",";
        //    testJson3 += "\"VatNumber\":\"GB123 4567 89\"";
        //    testJson3 += "},";
        //    testJson3 += "\"Destination\":";
        //    testJson3 += "{";
        //    testJson3 += "\"AddressId\":\"BL15748250\",\"CompanyName\":\"\",";
        //    testJson3 += "\"ContactName\":\"Bad Bob\",\"AddressLine1\":\"257 Ecclesall Road\",";
        //    testJson3 += "\"AddressLine2\":\"\",\"AddressLine3\":\"\",\"Town\":\"Sheffield\",";
        //    testJson3 += "\"County\":\"South Yorkshire\",\"CountryCode\":\"GB\",";
        //    testJson3 += "\"Postcode\":\"S5 7HJ\",\"PhoneNumber\":\"7505363818\",";
        //    testJson3 += "\"EmailAddress\":\"colin@test.com\",\"VatNumber\":\"\"";
        //    testJson3 += "},";
        //    testJson3 += "\"ShipmentInformation\":";
        //    testJson3 += "{";
        //    testJson3 += "\"ShipmentDate\":\"2022-01-16\",\"ServiceCode\":\"TPLN\",";
        //    testJson3 += "\"ServiceOptions\":";
        //    testJson3 += "{";
        //    testJson3 += "\"PostingLocation\":\"123456789\",\"ServiceLevel\":\"01\",";
        //    testJson3 += "\"ServiceFormat\":\"P\",\"Safeplace\":\"Front Porch\",";
        //    testJson3 += "\"SaturdayGuaranteed\":true,\"ConsequentialLoss\":\"Level5\",";
        //    testJson3 += "\"LocalCollect\":false,\"TrackingNotifications\":\"EmailAndSMS\",";
        //    testJson3 += "\"RecordedSignedFor\":false";
        //    testJson3 += "},";
        //    testJson3 += "\"TotalPackages\":2,\"TotalWeight\":3.1,";
        //    testJson3 += "\"WeightUnitOfMeasure\":\"KG\",\"Product\":\"LEGO\",";
        //    testJson3 += "\"DescriptionOfGoods\":\"LEGO bricks\",\"ReasonForExport\":\"Sale of goods\",";
        //    testJson3 += "\"Value\":112.97,\"Currency\":\"GBP\",\"Incoterms\":\"DDU\",";
        //    testJson3 += "\"LabelFormat\":\"PDF\",\"SilentPrintProfile\":\"75b59db8-3cd3-4578-888e-54be016f07cc\",";
        //    testJson3 += "\"ShipmentAction\":\"Process\",";
        //    testJson3 += "\"Packages\":";
        //    testJson3 += "[{";
        //    testJson3 += "\"PackageOccurrence\":1,\"PackagingId\":\"17968198-1\",";
        //    testJson3 += "\"Weight\":1.8,\"Length\":15,\"Width\":15,\"Height\":5";
        //    testJson3 += "},{";
        //    testJson3 += "\"PackageOccurrence\":2,\"PackagingId\":\"17968198-2\",";
        //    testJson3 += "\"Weight\":0.9,\"Length\":45,\"Width\":10,\"Height\":3";
        //    testJson3 += "},{";
        //    testJson3 += "\"PackageOccurrence\":3,\"PackagingId\":\"17968198-3\",";
        //    testJson3 += "\"Weight\":1,\"Length\":35,\"Width\":20,\"Height\":5";
        //    testJson3 += "}],";
        //    testJson3 += "\"Items\":";
        //    testJson3 += "[{";
        //    testJson3 += "\"ItemId\":\"10782\",\"Quantity\":1,";
        //    testJson3 += "\"Description\":\"Hulk vs. Rhino Truck Showdown\",\"Value\":17.99,";
        //    testJson3 += "\"Weight\":0.9,\"PackageOccurrence\":2,\"HsCode\":\"652534\",";
        //    testJson3 += "\"SkuCode\":\"SKU3455692\",\"CountryOfOrigin\":\"GB\",";
        //    testJson3 += "\"ImageUrl\":\"https://images.brickset.com/sets/large/10782-1.jpg?202109211242\"";
        //    testJson3 += "},{";
        //    testJson3 += "\"ItemId\":\"76205\",\"Quantity\":1,";
        //    testJson3 += "\"Description\":\"Gargantos Showdown\",\"Value\":24.99,";
        //    testJson3 += "\"Weight\":1.0,\"PackageOccurrence\":3,\"HsCode\":\"652584\",";
        //    testJson3 += "\"SkuCode\":\"SKU3455682\",\"CountryOfOrigin\":\"GB\",";
        //    testJson3 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76205-1.jpg?202109211239\"";
        //    testJson3 += "},{";
        //    testJson3 += "\"ItemId\":\"76175\",\"Quantity\":1,";
        //    testJson3 += "\"Description\":\"Attack on the Spider Lair\",\"Value\":69.99,";
        //    testJson3 += "\"Weight\":1.2,\"PackageOccurrence\":1,\"HsCode\":\"659534\",";
        //    testJson3 += "\"SkuCode\":\"SKU3499692\",\"CountryOfOrigin\":\"CN\",";
        //    testJson3 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/76175-1.jpg?202009170531\"";
        //    testJson3 += "},{";
        //    testJson3 += "\"ItemId\":\"10783\",\"Quantity\":1,";
        //    testJson3 += "\"Description\":\"Spider-Man at Doc Ock's Lab\",\"Value\":24.99,";
        //    testJson3 += "\"Weight\":0.6,\"PackageOccurrence\":1,\"HsCode\":\"655534\",";
        //    testJson3 += "\"SkuCode\":\"SKU3499699\",\"CountryOfOrigin\":\"CN\",";
        //    testJson3 += "\"ImageUrl\":\"https://images.brickset.com/sets/images/10783-1.jpg?202109211239\"";
        //    testJson3 += "}]},";
        //    testJson3 += "\"CustomsInformation\":";
        //    testJson3 += "{";
        //    testJson3 += "\"PreRegistrationNumber\":\"GB15748250\",\"PreRegistrationType\":\"EORI\",";
        //    testJson3 += "\"ShippingCharges\":\"12.44\",\"OtherCharges\":\"0.00\",";
        //    testJson3 += "\"QuotedLandedCost\":\"0.00\",\"InvoiceNumber\":\"15748250\",";
        //    testJson3 += "\"InvoiceDate\":\"2022-01-16\",\"ExportLicence\":false,";
        //    testJson3 += "\"AddresseeIdentificationReferenceNumber\":\"1234567890\"";
        //    testJson3 += "}";
        //    testJson3 += "}";
        //    #endregion

        //    PostOfficeData testItem;
        //    PostOfficeData copyTestItem;
        //    DateTime justDate = new DateTime(2022, 01, 16);

        //    //Generate the initial data.
        //    #region CreateBaseTestData
        //    testItem = new PostOfficeData();
        //    testItem.AddShipper("bricksinbloom7308",
        //                        "7308",
        //                        "BrickLink",
        //                        7308,
        //                        "Bricks In  Bloom",
        //                        "Leigha Middleton",
        //                        "Unit 4",
        //                        "Candy Works",
        //                        "15 Parkhouse Road",
        //                        "Carlisle",
        //                        "Cumbria",
        //                        "GB",
        //                        "CA3 0JU",
        //                        "1228 511030",
        //                        "bricksinbloom@bricklink.com",
        //                        "GB123 4567 89");
        //    testItem.AddDestination("BL15748250",
        //                        "",
        //                        "Colin Middleton",
        //                        "257 Ecclesall Road",
        //                        "",
        //                        "",
        //                        "Sheffield",
        //                        "South Yorkshire",
        //                        "GB",
        //                        "S5 7HJ",
        //                        "7505363818",
        //                        "colin@test.com",
        //                        "");
        //    testItem.AddShipmentInformation(justDate,
        //                        "TPLN",
        //                        2,
        //                        3.1,
        //                        "KG",
        //                        "LEGO",
        //                        "LEGO sets",
        //                        "Sale of goods",
        //                        112.97,
        //                        "GBP",
        //                        "DDU",
        //                        "PDF",
        //                        "75b59db8-3cd3-4578-888e-54be016f07cc",
        //                        "Process");
        //    testItem.AddServiceOption("123456789",
        //                        "01",
        //                        "P",
        //                        "Front Porch",
        //                        false,
        //                        "Level5",
        //                        false,
        //                        "EmailAndSMS",
        //                        false);
        //    testItem.AddPackage(1,
        //                        "17968198-1",
        //                        2.2,
        //                        15,
        //                        15,
        //                        5);
        //    testItem.AddPackage(2,
        //                        "17968198-2",
        //                        0.9,
        //                        45,
        //                        10,
        //                        3);
        //    testItem.AddItem("10782",
        //                        1,
        //                        "Hulk vs. Rhino Truck Showdown",
        //                        17.99,
        //                        0.9,
        //                        2,
        //                        "652534",
        //                        "SKU3455692",
        //                        "GB",
        //                        "https://images.brickset.com/sets/large/10782-1.jpg?202109211242");
        //    testItem.AddItem("76205",
        //                        1,
        //                        "Gargantos Showdown",
        //                        24.99,
        //                        1.0,
        //                        1,
        //                        "652584",
        //                        "SKU3455682",
        //                        "GB",
        //                        "https://images.brickset.com/sets/images/76205-1.jpg?202109211239");
        //    testItem.AddItem("76175",
        //                        1,
        //                        "Attack on the Spider Lair",
        //                        69.99,
        //                        1.2,
        //                        1,
        //                        "659534",
        //                        "SKU3499692",
        //                        "CN",
        //                        "https://images.brickset.com/sets/images/76175-1.jpg?202009170531");
        //    testItem.AddCustomsInformation("GB15748250",
        //                        "EORI",
        //                        10.42,
        //                        0.00,
        //                        0.00,
        //                        15748250,
        //                        justDate,
        //                        false,
        //                        1234567890);
        //    string resultJson1 = testItem.MakeJson();
        //    #endregion

        //    //Create a copy of the data
        //    #region CreateOtherTestData
        //    copyTestItem = (PostOfficeData)testItem.Clone();
        //    string resultJson2 = copyTestItem.MakeJson();

        //    //Modify the COPY version.
        //    copyTestItem.ShipperCompanyName = "BrickLane";
        //    copyTestItem.DestinationContactName = "Bad Bob";
        //    copyTestItem.ShipmentInfoDescriptionOfGoods = "LEGO bricks";
        //    copyTestItem.ServiceOptSaturdayGuaranteed = true;
        //    copyTestItem.GetCurrentPackage(0);
        //    copyTestItem.PackWeight = 1.8;
        //    copyTestItem.AddPackage(3,
        //                        "17968198-3",
        //                        1.0,
        //                        35,
        //                        20,
        //                        5);
        //    copyTestItem.GetCurrentItem(1);
        //    copyTestItem.ItemPackageOccurrence = 3;
        //    copyTestItem.AddItem("10783",
        //                    1,
        //                    "Spider-Man at Doc Ock's Lab",
        //                    24.99,
        //                    0.6,
        //                    1,
        //                    "655534",
        //                    "SKU3499699",
        //                    "CN",
        //                    "https://images.brickset.com/sets/images/10783-1.jpg?202109211239");
        //    copyTestItem.CustomsShippingCharges = 12.44;

        //    //Change original JSON.
        //    testItem.ShipperAddressLine1 = "Unit 5";

        //    string resultJson3 = testItem.MakeJson();
        //    string resultJson4 = copyTestItem.MakeJson();
        //    #endregion

        //    Assert.IsNotNull(testItem.shipper);
        //    Assert.IsNotNull(testItem.destination);
        //    Assert.IsNotNull(testItem.shipmentInformation);
        //    Assert.IsNotNull(testItem.shipmentInformation.serviceOptions);
        //    Assert.IsNotNull(testItem.shipmentInformation.PackagesList[0]);
        //    Assert.IsNotNull(testItem.shipmentInformation.PackagesList[1]);
        //    Assert.IsNotNull(testItem.shipmentInformation.ItemsList[0]);
        //    Assert.IsNotNull(testItem.shipmentInformation.ItemsList[1]);
        //    Assert.IsNotNull(testItem.shipmentInformation.ItemsList[2]);
        //    Assert.IsNotNull(testItem.customsInformation);
        //    Assert.AreEqual(resultJson1, testJson1, false);
        //    Assert.AreEqual(resultJson3, testJson2, false);

        //    Assert.IsNotNull(copyTestItem.shipper);
        //    Assert.IsNotNull(copyTestItem.destination);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation.serviceOptions);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation.PackagesList[0]);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation.PackagesList[1]);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation.ItemsList[0]);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation.ItemsList[1]);
        //    Assert.IsNotNull(copyTestItem.shipmentInformation.ItemsList[2]);
        //    Assert.IsNotNull(copyTestItem.customsInformation);
        //    Assert.AreEqual(resultJson2, testJson1, false);
        //    //Assert.AreEqual(resultJson4, testJson3, false);
        //}
        #endregion
    }
}