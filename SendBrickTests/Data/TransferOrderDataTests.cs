using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrick.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrick.Library.Tests
{
    [TestClass()]
    public class TransferOrderDataTests
    {
        #region TransferOrderTests
        [TestMethod()]
        public void TransferOrderDataAddBlankTest()
        {
            TransferOrderData testItem;
            testItem = new TransferOrderData();

            Assert.IsNotNull(testItem);
        }

        [TestMethod()]
        public void TransferOrderDataAddTestFromData()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData(SampleOrder1.SupplierId,
                                SampleOrder1.SupplierContactName,
                                SampleOrder1.SupplierBusinessName,
                                SampleOrder1.SupplierReference1,
                                SampleOrder1.SupplierReference2,
                                SampleOrder1.Department,
                                SampleOrder1.SupplierAddressLine1,
                                SampleOrder1.SupplierAddressLine2,
                                SampleOrder1.SupplierAddressLine3,
                                SampleOrder1.SupplierAddressLine4,
                                SampleOrder1.SupplierAddressTown,
                                SampleOrder1.SupplierAddressCounty,
                                SampleOrder1.SupplierCountryCode,
                                SampleOrder1.SupplierAddressPostcode,
                                SampleOrder1.SupplierPhoneNumber,
                                SampleOrder1.SupplierEmailAddress,
                                SampleOrder1.SupplierVatNumber,
                                SampleOrder1.CustomerId,
                                SampleOrder1.CustomerContactName,
                                SampleOrder1.CustomerBusinessName,
                                SampleOrder1.CustomerAddressLine1,
                                SampleOrder1.CustomerAddressLine2,
                                SampleOrder1.CustomerAddressLine3,
                                SampleOrder1.CustomerAddressLine4,
                                SampleOrder1.CustomerAddressTown,
                                SampleOrder1.CustomerAddressCounty,
                                SampleOrder1.CustomerCountryCode,
                                SampleOrder1.CustomerAddressPostcode,
                                SampleOrder1.CustomerPhoneNumber,
                                SampleOrder1.CustomerEmailAddress,
                                SampleOrder1.CustomerVatNumber,
                                SampleOrder1.CustomerSafeplace,
                                SampleOrder1.PostingDate,
                                SampleOrder1.PostageType,
                                SampleOrder1.PostingWeightUOM,
                                SampleOrder1.PostingLocation,
                                SampleOrder1.PostingServiceLevel,
                                SampleOrder1.PostingServiceFormat,
                                SampleOrder1.PostingSaturdayGuaranteed,
                                SampleOrder1.PostingConsequentialLoss,
                                SampleOrder1.PostingLocalCollect,
                                SampleOrder1.PostingTrackingNotifications,
                                SampleOrder1.PostingRecordedSignedFor,
                                SampleOrder1.CustomsProduct,
                                SampleOrder1.CustomsDescriptionOfGoods,
                                SampleOrder1.CustomsReasonForExport,
                                SampleOrder1.CustomsShippingCharges,
                                SampleOrder1.CustomsOtherCharges,
                                SampleOrder1.CustomsCurrency,
                                SampleOrder1.CustomsIncoterms,
                                SampleOrder1.CustomsInvoiceNumber,
                                SampleOrder1.CustomsInvoiceDate,
                                SampleOrder1.CustomsLabelFormat,
                                SampleOrder1.CustomsSilentPrintProfile,
                                SampleOrder1.CustomsShipmentAction,
                                SampleOrder1.CustomsPreRegistrationNumber,
                                SampleOrder1.CustomsPreRegistrationType,
                                SampleOrder1.CustomsQuotedLandedCost,
                                SampleOrder1.CustomsExportLicence,
                                SampleOrder1.AddresseeIdentificationReferenceNumber);

            Assert.IsNotNull(testItem);

            Assert.AreEqual(SampleOrder1.SupplierId, testItem.SupplierId, false);
            Assert.AreEqual(SampleOrder1.SupplierReference1, testItem.SupplierReference1, false);
            Assert.AreEqual(SampleOrder1.SupplierReference2, testItem.SupplierReference2, false);
            Assert.AreEqual(SampleOrder1.Department, testItem.Department, 0);
            Assert.AreEqual(SampleOrder1.SupplierBusinessName, testItem.SupplierBusinessName, false);
            Assert.AreEqual(SampleOrder1.SupplierContactName, testItem.SupplierContactName, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressLine1, testItem.SupplierAddressLine1, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressLine2, testItem.SupplierAddressLine2, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressLine3, testItem.SupplierAddressLine3, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressLine4, testItem.SupplierAddressLine4, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressTown, testItem.SupplierAddressTown, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressCounty, testItem.SupplierAddressCounty, false);
            Assert.AreEqual(SampleOrder1.SupplierCountryCode, testItem.SupplierCountryCode, false);
            Assert.AreEqual(SampleOrder1.SupplierAddressPostcode, testItem.SupplierAddressPostcode, false);
            Assert.AreEqual(SampleOrder1.SupplierPhoneNumber, testItem.SupplierPhoneNumber, false);
            Assert.AreEqual(SampleOrder1.SupplierEmailAddress, testItem.SupplierEmailAddress, false);
            Assert.AreEqual(SampleOrder1.SupplierVatNumber, testItem.SupplierVatNumber, false);

            Assert.AreEqual(SampleOrder1.CustomerId, testItem.CustomerId, false);
            Assert.AreEqual(SampleOrder1.CustomerBusinessName, testItem.CustomerBusinessName, false);
            Assert.AreEqual(SampleOrder1.CustomerContactName, testItem.CustomerContactName, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressLine1, testItem.CustomerAddressLine1, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressLine2, testItem.CustomerAddressLine2, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressLine3, testItem.CustomerAddressLine3, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressLine4, testItem.CustomerAddressLine4, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressTown, testItem.CustomerAddressTown, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressCounty, testItem.CustomerAddressCounty, false);
            Assert.AreEqual(SampleOrder1.CustomerCountryCode, testItem.CustomerCountryCode, false);
            Assert.AreEqual(SampleOrder1.CustomerAddressPostcode, testItem.CustomerAddressPostcode, false);
            Assert.AreEqual(SampleOrder1.CustomerPhoneNumber, testItem.CustomerPhoneNumber);
            Assert.AreEqual(SampleOrder1.CustomerEmailAddress, testItem.CustomerEmailAddress, false);
            Assert.AreEqual(SampleOrder1.CustomerVatNumber, testItem.CustomerVatNumber, false);

            Assert.AreEqual(SampleOrder1.PostingDate.ToString(), testItem.PostingDate.ToString(), false);
            Assert.AreEqual(SampleOrder1.PostageType, testItem.PostageType, false);
            Assert.AreEqual(0, testItem.PostingTotalPackages, 0);
            Assert.AreEqual(0, testItem.PostingTotalWeight, 0);
            Assert.AreEqual(SampleOrder1.PostingWeightUOM, testItem.PostingWeightUOM, false);
            Assert.AreEqual(SampleOrder1.CustomsProduct, testItem.CustomsProduct, false);
            Assert.AreEqual(SampleOrder1.CustomsDescriptionOfGoods, testItem.CustomsDescriptionOfGoods, false);
            Assert.AreEqual(SampleOrder1.CustomsReasonForExport, testItem.CustomsReasonForExport, false);
            Assert.AreEqual(0, testItem.CustomsValue, 0);
            Assert.AreEqual(SampleOrder1.CustomsCurrency, testItem.CustomsCurrency, false);
            Assert.AreEqual(SampleOrder1.CustomsIncoterms, testItem.CustomsIncoterms, false);
            Assert.AreEqual(SampleOrder1.CustomsLabelFormat, testItem.CustomsLabelFormat, false);
            Assert.AreEqual(SampleOrder1.CustomsSilentPrintProfile, testItem.CustomsSilentPrintProfile, false);
            Assert.AreEqual(SampleOrder1.CustomsShipmentAction, testItem.CustomsShipmentAction, false);

            Assert.AreEqual(SampleOrder1.PostingLocation, testItem.PostingLocation, false);
            Assert.AreEqual(SampleOrder1.PostingServiceLevel, testItem.PostingServiceLevel, false);
            Assert.AreEqual(SampleOrder1.PostingServiceFormat, testItem.PostingServiceFormat, false);
            Assert.AreEqual(SampleOrder1.CustomerSafeplace, testItem.CustomerSafeplace, false);
            Assert.IsFalse(testItem.PostingSaturdayGuaranteed);
            Assert.AreEqual(SampleOrder1.PostingConsequentialLoss, testItem.PostingConsequentialLoss, false);
            Assert.IsFalse(testItem.PostingLocalCollect);
            Assert.AreEqual(SampleOrder1.PostingTrackingNotifications, testItem.PostingTrackingNotifications, false);
            Assert.IsFalse(testItem.PostingRecordedSignedFor);

            Assert.AreEqual(SampleOrder1.CustomsPreRegistrationNumber, testItem.CustomsPreRegistrationNumber, false);
            Assert.AreEqual(SampleOrder1.CustomsPreRegistrationType, testItem.CustomsPreRegistrationType, false);
            Assert.AreEqual(SampleOrder1.CustomsShippingCharges, testItem.CustomsShippingCharges, 0);
            Assert.AreEqual(SampleOrder1.CustomsOtherCharges, testItem.CustomsOtherCharges, 0);
            Assert.AreEqual(SampleOrder1.CustomsQuotedLandedCost, testItem.CustomsQuotedLandedCost, 0);
            Assert.AreEqual(SampleOrder1.CustomsInvoiceNumber, testItem.CustomsInvoiceNumber, false);
            Assert.AreEqual(SampleOrder1.CustomsInvoiceDate.ToString(), testItem.CustomsInvoiceDate.ToString(), false);
            Assert.IsFalse(testItem.CustomsExportLicence);
            Assert.AreEqual(SampleOrder1.AddresseeIdentificationReferenceNumber, testItem.AddresseeIdentificationReferenceNumber, 0);
        }
        #endregion

        #region ParcelTests
        [TestMethod()]
        public void ParcelAddBlankTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddParcel();

            Assert.AreNotEqual(testItem.PostingTotalPackages, 0);
        }
        [TestMethod()]
        public void ParcelAddTwiceTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            int numberOfParcels = testItem.PostingTotalPackages;

            testItem.AddParcel();
            testItem.AddParcel();

            Assert.AreEqual(testItem.PostingTotalPackages, numberOfParcels + 2);
        }
        [TestMethod()]
        public void ParcelAddTestFromData()
        {
            double totalWeight = 0;
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddParcel( SampleParcel1.ParcelInstance,   // 2
                                SampleParcel1.ParcelId,         // "TestParcel4"
                                SampleParcel1.ParcelWeight,     // 5.1
                                SampleParcel1.ParcelLength,     // 16
                                SampleParcel1.ParcelWidth,      // 8
                                SampleParcel1.ParcelHeight);    // 3
            totalWeight += SampleParcel1.ParcelWeight;

            Assert.AreNotEqual(testItem.PostingTotalPackages, 0);
            Assert.AreEqual(SampleParcel1.ParcelInstance, testItem.ParcelInstance); // 2
            Assert.AreEqual(SampleParcel1.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel1.ParcelWeight, testItem.ParcelWeight);     // 5.1
            Assert.AreEqual(SampleParcel1.ParcelLength, testItem.ParcelLength);     // 16
            Assert.AreEqual(SampleParcel1.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel1.ParcelHeight, testItem.ParcelHeight);     // 3
            Assert.AreEqual(totalWeight, testItem.PostingTotalWeight);
        }
        [TestMethod()]
        public void ParcelGetFirstTest()
        {
            double totalWeight = 0;
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            // First Parcel
            testItem.AddParcel( SampleParcel1.ParcelInstance,   // 2
                                SampleParcel1.ParcelId,         // "TestParcel1"
                                SampleParcel1.ParcelWeight,     // 5.1
                                SampleParcel1.ParcelLength,     // 16
                                SampleParcel1.ParcelWidth,      // 8
                                SampleParcel1.ParcelHeight);    // 3
            totalWeight += SampleParcel1.ParcelWeight;
            
            // Second Parcel
            testItem.AddParcel( SampleParcel2.ParcelInstance,   // 3
                                SampleParcel2.ParcelId,         // "TestParcel2"
                                SampleParcel2.ParcelWeight,     // 1.3
                                SampleParcel2.ParcelLength,     // 8
                                SampleParcel2.ParcelWidth,      // 3
                                SampleParcel2.ParcelHeight);    // 1
            totalWeight += SampleParcel2.ParcelWeight;

            // Third Parcel
            testItem.AddParcel( SampleParcel3.ParcelInstance,   // 6
                                SampleParcel3.ParcelId,         // "TestParcel3"
                                SampleParcel3.ParcelWeight,     // 0.2
                                SampleParcel3.ParcelLength,     // 5
                                SampleParcel3.ParcelWidth,      // 5
                                SampleParcel3.ParcelHeight);    // 2
            totalWeight += SampleParcel3.ParcelWeight;

            // Fourth Parcel
            testItem.AddParcel( SampleParcel4.ParcelInstance,   // 1
                                SampleParcel4.ParcelId,         // "TestParcel4"
                                SampleParcel4.ParcelWeight,     // 3.2
                                SampleParcel4.ParcelLength,     // 15
                                SampleParcel4.ParcelWidth,      // 8
                                SampleParcel4.ParcelHeight);    // 1
            totalWeight += SampleParcel4.ParcelWeight;


            bool hasFound = testItem.FindFirstParcel();

            Assert.AreEqual(4, testItem.PostingTotalPackages);
            Assert.AreEqual(totalWeight, testItem.PostingTotalWeight);
            // Has found the first parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel1.ParcelInstance, testItem.ParcelInstance); // 2, 5.1 , 3, 16, 8
            Assert.AreEqual(SampleParcel1.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel1.ParcelWeight, testItem.ParcelWeight);     // 5.1
            Assert.AreEqual(SampleParcel1.ParcelLength, testItem.ParcelLength);     // 16
            Assert.AreEqual(SampleParcel1.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel1.ParcelHeight, testItem.ParcelHeight);     // 3
        }
        [TestMethod()]
        public void ParcelGetLastTest()
        {
            double totalWeight = 0;
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            // First Parcel
            testItem.AddParcel(SampleParcel1.ParcelInstance,   // 2
                                SampleParcel1.ParcelId,         // "TestParcel4"
                                SampleParcel1.ParcelWeight,     // 5.1
                                SampleParcel1.ParcelLength,     // 16
                                SampleParcel1.ParcelWidth,      // 8
                                SampleParcel1.ParcelHeight);    // 3
            totalWeight += SampleParcel1.ParcelWeight;

            // Second Parcel
            testItem.AddParcel(SampleParcel2.ParcelInstance,   // 3
                                SampleParcel2.ParcelId,         // "TestParcel2"
                                SampleParcel2.ParcelWeight,     // 1.3
                                SampleParcel2.ParcelLength,     // 8
                                SampleParcel2.ParcelWidth,      // 3
                                SampleParcel2.ParcelHeight);    // 1
            totalWeight += SampleParcel2.ParcelWeight;

            // Third Parcel
            testItem.AddParcel(SampleParcel3.ParcelInstance,   // 6
                                SampleParcel3.ParcelId,         // "TestParcel3"
                                SampleParcel3.ParcelWeight,     // 0.2
                                SampleParcel3.ParcelLength,     // 5
                                SampleParcel3.ParcelWidth,      // 5
                                SampleParcel3.ParcelHeight);    // 2
            totalWeight += SampleParcel3.ParcelWeight;

            // Fourth Parcel
            testItem.AddParcel(SampleParcel4.ParcelInstance,   // 1
                                SampleParcel4.ParcelId,         // "TestParcel4"
                                SampleParcel4.ParcelWeight,     // 3.2
                                SampleParcel4.ParcelLength,     // 15
                                SampleParcel4.ParcelWidth,      // 8
                                SampleParcel4.ParcelHeight);    // 1
            totalWeight += SampleParcel4.ParcelWeight;


            bool hasFound = testItem.FindLastParcel();

            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(totalWeight, testItem.PostingTotalWeight);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel4.ParcelInstance, testItem.ParcelInstance); // 1
            Assert.AreEqual(SampleParcel4.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel4.ParcelWeight, testItem.ParcelWeight);     // 3.2
            Assert.AreEqual(SampleParcel4.ParcelLength, testItem.ParcelLength);     // 15
            Assert.AreEqual(SampleParcel4.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel4.ParcelHeight, testItem.ParcelHeight);     // 1
        }
        [TestMethod()]
        public void ParcelStepThroughTest()
        {
            double totalWeight = 0;
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            // First Parcel
            testItem.AddParcel(SampleParcel1.ParcelInstance,   // 2
                                SampleParcel1.ParcelId,         // "TestParcel4"
                                SampleParcel1.ParcelWeight,     // 5.1
                                SampleParcel1.ParcelLength,     // 16
                                SampleParcel1.ParcelWidth,      // 8
                                SampleParcel1.ParcelHeight);    // 3
            totalWeight += SampleParcel1.ParcelWeight;

            // Second Parcel
            testItem.AddParcel(SampleParcel2.ParcelInstance,   // 3
                                SampleParcel2.ParcelId,         // "TestParcel2"
                                SampleParcel2.ParcelWeight,     // 1.3
                                SampleParcel2.ParcelLength,     // 8
                                SampleParcel2.ParcelWidth,      // 3
                                SampleParcel2.ParcelHeight);    // 1
            totalWeight += SampleParcel2.ParcelWeight;

            // Third Parcel
            testItem.AddParcel(SampleParcel3.ParcelInstance,   // 6
                                SampleParcel3.ParcelId,         // "TestParcel3"
                                SampleParcel3.ParcelWeight,     // 0.2
                                SampleParcel3.ParcelLength,     // 5
                                SampleParcel3.ParcelWidth,      // 5
                                SampleParcel3.ParcelHeight);    // 2
            totalWeight += SampleParcel3.ParcelWeight;

            // Fourth Parcel
            testItem.AddParcel(SampleParcel4.ParcelInstance,   // 1
                                SampleParcel4.ParcelId,         // "TestParcel4"
                                SampleParcel4.ParcelWeight,     // 3.2
                                SampleParcel4.ParcelLength,     // 15
                                SampleParcel4.ParcelWidth,      // 8
                                SampleParcel4.ParcelHeight);    // 1
            totalWeight += SampleParcel4.ParcelWeight;


            bool hasFound = testItem.FindFirstParcel();

            // Check that we've got the first parcel correctly.
            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(totalWeight, testItem.PostingTotalWeight);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel1.ParcelInstance, testItem.ParcelInstance); // 2, 5.1 , 3, 16, 8
            Assert.AreEqual(SampleParcel1.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel1.ParcelWeight, testItem.ParcelWeight);     // 5.1
            Assert.AreEqual(SampleParcel1.ParcelLength, testItem.ParcelLength);     // 16
            Assert.AreEqual(SampleParcel1.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel1.ParcelHeight, testItem.ParcelHeight);     // 3

            hasFound = testItem.FindNextParcel();

            // Check that we've got the second parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel2.ParcelInstance, testItem.ParcelInstance); // 3
            Assert.AreEqual(SampleParcel2.ParcelId, testItem.ParcelId);             // "TestParcel2"
            Assert.AreEqual(SampleParcel2.ParcelWeight, testItem.ParcelWeight);     // 1.3
            Assert.AreEqual(SampleParcel2.ParcelLength, testItem.ParcelLength);     // 8
            Assert.AreEqual(SampleParcel2.ParcelWidth, testItem.ParcelWidth);       // 3
            Assert.AreEqual(SampleParcel2.ParcelHeight, testItem.ParcelHeight);     // 1

            hasFound = testItem.FindNextParcel();

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel3.ParcelInstance, testItem.ParcelInstance); // 6
            Assert.AreEqual(SampleParcel3.ParcelId, testItem.ParcelId);             // "TestParcel3"
            Assert.AreEqual(SampleParcel3.ParcelWeight, testItem.ParcelWeight);     // 0.2
            Assert.AreEqual(SampleParcel3.ParcelLength, testItem.ParcelLength);     // 5
            Assert.AreEqual(SampleParcel3.ParcelWidth, testItem.ParcelWidth);       // 5
            Assert.AreEqual(SampleParcel3.ParcelHeight, testItem.ParcelHeight);     // 2

            hasFound = testItem.FindNextParcel();

            // Check that we've got the fourth parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel4.ParcelInstance, testItem.ParcelInstance); // 1
            Assert.AreEqual(SampleParcel4.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel4.ParcelWeight, testItem.ParcelWeight);     // 3.2
            Assert.AreEqual(SampleParcel4.ParcelLength, testItem.ParcelLength);     // 15
            Assert.AreEqual(SampleParcel4.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel4.ParcelHeight, testItem.ParcelHeight);     // 1

            hasFound = testItem.FindNextParcel();
            // Check that we've not found any more parcels.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ParcelStepBackTest()
        {
            double totalWeight = 0;
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            // First Parcel
            testItem.AddParcel(SampleParcel1.ParcelInstance,   // 2
                                SampleParcel1.ParcelId,         // "TestParcel4"
                                SampleParcel1.ParcelWeight,     // 5.1
                                SampleParcel1.ParcelLength,     // 16
                                SampleParcel1.ParcelWidth,      // 8
                                SampleParcel1.ParcelHeight);    // 3
            totalWeight += SampleParcel1.ParcelWeight;

            // Second Parcel
            testItem.AddParcel(SampleParcel2.ParcelInstance,   // 3
                                SampleParcel2.ParcelId,         // "TestParcel2"
                                SampleParcel2.ParcelWeight,     // 1.3
                                SampleParcel2.ParcelLength,     // 8
                                SampleParcel2.ParcelWidth,      // 3
                                SampleParcel2.ParcelHeight);    // 1
            totalWeight += SampleParcel2.ParcelWeight;

            // Third Parcel
            testItem.AddParcel(SampleParcel3.ParcelInstance,   // 6
                                SampleParcel3.ParcelId,         // "TestParcel3"
                                SampleParcel3.ParcelWeight,     // 0.2
                                SampleParcel3.ParcelLength,     // 5
                                SampleParcel3.ParcelWidth,      // 5
                                SampleParcel3.ParcelHeight);    // 2
            totalWeight += SampleParcel3.ParcelWeight;

            // Fourth Parcel
            testItem.AddParcel(SampleParcel4.ParcelInstance,   // 1
                                SampleParcel4.ParcelId,         // "TestParcel4"
                                SampleParcel4.ParcelWeight,     // 3.2
                                SampleParcel4.ParcelLength,     // 15
                                SampleParcel4.ParcelWidth,      // 8
                                SampleParcel4.ParcelHeight);    // 1
            totalWeight += SampleParcel4.ParcelWeight;


            bool hasFound = testItem.FindLastParcel();

            // Check that we've got the last (fourth) parcel correctly.
            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(totalWeight, testItem.PostingTotalWeight);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel4.ParcelInstance, testItem.ParcelInstance); // 1
            Assert.AreEqual(SampleParcel4.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel4.ParcelWeight, testItem.ParcelWeight);     // 3.2
            Assert.AreEqual(SampleParcel4.ParcelLength, testItem.ParcelLength);     // 15
            Assert.AreEqual(SampleParcel4.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel4.ParcelHeight, testItem.ParcelHeight);     // 1

            hasFound = testItem.FindPrevParcel();

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(SampleParcel3.ParcelInstance, testItem.ParcelInstance); // 6
            Assert.AreEqual(SampleParcel3.ParcelId, testItem.ParcelId);             // "TestParcel3"
            Assert.AreEqual(SampleParcel3.ParcelWeight, testItem.ParcelWeight);     // 0.2
            Assert.AreEqual(SampleParcel3.ParcelLength, testItem.ParcelLength);     // 5
            Assert.AreEqual(SampleParcel3.ParcelWidth, testItem.ParcelWidth);       // 5
            Assert.AreEqual(SampleParcel3.ParcelHeight, testItem.ParcelHeight);     // 2

            hasFound = testItem.FindPrevParcel();

            // Check that we've got the second parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel2.ParcelInstance, testItem.ParcelInstance); // 3
            Assert.AreEqual(SampleParcel2.ParcelId, testItem.ParcelId);             // "TestParcel2"
            Assert.AreEqual(SampleParcel2.ParcelWeight, testItem.ParcelWeight);     // 1.3
            Assert.AreEqual(SampleParcel2.ParcelLength, testItem.ParcelLength);     // 8
            Assert.AreEqual(SampleParcel2.ParcelWidth, testItem.ParcelWidth);       // 3
            Assert.AreEqual(SampleParcel2.ParcelHeight, testItem.ParcelHeight);     // 1

            hasFound = testItem.FindPrevParcel();

            // Check that we've got the first parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel1.ParcelInstance, testItem.ParcelInstance); // 2, 5.1 , 3, 16, 8
            Assert.AreEqual(SampleParcel1.ParcelId, testItem.ParcelId);             // "TestParcel4"
            Assert.AreEqual(SampleParcel1.ParcelWeight, testItem.ParcelWeight);     // 5.1
            Assert.AreEqual(SampleParcel1.ParcelLength, testItem.ParcelLength);     // 16
            Assert.AreEqual(SampleParcel1.ParcelWidth, testItem.ParcelWidth);       // 8
            Assert.AreEqual(SampleParcel1.ParcelHeight, testItem.ParcelHeight);     // 3

            hasFound = testItem.FindPrevParcel();
            // Check that we've not found any more parcels.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ParcelGetSpecificTest()
        {
            double totalWeight = 0;
            TransferOrderData testItem;
         
            testItem = new TransferOrderData();
            // First Parcel
            testItem.AddParcel(SampleParcel1.ParcelInstance,   // 2
                                SampleParcel1.ParcelId,         // "TestParcel4"
                                SampleParcel1.ParcelWeight,     // 5.1
                                SampleParcel1.ParcelLength,     // 16
                                SampleParcel1.ParcelWidth,      // 8
                                SampleParcel1.ParcelHeight);    // 3
            totalWeight += SampleParcel1.ParcelWeight;

            // Second Parcel
            testItem.AddParcel(SampleParcel2.ParcelInstance,   // 3
                                SampleParcel2.ParcelId,         // "TestParcel2"
                                SampleParcel2.ParcelWeight,     // 1.3
                                SampleParcel2.ParcelLength,     // 8
                                SampleParcel2.ParcelWidth,      // 3
                                SampleParcel2.ParcelHeight);    // 1
            totalWeight += SampleParcel2.ParcelWeight;

            // Third Parcel
            testItem.AddParcel(SampleParcel3.ParcelInstance,   // 6
                                SampleParcel3.ParcelId,         // "TestParcel3"
                                SampleParcel3.ParcelWeight,     // 0.2
                                SampleParcel3.ParcelLength,     // 5
                                SampleParcel3.ParcelWidth,      // 5
                                SampleParcel3.ParcelHeight);    // 2
            totalWeight += SampleParcel3.ParcelWeight;

            // Fourth Parcel
            testItem.AddParcel(SampleParcel4.ParcelInstance,   // 1
                                SampleParcel4.ParcelId,         // "TestParcel4"
                                SampleParcel4.ParcelWeight,     // 3.2
                                SampleParcel4.ParcelLength,     // 15
                                SampleParcel4.ParcelWidth,      // 8
                                SampleParcel4.ParcelHeight);    // 1
            totalWeight += SampleParcel4.ParcelWeight;


            bool hasFound = testItem.FindSpecificParcel(2);

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(4, testItem.PostingTotalPackages);
            Assert.AreEqual(totalWeight, testItem.PostingTotalWeight);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(SampleParcel3.ParcelInstance, testItem.ParcelInstance); // 6
            Assert.AreEqual(SampleParcel3.ParcelId, testItem.ParcelId);             // "TestParcel3"
            Assert.AreEqual(SampleParcel3.ParcelWeight, testItem.ParcelWeight);     // 0.2
            Assert.AreEqual(SampleParcel3.ParcelLength, testItem.ParcelLength);     // 5
            Assert.AreEqual(SampleParcel3.ParcelWidth, testItem.ParcelWidth);       // 5
            Assert.AreEqual(SampleParcel3.ParcelHeight, testItem.ParcelHeight);     // 2
        }
        #endregion

        #region ItemTests
        [TestMethod()]
        public void ItemAddBlankTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem();

            Assert.AreNotEqual(testItem.TotalItemCount, 0);
        }
        [TestMethod()]
        public void ItemAddTwiceTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            int numberOfItems = testItem.TotalItemCount;

            testItem.AddItem();
            testItem.AddItem();

            Assert.AreEqual(testItem.TotalItemCount, numberOfItems + 2);
        }
        [TestMethod()]
        public void ItemAddTestFromData()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", "");

            Assert.AreEqual(testItem.TotalItemCount, 1);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");
        }
        [TestMethod()]
        public void ItemGetFirstTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindFirstItem();

            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");
        }
        [TestMethod()]
        public void ItemGetLastTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindLastItem();

            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "4");
            Assert.AreEqual(testItem.ItemQuantity, 8);
            Assert.AreEqual(testItem.ItemParcelInstance, 1);
            Assert.AreEqual(testItem.ItemDescription, "Brick 1x2");
            Assert.AreEqual(testItem.ItemValue, 0.24);
            Assert.AreEqual(testItem.ItemWeight, 0.24);
            Assert.AreEqual(testItem.ItemHsCode, "Code7");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU7");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "China");
            Assert.AreEqual(testItem.ItemImageUrl, "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P");
        }
        [TestMethod()]
        public void ItemStepThroughTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindFirstItem();

            // Check that we've got the first item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the second item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "5");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Turntable 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.12);
            Assert.AreEqual(testItem.ItemWeight, 0.03);
            Assert.AreEqual(testItem.ItemHsCode, "Code3");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the third item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "2");
            Assert.AreEqual(testItem.ItemQuantity, 2);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Tile 2x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code2");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU2");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the fourth item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "3");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Round Brick 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.15);
            Assert.AreEqual(testItem.ItemWeight, 0.05);
            Assert.AreEqual(testItem.ItemHsCode, "Code4");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU4");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the last (fifth) item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "4");
            Assert.AreEqual(testItem.ItemQuantity, 8);
            Assert.AreEqual(testItem.ItemParcelInstance, 1);
            Assert.AreEqual(testItem.ItemDescription, "Brick 1x2");
            Assert.AreEqual(testItem.ItemValue, 0.24);
            Assert.AreEqual(testItem.ItemWeight, 0.24);
            Assert.AreEqual(testItem.ItemHsCode, "Code7");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU7");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "China");
            Assert.AreEqual(testItem.ItemImageUrl, "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P");

            hasFound = testItem.FindNextItem();
            // Check that we've not found any more item.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ItemStepBackTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindLastItem();

            //// Check that we've got the last (fifth) item correctly.
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "4");
            Assert.AreEqual(testItem.ItemQuantity, 8);
            Assert.AreEqual(testItem.ItemParcelInstance, 1);
            Assert.AreEqual(testItem.ItemDescription, "Brick 1x2");
            Assert.AreEqual(testItem.ItemValue, 0.24);
            Assert.AreEqual(testItem.ItemWeight, 0.24);
            Assert.AreEqual(testItem.ItemHsCode, "Code7");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU7");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "China");
            Assert.AreEqual(testItem.ItemImageUrl, "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the fourth item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "3");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Round Brick 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.15);
            Assert.AreEqual(testItem.ItemWeight, 0.05);
            Assert.AreEqual(testItem.ItemHsCode, "Code4");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU4");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the third item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "2");
            Assert.AreEqual(testItem.ItemQuantity, 2);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Tile 2x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code2");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU2");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the second item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "5");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Turntable 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.12);
            Assert.AreEqual(testItem.ItemWeight, 0.03);
            Assert.AreEqual(testItem.ItemHsCode, "Code3");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the first item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();
            // Check that we've not found any more item.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ItemGetSpecificTest()
        {
            TransferOrderData testItem;

            testItem = new TransferOrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindSpecificItem(2);

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "2");
            Assert.AreEqual(testItem.ItemQuantity, 2);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Tile 2x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code2");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU2");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");
        }
        #endregion
    }
}