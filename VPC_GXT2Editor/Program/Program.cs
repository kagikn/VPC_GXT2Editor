using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentOwl.BetterListView;
using System.Reflection;
namespace VPC_GXT2Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string listviewResourceName = "VPC_GXT2Editor.betterlistviewexpress-net35.dll";
            EmbeddedAssembly.Load(listviewResourceName, "betterlistviewexpress-net35.dll");

            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(VPC_GXT2Editor_AssemblyResolve);
            Application.Run(new Main());
        }
        static Assembly VPC_GXT2Editor_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }

}
