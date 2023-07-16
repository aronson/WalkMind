using System.IO;

namespace LearnMind
{
    public class Save
    {
        private readonly FileInfo _file;

        public Save(FileInfo file)
        {
            _file = file;
        }
    }
}