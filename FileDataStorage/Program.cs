class Program
{
    static void Main(string[] args)
    {
        string[] dataArray = File.ReadAllLines("./Users.txt");

        dataArray = increaseArraySize(dataArray);

        dataArray[dataArray.Length - 1] = args[0];

        //This blocks repeated values
        if(dataArray.Contains(args[0])){
            return;
        }

        //Find index of an item on the array
        int index = Array.FindIndex(dataArray, element => element == "lmao");

        //Delete every item from the array that has the value "User1"
        dataArray = dataArray.Where(val => val !=  "User1").ToArray();

        File.WriteAllLines("./Users.txt", dataArray);
    }

    public static string[] increaseArraySize(string[] arr)
    {
        string[] newArr = new string[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        return newArr;
    }

}