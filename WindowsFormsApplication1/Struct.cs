using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    enum BUTTON
    {
        SHAKING_HANDS,              //0
        SET_VCSEL_BIAS,             //1
        SET_VCSEL_SINEP2P,          //2
        SET_VCSEL_SINEFRE,          //3
        READ_PD,                    //4
        LAST_COMMAND_FLAG           //5
    }
    enum WMD_STATE
    {
        FREE,
        PICTURE1SPIN,
        PICTURE2SPIN,
    }
    enum MESSAGE_STATE
    {
        WAITING_FF1,
        WAITING_FF2,
        SENDER_ID,
        RECEIVER_ID,
        RECEIVE_LEN_H,
        RECEIVE_LEN_L,
        RECEIVE_PACKAGE,
        RECEIVE_CHECK
    }
    struct MESSAGE
    {
        public byte sender_id;
        public byte receiver_id;
        public ushort length;
        public byte[] data;
    };
}
