using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicOntologies
{
    public class CheckListBoxItem
    {
        public string fullPath;
        public string text;

        public CheckListBoxItem(string _fullPath, string _text)
        {
            fullPath = _fullPath;
            text = _text;
        }

        public override string ToString() { return text; }
    }
}
