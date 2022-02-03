using SetBrightnessLibrary;

namespace TurnBrightnessUp {
    internal class Program {
        private static void Main(string[] args) {
            var brightness = 10;
            if (args.Length == 1) {
                brightness = int.Parse(args[0]);
            }

            var screenBrightness  = new ScreenBrightness();
            var currentBrightness = screenBrightness.GetBrightness();
            currentBrightness += brightness;
            if (currentBrightness > 100) {
                currentBrightness = 100;
            }

            screenBrightness.SetBrightness(currentBrightness);
        }
    }
}