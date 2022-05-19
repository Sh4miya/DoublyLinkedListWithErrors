using DoublyLinkedListWithErrors;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Name: Lizzie Corbett
        //Student ID: 20498620

        [TestMethod]
        public void addHeadWhenListNotEmpty() //add head when list is not empty
        {
            DLLNode p = new DLLNode(33);
            DLLNode q = new DLLNode(5);
            DLList l = new DLList();
            l.addToHead(p);
            l.addToHead(q);
            Assert.AreSame(l.head, q);
        }

        [TestMethod]
        public void addHeadWhenListEmpty() //add head when list is empty
        {
            DLLNode p = new DLLNode(20);
            DLList l = new DLList();
            l.addToHead(p);
            Assert.AreSame(l.head, p); //check head is node p
        }

        [TestMethod]
        public void removeHeadFromList() //removing the head of the list
        {
            DLLNode p = new DLLNode(14);
            DLLNode q = new DLLNode(15);
            DLLNode r = new DLLNode(3);
            DLList l = new DLList();
            l.addToHead(p);
            l.addToHead(q);
            l.addToHead(r);
            l.removHead();

            Assert.AreSame(l.head, q); //check head is node q
        }

        [TestMethod]
        public void removeHeadFromEmptyList() //removing the head from empty list
        {
            DLList l = new DLList();

            l.removHead();

            Assert.IsNull(l.head); //check is null
        }

        [TestMethod]
        public void addTailWhenListNotEmpty() //add tail when list not empty
        {
            DLLNode p = new DLLNode(2);
            DLLNode q = new DLLNode(69);
            DLList l = new DLList();
            l.addToTail(p);
            l.addToTail(q);

            Assert.AreSame(l.tail, q); //check tail is q

        }

        [TestMethod]
        public void addTailToEmptyList() //add tail to empty list
        {
            DLLNode p = new DLLNode(5);
            DLList l = new DLList();
            l.addToTail(p);

            Assert.AreSame(l.tail, p); //check tail is p

        }

        [TestMethod]
        public void removeTailFromEmptyList() //remove tail from empty list
        {
            DLList l = new DLList();
            l.removeTail();
            Assert.IsNull(l.tail); //check is null
        }

        [TestMethod]
        public void removeTailFromList() //remove tail from list
        {
            DLLNode p = new DLLNode(2);
            DLLNode q = new DLLNode(69);
            DLLNode r = new DLLNode(6);
            DLLNode s = new DLLNode(24);
            DLList l = new DLList();

            l.addToHead(p);
            l.addToHead(q);
            l.addToHead(r);
            l.addToHead(s);

            l.removeNode(p);

            Assert.AreSame(l.tail, q); //check removed node p by confirming the new head is q

        }

        [TestMethod]
        public void searchNodeFromList() // search for node '6' and return result
        {
            DLLNode p = new DLLNode(2);
            DLLNode q = new DLLNode(69);
            DLLNode r = new DLLNode(6);
            DLLNode s = new DLLNode(24);
            DLList l = new DLList();

            l.addToHead(p);
            l.addToHead(q);
            l.addToHead(r);
            l.addToHead(s);

            DLLNode result = l.search(6);
            Assert.AreSame(result, r); //check the node has been correctly found

        }

        [TestMethod]
        public void searchNodeFromListThatDoesntExist() // search for node '6' and return result
        {
            DLLNode p = new DLLNode(2);
            DLLNode q = new DLLNode(69);
            DLLNode r = new DLLNode(6);
            DLLNode s = new DLLNode(24);
            DLList l = new DLList();

            l.addToHead(p);
            l.addToHead(q);
            l.addToHead(r);
            l.addToHead(s);

            DLLNode result = l.search(7);
            Assert.IsNull(result); //check the node has not been found

        }

        [TestMethod]
        public void searchHeadNode()
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);

            DLList l = new DLList();

            l.addToHead(a);
            l.addToHead(b);
            l.addToHead(c);

            DLLNode result = l.search(3);
            Assert.AreSame(l.head, result); //check the head node and search are the same

        }

        [TestMethod]
        public void searchTailNode()
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);

            DLList l = new DLList();

            l.addToTail(a);
            l.addToTail(b);
            l.addToTail(c);

            DLLNode result = l.search(3);
            Assert.AreSame(l.tail, result); //check the tail node and the search are the same

        }

        [TestMethod]
        public void searchNodeFromEmptyList() //search for node in an empty list
        {

            DLList l = new DLList();
            DLLNode result = l.search(3);
            Assert.IsNull(result); //check is null

        }

        [TestMethod]
        public void removeNodeFromListTail()
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);

            DLList l = new DLList();

            l.addToHead(a);
            l.addToHead(b);
            l.addToHead(c);
            l.removeNode(a);

            Assert.AreSame(l.tail, b); //check new tail is b

        }

        [TestMethod]
        public void removeNodeFromListHead()
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);

            DLList l = new DLList();

            l.addToHead(a);
            l.addToHead(b);
            l.addToHead(c);
            l.addToHead(d);

            l.removeNode(d);

            Assert.AreSame(l.head, c); // check node c is new head 

        }

        [TestMethod]
        public void removeNodeFromMiddle()
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);

            DLList l = new DLList();

            l.addToHead(a);
            l.addToHead(b);
            l.addToHead(c);

            l.removeNode(b);

            Assert.AreSame(l.head.next, a); //check middle node has been removed

        }

        [TestMethod]
        public void removeNodeFromEmptyList()
        {
            DLLNode a = new DLLNode(1);

            DLList l = new DLList();

            l.removeNode(a);

            Assert.IsNull(l.head); //attempt to remove head and return null if doesnt exist

        }

        [TestMethod]
        public void checkIsNotPrime()
        {
            DLLNode a = new DLLNode(9);

            DLList l = new DLList();

            l.addToHead(a);

            bool checkPrime = a.isPrime(l.head.num); // confirming node is not prime

            Assert.IsFalse(checkPrime);

        }

        [TestMethod]
        public void checkIsPrime()
        {
            DLLNode a = new DLLNode(3);

            DLList l = new DLList();

            l.addToHead(a);

            bool checkPrimeOne = a.isPrime(l.head.num); // check if node is prime

            Assert.IsTrue(checkPrimeOne);

        }

        [TestMethod]
        public void checkIsNotPrimeNegative()
        {
            DLLNode a = new DLLNode(-2);

            DLList l = new DLList();

            l.addToHead(a);

            bool checkPrimeOne = a.isPrime(l.head.num); //check negative number

            Assert.IsFalse(checkPrimeOne);

        }

        [TestMethod]
        public void checkTotal()
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);

            DLList l = new DLList();

            l.addToHead(a);
            l.addToHead(b);

            int t = l.total();

            Assert.AreEqual(t, 2); //check the total is correct
        }

        [TestMethod]
        public void checkTotalEmptyList()
        {
            DLList l = new DLList();

            int t = l.total();

            Assert.AreEqual(t, 0); //check total of an empty list is 0
        }

    }
}
