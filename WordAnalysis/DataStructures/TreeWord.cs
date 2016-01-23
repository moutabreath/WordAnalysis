using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordAnalysis.DataStructures
{
    class TreeWord
    {
        private string key;
        private string value;
        private TreeWord left;
        private TreeWord right;

        public string getValue() { return value; }
        public void Add(string newVal, string newKey)
        {
            if ((key == null) || (key == ""))
            {
                key = newKey;
                value = newVal;
                return;          
            }
            if (key.CompareTo(newKey) > 0)
            {
                if (left == null)
                {
                    left = new TreeWord();                    
                }
                left.Add(newVal, newKey);
                return;
            }
            if (key.CompareTo(newKey) <= 0)
            {
                if (right == null)
                {
                    right = new TreeWord();
                }
                right.Add(newVal, newKey);
            }            
        }

        public string search(string key)
        {
            if (this.key == key)
            {
                string returnedIds = value;
                if (right != null)
                {
                    returnedIds += ", " + right.search(key);
                }
                return returnedIds;
            }
            if (key.CompareTo(this.key) < 0)
            {
                if (left == null) { return ""; }
                return left.search(key);
            }
            else
            {
                if (right == null) { return ""; }
                return right.search(key);
            }
        }
    }
}
