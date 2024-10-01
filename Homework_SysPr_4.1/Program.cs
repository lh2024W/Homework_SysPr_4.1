namespace Homework_SysPr_4._1
{
    public class Program
    {
        static void Main()
        {
            //Используя два потока, реализовать вывод двух слов, с левой стороны консоли и с правой. 
            //Каждую секунду, оба слова смещаются на одну позицию, ближе к центру.
            //Потоки завершают свою работу, как только слова дойдет до противоположных краев консоли.


            Thread thread = new Thread(() =>
            {
                for (int i = 5; i < 110; i++)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(i, 0);
                    Console.WriteLine("Hello");
                    Thread.Sleep(200);
                    Console.Clear();
                }
            });
            thread.Start();

            Thread thread1 = new Thread(() =>
            {
                for (int i = 110; i > 5; i--)
                {
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(i, 10);
                    Console.WriteLine("World!");
                    Thread.Sleep(200);
                    Console.Clear();
                }
            });
            thread1.Start();
        }
    }
}
