using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm1());

            stopwatch.Stop();
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
            long thresholdMilliseconds = 2000; // Próg czasowy w milisekundach (np. 2 sekundy)

            if (elapsedMilliseconds > thresholdMilliseconds)
            {
                LogEvent($"Aplikacja uruchamiała się przez {elapsedMilliseconds} ms, co przekracza próg {thresholdMilliseconds} ms.");
            }
        }

        static void LogEvent(string message)
        {
            // Logowanie zdarzenia - możesz dostosować ten kod do własnych potrzeb.
            // Na przykład: zapis do pliku, rejestru systemowego, itp.
            string logFilePath = "ApplicationLog.txt";
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
