using System;

namespace State
{
    class TurnOffCamera : IState
    {
        public void TakePhoto(Camera camera) => Console.WriteLine("You can't do that because the camera is off");

        public void TakeSlowMotion(Camera camera) => Console.WriteLine("You can't do that because the camera is off");

        public void TakeVideo(Camera camera) => Console.WriteLine("You can't do that because the camera is off");

        public void TurnOff(Camera camera) => Console.WriteLine("The camera is already off because the camera is off");

        public void TurnOn(Camera camera)
        {
            camera.SetState(new TurnOnCamera());
            Console.WriteLine("The camera turns on");
        }
    }
}
