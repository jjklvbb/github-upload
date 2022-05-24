using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace MagicOntologies
{
    [Serializable]
    public class OntologyConfig
    {
        public string ontologyPath;
        public List<FileMetadata> files;
        public List<JToken> nodes;
        public string entityName;
        public string date;

        public OntologyConfig()
        {
             files = new List<FileMetadata>();
             nodes = new List<JToken>();
        }

        public OntologyConfig(string _ontologyPath, List<FileMetadata> _files, List<JToken> _nodes, string _entityName, string _date)
        {
            ontologyPath = _ontologyPath;
            files = _files;
            nodes = _nodes;
            entityName = _entityName;
            date = _date;
        }
    }
}
