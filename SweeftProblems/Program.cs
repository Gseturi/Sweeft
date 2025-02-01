using SweeftProblems;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("first");
Console.WriteLine(Problems.sPalindrome("Racecar")); //true
Console.WriteLine(Problems.sPalindrome("A man, a plan, a canal, Panama")); //true
Console.WriteLine(Problems.sPalindrome("Hello")); //false
Console.WriteLine(Problems.sPalindrome("bbaah*aa*Haabb")); //true
Console.WriteLine("second");
Console.WriteLine(Problems.MinSplit(87)); 
Console.WriteLine(Problems.MinSplit(50)); 
Console.WriteLine(Problems.MinSplit(51)); 
Console.WriteLine(Problems.MinSplit(17));
Console.WriteLine("third");
Console.WriteLine(Problems.NotContains(new int[] { 1, 2, 3, 5 }));   //4
Console.WriteLine(Problems.NotContains(new int[] { 3, 4, -1, 1 }));  //2
Console.WriteLine(Problems.NotContains(new int[] { -1, -2, -3 }));   //1
Console.WriteLine(Problems.NotContains(new int[] { 1, 3, 6, 4, 1, 2 })); //5
Console.WriteLine("forth");
Console.WriteLine(Problems.IsProperly("(())")); //true
Console.WriteLine(Problems.IsProperly("(()())")); //true
Console.WriteLine(Problems.IsProperly(")(")); //false
Console.WriteLine(Problems.IsProperly("((())")); //false
Console.WriteLine("fifth");
Console.WriteLine(Problems.CountVariants(5));
Console.WriteLine(Problems.CountVariants(8));
Console.WriteLine(Problems.CountVariants(1));
Console.WriteLine(Problems.CountVariants(2));

