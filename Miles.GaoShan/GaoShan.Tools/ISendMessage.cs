using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaoShan.Tools
{
    public interface ISendMessage
    {
        bool Send(string msg,params string[] phones);
    }
}
