using System;
using System.Management;

namespace SetBrightnessLibrary {
    public class ScreenBrightness {
        public int GetBrightness() {
            var searcher   = new ManagementObjectSearcher("root\\wmi", "select * from WmiMonitorBrightness");
            var results    = searcher.Get();
            var enumerator = results.GetEnumerator();
            enumerator.MoveNext();
            var brightness = (byte)enumerator.Current["CurrentBrightness"];
            return Convert.ToInt32(brightness);
        }

        public void SetBrightness(int brightness) {
            var searcher   = new ManagementObjectSearcher("root\\wmi", "select * from WmiMonitorBrightnessMethods");
            var results    = searcher.Get();
            var enumerator = results.GetEnumerator();
            enumerator.MoveNext();
            var current = (ManagementObject)enumerator.Current;
            current.InvokeMethod("WmiSetBrightness", new object[] { (uint)1, brightness });
        }
    }
}