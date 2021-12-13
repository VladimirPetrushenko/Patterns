﻿using System;

namespace State
{
    class TakePhotoCamera : IState
    {
        public void TakePhoto(Camera camera) => Console.WriteLine("The camera takes photo now");

        public void TakeSlowMotion(Camera camera) => Console.WriteLine("You can't do that because you need to choise the video");

        public void TakeVideo(Camera camera)
        {
            camera.SetState(new TakeVideoCamera());
            Console.WriteLine("The camera takes video");
        }

        public void TurnOff(Camera camera)
        {
            camera.SetState(new TurnOffCamera());
            Console.WriteLine("The camera turns off");
        }
        public void TurnOn(Camera camera) => Console.WriteLine("The camera is already on");
    }
}
