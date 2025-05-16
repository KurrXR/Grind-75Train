/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode(0); // 建立虛擬節點作為結果的頭節點
        var tail = dummy;

        while (list1 != null && list2 != null){
            if (list1.val<list2.val){
                tail.next = list1;
                list1 = list1.next;
            }
            else{
                tail.next = list2;
                list2 = list2.next;
        }
        tail = tail.next;
        }
        tail.next = list1 ?? list2; // 將剩餘的節點接到結果的尾節點
        return dummy.next;
    }
  
}