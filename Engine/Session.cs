using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Session
    {
        //Fields.
        private List<string> files;

        //Properties.
        public List<string> Files
        {
            get { return files; }
            set { files = value; }
        }
        public string[] FilesArray
        {
            get { return files.ToArray(); }
        }

        //Constructor.
        public Session()
        {
            files = new List<string>();
        }

        public void AddFiles()
        {

        }
    }
}
