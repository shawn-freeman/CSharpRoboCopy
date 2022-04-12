using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ClassLibrary1
{
    public class RobocopyWrapper
    {
        public bool CallRoboCopy(string source, string dest, string filename, string options)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    myProcess.StartInfo.Arguments = $"/C RoboCopy /S {source} {dest} {filename} {options}";
                    myProcess.StartInfo.FileName = "CMD.EXE";
                    myProcess.Start();
                    myProcess.WaitForExit();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
