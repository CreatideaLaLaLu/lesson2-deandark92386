using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taoyuan.Port.VotingSystem.Service.BaseDatas
{
    public class NamingRuleService
    {
        public int TestFunction(int index)
        {
            switch (index)
            {
                //bad
                //case 1: break;
                //default: break;
                //good
                case 1:
                    break;
                default:
                    break;
            }
            //bad
            //if (index == 0)
            //    DoTrue();
            //else
            //    DoFalse();


            //good
            if (index == 0)
            {
                DoTrue();
            }

            else
            {
                DoFalse();
            }

            //bad 上面已有動作
            //if (DoTrue() == true) { DoTrue(); }
            //good
            if (DoTrue())
            {
                DoTrue();
            }


            //bad 
            //return (index * (index + 1) / 2);

            //good
            return index * (index + 1) / 2;
        }

        private bool DoTrue()
        {
            return true;
        }
        private bool DoFalse()
        {
            return false;
        }

        public void TestStringFunction(string value)
        {
            string NewString = "ABCDEFG"; //新字串
            //bad 
            if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");

            //good
            if (value != null || value != "")
            {
                value = new StringBuilder(value).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }

        }

    }
}
