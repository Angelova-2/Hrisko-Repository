namespace zadachi
{
    internal class Program
    {
        static void Main(string[] args)


        {


            public class ArrayStack<T>
        {
            private T[] elements;

            public int Count
            {
                get; private set;
            }

            private const int InitialCapacity = 16;

            public ArrayStack(int capacity = InitialCapacity) 
            {

                elements = new T[capacity];

            }
            public void Push(T element) 
            {
                if (this.Count == this.elements.Length)
                {
                    this.Count++;
                }

               
            }
            public T Pop()  
            {
               if (this.Count == 0)

            }
            public T[] ToArray() 
            { 
                return new T[InitialCapacity];
            }
            private void Grow() 
            {

            }
    }


    }
}
