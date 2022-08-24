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