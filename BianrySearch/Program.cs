internal class Program
{
    static int BinarySearch(int [] arr,int start, int end,int element)
    {
        if (start <= end)
        {
            int middle = (start + end) / 2;
            if (arr[middle] == element) 
            return middle;
            if (arr[middle] > element)
                return BinarySearch(arr, start, middle - 1, element);
            return BinarySearch(arr, middle + 1, end, element);
        }
        return -1;
    }
   
    private static void Main(string[] args)
    {
        int element;
        int [] arr = { 2, 3, 4, 10, 40 };
        int size = arr.Length;
        Console.WriteLine("Enter an integer: ");
        element =int.Parse( Console.ReadLine());
        int result= BinarySearch(arr,0,size-1,element);
        if(result == -1)
            Console.WriteLine($"Element { element } was not found");
        else Console.WriteLine($"Element {element } was found at index {result}");
        Console.ReadKey();

    }
}