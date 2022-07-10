using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ITransactionRepository
    {
        public IEnumerable<CoreBusiness.Transaction> Get(string cashierName);
        public IEnumerable<CoreBusiness.Transaction> GetByDay(string cashierName, DateTime date);
        public IEnumerable<CoreBusiness.Transaction> Search(string cashierName, DateTime startDate, DateTime dateTime);
        public void Save(string cashierName, int ProductId, string productName, double price, int beforeQty, int soldQty);
    }
}
