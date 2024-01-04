
//Завдання 2
//Завдання 3
//Створіть інтерфейс ISort.
//У ньому мають бути три методи:
//■ void SortAsc() — сортування за зростанням;
//■ void SortDesc() — сортування за зменшенням;
//■ void SortByParam(bool isAsc) — сортування залежно від переданого параметра.
//Якщо isAsc дорівнює true, сортуємо за зростанням.
//Якщо isAsc дорівнює false, сортуємо за зменшенням
//Клас, створений у першому завданні Array, має імплементувати інтерфейс ISort.
//Метод SortAsc — сортує масив за зростанням.
//Метод SortDesc — сортує масив за спаданням.
//Спосіб SortByParam — сортує масив залежно від переданого параметра.
//Якщо isAsc дорівнює true, сортуємо за зростанням.
//Якщо isAsc дорівнює false, сортуємо за зменшенням.
//Напишіть код для тестування отриманої функціональності.

namespace Lesson
{  
    public class Progarm
    {
        public static void Main()
        {
            Console.WriteLine("Enter lenght you array:");
            int lenghtUserArray = Convert.ToInt32 (Console.ReadLine());

            int[] arrayForFunction = new int[lenghtUserArray];

            MyArray testArray = new MyArray(arrayForFunction);

            testArray.RandomArray(arrayForFunction);
            testArray.Show();

            //Console.WriteLine("Enter the text you want see:");
            //string userText = Console.ReadLine();
            //testArray.Show(userText);

            //Console.WriteLine($"Max number in you array: {testArray.Max()}");
            //Console.WriteLine($"Min number in you array: {testArray.Min()}");
            //Console.WriteLine($"Averege you array: {testArray.Avg()}");

            //Console.WriteLine("Enter a number to search: ");
            //int serchNumber = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine(testArray.Search(serchNumber));

            testArray.SortAsc(arrayForFunction);
            testArray.Show();
            
            testArray.SortDesc(arrayForFunction);
            testArray.Show();

            Console.WriteLine("Enter how you want to sort: ascending or descending");
            string userRequest = Console.ReadLine();
            if (userRequest == "ascending")
            {
                testArray.SortByParam(true);
                testArray.Show();
            }
            else if (userRequest == "descending")
            {
                testArray.SortByParam(false);
                testArray.Show();
            }
            else
            {
                throw new Exception("Please enter correct world!");
            }
        }
    }
}