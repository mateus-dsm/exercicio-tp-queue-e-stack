internal class Program
{
    public static Queue<T> CopiaQueue<T>(Queue<T> queueOrigem)
    {
        Queue<T> novaQueue = new Queue<T>();
        foreach(T item in queueOrigem) novaQueue.Enqueue(item);
        return novaQueue;
    }

    public static Stack<T> CopiaStack<T>(Stack<T> stackOrigem)
    {
        Stack<T> novaStack = new Stack<T>();
        T[] values = new T[stackOrigem.Count];
        int index = 0;

        foreach(T item in stackOrigem) values[index++] = item;

        for (int i = stackOrigem.Count- 1; i >= 0; i--) novaStack.Push(values[i]);

        return novaStack;
    }

    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        foreach (int i in queue) Console.WriteLine(i);
        Console.WriteLine();

        Queue<int> novaQueue = CopiaQueue<int>(queue);
        foreach (int i in novaQueue) Console.WriteLine(i);

        Console.WriteLine();

        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        foreach (int i in stack) Console.WriteLine(i);
        Console.WriteLine();

        Stack<int> novaStack = CopiaStack<int>(stack);
        foreach(int i in novaStack) Console.WriteLine(i);
    }
}