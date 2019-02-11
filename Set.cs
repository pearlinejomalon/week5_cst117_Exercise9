//Correction by Pearl Jomalon

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lydia's code - find the errors!
namespace CST117_IC08_console
{
    class Set
    {
        private List<int> elements;

        public Set()
        {
            elements = new List<int>();
        }

        //doesn't need return type, change bool to void
        //public bool addElement(int val)
        public void addElement(int val)
        {
            //this section is changed to reflect void instead of bool
            //if (containsElement(val)) return false;
            //else
            //{
                //elements.Add(val);
                //return true;
            //}
            if (!containsElement(val))
            {
                elements.Add(val);
            }
        }

        private bool containsElement(int val)
        {

            for (int i = 0; i < elements.Count; i++)
          if (val == elements[i])
                    return true;
                         {
         //prevented loop by returning value
                //else
                    //return false;
                }
                    return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        //method not used
        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {

            for(int i = 0; i < rhs.elements.Count; i++)
            {
                this.addElement(rhs.elements[i]);
            }
            //chane return from rhs to this
            //return rhs;
            return this;
        }

        //added new method to duplicate Set and perform union on duplicate instead of original
        public Set DuplicateSet(Set A, Set _A)
        {
            for (int i = 0; i < A.elements.Count; i++)
            {
                _A.addElement(A.elements[i]);
            }
            return _A;
        }
    }
}
