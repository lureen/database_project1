using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database_Project1
{
    class InsertData
    {
        public string tableName { get; set; }           //set and get tablename
        List<string> valueList;                         //list for holding the field values

        public InsertData()
        {
            valueList = new List<string>();
        }
        public void setValueList(string fieldValues)  // set the field values from the user's input
        {
            valueList.Add(fieldValues);
        }

    }
}
