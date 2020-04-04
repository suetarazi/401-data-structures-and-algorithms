using System;
using System.Collections.Generic;
using System.Text;

namespace Fifo_Animal_Shelter
{
    public class AnimalShelter
    {
    
        Node front = null;
        Node rear = null;
        
        /// <summary>
        /// method to add a new animal to the rear of the queue 
        /// </summary>
        /// <param name="animal">animal is the cat or dog being added</param>
        public void Enqueue(string animal)
        {
            Node node = new Node();

            if (rear != null)
            {
                node.Value = animal;
                rear.Next = node;
                node = rear;
            }

        }

        /// <summary>
        /// method to remove the next animal from the front of the line (cat or dog); if 'pref' is not a cat or dog, method returns null.
        /// </summary>
        /// <param name="pref">string - the request for the next animal</param>
        /// <returns></returns>
        public string Dequeue(string pref)
        {
            if(pref != "cat" || pref != "dog")
            {
                return null;
            }
            else 
            {
                var temp = front;
                front = front.Next;
                front.Next = null;
                return front.Value;
            }
                

        }
    
    }
}
