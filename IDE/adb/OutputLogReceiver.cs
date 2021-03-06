﻿using Managed.Adb;
using System.Text;

namespace NIDE.adb
{
    internal class OutputLogReceiver : IShellOutputReceiver
    {
        public bool IsCancelled { get; set; } = false;

        public void AddOutput(byte[] data, int offset, int length)
        {
            string item = Encoding.UTF8.GetString(data, offset, length);
            string[] items = item.Split('\n');
            foreach (var its in items)
            {
                string it = its.Trim();
                if (it.Contains("INNERCORE"))
                {
                    string msg = it.Substring(it.IndexOf(':') + 2);
                    ProgramData.Log("InnerCore", msg, ProgramData.LOG_STYLE_NORMAL);
                }
                else if (it.Contains("MOD-PRINT"))
                {
                    string msg = it.Substring(it.IndexOf(':') + 2);
                    ProgramData.Log("Mod-Print", msg, ProgramData.LOG_STYLE_NORMAL);
                }
            }
        }

        public void Flush()
        {
            
        }
    }
}
