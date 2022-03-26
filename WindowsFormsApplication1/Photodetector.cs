using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    class Photodetector
    {
        public Photodetector()
        {
            voltage1 = 0;
            voltage2 = 0;
            value1 = 0;
            value2 = 0;
        }
        public Single voltage1; //转换为电压后的PD1值
        public Single voltage2; //转换为电压后的PD2值

        public ushort value1;   //原始16位字符的PD1值
        public ushort value2;   //原始16位字符的PD2值

    }
    
}
