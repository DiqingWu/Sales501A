using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501sales
{
    static class TransactionDataBase
    {
        static private Dictionary<int, Tansaction> _transactionDataBase = new Dictionary<int, Tansaction>();
        /// <summary>
        /// constuctor for database
        /// </summary>
        /// <param name="first"></param>
        /// <param name="last"></param>
        /// <param name="items"></param>
        /// <param name="address"></param>
        /// <param name="cost"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="date"></param>
        static public void AddTransaction(string first, string last, string[] items, string address, int[] cost, string email, int id, DateTime date)
        {

            if (!CheckTransactionExist(id))
            {
                _transactionDataBase.Add(id,new Tansaction(first,last,items,address,cost,email,id,date));
            }
            else
            {
                // return something
                //error beacuse id is already exist
            }

        }
        /// <summary>
        /// check keyvalue is exist.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        static public bool CheckTransactionExist(int b)
        {
            foreach (int s in _transactionDataBase.Keys)
            {
                if (s == b)
                    return true;
            }
            return false;
        }
    }
}
