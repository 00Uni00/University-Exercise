namespace Array_1D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Case
            //--------------------------------------------
            int[] a = new int[] { -2, -1, 0, 1, 4 };
            int[] b = new int[] { -3, -2, -1, 1, 2, 3 };
            //--------------------------------------------
            LinkedListM listA = new LinkedListM();
            LinkedListM listB = new LinkedListM();
            LinkedListM result = new LinkedListM();

            FillList(a, b, listA);
            FillList(b, a, listB);

            result = MergeSort(listA, listB);
            result.Print();
        }

        public static LinkedListM MergeSort(LinkedListM list1, LinkedListM list2)
        {
            LinkedListM result = new LinkedListM();
            Node listA = list1.head;
            Node listB = list2.head;
            while (listA != null && listB != null)
            {
                if (listA.data > listB.data)
                {
                    result.Add(listB.data);
                    listB = listB.next;
                }
                else
                {
                    result.Add(listA.data);
                    listA = listA.next;
                }
            }
            while (listA != null)
            {
                result.Add(listA.data);
                listA = listA.next;
            }
            while (listB != null)
            {
                result.Add(listB.data);
                listB = listB.next;
            }

            return result;
        }

        public static void FillList(int[] variables, int[] array, LinkedListM result)
        {
            int index = 0;
            for (int i = 0; i < variables.Length; i++)
            {
                if (BinarySearch(variables[i], array))
                {
                    if (CheckDuplicate(variables[i], variables, index)) result.Add(variables[i]);
                }
                index++;
            }
        }

        public static bool CheckDuplicate(int number, int[] array, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (number == array[i]) return false;
            }
            return true;
        }

        public static bool BinarySearch(int number, int[] array)
        {
            int max = array.Length - 1;
            int min = 0;

            while (min <= max)
            {
                int mid = min + (max - min) / 2;

                if (array[mid] == number)
                {
                    return false;
                }
                else if (array[mid] > number)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return true;
        }

        public class Node
        {
            public int data;
            public Node? next;

            public Node(int _data)
            {
                data = _data;
                next = null;
            }
        }

        public class LinkedListM
        {
            public Node head;

            public LinkedListM()
            {
                head = null;
            }

            public void Add(int data)
            {
                Node node = new Node(data);

                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node thisNode = head;
                    while (thisNode.next != null)
                    {
                        thisNode = thisNode.next;
                    }
                    thisNode.next = node;
                }
            }

            public void Print()
            {
                if (head == null)
                {
                    Console.Write("empty");
                }
                else
                {
                    Node thisNode = head;
                    while (thisNode != null)
                    {
                        Console.Write(thisNode.data);
                        if (thisNode.next == null) break;
                        Console.Write(" ");
                        thisNode = thisNode.next;
                    }
                }
            }
        }
    }
}