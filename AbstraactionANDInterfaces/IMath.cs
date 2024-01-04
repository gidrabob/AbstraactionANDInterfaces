namespace Lesson
{
    public interface IMath
    {
       public int  Max(); // повертає максимум;
       public int Min(); // повертає мінімум;
       public float Avg(); // повертає середньоарифметичне;
       public bool Search(int valueToSearch); //шукає valueSearch всередині контейнера даних.
    }
}
