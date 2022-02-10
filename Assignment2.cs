//Assignment 2

class Assignment2
{
    public Assignment2()
    {
        Console.WriteLine("\n\nAssignment 2");
        //Test your Knowledge
        //1) When to use String vs. StringBuilder in C#?
        //When heavy string manipulation is involve, its better to use StringBuilder tha String.
        //String is in System namespace but StringBuilder is in System.Text namespace.

        //2) What is the base class for all arrays in C#?
        //Array in the System namespace is the base class for all arrays in C#

        //3) How do you sort an array in C#?
        //Array.Sort(array) sorts in ascending order, Array.Reverse(array) sorts in decending order;

        //4) What property of an array object can be used to get the total number of elements in an array?
        //Length method returns the total number of elements in the array.

        //5) Can you store multiple data types in System.Array?
        //No, all data types in Array most be the same data type

        //6) What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
        //System.Array.Clone() returns a new array object containing all the elements of the original array.
        //System.Array.CopyTo() copies elements of the array into another existing array. It can start copiyng at a given index.

        //Practice Array
        Console.WriteLine("Practice Array");
        //1) Copying an Array
        int[] arrayTest1 = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int[] arrayTest2 = new int[arrayTest1.Length];
        for (int i = 0; i < arrayTest1.Length; i++)
        {
            arrayTest2[i] = arrayTest1[i];
        }
        Console.Write("Array 1: ");
        for (int i = 0; i < arrayTest1.Length; i++)
        {
            Console.Write(arrayTest1[i] + " ");
        }
        Console.Write("\nArray 2: ");
        for (int i = 0; i < arrayTest1.Length; i++)
        {
            Console.Write(arrayTest2[i] + " ");
        }
        Console.WriteLine("");

        //2) Grocery List
        List<string> groceryList = new List<string>();
        string userInput = " ";
        while (userInput != "")
        {
            //Get user input
            Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
            userInput = Console.ReadLine();
            //If claer, subtracting, or adding
            if (userInput.Equals("--"))
            {
                groceryList.Clear();
            }
            else if (userInput != "")
            {
                if (userInput[0] == '-')
                {
                    groceryList.Remove(userInput.Trim('-'));
                }
                else if (userInput[0] == '+')
                {
                    groceryList.Add(userInput.Trim('+'));
                }
            }
            //Display List
            Console.WriteLine("List of items:");
            for (int i = 0; i < groceryList.Count; i++)
            {
                Console.WriteLine(groceryList[i]);
            }
        }

        //3) FrindPrimesInRange
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeFound = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeFound.Add(i);
                }
            }
            return primeFound.ToArray();
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) { return false; }
            }
            return true;
        }

        Console.WriteLine("Write the starting numb first, then the ending number");
        int[] primeNumbers = FindPrimesInRange(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        Console.Write("Prime array: ");
        for (int i = 0; i < primeNumbers.Length; i++)
        {
            Console.Write(primeNumbers[i] + " ");
        }
        Console.WriteLine("");
        
        //4) Rotation Addition~
        static void RotationalAddition(int[] intArray, int k)
        {
            List<int[]> rotatedList = new List<int[]>();
            for (int i = 0; i < k; i++)
            {
                int[] rotationArray = new int[intArray.Length];
                for (int s = 0; s < intArray.Length; s++)
                {
                    rotationArray[(s + i) % intArray.Length] = rotationArray[s];
                }
                rotatedList.Add(rotationArray);
            }
            //Adding
            int[] sum = new int[intArray.Length];
            for (int r = 1; r < k; r++)
            {
                for (int l = 0; l < intArray.Length - 1; l++)
                {
                    sum[l] += rotatedList[r][l];
                }
            }
            //Printing
            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
        }
        RotationalAddition(new int[] { 3, 2, 4, -1 }, 2);
        Console.WriteLine("");

        //5) Longest sequence~
        static void LongestSequence(int[] intArray)
        {
            int currentNumb = 0;
            List<int> currentSequence = new List<int>();
            List<int> longestSequence = new List<int>();
            for (int i = 0; i < intArray.Length; i++)
            {
                if (currentNumb == intArray[i])
                {
                    currentSequence.Add(intArray[i]);
                }
                else
                {
                    if (currentSequence.Count() > longestSequence.Count())
                    {
                        longestSequence = currentSequence;
                    }
                    currentNumb = intArray[i];
                    currentSequence.Clear();
                    currentSequence.Add(intArray[i]);
                }
            }
            //Print out
            for (int x = 0; x < longestSequence.Count; x++)
            {
                Console.Write(longestSequence[x] + ' ');
            }
        }
        LongestSequence(new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 });


        //6)


        //Practice String
        Console.WriteLine("\nPractice String");
        //1) Reverse String
        Console.WriteLine("Write a string to reverse:");
        string textInput = Console.ReadLine();
        char[] textInputChar = textInput.ToCharArray();
        Array.Reverse(textInputChar);
        string reverseText1 = new string (textInputChar);
        Console.WriteLine(reverseText1);
        for (int x = textInput.Length - 1; x >= 0; x--)
        {
            Console.Write(textInput[x]);
        }
        Console.WriteLine("");

        //2)

        //3)

        //4)
    }
}