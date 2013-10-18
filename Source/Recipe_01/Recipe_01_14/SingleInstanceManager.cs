using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows;

namespace Recipe_01_14
{
    public class SingleInstanceManager : WindowsFormsApplicationBase
    {
        public SingleInstanceManager()
        {
            this.IsSingleInstance = true;
        }

        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
        {
            bool result = base.OnStartup(eventArgs);
        
            App app = new App();
            app.Run();

            return result;
        }

        protected override void OnStartupNextInstance(
        StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            string args = Environment.NewLine;
            foreach (string arg in eventArgs.CommandLine)
            {
                args += Environment.NewLine + arg;
            }
            string msg = string.Format("New instance started with {0} args.{1}",
            eventArgs.CommandLine.Count,
            args);
            MessageBox.Show(msg);
        }

        protected override void OnCreateMainForm()
        {
            base.OnCreateMainForm();
        }
    }
}
