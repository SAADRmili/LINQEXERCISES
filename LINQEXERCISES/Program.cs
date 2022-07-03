using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //ex1
        Console.WriteLine("Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100 : ");
        int[] numbers = { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };
        var query1 = numbers.Where(x => x > 30 && x < 100);

        foreach (var s in query1)
        {
            Console.Write($"{s} "); // 54 82 95
        }
        Console.WriteLine("\n");


        //ex2
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");
        Console.WriteLine("Write a query that returns words at least 5 characters long and make them uppercase.");
        var words = new List<string>() { "zebra", "elephant", "cat", "dog", "rhino", "bat" };

        var query2 = words.Where(x => x.Length >= 5).Select(x=>x.ToUpper());

        foreach (var animal in query2)
        {
            Console.Write($"{animal}, "); // ZEBRA, ELEPHANT, RHINO,
        }
        //ex3
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");


        Console.WriteLine("Write a query that returns words starting with letter 'a' and ending with letter 'm'.");
        var words2 = new List<string>() { "alabam", "am", "balalam", "tara", "", "a", "axeliam", "39yo0m", "trol" };

        var query3 = words2.Where(x=>x.StartsWith("a") && x.EndsWith("m")).ToList();

        foreach (var word in query3)
        {
            Console.Write($"{word}, "); // alabam, am, axeliam,
        }
        //ex4
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");


        Console.WriteLine("Write a query that returns top 5 numbers from the list of integers in descending order.");
        var numbers2 = new List<int>() { 6, 0, 999, 11, 443, 6, 1, 24, 54 };

        var query4 = numbers2.OrderByDescending(x => x).Take(5).ToList();

        foreach (var number in query4)
        {
            Console.Write($"{number} "); // 999 443 54 24 11
        }
        //ex5
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that returns list of numbers and their squares only if square is greater than 20");
        var numbers3 = new List<int>() { 3, 9, 2, 4, 6, 5, 7 };

        var query5 = numbers3.Where(x=>x*x>20 ).Select(x=> new { sqr  = x +"-"+ x * x });

        foreach (var s in query5)
        {
            Console.Write($"{s.sqr}, "); // 9 - 81, 6 - 36, 5 - 25, 7 - 49,
        }
        //ex6
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that replaces 'ea' substring with astersik (*) in given list of words.");

        var words3 = new List<string>() { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

        var query6 = words3.Where(x => x.Contains("ea", StringComparison.OrdinalIgnoreCase)).Select(x => x.Replace("ea", "*"));

        foreach (var word in query6)
        {
            Console.Write(word + " "); // n*r sp*k tonight w*pon customer d*l lawyer
        }
        //ex7
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Given a non-empty list of words, sort it alphabetically and return a word that contains letter 'e'.");

        var words4 = new List<string>() { "cow", "dog", "elephant", "cat", "rat", "squirrel", "snake", "stork" }; ;

        var query7 = words4.OrderBy(x => x).LastOrDefault(x => x.Contains("e"));

        if(query7!=null)
            Console.WriteLine($"{query7}"); // squirrel

        //ex8
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that shuffles sorted array.");

        var numbers4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var r = new Random();
        var query8 = numbers4.OrderBy(x =>r.Next()).ToList();

        foreach (var item in query8)
        {
            Console.Write(item + " "); 
        }

        //ex9
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Given a non-empty string consisting only of special chars (!, @, # etc.), return a number (as a string) where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).");

        Console.WriteLine("\n");
        var charSpecial = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

        var strSp = "*$(#&"; 

        var query9 = string.Join("", strSp.Select(c => Array.IndexOf(charSpecial, c)));

      
        Console.WriteLine(query9);

        //ex10
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that returns most frequent character in string. Assume that there is only one such character.");

        var str = "n093nfv034nie9";

        var query10 = str.GroupBy(x=>x).OrderByDescending(x=>x.Count()).First().Key;

        Console.Write(query10);

        //ex11
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");


        Console.WriteLine("Given a non-empty list of strings, return a list that contains only unique (non-duplicate) strings.");
        var words5 = new List<string>() { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" }; ;

        var query11 = words5.GroupBy(x=>x).Where(x=>x.Count()==1).Select(x=>x.Key);

        foreach (var value in query11)
        {
            Console.WriteLine($"{value}"); //Hello Hi! Bye
        }
        //ex12
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");


        Console.WriteLine("Write a query that returns only uppercase words from string.");

        var strUp = "THIS is UPPERCASE string LOL";

        var query12 = strUp.Split(' ').Where(x => string.Equals(x, x.ToUpper(), StringComparison.Ordinal));

        foreach (var u in query12)
        {
            Console.Write($"{u}, "); // THIS, UPPERCASE, LOL,
        }
        //ex13
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that returns dot product of two arrays.");

        var list1 = new List<int>() { 5, 8, 2, 9 };
        var list2 = new List<int>() { 1, 7, 2, 4 };


        var query13 = list1.Zip(list2 ,(x,y)=>y*x).Sum();


        Console.WriteLine(query13);

        //ex14
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that returns letters and their frequencies in the string.");

        string stringFre = "abracadabra";

        var query14 = stringFre.GroupBy(x => x).Select(x => new
        {
            Key = x.Key,
            Count = x.Count()
        });

        foreach (var l in query14)
        {
            Console.Write($"Letter {l.Key} occurs {l.Count} time(s), ");
            // Letter a occurs 5 time(s), Letter b occurs 2 time(s), Letter r occurs 2 time(s)
            // Letter r occurs 2 time(s), Letter c occurs 1 time(s), Letter d occurs 1 time(s)
        }
        //ex15
        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that returns names of days.");

        var dayofWeeks = Enum.GetValues(typeof(DayOfWeek)).Cast<DayOfWeek>();

        foreach (var d in dayofWeeks)
        {
            Console.Write($"{d} "); // Sunday Monday Tuesday Wednesday Thursday Friday Saturday
        }

        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that returns double letters sequence in format: AA AB AC ... ZX ZY ZZ");


        var doubleLetters= Enumerable.Range((char)65, 26)
                        .SelectMany(x => Enumerable.Range((char)65, 26).Select(y => (char)x + "" + (char)y));

        foreach (var l in doubleLetters)
        {
            Console.Write(l + " "); // AA AB AC ... AZ BA BB ... ZX ZY ZZ
        }

        Console.WriteLine("\n");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("\n");

        Console.WriteLine("Write a query that transposes square array (switch rows with columns).");
        var list = new List<List<int>>()
        {
                                     new List<int>{ 1, 2, 3, 4, 5 },
                                     new List<int>{ 6, 7, 8, 9, 10 },
                                     new List<int>{ 11, 12, 13, 14, 15 },
                                     new List<int>{ 16, 17, 18, 19, 20 },
                                     new List<int>{ 21, 22, 23, 24, 25 }
        }; 

        var query15 = list.SelectMany(x=> x.Select((i,index) => new {i,index}))
            .GroupBy(i => i.index, i => i.i)
             .Select(g => g)
                .ToList();

        foreach (var row in query15)
        {
            foreach (var number in row)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}