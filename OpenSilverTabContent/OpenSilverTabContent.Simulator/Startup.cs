using OpenSilver.Simulator;
using System;

namespace OpenSilverTabContent.Simulator
{
    static class Startup
    {
        [STAThread]
        static int Main(string[] args)
        {
            return SimulatorLauncher.Start(typeof(App));
        }
    }
}
