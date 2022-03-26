using System;

namespace WindowsFormsApplication1
{
    class Vcsel
    {
        public Vcsel()
        {
            voltage_bias = 0;
            voltage_sinep2p = 0;
            voltage_sinefre = 0;

            current_bias = 0;
            current_sinep2p = 0;
            current_sinefre = 0;
        }
        public Single voltage_bias;
        public Single voltage_biasundercontrol;
        public Single voltage_sinep2p;
        public Single voltage_sinefre;

        public Single current_bias;
        public Single current_sinep2p;
        public Single current_sinefre;
    }
}
