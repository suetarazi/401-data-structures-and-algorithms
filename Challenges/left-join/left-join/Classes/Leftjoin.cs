using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace left_join.Classes
{
    public class Leftjoin
    {
        /// <summary>
        /// method that performs a left join of two hashmaps and returns a hashtable
        /// </summary>
        /// <param name="hashmap1">hashmap of key:value pairs</param>
        /// <param name="hashmap2">hashmap of key:value pairs</param>
        /// <returns></returns>
        public Hashtable LeftJoin (Hashtable hashmap1, Hashtable hashmap2)
        {
            //input are two hashmaps (note hashmaps are a fixed size and do not allow for linked lists or collisions
            //create a hashtable:
            Hashtable hashtable = new Hashtable();
            //take hashmap1 and put it into a hashtable
            foreach(Node node in hashmap1)
            {
                node.Key = key;
                node.Value = value;
                node2.Key = key2;
                node2.Value = Value2;
                hashtable.Add(key, value);
            //take hashmap2 and for each value, if hashtable.Contains(key) && hashmap2.Contains(key), then add the key, value pair to hashtable; else add Null to any values only the hashtable. 
                foreach(Node node2 in hashmap2)
                {
                    if(hashtable.Contains(key2) == node2.key2)
                    {
                        hashtable.Add(key2, value2);
                    }
                }
            return hashtable;
                        
            }
        }



    }
}
