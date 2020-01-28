using System;

namespace VList
{
    internal class VList
        {
            internal Node head;

            public class Node
            {
                internal int data;
                internal int key;
                internal Node next;
                public Node(int data,int key)
                {

                    this.key = key;
                    this.data = data;
                    next = null;
                }
        }

            internal void Add(VList vlist, int new_data,int new_key)
            {
                Node new_node = new Node(new_data,new_key);
                if (vlist.head == null)
                {
                    vlist.head = new_node;
                    return;
                }
                Node lastNode = GetLastNode(vlist);
                lastNode.next = new_node;
            }

            internal Node GetLastNode(VList vList)
            {
                Node temp = vList.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                return temp;
            }

            internal void Remove(VList vList, int key)
            {
                Node temp = vList.head;
                Node prev = null;
                if (temp != null && temp.key == key)
                {
                    vList.head = temp.next;
                    return;
                }
                while (temp != null && temp.key != key)
                {
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;
            }


            internal void Print(VList vList)
            {
                Node n = vList.head;
                while (n != null)
                {
                    Console.Write("Key: " + n.key);
                    Console.WriteLine("Data: " + n.data + " ");
                    n = n.next;
                }
           // Console.ReadLine();
            }

            internal bool Search(VList vList, int data)
            {
                Node n = vList.head;
                int flag = 0;
            while (n != null)
                {
                    if (n.data == data)
                    {
                        flag = 1;
                        
                    }
                    n = n.next;
                }
             if (flag == 1)
                return true;
             else
                return false;
            }

        internal int KSearch(VList vList, int data)
        {
            Node n = vList.head;
            int flag = 0;
            int key = 0;
            while (n != null)
            {
                if (n.data == data)
                {
                    key = n.key;
                    flag = 1;
                }
                n = n.next;
            }
            if (flag == 1)
                return key;
            else
                return 999;
        }

        internal int DSearch(VList vList, int key)
        {
            Node n = vList.head;
            int flag = 0;
            int data = 0;
            while (n != null)
            {
                if (n.key == key)
                {
                    data = n.data;
                    flag = 1;
                }
                n = n.next;
            }
            if (flag == 1)
                return data;
            else
                return 999;
        }


    }

   
}
