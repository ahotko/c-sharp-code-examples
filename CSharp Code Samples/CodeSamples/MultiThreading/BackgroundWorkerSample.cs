using System;
using System.ComponentModel;
using System.Threading;

namespace CodeSamples.MultiThreading
{
    public class BackgroundWorkerSample
    {
        private readonly AutoResetEvent resetEvent = new AutoResetEvent(false);

        public void Go()
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorker_DoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorker_RunWorkerCompleted);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(BackgroundWorker_ProgressChanged);
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            //start background worker
            if(!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
            //wait for background worker to finish; not necessary, but required for testing samples, so they execute in order
            resetEvent.WaitOne();
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine($"...reporting progress: {e.ProgressPercentage}%");
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;
            for(int i=0;i<11;i++)
            {
                Console.WriteLine($"...doing it's job");
                worker.ReportProgress(i*10);
                System.Threading.Thread.Sleep(50);
            }
            e.Result = 42; //object, can use any class
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Console.WriteLine($"...done, Result = {e.Result.ToString()}");
            resetEvent.Set();
        }
    }
}
