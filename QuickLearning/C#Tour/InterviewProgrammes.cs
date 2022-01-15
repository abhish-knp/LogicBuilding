using System;

static void Main(string[] args)  
{  
    //Reverse the string
    
    string _Inputstr = string.Empty;
    string _Reversestr = string.Empty;  
    //Console.Write("Enter the string : ");  
    _Inputstr = Console.ReadLine();  
    for (inti = _Inputstr.Length - 1; i >= 0; i--)  
    {  
        _Reversestr += _Inputstr[i];  
    }  
    Console.WriteLine("The reverse string is {0}", _Reversestr);  
    Console.ReadLine();  
}  

//Swap two numbers
public class SwaptwoNumbers
{
    public SwaptwoNumber(int a, int b)
    {
        int a=75,b=84,t;
        t=a;
        a=b;
        b=t;
        Console.WriteLine("Values after swapping:");
        Console.WriteLine("a is :"+a);
        Console.WriteLine("b is :"+b);
    }   

    public SwaptreeNumber(int a, int b, int c)
    {
        string a,b;
        int temp,c,d;
        Console.Write("Enter value for a :");
        a = Console.ReadLine();
        c = Convert.ToInt32(a);
        Console.WriteLine("A's value is {0}", c);
        Console.Write("Enter value for b : ");
        b = Console.ReadLine();
        d = Convert.ToInt32(b);
        Console.WriteLine("B's value is {0}", d);
        temp=c;
        c=d;
        d=temp;
        Console.WriteLine("Values after swapping are:");
        Console.WriteLine("a is : "+c);
        Console.WriteLine("b is : "+d);

    }
}

// Number is Prim or nOt
public class primeNumber
{
    //prime or not
    public PrimeFinder(int n)
    {
        int n, a, m = 0, PrimeIndicator = 0;
        Console.Write("Please enter the number to check for Primality: ");
        n = int.Parse(Console.ReadLine());
        m = n / 2;
        for (a = 2; a <= m; a++)
        {
            if (n % a == 0)
            {
                Console.Write("The entered number is not  a Prime number .");
                PrimeIndicator = 1;
                break;
            }
        }
        if (PrimeIndicator == 0)
        Console.Write("The entered number is a Prime number . ");

    }

    // 
    public WhileLoop(int n)
    {
        int n, i, a;
        Console.Write("Enter any number: ");
        n = Convert.ToInt32(Console.ReadLine()); // read the user input
        a = 0;
        i = 2;
        while (i <= n / 2)
        {
            if (n % i == 0)
            {
                a = 1;
                break;
            }
            i++;
        }
        if (a == 0)
            Console.WriteLine(n + " Prime Number as there are no factors");
        else
            Console.WriteLine(n + " not a Prime Number ");
            Console.ReadLine();
    }

    // Series of Prime Number
    public SeriesPrime(int n)
    {
        bool Prime = true;
        Console.WriteLine("Prime Numbers between 1 to 100 : ");
        for (int a = 2; a <= 100; a++) //upper limit and lower limit are defined
        {
            for (int b = 2; b <= 100; b++)// base logic for the primality
            {
                if (a != b && a % b == 0) //modulo operators employed
                {
                    Prime = false;
                    break;
                }
            }
            if (Prime)
            {
                Console.Write("\t" + a); //printing the correct variable
            }
            Prime = true;
        }
        Console.ReadKey(); //hold the output screen
    }

    public class pandildrom
    {
        public checkinPalindrom(string letter)
        {
            string inputStr, r;
            inputStr = "Madam";
            char[] letter = inputStr.ToCharArray();
            Array.Reverse(letter);
            r = new string(letter);
            bool bool1 = inputStr.Equals(r, StringComparison.OrdinalIgnoreCase);
            if (bool1 == true) {
                Console.WriteLine("This string " + inputStr + " is a Palindrome!");
            } else {
                Console.WriteLine("This string " + inputStr + " is not a Palindrome!");
            }
                Console.ReadLine();
        }
    }

    public class Factorial
    {
        public Factorial(int a)
        {
            int a = 7;
            int fact = 1;
            for (int x = 1; x <= a; x++)
            {
            fact *= x;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
        public FactorialRecursive(int n)
        {
            int n= 5;
            long fact = Fact(n);
            Console.WriteLine("factorial is {1}", n, fact);
            Console.ReadKey();
           
            return n * Fact(n - 1);
        }
        public static long Fact(int n)
            {
                if (n == 0)
                {
                return 1;
                }
            }
    
    }

    

}


