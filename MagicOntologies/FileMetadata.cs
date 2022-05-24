using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicOntologies
{
    [Serializable]
    public class FileMetadata
    {
        public string fullPath;
        public string text;
        public Dictionary<string, string> readyData = new Dictionary<string, string>();
        //атрибут #Имя сущности
        public string entityName;
        //атрибут #Дата
        public string date;

        public FileMetadata(string _fullPath, string _text, Dictionary<string, string> _readyData, string _entityName, string _date)
        {
            fullPath = _fullPath;
            text = _text;
            readyData = _readyData;
            entityName = _entityName;
            date = _date;
        }
    }
}
