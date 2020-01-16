using System;

namespace DelegatesAndEvents
{
    //public delegate int BizRulesDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> addDel = (x, y) => x + y;
            Func<int, int, int> multipDel = (x, y) => x * y;
            var data = new ProcessData();
            data.Process(1, 2, addDel);

            Action<int, int> MyAddAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> MyMultipAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(1, 2, MyAddAction);

            var worker = new Worker();
            worker.WorkPerformed += Worker_WorkerPerformed;
            worker.WorkCompleted +=  (s, e) => Console.WriteLine("Worker is done");
            worker.DoWork(8, WorkType.GenerateReports);
        }

        private static void Worker_WorkerPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked: " + e.Hours + " " + e.WorkType); ;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
