using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PID
    {
        public PID()
        {
            P = 0.1F;
            I = 0.01F;
            D = 0F;

            err0 = 0;
            err1 = 0;
            errSum = 0;
            derr = 0;
        }
        public Single P;
        public Single I;
        public Single D;

        public Single ExpectedValue;
        public Single ActualValue;

        private Single err0;
        private Single err1;
        private Single errSum;
        private Single derr;

        private Single ControlValue;
        public Single Calculate()
        {
            err0 = ExpectedValue - ActualValue;
            errSum += err0;
            derr = err0 - err1;
            err1 = err0;
            ControlValue = P * err0 + I * errSum + D * derr;
            return ControlValue;
        }
        public void Reset()
        {
            err0 = 0;
            err1 = 0;
            errSum = 0;
            derr = 0;
        }
    }
}
