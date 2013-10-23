using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace Recipe_01_14
{
    public class EntryPoint
    {
        [STAThread]
        public static void Main(string[] args)
        {
            SingleInstanceManager manager = new SingleInstanceManager();

            try
            {
                manager.Run(args);
            }
            catch (NoStartupFormException)
            {
                // Do nothing
            }
        }
    }
}