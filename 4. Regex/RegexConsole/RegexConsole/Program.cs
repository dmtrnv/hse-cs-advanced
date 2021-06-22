using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace RegexConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задача 1. Проверить является ли заданная строка шестизначным числом, записанным в десятичной системе счисления без нулей в старших разрядах.  

            var testDataForTask1 = new string[]
            {
                "123456",
                "234567",
                "102580",
                "1234567",
                "12345",
                "012345",
                "005234",
                "000001",
                "000235235",
                " ",
                "234500 руб.",
                "Стоимость - 102370 руб.",
                " 123456",
                "123456 "
            };

            var patternForTask1 = @"^[1-9]\d{5}$";

            Console.WriteLine("Задача 1. Проверить является ли заданная строка шестизначным числом, записанным в десятичной системе счисления без нулей в старших разрядах.\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask1}\n");
            Console.WriteLine("Результат проверки:\n");

            foreach (var str in testDataForTask1)
            {
                Console.WriteLine($"\"{str}\" : {Regex.IsMatch(str, patternForTask1)}");
            }

            Console.Write("\n\n\n\n");

            #endregion

            #region Задача 2. Написать регулярное выражение, определяющее является ли заданная строка правильным MACадресом. Адрес состоит из 6 - ти чисел, записанных в шестнадцатеричной системе счисления от 0 до FF и разделенных символом «:». 

            var testDataForTask2 = new string[]
            {
                "01:32:54:67:89:AB",
                "aE:dC:cA:56:76:54",
                "aE:dC:cA:56:76:5n",
                "01:32:54:67:89:AB:",
                "01:33:47:65:89:ab:cd",
                "01:23:45:67:89:Az",
                "ab.bb.23.11.00",
                " ",
                "12-aa-bc-3f-ff",
                "qqwwaaeerr"
            };

            var patternForTask2 = @"^([A-Fa-f0-9]{2}:){5}[A-Fa-f0-9]{2}$";

            Console.WriteLine("Задача 2. Написать регулярное выражение, определяющее является ли заданная строка правильным MACадресом. Адрес состоит из 6 - ти чисел, записанных в шестнадцатеричной системе счисления от 0 до FF и разделенных символом «:».\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask2}\n");
            Console.WriteLine("Результат проверки:\n");

            foreach (var str in testDataForTask2)
            {
                Console.WriteLine($"\"{str}\" : {Regex.IsMatch(str, patternForTask2)}");
            }

            Console.Write("\n\n\n\n");

            #endregion

            #region Задача 3. Написать регулярное выражение, определяющее является ли данная строчка шестнадцатиричным идентификатором цвета в HTML. Где #FFFFFF для белого, #000000 для черного, #FF0000 для красного и.т.д. 

            var testDataForTask3 = new string[]
            {
                "#FFFFFF",
                "#FF3421",
                "#00ff00",
                "232323 f#fddee",
                "#fd2",
                "#ffEAKl",
                " ",
                "#FF3421 ",
                " #FF3421"
            };

            var patternForTask3 = @"^#[A-Fa-f0-9]{6}$";

            Console.WriteLine("Задача 3. Написать регулярное выражение, определяющее является ли данная строчка шестнадцатиричным идентификатором цвета в HTML. Где #FFFFFF для белого, #000000 для черного, #FF0000 для красного и.т.д.\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask3}\n");
            Console.WriteLine("Результат проверки:\n");

            foreach (var str in testDataForTask3)
            {
                Console.WriteLine($"\"{str}\" : {Regex.IsMatch(str, patternForTask3)}");
            }

            Console.Write("\n\n\n\n");

            #endregion

            #region Задача 4. Проверить, надежно ли составлен пароль. Пароль считается надежным, если он состоит из 8 или более символов. Где символом может быть английская буква, цифра и знак подчеркивания. Пароль должен содержать хотя бы одну заглавную букву, одну маленькую букву и одну цифру.

            var testDataForTask4 = new string[]
            {
                "C00l_Pass",
                "SupperPas1",
                "SupperPas",
                "Cool_pass",
                "C00l",
                "Qasdasdasd1",
                "1asfQQasda",
                "SupperPas1 ",
                " SupperPas1",
                "a1asfqwrqwasfasT",
                "TTTTTTTTTTT_2a",
                " "
            };

            var patternForTask4 = @"^\w{8,}(?<=.*[A-Z].*)(?<=.*[a-z].*)(?<=.*\d.*)$";

            Console.WriteLine("Задача 4. Проверить, надежно ли составлен пароль. Пароль считается надежным, если он состоит из 8 или более символов. Где символом может быть английская буква, цифра и знак подчеркивания. Пароль должен содержать хотя бы одну заглавную букву, одну маленькую букву и одну цифру.\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask4}\n");
            Console.WriteLine("Результат проверки:\n");

            foreach (var str in testDataForTask4)
            {
                Console.WriteLine($"\"{str}\" : {Regex.IsMatch(str, patternForTask4)}");
            }

            Console.Write("\n\n\n\n");

            #endregion

            #region Задача 5. В сообщении может содержаться дата в формате дд.мм.гггг. В заданном формате дд - целое число из диапазона от 1 до 31, мм - целое число из диапазона от 1 до 12, а гггг - целое число из диапазона от 1900 до 2012 (если какая-то часть формата нарушена, то данная подстрока в качестве даты не рассматривается). Найти все даты, которые относятся к текущему году.

            var testDataForTask5 = "Юрий Гагарин полетел в космос 12.04.1961. 26.12.1991 распался СССР. 11.06.2009 ВОЗ впервые за 40 лет объявила о всемирной пандемии свиного гриппа. Запуск космического корабля \"Союз ТМА-14\" состоялся 26.03.2009. 07.02.2014 начались зимние олимпийские игры в Сочи.";

            var patternForTask5 = @"(?<=\s|^)(0[1-9]|[1-2]\d|3[0-1])[\.](0[1-9]|1[0-2])[\.](?<year>19\d{2}|20(0\d|1[0-2]))(?=\s|\.|,|$)";

            var regexForTask5 = new Regex(patternForTask5);

            var currentYear = "2009";

            Console.WriteLine("Задача 5. В сообщении может содержаться дата в формате дд.мм.гггг. В заданном формате дд - целое число из диапазона от 1 до 31, мм - целое число из диапазона от 1 до 12, а гггг - целое число из диапазона от 1900 до 2012 (если какая-то часть формата нарушена, то данная подстрока в качестве даты не рассматривается). Найти все даты, которые относятся к текущему году.\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask5}\n");
            Console.WriteLine("Результат проверки:\n");
            Console.WriteLine($"Текст: {testDataForTask5}\n");
            Console.WriteLine($"Текущий год: {currentYear}\n");
            Console.WriteLine("Найденные даты:\n");

            foreach (Match match in regexForTask5.Matches(testDataForTask5))
            {
                if (match.Groups["year"].ToString() == currentYear)
                {
                    Console.WriteLine($"{match.Value}");
                }
            }

            Console.Write("\n\n\n\n");

            #endregion

            #region Задача 6. В сообщении может содержаться время в формате чч:мм:сс. В заданном формате чч - целое число из диапазона от 00 до 24, мм и сс - целые числа из диапазона от 00 до 60 (если какая-то часть формата нарушена, то данная подстрока в качестве даты не рассматривается).

            var testDataForTask6 = "Кот проснулся в 06:59:18. В 7:22:00 он позавтракал, а в 09:11:07 отправился на прогулку. Кот по имени \"Барсик\" вернулся с домой около 16:16:16. К 23:59:59 он уснул.";

            var patternForTask6 = @"(?<=\s|^)([0-1]\d|2[0-3]):[0-5]\d:[0-5]\d(?=\s|\.|,|$)";

            var regexForTask6 = new Regex(patternForTask6);

            Console.WriteLine("Задача 6. В сообщении может содержаться время в формате чч:мм:сс. В заданном формате чч - целое число из диапазона от 00 до 24, мм и сс - целые числа из диапазона от 00 до 60 (если какая-то часть формата нарушена, то данная подстрока в качестве даты не рассматривается).\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask6}\n");
            Console.WriteLine("Результат проверки:\n");
            Console.WriteLine($"Текст: {testDataForTask6}\n");
            Console.WriteLine("Найденные времена:\n");

            foreach (Match match in regexForTask6.Matches(testDataForTask6))
            {
                Console.WriteLine($"{match.Value}");
            }

            Console.Write("\n\n\n\n");

            #endregion

            #region Задача 7. Разработать программу для поиска в тексте всех корректно записанных римских чисел (от 1 до 3999) и их замены на соответствующее “арабское” число.

            var testDataForTask7 = "I, II, III, IIII, IV, V, VI, VII, VIII, VIIII, IX, X, XI, XII, XIII, XIIII, XIV, XV, XVI, XVII, XVIII, XVIIII, XIX, XIXI, XX, XXI, XL, LXX, XC, CCC, DCC, MCCLXXXIX, MMCDI, CDLXVIII, CXVIII, MMDCXI, MMMCMXCIX, MMMM.";

            var patternForTask7 = @"(?<=\s|^)M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})(?=\s|\.|,|$)";

            var regexForTask7 = new Regex(patternForTask7);

            Console.WriteLine("Задача 7. Разработать программу для поиска в тексте всех корректно записанных римских чисел (от 1 до 3999) и их замены на соответствующее “арабское” число.\n");
            Console.WriteLine($"Регулярное выражение: {patternForTask7}\n");
            Console.WriteLine("Результат проверки:\n");
            Console.WriteLine($"Исходный текст:\n{testDataForTask7}\n");
            Console.WriteLine("Обработанный текст:");

            Console.WriteLine(regexForTask7.Replace(testDataForTask7, m => $"{m.Value} = {ParseRomanNumber(m.Value).ToString()}"));

            Console.Write("\n\n\n\n");

            #endregion

            Console.ReadKey();
        }

        static int ParseRomanNumber(string romanNumber)
        {
            var numbers = new List<int>();

            for (var i = (romanNumber.Length - 1); (i - 1) >= 0; i -= 2)
            {
                var number = RomanNumbers[romanNumber[i].ToString()];
                var preNumber = RomanNumbers[romanNumber[i - 1].ToString()];

                if (number > preNumber)
                {
                    numbers.Add(number - preNumber);
                }
                else
                {
                    numbers.Add(number + preNumber);
                }
            }    

            if (romanNumber.Length % 2 != 0)
            {
                numbers.Add(RomanNumbers[romanNumber[0].ToString()]);
            }

            return numbers.Sum();
        }

        static readonly Dictionary<string, int> RomanNumbers = new Dictionary<string, int>()
        {
            ["I"] = 1,
            ["V"] = 5,
            ["X"] = 10,
            ["L"] = 50,
            ["C"] = 100,
            ["D"] = 500,
            ["M"] = 1000
        };
    }
}
