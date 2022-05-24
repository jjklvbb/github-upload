using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicOntologies
{
    public class QuestionLogic
    {

        public static string QueryBuilder(System.Windows.Forms.CheckedListBox.CheckedItemCollection checkedItems, 
            System.Windows.Forms.CheckedListBox.ObjectCollection items, string key1, string key2)
        {
            string Query = $@"select value, numdoc_name from valueitog
                             join tableall on all_valueitog = value_id
                             join numdoc on all_numdoc = numdoc_id
                             where all_indicator = (select indicator_id from indicator where indicator_name like '%{key1}%') and
                             all_numdoc in(select all_numdoc from tableall
                             where all_valueitog in(select value_id from valueitog where value like '%{key2}%'))";
            ;

            int i = 0;
            foreach (CheckListBoxItem item in checkedItems)
            {
                if (item.text == "Все файлы")
                {
                    foreach (CheckListBoxItem additem in items)
                    {
                        if (i == 0) Query += $"\nand (";
                        else Query += $"\nor ";
                        Query += $"numdoc_name = '{additem.fullPath}'";
                        i++;
                    }
                    Query += ");";
                    return Query;
                }
            }

            i = 0;
            foreach (CheckListBoxItem item in checkedItems)
            {
                //Query += $"\n";
                if (i == 0) Query += $"\nand (";
                else Query += $"\nor ";
                Query += $"numdoc_name = '{item.fullPath}'";
                i++;
            }
            Query += ");";

            return Query;

        }
    }
}
