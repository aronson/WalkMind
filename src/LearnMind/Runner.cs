using System.Diagnostics;

namespace LearnMind
{
    public class Runner
    {
        private readonly Process _process;
        public Runner(Process cogmindProcess)
        {
            _process = cogmindProcess;
        }
    }
}