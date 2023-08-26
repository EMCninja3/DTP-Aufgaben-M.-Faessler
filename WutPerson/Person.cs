using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WutPerson
{
    internal class Person
    {
        private int wutLevel;
        private int appetitLevel;

        public Person(int wutLevel, int appetitLevel)
        {
            this.wutLevel = wutLevel;
            this.appetitLevel= appetitLevel;
        }

        public void Provozieren(int level)
        {
            
            
            wutLevel += level;
            if (wutLevel > 6)
            {
                Ausrasten();
            }
        }
        private void Ausrasten()
        {
            wutLevel= 0;
        }
        public void Essengeben()
        {
            wutLevel--;
        }
        public void EssenVerweigern()
        {
            wutLevel++;
        }
        public void ArbeitsauftragGeben(int level)
        {
            wutLevel += level;
        }
    }
}
