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

**Reverse Linked list II**

Reverse a linked list from position m to n. Do it in-place and in one-pass.

> For example:
> 
> Given 1->2->3->4->5->NULL, m = 2 and n = 4,
> 
> return 1->4->3->2->5->NULL.

> Note: Given m, n satisfy the following condition: 1 ≤ m ≤ n ≤ length of list.

---

**Linked List Cycle II**

Given a linked list, return the node where the cycle begins. If there is no cycle, return null. Note: Do not modify the linked list.

> Follow up:
> 
> Can you solve it without using extra space?

**Solution**

Actually we can just use set.insert(key).second to check but it will take up O(n) space which is quite an awful waste, so here we just going to check the circle and then locate it.

- If there is a circle then once the slow meets the fast the first time, there will be a formula as follows: a+b+kl = 2(a+b) -> kl-b = a (a is the length between the head and the start of the circle, b is the steps the slow pointer moves in the circle while l is the length of the circle).

- After that we can reset the fast and slow down the fast (same speed as the slow using kl-b = a) then once they meet again, the location will be the start of the circle.

At last we take up constant space to solve this and traverse the linked list twice at most (as for the slow pointer).

---

**Reverse Nodes in k-Group**

Given a linked list, reverse the nodes of a linked list k at a time and return its modified list. 

If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is. 

You may not alter the values in the nodes, only nodes itself may be changed. 

Only constant memory is allowed.

> For example,
> 
> Given this linked list: 1->2->3->4->5
> 
> For k = 2, you should return: 2->1->4->3->5
> 
> For k = 3, you should return: 3->2->1->4->5

---

~~~~




























