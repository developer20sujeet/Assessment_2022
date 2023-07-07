
using SingleLinkedList;

SingleLinkedLists singleLinkedList   = new SingleLinkedLists();

singleLinkedList.printAll(singleLinkedList);
singleLinkedList.AddFirst(1);
singleLinkedList.printAll(singleLinkedList);
singleLinkedList.AddLast(2);
singleLinkedList.printAll(singleLinkedList);
singleLinkedList.AddLast(3);
singleLinkedList.printAll(singleLinkedList);
singleLinkedList.AddLast(4);
singleLinkedList.printAll(singleLinkedList);

singleLinkedList.AddMiddle(2, 22);
singleLinkedList.printAll(singleLinkedList);

singleLinkedList.IterativeReverseSinglyLinkedLIst(singleLinkedList.head);
string s;
s = singleLinkedList.ToString();