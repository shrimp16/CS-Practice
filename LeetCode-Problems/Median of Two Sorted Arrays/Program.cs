//Problem:
//https://leetcode.com/problems/median-of-two-sorted-arrays/
class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 3, 4 };

        int m = nums1.Length;
        int n = nums2.Length;

        int[] newArr = new int[m + n];

        for (int i = 0; i < m; i++)
        {
            newArr[i] = nums1[i];
        }

        for (int i = m, b = 0; i < m + n; i++, b++)
        {
            newArr[i] = nums2[b];
        }

        Array.Sort(newArr);

        if (newArr.Length % 2 == 0)
        {
            int a = newArr[newArr.Length / 2 - 1];
            int b = newArr[newArr.Length / 2];
            double result = (double)(a + b) / 2;
            Console.WriteLine(result);
        }
        else
        {
            int result = (int)Math.Round((double)newArr.Length / 2);
            Console.WriteLine((double)newArr[result]);
        }
        
    }
}
