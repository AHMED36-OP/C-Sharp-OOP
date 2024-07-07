namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region Q1
            
             //1- . Write a program that prints an identity matrix using for loop, in other words takes
             //     a value n from the user and shows the identity table of size n * n.  
             
            Console.Write("Enter the size of the identity matrix: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            #endregion
            */



            /*
            #region Q2
            //Write a program in C# Sharp to find the sum of all elements of the array.





            int sum = 0;
            int numIndex;
            Console.Write("please enter Number of element : ");
            numIndex = int.Parse(Console.ReadLine());
            int[] arr = new int[numIndex];

            for (int i = 0; i < arr.Length;)
            {
                Console.Write($"Please Enter Value {i + 1} : ");

                if (int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    sum += arr[i];
                    i++;
                }
                else
                {
                    i = i;
                }
            }

            Console.WriteLine("the sum equals : " + sum);


            #endregion
            */


            /*
            #region Q3
            //Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order


            int[] arr1 = new int[] { 30, 10, 40, 20, 50 };
            int[] arr2 = new int[] { 70, 60, 90, 80, 100 };
            int[] arr3 = new int[10];

            

            //(Source , بداية ال source  , هتطبع فين , m هتبدا منين في اللي هتبع فيه , length)
            Array.ConstrainedCopy(arr1, 0, arr3, 0, 5);
            Array.ConstrainedCopy(arr2, 0, arr3, 5, 5);
            Array.Sort(arr3);
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }


            #endregion

            */

            /*
            #region Q4

            int frequance = 0;
            int[] arr1 = new int[] { 30, 10,40,50,30,30,10,20,50, 40, 20, 50 ,60,50,10,50};
            for (int i = 0; i < arr1.Length; i++)
            {
                
                for (int  j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        frequance++;
                    }
                }
                
                Console.WriteLine($"the frequance for {arr1[i]} : {frequance}" );
                frequance = 0;
            }
            #endregion
            */


            /*
            #region Q5
            //Write a program in C# Sharp to find maximum and minimum element in an array

            Console.Write("Please Enter Number of Elements in Array: ");
            int numIndex = int.Parse(Console.ReadLine());

            int[] arr = new int[numIndex];

            for (int i = 0; i < arr.Length;)
            {
                Console.Write($"Please Enter Value {i + 1} in Array: ");
                if (int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    i++;
                }
                else
                {
                    i = i;
                }
            }

            Array.Sort(arr);

            Console.WriteLine("===================================");
            Console.WriteLine($"The minimum element: {arr[0]}");
            Console.WriteLine($"The maximum element: {arr[arr.Length - 1]}");

            #endregion

            */


            /*

            #region Q6
            //Write a program in C# Sharp to find the second largest element in an array.

            Console.Write("Please Enter Number of Elements in Array: ");
            int numIndex = int.Parse(Console.ReadLine());

            int[] arr = new int[numIndex];

            for (int i = 0; i < arr.Length;)
            {
                Console.Write($"Please Enter Value {i + 1} in Array: ");
                if (int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    i++;
                }
                else
                {
                    i = i;
                }
            }

            
            Array.Sort(arr);
            int minelement = arr[0];

            Array.Reverse(arr);

            int index_second_largest_element = arr.Length;
            for (int n = 1; n < arr.Length; n++)
            {
                if (arr[n] < arr[n - 1])
                {
                    index_second_largest_element = n;
                    break;
                }
            }


            Console.WriteLine($"The minimum element : {minelement}"  );
            Console.WriteLine($"The second largest element :  { arr[index_second_largest_element]}");


            #endregion
            */

            /*
            #region Q8
            //- Write a program to create two multidimensional arrays of same size. Accept value from user and
            //store them in first array. Now copy all the elements of first array on second array and print second array.

            int[,] arr1 = new int[3, 5];
            int[,] arr2 = new int[3, 5];


            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                Console.WriteLine($"please Enter Markes of student {i + 1} ");
                for (int j = 0; j < arr1.GetLength(1);)
                {
                    Console.Write($"please Enter Markes of subject {j + 1} for student {i + 1} : ");

                    j = int.TryParse(Console.ReadLine(), out arr1[i, j]) ? ++j : j;
                }
            }

            Console.Clear();
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                Array.Copy(arr1, i * arr1.GetLength(1), arr2, i * arr2.GetLength(1), arr1.GetLength(1));
            }

            
            for (int n = 0; n < arr1.Length; n++)
            {
                Console.WriteLine($"Marks of student {n / arr2.GetLength(1) + 1} for subject is {n % arr2.GetLength(1) + 1}  =   {arr1[n / arr1.GetLength(1), n % arr1.GetLength(1)]}");

                if (n == 4 || n == 9)
                {
                    Console.WriteLine("================================================================");
                }
            }

            #endregion
            */

            /*

            #region Q9
            //- Write a Program to Print One Dimensional Array in Reverse Order


            Console.Write("Please Enter Number of Elements in Array: ");
            int numIndex = int.Parse(Console.ReadLine());

            int[] arr = new int[numIndex];

            for (int i = 0; i < arr.Length;)
            {
                Console.Write($"Please Enter Value {i + 1} in Array: ");
                if (int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    i++;
                }
                else
                {
                    i = i;
                }
            }


            Array.Reverse(arr);
            for (int n = 0; n < arr.Length; n++)
            {
                Console.WriteLine(arr[n]);
            }

            #endregion


            */
        }
    }
}
