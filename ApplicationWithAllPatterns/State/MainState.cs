namespace State
{
    public class MainState
    {
        public static void Make()
        {
            Camera camera = new Camera();

            camera.TurnOn();
            camera.TakePhoto();
            camera.TakeSlowMotion();
            camera.TakeVideo();
            camera.TakeSlowMotion();
            camera.TurnOn();
            camera.TurnOff();
            camera.TakePhoto();
        }
    }
}
