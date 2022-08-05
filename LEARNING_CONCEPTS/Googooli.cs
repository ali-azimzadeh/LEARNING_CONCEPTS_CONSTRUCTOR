using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_CONCEPTS
{
    class Googooli
    {

        public Googooli()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"> </param>
        /// <param name="fullName"> </param>
        public Googooli(int age,string fullName)
        {
            Age = age;

            FullName = fullName;
        }

        public int Age;

        public string FullName;
    }
}
