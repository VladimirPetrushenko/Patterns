using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class Camera
    {
        private IState state;
        public Camera() => state = new TurnOffCamera();

        public void SetState(IState state) => this.state = state;

        public void TakePhoto() => state.TakePhoto(this);
        public void TakeVideo() => state.TakeVideo(this);
        public void TakeSlowMotion() => state.TakeSlowMotion(this);
        public void TurnOn() => state.TurnOn(this);
        public void TurnOff() => state.TurnOff(this);
    }
}
