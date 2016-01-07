using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
   public class ListDictionary<tkey, tvalue>
    {
        private List<tvalue> Values { get; set; }
        private int hashedIndex;

        public ListDictionary()
        {
            Values = new List<tvalue>(new tvalue [500000]); 
        }
        
        public List<tvalue> publicValues
        {
            get { return Values; }
            set { Values = value; }
        }
        

        public int calculateHash(tvalue value)
        {
            
           int sum = 0;
            string hashedValue = value.ToString();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(hashedValue);
            foreach (byte ascii in asciiBytes)
            {
                sum += ascii;
            }
            return sum;
        }
        public int calculateHash(tkey value)
        {
            int sum = 0;
            string hashedValue = value.ToString();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(hashedValue);
            foreach (byte ascii in asciiBytes)
            {
                sum += ascii;
            }
            return sum;
        }
        #region oldHash
        //public int getIndex(int hashedCode)
        //{
        //    string hashed = hashedCode.ToString();
        //    char lastItem = hashed[hashed.Length];
        //    int lastInt = Convert.ToInt32(lastItem);
        //    if (lastInt== 0)
        //    {
        //        hashedIndex = 0;
        //    }
        //    else
        //    {
        //        hashedIndex = lastInt *= 2;
        //    }
        //    return hashedIndex;

        //}
        #endregion


        public tvalue getItemFromDictionary(tkey item)
        {
            int index = calculateHash(item);
            tvalue value = (Values[index]);
            return value;
        }
        public tvalue getItemFromDictionaryByHash(int index)
        {
            tvalue value = (Values[index]);
            return value;
        }

        public void addItemToDictionary(tvalue item)
        {
            int index = calculateHash(item);
            //Console.WriteLine("Index " + index);
            Values[index] = item;
        }
     
    }
}
