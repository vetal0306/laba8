using System;

namespace laba8
{
    class Program
    {
        static void Main(string[] args)
        {
            //реверс рядка 
            string s = "halo";
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            //Console.WriteLine(arr);

            // зміна регістру

            //string l;
            //string str = Console.ReadLine();            
            //string[] ar = str.Split(' ');
                       
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    ar[i] = (string)(ar[i].Remove(1, ar[i].Length - 1)).ToUpper() + ar[i].Remove(0, 1);
            //    l = String.Join(" ", ar[i]);
            //    Console.WriteLine(l);
            //}

            //паліндром
            string k = Console.ReadLine();
            k = k.Replace(" ", ""); //видаляємо пробіли
            char[] l = k.ToCharArray(); //перетворюємо в масив 
            Array.Reverse(l); //інвертуємо смиволи
            string text = new string(l); //перетворюємо в рядок 

            if (k == text)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");       







            /*
            // Способи створення екземпляру типу string
            // 1. Створення та ініціалізація рядка при його оголошенні
            string s1 = "Hello";
            Console.WriteLine("s1 = {0}", s1);

            // 2. Створення рядка з масиву типу char[]
            char[] ArrayChar = { 'H', 'e', 'l', 'I', 'o' };
            string s2 = new string(ArrayChar);
            Console.WriteLine("s2 = {0}", s2);
            string s3 = new string(ArrayChar, 2, 3); // отримати частину рядка
            Console.WriteLine("s3 = {0}", s3);
            // 3. Створення рядка з допомогою перевантаженого оператора присвоєння =
            string s4;
            s4 = "Hello";
            Console.WriteLine("s4 = {0}", s4);
            // 4. Створення рядка з одного символу
            string s5 = new string('+', 10); // символ '+' - 10 разів
            Console.WriteLine("s5 = {0}", s5);
            // 5. Буквальні рядки (verbatim strings)
            string s6;
            s6 = @"C:\Programs\abc.txt "; // це є буквальний рядок, перед рядком стоїть @

            Console.WriteLine("s6 = {0}", s6);
            Console.ReadKey();

            // пустий рядок
            var empty1 = "";
            var empty2 = string.Empty;
            // перевірка на пустоту
            string nullString = null;
            var b1 = string.IsNullOrEmpty(nullString); //true
            var b2 = string.IsNullOrEmpty("test"); // false

            string whiteString = "\t \r\n";
            b1 = string.IsNullOrWhiteSpace(whiteString); //true
            b2 = string.IsNullOrWhiteSpace(" 123 "); // false

            // об'єднання рядків
            string h = "Hello";
            string w = "World";
            h += ""; //додаємо пробіл
            w = w + "!"; //склеюємо зі знаком оклику
            Console.WriteLine(string.Concat(h, w)); //склеює два рядки

            //перший аргумент - символ розділювача
            var t1 = string.Join("1", "2", "3"); //1,2,3
                                                 //цілочисельний масив перетворюється в текст
            var t2 = string.Join(";", new[] { 7, 8, 9 }); //7; 8; 9

            // Зміна регістру
            var t = "Abdc";
            var lower = t.ToLower(); //abcd
            var upper = t.ToUpper(); //ABCD

            b1 = "abc" == "abc"; //true
            b2 = "bcd" != "Bcd"; //true
            var b3 = "x".Equals("c"); //false

            int x = string.Compare("qwerty", "asdfg"); // > 0

            int y = string.CompareOrdinal("v", "v"); // == 0

            var st = "0987654321";
            bool b = st.StartsWith("09"); //true

            st = "0987654321";
            b = st.EndsWith("32"); //false

            int i1 = "twit".IndexOf("t"); //0

            int i2 = "twit".LastIndexOf("t"); //3

            string s = "Test";
            string s7 = s;
            var trim = s7.Trim(); // "1 Test"
            var start = s7.TrimStart(); // "1 Test"
            var end = s7.TrimEnd(); // "1 Test"
            var custom = s7.Trim(' ', 't'); // "1 Tes"

            string[] parts = "10,11,12".Split(",");

            string csv = "a; b; c; ; d; f; g;";
            parts = csv.Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            string k = "United Kingdom";
            var r1 = k.Substring(0, 6); //United
            var r2 = k.Substring(7, 4); //King
            var r3 = k.Substring(7); //Kingdom

            //заміна слова
            string n = "United States";
            string m = n.Replace("States", "Kingdom");
            Console.WriteLine(m); //United Kingdom
                                  //багатократна заміна символів
            var f = "2; 4; 6; 8; 10";
            Console.WriteLine(f.Replace(";", ",")); //2, 4, 6, 8, 10

            string v = "Some message";
            //вставка слова
            string p = v.Insert(5, "text");
            Console.WriteLine(p); //Some textmessage
                                  //вставляємо пробіл між словами
            Console.WriteLine(p.Insert(9, " ")); //Some text message

            string text = "London is the Capital of Great Britain";
            //видаляємо слово Great
            Console.WriteLine(text.Remove(25, 6));
            //залишаємо тільки London
            Console.WriteLine(text.Remove(6));

            string[] nums = new[] {"10", "1023","2"};
            //виводимо числа з вирівнюванням по правому краю
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i].PadLeft(4));

            // Результат
            // 10
            //1023
            // 2

            //додавання не значущих нулів до двійкових чисел
            string[] binNums = new[] { "101","111010", "11001"};
            for (int i = 0; i < binNums.Length; i++)
            {
                Console.WriteLine(binNums[i].PadLeft(8, '0'));
            }
            //00000101
            //00111010
            //00011001

            //доповнення справа
            string tree = "|";
            for (int i = 1; i < 6; i++)
            Console.WriteLine(tree.PadRight(i, '*'));
            

            // string => int
            string s = "389";
            int i;
            i = int.Parse(s);
            i = int.Parse("-29"); // i = -29

            // int => string
            string a;
            int a1;
            a1 = 230;
            a = a1.ToString(); // s = "230";


            double x;
            //string s;
            s = "9.83";
            //генерується виключна ситуація FormatException
            //з повідомленням &quot;Input string was not in a correct format.&quot;
            x = double.Parse(s);
            // Нижче наведено правильний варіант для ОС з кириличним кодуванням:
            // string => double            
            s = "9,83";
            x = double.Parse(s);
            //Перетворення числа з плаваючою комою вstring
            // double => string           
            x = -39.038;
            s = x.ToString(); // s = "-39,038"
            //Переведення значення змінної логічного типу bool в рядок string
            // string => bool
            bool b;            
            s = "true";
            b = bool.Parse(s); // b = True
            */
        }
    }
}
