using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_11
{
    public interface IRandomMessageBuilder
    {
        void AddDateTime(bool isRandom);
        void AddGreeting();
        void AddName();
        string Result();


    }
}
