using System.Collections.Generic;

namespace RoundRobin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrival = { 0, 2, 5, 6, 8 };
            int[] run = { 7, 2, 3, 4, 5 };
            int period = 5;

            GetAvgWaitTime(arrival, run, period);

        }

        private static void GetAvgWaitTime(int[] arr, int[] run, int period)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(0);
            int currentTime = arr[0];
            int currentindex = 0;
            int currentWindow = 0;
            int[] lastRun = arr;
            int[] wait = new int[arr.Length];
            int arrtag = 1;
            while (q.Count > 0)
            {
                currentindex = q.Dequeue();
                wait[currentindex] = currentTime - lastRun[currentindex];
                currentWindow = run[currentindex] < period ? run[currentindex] : period;
                run[currentindex] -= currentWindow;
                currentTime += currentWindow;
                lastRun[currentindex] = currentTime;
                if (arrtag != arr.Length - 1)
                {
                    for (int i = arrtag; i < arr.Length; i++)
                    {
                        if (arr[i] <= currentTime)
                        {
                            q.Enqueue(i);
                        }
                        else
                        {
                            arrtag = i;
                            break;
                        }
                    }
                }


                if (run[currentindex] > 0)
                {
                    q.Enqueue(currentindex);
                }
            }




            System.Console.WriteLine(getAvgWaitTime(wait));
            System.Console.ReadLine();

        }
        private static double getAvgWaitTime(int[] wait)
        {
            double total = 0.0;
            for (int i = 0; i < wait.Length; i++)
            {
                total += wait[i];
            }

            return total / wait.Length;
        }
    }
}
