using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void addToTail(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                tail.next = p;               
                p.previous = tail;
                tail = p;
            }
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head.previous = p;
                head = p;
            }
            return;
        } // end of addToHead

        public void removHead()
        {
            if (head == null)
            {
                return;
            }

            head = head.next;
            head.previous = null;


        } // removeHead

        public void removeTail()
        {
            if (tail == null)
            {   
                return;
            } 
            if (head == tail)
            {
                head = null;
                tail = null;
                return;
            }
        } // remove tail

        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            DLLNode p = head;

            while (p != null)
            {
                
                if (p.num == num) break;
                else
                    p = p.next;
            }
            return p;
        } // end of search (return pointer to the node);

        public void removeNode(DLLNode p)
        { // removing the node p.

            if (p == null)
            {
                return;
            }
            else
            {
                DLLNode temp = head;
                while (temp != null)
                {
                    if (temp.num == p.num)
                    {
                        if (head == temp)
                        {
                            head = temp.next;
                        }
                        if (tail == temp)
                        {
                            tail = temp.previous;
                        }
                        if (temp.next != null)
                        {
                            temp.next.previous = temp.previous;
                        }
                        if (temp.previous != null)
                        {
                            temp.previous.next = temp.next;
                        }
                    }
                    temp = temp.next;
                }
            }
            return;
        } // end of remove a node

        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next.next;
            }
            return (tot);
        } // end of total

    } // end of DLList class
}
