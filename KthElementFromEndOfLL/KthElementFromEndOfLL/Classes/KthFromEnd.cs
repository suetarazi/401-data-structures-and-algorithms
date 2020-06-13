using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace KthElementFromEndOfLL.Classes
{
    
    public class KthFromEnd
    {
        public Node Head { get; set; }
        private Node Current { get; set; }

        /// <summary>
        /// This challenge is the tortise and the hare (or the walker and the runner). We need two variables (one to travel to the end of the LL (var = i) and one that is i-k behind it (we'll assign that to Current). When i.Next = Null, we are at end end of the LL and we can return Current.Value as the value of the kth from the end node.  
        /// </summary>
        /// <param name="k">int</param>
        /// <returns>int value</returns>
        public int LLKthFromEnd(LinkedList ll, int k)
        {
                        
            int i = 0;
            int j = i - k;

            Current = Head;
            while(Current != Null)
            {
                Node.Next = Head;
                i = i + 1;
                Node.Current = j;
                j = i - k;
            }
            return Current.Value;
        }
    }
}
