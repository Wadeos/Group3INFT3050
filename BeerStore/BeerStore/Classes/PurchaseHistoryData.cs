using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;

namespace BeerStore.Classes
{
    [DataObject(true)]
    public class PurchaseHistoryData
    {
        public PurchaseHistoryData()
        {
            p_purchase.Add(new PurchaseHistory() { OrderID = 1, Date = new DateTime(2018, 1, 1, 18, 24, 36), Product = "Tooheys", Price = 9.99, Quantity = 1, Status = "Complete", Total = 9.99 });
            p_purchase.Add(new PurchaseHistory() { OrderID = 1, Date = new DateTime(2018, 6, 4, 8, 24, 36), Product = "Corona", Price = 10, Quantity = 2, Status = "Complete", Total = 20 });
            p_purchase.Add(new PurchaseHistory() { OrderID = 1, Date = new DateTime(2018, 7, 24, 23, 59, 59), Product = "Tooheys", Price = 9.99, Quantity = 6, Status = "Complete", Total = 59.94 });
            p_purchase.Add(new PurchaseHistory() { OrderID = 1, Date = new DateTime(2018, 8, 11, 18, 30, 30), Product = "Tooheys", Price = 9.99, Quantity = 1, Status = "Pending", Total = 9.99 });
        }

        public List<PurchaseHistory> PurchaseHistory
        {
            get { return p_purchase; }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public PurchaseHistory GetPurchaseHistory(int id)
        {
            foreach (PurchaseHistory p in p_purchase)
            {
                if (p.OrderID == id)
                    return p;
            }
            return null;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<PurchaseHistory> GetPurchaseHistory()
        {
            return p_purchase;
        }

        private List<PurchaseHistory> p_purchase = new List<PurchaseHistory>();
    }
}