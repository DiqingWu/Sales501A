using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501sales
{
    static class RebatesDataBase
    {
        static private Dictionary<string, Rebates> _rebatesDataBase = new Dictionary<string, Rebates>();

        static public void AddRebates(DateTime date,string item,double off)
        {
            off = 1 - off / 100;
            
            if(!CheckRebatesExist(item))
            {
                _rebatesDataBase.Add(item, new Rebates(date, off));
            }
            else
            {
                _rebatesDataBase[item].Date = date;
                if (off < _rebatesDataBase[item].Off)
                    _rebatesDataBase[item].Off = off;
            }
            
        }
        static public bool CheckRebatesExist(string b)
        {
            foreach (string s in _rebatesDataBase.Keys)
            {
                if (s == b)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// check and find vaildrebates.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        static public Rebates FindVaildRebates(string item)
        {
            if (!CheckRebatesExist(item))
                return null;
            return _rebatesDataBase[item];
        }
        static public int CheckValidRebates(DateTime time, Rebates rebate)
        {
            DateTime latestDate = rebate.Date;
            latestDate.AddDays(15);
            latestDate.AddMonths(1);
            // add 1month and 15 to see the expaire date.
            return DateTime.Compare(latestDate, time);
        }
        /// <summary>
        /// method function to combine FindVaildRebates and CheckValidRebates
        /// will return -1 if out of date. return 0 if no rebate found
        /// </summary>
        /// <param name="time"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        static public double GetOff(DateTime time, string item)
        {
            Rebates currentRebates = FindVaildRebates(item);
            if (currentRebates == null)
                return 1;
            if(CheckValidRebates(time, currentRebates) < 0)
            {
                return 1; // out of date
            }
            else
            {
                return currentRebates.Off;
            }

        }
    }
}
