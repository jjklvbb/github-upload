using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MagicOntologies
{
    class Parsing
    {
        public static void FindMetaAttribute(List<JToken> nodes, JObject str, out string _entityName, out string _date)
        {
            JToken name = nodes.Where(n => n["name"].ToString() == "#Имя сущности").LastOrDefault();
            List<JToken> outRelName = str["relations"].Where(n => n["source_node_id"].ToString() == name.Value<string>("id")).ToList();
            JToken tokenName = str["nodes"].Where(n => n["id"].ToString() == outRelName.Last()["destination_node_id"].ToString()).LastOrDefault();
            _entityName = tokenName["name"].ToString();

            JToken date = nodes.Where(n => n["name"].ToString() == "#Дата").LastOrDefault();
            List<JToken> outRelDate = str["relations"].Where(n => n["source_node_id"].ToString() == date.Value<string>("id")).ToList();
            JToken tokenDate = str["nodes"].Where(n => n["id"].ToString() == outRelDate.Last()["destination_node_id"].ToString()).LastOrDefault();
            _date = tokenDate["name"].ToString();
        }

        static string DeleteFirstSpaces(string str)
        {
            if (str.Length == 0) return "";
            while (str[0] == ' ')
            {
                str = str.Substring(1);
            }
            return str;
        }

        static public Dictionary<string, string> Parser(string text, List<JToken> nodes)
        {
            SortedDictionary<int, string> dic = new SortedDictionary<int, string>();
            Dictionary<string, string> readyData = new Dictionary<string, string>();
            MatchCollection mc;

            foreach (JToken el in nodes)
            {
                string searchtext = "";
                string name = (string)el["name"];
                foreach (char ch in name)
                {
                    if (ch == '[' || ch == ']' || ch == '\\' || ch == '/' || ch == '^' || ch == '$' || ch == '.' || ch == '|' || ch == '?' ||
                        ch == '*' || ch == '+' || ch == '(' || ch == ')' || ch == '{' || ch == '}')
                        searchtext += "\\";
                    searchtext += ch;
                }
                Regex regex = new Regex($"({searchtext})", RegexOptions.IgnoreCase | RegexOptions.Compiled);

                mc = regex.Matches(text);
                if (mc.Count != 0)
                {
                    for (int i = 0; i < mc.Count; i++)
                        if (!dic.ContainsKey(mc[i].Index))
                        {
                            dic.Add(mc[i].Index, mc[i].Value.Trim());
                            break;
                        }
                }
            }

            for (int i = 0; i <= dic.Count() - 1; i++)
            {
                string key = dic.ElementAt(i).Value;
                int idx = i + 1, leng = 0 - dic.ElementAt(i).Key - key.Length;
                if (i != dic.Count() - 1) leng += dic.ElementAt(idx).Key;
                if (leng != 0)
                {
                    string s;
                    if (i != dic.Count() - 1) s = text.Substring(dic.ElementAt(i).Key + key.Length, leng).Trim();
                    else s = text.Substring(dic.ElementAt(i).Key + key.Length).Trim();
                    if (s != "")
                    {
                        if (s[0] == ':')
                            s = s.Substring(1);
                        s = DeleteFirstSpaces(s);
                        if (!readyData.ContainsKey(key))
                            readyData.Add(key, s);
                    }
                }
            }

            return readyData;
        }
    }
}
