using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Time
    {
        public void Delay_ms(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)//毫秒
            {
                Application.DoEvents();//可执行某无聊的操作
            }
        }
    }
}
