using System.Linq;

namespace Lesson
{
    public class MyArray : IOutput, IMath//, ISort //(масив цілого типу) із необхідними методами
    {
        public int[] TestArray { get; set; }
        public MyArray(int[] testArray)
        {
            TestArray = testArray;
        }
        public int[] RandomArray(int[] testArray) //рандомний масив
        {
            Random generate = new Random();
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = generate.Next(1, 20);
            }
            return TestArray;
        }
        public void Show()
        {
            Console.WriteLine("\nYou array:");
            foreach (int i in TestArray)
            {
                Console.Write($"{i} ");
            }
        }
        public void Show(string info)
        {
            foreach (int i in TestArray)
                Console.WriteLine($"{info}:{i}");
        }
        public int Max() // повертає максимум;
        {
            int maxValue = TestArray.Max<int>();
            return maxValue;
        }
        public int Min() // повертає мінімум;
        {
            int minValue = TestArray.Min<int>();
            return minValue;
        }
        public float Avg()// повертає середньоарифметичне;
        {
            float sumArrayNumber = 0;

            for (int i = 0; i < TestArray.Length; i++)
            {
                sumArrayNumber += TestArray[i];
            }
            return sumArrayNumber / TestArray.Length;
        }
        public bool Search(int valueToSearch) //шукає valueSearch всередині контейнера даних.
        {
            bool result = true;
            foreach (var item in TestArray)
            {
                if (item == valueToSearch)
                {
                    result = true;
                    break;
                }
                else
                    result = false;
            }
            return result;
        }
        public void SortAsc(int[] testArray)  // сортування за зростанням;
        {
            for (int i = 0; i < testArray.Length-1; i++)
            {
                for (int j = 0; j < testArray.Length - i - 1; j++)
                {
                    if (testArray[j] > testArray[j + 1])
                    {
                        int temp = testArray[j];
                        testArray[j] = testArray[j + 1];
                        testArray[j + 1] = temp;
                    }
                }
            }
        }
        public void SortDesc(int[] TestArray)  // сортування за зменшенням;
        {
            for (int i = 0; i < TestArray.Length - 1; i++)
            {
                for (int j = 0; j < TestArray.Length - i - 1; j++)
                {
                    if (TestArray[j] < TestArray[j + 1])
                    {
                        int temp = TestArray[j];
                        TestArray[j] = TestArray[j + 1];
                        TestArray[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByParam(bool isAsc) // сортування залежно від переданого параметра.
        {
            if (!isAsc)
            {
                SortAsc(TestArray);
            }
            else 
            {
                SortDesc(TestArray);
            }                  

        }
    }
}
