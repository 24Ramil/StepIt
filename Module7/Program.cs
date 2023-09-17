

int[] a = { 1, 2, 3, 4, 5, 5 };
MyArray3 arr = new(a);
Console.WriteLine( arr.CountDistinct());


#region Exception1

//class MyArray1 : ICalc
//{
//    private int[] data;

//    public MyArray1(int[] array)
//    {
//        data = array;
//    }

//    public int Less(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int item in data)
//        {
//            if (item < valueToCompare)
//            {
//                count++;
//            }
//        }
//        return count;
//    }

//    public int Greater(int valueToCompare)
//    {
//        int count = 0;
//        foreach (int item in data)
//        {
//            if (item > valueToCompare)
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}


//interface ICalc 
//{
//    int Less(int valueToCompare);
//    int Greater(int valueToCompare);
//}
#endregion


#region Exception2
//class MyArray2 : IOutput2
//{
//    private int[] data;

//    public MyArray2(int[] array)
//    {
//        data = array;
//    }

//    public void ShowEven()
//    {
//        Console.WriteLine("Even values: ");
//        foreach (int item in data)
//        {
//            if (item % 2 == 0)
//            {
//                Console.Write(item);
//            }
//        }
//    }

//    public void ShowOdd()
//    {
//        Console.WriteLine("Odd values: ");
//        foreach (int item in data)
//        {
//            if (item % 2 != 0)
//            {
//                Console.Write(item);
//            }
//        }
//    }
//}

//public interface IOutput2
//{
//    void ShowEven();
//    void ShowOdd();
//}

#endregion



#region Exception3

public class MyArray3 : ICalc2
{
    private int[] data;

    public MyArray3(int[] array)
    {
        data = array;
    }
    
    //public int CountDistinict()
    //{
    //    return data.Distinct().Count();
    //}

    public int CountDistinct() 
    {
        int[] uniguevalues = new int[data.Length];
        int countDistinicts = 0;
        int checkUnigue = 0;

        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data.Length; j++)
            {
                if (data[i] == data[j]) 
                    checkUnigue++;
            }

            if (checkUnigue < 2)
            {
                uniguevalues[countDistinicts] = data[i];
                countDistinicts++;
            }
            checkUnigue = 0;

        }

        return countDistinicts;
    }

    public int EqualToValue(int valueToCompare)
    {
        int countEqualToValue = 0;
        for(int i = 0; i < data.Length; i++) 
        {
            if (data[i] == valueToCompare)
                countEqualToValue++;
        }

        return countEqualToValue;
    }

}


public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

#endregion