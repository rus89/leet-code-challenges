**Description**

One of the basic structures in algorithm which can be used to achieve lots of funny algorithms and problems.

**Problems**

There will be some of the most typical problems in this aspect, which I believe almost covers all the basic techniques that you need to solve a linked list problem.

---

**Remove Duplicates from Sorted List**

Given a sorted linked list, delete all duplicates such that each element appear only once.

> For example
> 
> Given 1->1->2, return 1->2
> 
> Given 1->1->2->3->3, return 1->2->3.

**Solution**

We can just solve it like in an array using another index to collect the valid nodes. Here, once I made a serious mistake inserting extra `;` after `while` which directly result in an in-debuggeable situation.

---

**Remove Duplicates from Sorted List II**

Given a sorted linked list, delete all nodes that have duplicate numbers, leaving only distinct numbers from the original list.

>For example, 
> 
> Given 1->2->3->3->4->4->5, return 1->2->5.
> 
> Given 1->1->1->2->3, return 2->3.

---

**Palindrome Linked List**

Given a singly linked list, determine if it is a palindrome.

> Follow up:
> 
> Could you do it in O(n) time and O(1) space?

---

**Rotate List**

Given a list, rotate the list to the right by k places, where k is non-negative.

> For example:
> 
> Given 1->2->3->4->5->NULL and k = 2,
> 
> return 4->5->1->2->3->NULL.

---

~~~~




























