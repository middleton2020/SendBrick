using System;
using System.Collections.Generic;
using System.Text;
using CM.SendBrick.Library.Data;
using CM.SendBrick.Library.Core;
using CM.JsonTools;

namespace CM.SendBrick.Library.BrickLink
{
    public class BrickLinkComs
    {
        private OrderManager _orderManager = null;
        private TransferOrderData _order = null;
        private int _currentOrder = 0;

        public BrickLinkComs()
        {
            try
            {
                JsonReader.DeligateMakeClass makeClass = new JsonReader.DeligateMakeClass(MakeClass);
                JsonReader.DeligateCloseClass closeClass = new JsonReader.DeligateCloseClass(CloseClass);
                JsonReader.DeligateMakeArray makeArray = new JsonReader.DeligateMakeArray(MakeArray);
                JsonReader.DeligateCloseArray closeArray = new JsonReader.DeligateCloseArray(CloseArray);
                JsonReader.DeligateSetBoolean setBoolean = new JsonReader.DeligateSetBoolean(SetField);
                JsonReader.DeligateSetDecimal setDecimal = new JsonReader.DeligateSetDecimal(SetField);
                JsonReader.DeligateSetInteger setInteger = new JsonReader.DeligateSetInteger(SetField);
                JsonReader.DeligateSetString setString = new JsonReader.DeligateSetString(SetField);

                JsonReader jsonReader = new JsonReader(makeClass, closeClass,
                    makeArray, closeArray, setBoolean, setDecimal, setInteger,
                    setString);

                if (_orderManager == null)
                {
                    _orderManager = new OrderManager();
                }
            }
            catch
            {
                throw;
            }
        }

        public BrickLinkComs(OrderManager inpManager) : this()
        {
            try
            {
                _orderManager = inpManager;
            }
            catch
            {
                throw;
            }
        }

        public void MakeClass(string inpName)
        {
            try
            {
                if (inpName == "" || inpName == "Root")
                {
                    _order = new TransferOrderData();
                    _currentOrder = _orderManager.AddOrder(_order);
                    _order.SourceSystem = SystemTypes.SourceSystemType.BrickLink;
                }
                else if (inpName == "payment")
                {
                    _orderManager.GetOrder(_currentOrder);
                }
                else if (inpName == "shipping")
                {
                    _orderManager.GetOrder(_currentOrder);
                }
                //else if (inpName == "shipping")
                //{

                //}
                else if (inpName == "address")
                {
                    _orderManager.GetOrder(_currentOrder);
                }
                else if (inpName == "name")
                {
                    _orderManager.GetOrder(_currentOrder);
                }
                else if (inpName == "cost")
                {
                    _orderManager.GetOrder(_currentOrder);
                }
                else if (inpName == "disp_cost")
                {
                    _orderManager.GetOrder(_currentOrder);
                }
                else if (inpName == "external_lot_ids")
                {

                }
                else if (inpName == "ids")
                {

                }
            }
            catch
            {
                throw;
            }
        }
        public void CloseClass(string inpName)
        {
            try
            {

            }
            catch
            {
                throw;
            }
        }
        public void MakeArray(string inpName)
        {
            try
            {
                if (inpName == "" || inpName == "Root")
                {

                }
                else if (inpName == "ids")
                {

                }
            }
            catch
            {
                throw;
            }
        }
        public void CloseArray(string inpName)
        {
            try
            {
                switch (inpName)
                {
                }
            }
            catch
            {
                throw;
            }
        }
        public void SetField(string inpName, bool inpValue)
        {
            try
            {
                switch (inpName)
                {
                }
            }
            catch
            {
                throw;
            }
        }
        public void SetField(string inpName, decimal inpValue)
        {
            try
            {
                switch (inpName)
                {
                }
            }
            catch
            {
                throw;
            }
        }
        public void SetField(string inpName, int inpValue)
        {
            try
            {
                switch (inpName)
                {
                    case "order_id":
                        _order.SupplierReference1 = inpValue.ToString();
                        break;
                }
            }
            catch
            {
                throw;
            }
        }
        public void SetField(string inpName, string inpValue)
        {
            try
            {
                switch (inpName)
                {
                    case "date_ordered":
                        _order.PostingDate = Convert.ToDateTime(inpValue);
                        break;
                    case "seller_name":
                        _order.SupplierContactName = inpValue;
                        break;
                    case "store_name":
                        _order.SupplierBusinessName = inpValue;
                        break;
                    case "buyer_name":
                        _order.CustomerContactName = inpValue;
                        break;
                    case "buyer_email":
                        _order.CustomerEmailAddress = inpValue;
                        break;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
