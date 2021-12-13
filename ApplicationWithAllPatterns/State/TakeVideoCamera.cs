using System;

namespace State
{
    class TakeVideoCamera : IState
    {
        public void TakePhoto(Camera camera)
        {
            camera.SetState(new TakePhotoCamera());
            Console.WriteLine("The camera takes photo");
        }

        public void TakeSlowMotion(Camera camera)
        {
            camera.SetState(new TakeSlowMotionCamera());
            Console.WriteLine("The camera takes slow motion");
        }

        public void TakeVideo(Camera camera) => Console.WriteLine("The camera takes video now");

        public void TurnOff(Camera camera)
        {
            camera.SetState(new TurnOffCamera());
            Console.WriteLine("The camera turns off");
        }
        public void TurnOn(Camera camera) => Console.WriteLine("The camera is already on");

    }
}
