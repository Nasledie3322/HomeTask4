// Task1
// int EvenCount(int n)
// {
//     int Even = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         if (snt % 2 == 0 && snt != 0)
//         {
//             Even++;
//         }
//     }
//     return Even;
// }

// int OddCount(int n)
// {
//     int Odd = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         if (snt % 2 != 0)
//         {
//             Odd++;
//         }
//     }
//     return Odd;
// }

// int ZeroCount(int n)
// {
//     int Zero = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         if (snt == 0)
//         {
//             Zero++;
//         }
//     }
//     return Zero;
// }

// int DigitCount(int n)
// {
//     int Digits = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         Digits++;
//     }
//     return Digits;
// }

// int MinDigit(int n)
// {
//     int min = 99999;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         if (snt < min)
//         {
//             min = snt;
//         }
//     }
//     return min;
// }

// int MaxDigit(int n)
// {
//     int max = -99999;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         if (snt > max)
//         {
//             max = snt;
//         }
//     }
//     return max;
// }

// int SumDigit(int n)
// {
//     int Sum = 0;
//     for (int i = n; i > 0; i /= 10)
//     {
//         int snt = i % 10;
//         Sum += snt;
//     }
//     return Sum;
// }

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Even : " + EvenCount(n));
// System.Console.WriteLine("Odd : " + OddCount(n));
// System.Console.WriteLine("Zeros : " + ZeroCount(n));
// System.Console.WriteLine("Digits : " + DigitCount(n));
// System.Console.WriteLine("Min : " + MinDigit(n));
// System.Console.WriteLine("Max : " + MaxDigit(n));
// System.Console.WriteLine("Sum of Digits : " + SumDigit(n));




// Task2
// char CheckGrade(int n)
// {
//     if (n >= 90 && n <= 100)
//     {
//         return 'A';
//     }
//     else if (n >= 80 && n <= 89)
//     {
//         return 'B';
//     }
//     else if (n >= 70 && n <= 79)
//     {
//         return 'C';
//     }
//     else if (n >= 60 && n <= 69)
//     {
//         return 'D';
//     }
//     else
//     {
//         return 'F';
//     }
// }
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckGrade(n));



// Task3
// int[] arr = new int[6];
// int Negative = 0;
// int Positive = 0;
// int Zeros = 0;
// int Even = 0;
// int Odd = 0;
// int Max = -99999;
// int Min = 99999;
// int Sum = 0; 
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < 0)
//     {
//         Negative++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] >= 0)
//     {
//         Positive++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] == 0)
//     {
//         Zeros++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 == 0 && arr[i] != 0)
//     {
//         Even++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] % 2 != 0)
//     {
//         Odd++;
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > Max)
//     {
//         Max = arr[i];
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] < Min)
//     {
//         Min = arr[i];
//     }
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     Sum += arr[i];
// }
// System.Console.WriteLine("Negative = " + Negative);
// System.Console.WriteLine("Positive = " + Positive);
// System.Console.WriteLine("Zeros = " + Zeros);
// System.Console.WriteLine("Even = " + Even);
// System.Console.WriteLine("Odd = " + Odd);
// System.Console.WriteLine("Max = " + Max);
// System.Console.WriteLine("Min = " + Min);
// System.Console.WriteLine("Sum = " + Sum);



// Task4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     if (i % 2 == 0)
//     {
//     System.Console.Write(arr[i] + " ");
//    }
// }





// Task5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] > arr[i - 1])
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);




// Task6
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i != j && arr[i] == arr[j])
//         {
//             Console.Write(arr[i] + " ");
//             break; 
//         }
//     }
// }




// Task7
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// for (int i = a; i <= b; i++)
// {
//     Console.WriteLine("-------------------------------");
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}x{j}= {i * j}");
//     }
// }




// Task9
// int Power(int a, int b)
// {
//     if (b == 0)
//         return 1;
//     else
//         return a * Power(a, b - 1);
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int res = Power(a, b);
// Console.WriteLine($"The value of {a} to the power of {b} is : {res}");




// Task10
// int Fibonacci(int n)
// {
//     if (n == 0) return 0;
//     else if (n == 1) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// Console.Write("Input number of terms for the Fibonacci series : ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write($"The Fibonacci series of {n} terms is : ");
// for (int i = 0; i < n; i++)
// {
//     Console.Write(Fibonacci(i) + " ");
//  }
