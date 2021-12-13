using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface IState
    {
        void TurnOn(Camera camera);
        void TurnOff(Camera camera);
        void TakePhoto(Camera camera);
        void TakeVideo(Camera camera);
        void TakeSlowMotion(Camera camera);
    }
}
