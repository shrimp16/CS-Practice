class Program
{
    static void Main(string[] args)
    {
        string[] dataArray = File.ReadAllLines("./Users.txt");

        //This blocks repeated values
        if (args.Length > 0 && dataArray.Contains(args[0]))
        {
            return;
        }

        //Find index of an item on the array
        int index = Array.FindIndex(dataArray, element => element == "lmao");

        //Delete every item from the array that has the value "User1"
        dataArray = dataArray.Where(val => val != "User1").ToArray();

        ArrayManager<string> stringArrayManager = new ArrayManager<string>();

        dataArray = stringArrayManager.addToArray(dataArray, args[0]);

        File.WriteAllLines("./Users.txt", dataArray);
    }

}

class ArrayManager<T>
{
    public T[] addToArray(T[] arr, T value)
    {
        T[] newArr = new T[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }
        newArr[newArr.Length - 1] = value;
        return newArr;
    }

}