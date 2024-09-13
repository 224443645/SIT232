class Program
{
    static void Main(string[] args)
    {
        // 1
        double[] myArray = new double[10];

        myArray[0] = 1.0;
        myArray[1] = 1.1;
        myArray[2] = 1.2;
        myArray[3] = 1.3;
        myArray[4] = 1.4;
        myArray[5] = 1.5;
        myArray[6] = 1.6;
        myArray[7] = 1.7;
        myArray[8] = 1.8;
        myArray[9] = 1.9;

        Console.WriteLine("The element at index 0 in the array is " + myArray[0]);
        Console.WriteLine("The element at index 1 in the array is " + myArray[1]);
        Console.WriteLine("The element at index 2 in the array is " + myArray[2]);
        Console.WriteLine("The element at index 3 in the array is " + myArray[3]);
        Console.WriteLine("The element at index 4 in the array is " + myArray[4]);
        Console.WriteLine("The element at index 5 in the array is " + myArray[5]);
        Console.WriteLine("The element at index 6 in the array is " + myArray[6]);
        Console.WriteLine("The element at index 7 in the array is " + myArray[7]);
        Console.WriteLine("The element at index 8 in the array is " + myArray[8]);
        Console.WriteLine("The element at index 9 in the array is " + myArray[9]);

        // 2
        int[] myInts = new int[10];

        for (int i = 0; i < 10; i++)
        {
            myInts[i] = i;
        }

        for (int i = 0; i < myInts.Length; i++)
        {
            Console.WriteLine($"The element at position {i} in the array is {myInts[i]}");
        }

        // 3
        int[] studentArray = { 87, 68, 94, 100, 83, 78, 85, 91, 87 };

        int total = 0;

        for (int i = 0; i < studentArray.Length; i++) { total += studentArray[i]; }

        Console.WriteLine("The total marks for the student is: " + total);
        Console.WriteLine("THis consist of " + studentArray.Length + " marks");
        Console.WriteLine("Therefore the average mark is " + total / studentArray.Length);

        // 4
        string[] studentNames = new string[6];

        for (int i = 0; i < studentNames.Length; i++)
        {
            studentNames[i] = Console.ReadLine();
        }

        for (int i = 0; i < studentNames.Length; i++)
        {
            Console.WriteLine(studentNames[i]);
        }

        // 5
        double[] doubleArr = new double[10];
        int currentSize = 0;
        double currentLargest, currentSmallest;

        for (int i = 0; i < doubleArr.Length; i++)
        {
            doubleArr[i] = Convert.ToDouble(Console.ReadLine());
            currentSize += 1;
        }

        currentLargest = doubleArr[0]; currentSmallest = doubleArr[0];
        for (int i = 1; i < doubleArr.Length; i++)
        {
            if (doubleArr[i] > currentLargest)
            {
                currentLargest = doubleArr[i];
            }

            if (doubleArr[i] < currentSmallest)
            {
                currentSmallest = doubleArr[i];
            }
        }

        Console.WriteLine("Largest " + currentLargest);
        Console.WriteLine("Smallest " + currentSmallest);

        // 6
        int[,] my2d = new int[3, 4] { { 1, 2, 3, 4 }, { 1, 1, 1, 1 }, { 2, 2, 2, 2 } };

        for (int i = 0; i < my2d.GetLength(0); i++)
        {
            for (int j = 0; j < my2d.GetLength(1); j++)
            {
                Console.Write(my2d[i, j] + "\t");
            }
            Console.WriteLine();
        };

        // 7
        List<String> myStudentList = new List<String>();

        Random randomValue = new Random();
        int randomNumber = randomValue.Next(1, 12);

        Console.WriteLine("You now need to add " + randomNumber + " students to your class list");
        for (int i = 0; i < randomNumber; i++)
        {

            Console.WriteLine("Please enter the name of the Student" + (i + 1) + ": ");
            myStudentList.Add(Console.ReadLine());
            Console.WriteLine();
        }

        for (int i = 0; i < myStudentList.Count; i++)
        {
            Console.WriteLine(myStudentList[i]);
        }

        // 8
        int[] palin = new int[1] { 1 };
        Console.WriteLine(Palindrome(palin));

        int[] palin1 = new int[5] { 1, 2, 3, 2, 1 };
        Console.WriteLine(Palindrome(palin1));

        int[] palin2 = new int[5] { 1, 6, 3, 2, 1 };
        Console.WriteLine(Palindrome(palin2));

        // 9 
        List<int> list_a = new List<int> { 1, 2, 3, 4 };
        List<int> list_b = new List<int> { 1, 2, 3, 6, 9, };
        List<int> merged = Merge(list_a, list_b);
        Console.WriteLine(merged.Count);
        foreach (int value in merged) { Console.Write(value + " "); }
        Console.WriteLine();

        // 10
        int[,] to_convert = new int[4, 6]
        {
            {0, 2, 4, 0, 9, 5},
            {7, 1, 3, 3, 2, 1},
            {1, 3, 9, 8, 5, 6},
            {4, 6, 7, 9, 1, 0}
        };

        int[] converted = ArrayConversion(to_convert);

        foreach (int value in converted)
        {
            Console.Write(value + ", ");
        }
        Console.WriteLine();
    }

    // 8 
    static bool Palindrome(int[] array)
    {
        bool Palindrome = true;
        int length = array.GetLength(0);

        for (int i = 0; i < length; i++)
        {
            if (array[i] != array[length - i - 1])
            {
                Palindrome = false;
                break;
            }
        }
        return Palindrome;
    }

    // 9 
    static List<int> Merge(List<int> list_a, List<int> list_b)
    {
        bool list_a_ascending = true;
        int prev = list_a[0];
        foreach (int value in list_a)
        {
            if (value < prev)
            {
                list_a_ascending = false;
                break;
            }
            prev = value;
        }

        bool list_b_ascending = true;
        prev = list_b[0];
        foreach (int value in list_b)
        {
            if (value < prev)
            {
                list_b_ascending = false;
                break;
            }
            prev = value;
        }


        if (list_b_ascending && list_a_ascending)
        {
            List<int> merged = new List<int>(list_a);
            foreach (int item in list_b)
            {
                merged.Add(item);
            }

            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < merged.Count - 1; i++)
                {
                    if (merged[i] > merged[i + 1])
                    {
                        int tmp = merged[i];
                        merged[i] = merged[i + 1];
                        merged[i + 1] = tmp;
                        sorted = false;
                    }
                }
            }
            return merged;
        }
        else
        {
            return null;
        }
    }

    // 10 
    static int[] ArrayConversion(int[,] array)
    {
        // Could initialy iterate over array to find odd number count, but i thought this would be easier
        List<int> converted = new List<int>();

        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int x = 0; x < array.GetLength(0); x++)
            {
                if (array[x, y] % 2 == 1)
                {
                    converted.Add(array[x, y]);
                }
            }
        }

        return converted.ToArray();
    }
}