using System;
using System.Threading;
using System.Diagnostics;

namespace YGGDrafus
{
    public static class ExecuteCmd
    {
        /// <summary>
        /// Executes a shell command synchronously.
        /// </summary>
        /// <param name="command">string command</param>
        public static void ExecuteCommandSync(object command)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run, and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows, and then exit.
                ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    // The following commands are needed to redirect the standard output. 
                    //This means that it will be redirected to the Process.StandardOutput StreamReader.
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    // Do not create the black window.
                    CreateNoWindow = true
                };
                // Now we create a process, assign its ProcessStartInfo and start it
                Process proc = new Process
                {
                    StartInfo = procStartInfo
                };
                proc.Start();
            }
            catch (Exception)
            {
                // Log the exception
            }
        }

        /// <summary>
        /// Execute the command Asynchronously.
        /// </summary>
        /// <param name="command">string command.</param>
        public static void ExecuteCommandAsync(string command)
        {
            try
            {
                //Asynchronously start the Thread to process the Execute command request.
                Thread objThread = new Thread(new ParameterizedThreadStart(ExecuteCommandSync))
                {
                    //Make the thread as background thread.
                    IsBackground = true,
                    //Set the Priority of the thread.
                    Priority = ThreadPriority.AboveNormal
                };
                //Start the thread.
                objThread.Start(command);
            }
            catch (ThreadStartException)
            {
                // Log the exception
            }
            catch (ThreadAbortException)
            {
                // Log the exception
            }
            catch (Exception)
            {
                // Log the exception
            }
        }

    }
}
