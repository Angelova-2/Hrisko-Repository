using System.Xml.Linq;

namespace izpit06
{
    internal class Program
    {
        static void Main(string[] args)
        {
           class Node
        {
            public int Value { get; set; }
            public Node(int value)


            {
                Value = value;
            }

            class DynamicNodeArray
            {
                private Node[] nodes;
                private int count;
            }
           
            public DynamicNodeArray()
            {
                nodes = new Node[2];

                count = 0;
            }

            public void Add(int value) { }
            private void Resize() { }    
            public void Count() { }
            public void SetValue(int index, int value) { }
            public void GetValue(int value) { } 
            public void Print() { }


            class DynamicNodeArray
            {
                public void Sort(DynamicNodeArray array)
                {
                    QuickSortMethod(array, 0, array.Count() - 1);
                }

                private void QuickSortMethod(DynamicNodeArray array, int left, int right)
                {
                    if (left < right)
                    {
                        int pivotIndex = Partition(array, left, right);

                        QuickSortMethod(array, left, pivotIndex - 1);
                        QuickSortMethod(array, pivotIndex + 1, right);
                    }
                }

                private int Partition(DynamicNodeArray array, int left, int right)
                {
                    int pivot = array.GetValue(right);

                    int i = left - 1;

                    for (int j = left; j < right; j++)
                    {
                        if (array.GetValue(j) <= pivot)
                        {
                            i++;


                            Swap(array, i, j);
                        }
                    }

                    Swap(array, i + 1, right);
                    return i + 1;
                }

                private void Swap(DynamicNodeArray array, int i, int j)
                {
                    int temp = array.GetValue(i);
                    array.SetValue(i, array.GetValue(j));
                    array.SetValue(j, temp);
                }
            }
        }
    }
}