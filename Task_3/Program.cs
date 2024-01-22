
using Task_3;

static int[] CreateArray()
{
    int[] nums = new int[10];
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(100);
    }
    return nums;
}

int[] nums1 = CreateArray();

MainClass mainClass = new MainClass();

Console.WriteLine("Вызов сортировки методом Шелла");
MainClass.SortArray methodShell =  mainClass.SelectSortMethod(Sort.Shell);
methodShell(nums1);

foreach (int i in nums1)
{
    Console.WriteLine(i);
}

Console.WriteLine();

int[] nums2 = CreateArray();

Console.WriteLine("Вызов сортировки методом пузырька");
MainClass.SortArray methodBubble = mainClass.SelectSortMethod(Sort.Bubble);
methodShell(nums2);

foreach (int i in nums2)
{
    Console.WriteLine(i);
}