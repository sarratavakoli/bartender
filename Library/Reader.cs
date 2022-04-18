namespace Library
{
    /// <summary>
    /// https://stackoverflow.com/questions/57615/how-to-add-a-timeout-to-console-readline
    /// </summary>
    public class Reader
    {
        private static Thread inputThread;
        private static AutoResetEvent getInput, gotInput;
        private static ConsoleKey input;

        static Reader()
        { }

        private static void reader()
        {
            getInput.WaitOne();
            try
            {
                input = Console.ReadKey(true).Key;

            }
            catch (Exception)
            { }
            gotInput.Set();
        }

        // omit the parameter to read a line without a timeout
        public static ConsoleKey ReadLine(int timeOutMillisecs = Timeout.Infinite)
        {
            getInput = new AutoResetEvent(false);
            gotInput = new AutoResetEvent(false);
            inputThread = new Thread(reader);
            inputThread.IsBackground = true;
            inputThread.Start();

            getInput.Set();
            bool success = gotInput.WaitOne(timeOutMillisecs);
            inputThread.Interrupt();

            if (success)
                return input;
            else
                return ConsoleKey.NoName;
        }
    }
}