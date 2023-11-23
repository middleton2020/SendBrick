using System;
using System.Collections.Generic;
using System.Text;

namespace CM.SendBrick.Library.Data
{
    public class OrderManager
    {
        private Dictionary<int, IOrderData> _ordersList = new Dictionary<int, IOrderData>();
        private int _sequence = -1;

        public int AddOrder(IOrderData OrderData)
        {
            _sequence += 1;
            _ordersList.Add(_sequence, OrderData);

            return _sequence;
        }

        public IOrderData GetOrder(int Instance)
        {
            IOrderData orderRecord = null;

            if (Instance < 0 || Instance > _sequence)
            {
                throw new IndexOutOfRangeException("There is no order with ID " + Instance.ToString());
            }

            orderRecord = _ordersList[Instance];
            if (orderRecord == null)
            {
                throw new KeyNotFoundException("No valid order with ID " + Instance.ToString());
            }

            return orderRecord;
        }
    }
}
