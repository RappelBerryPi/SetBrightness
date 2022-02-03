using SetBrightnessLibrary;

namespace TurnBrightnessDown {
    internal class Program {
        private static void Main(string[] args) {
            var brightness = 10;
            if (args.Length == 1) {
                brightness = int.Parse(args[0]);
            }

            var screenBrightness  = new ScreenBrightness();
            var currentBrightness = screenBrightness.GetBrightness();
            currentBrightness -= brightness;
            if (currentBrightness < 0) {
                currentBrightness = 0;
            }

            screenBrightness.SetBrightness(currentBrightness);
        }
    }
}