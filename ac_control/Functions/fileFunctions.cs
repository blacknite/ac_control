using System.IO;

namespace ac_control.Functions
{
    public class fileFunctions
    {
        /// <summary>
        /// makes a directory for gpio access in /sys/class/gpio
        /// </summary>
        /// <param name="gpio">gpio to create (use boradcom gpio number)</param>
        public static void makeGPIO(string gpio)
        {
            if (!existsGPIO(gpio))
            {
                File.WriteAllText("/sys/class/gpio/export", gpio);
                //set direction to out
                File.WriteAllText(string.Format("/sys/class/gpio/gpio{0}/direction", gpio), "out");
            }
        }

        /// <summary>
        /// determines if a gpio directory exists
        /// </summary>
        /// <param name="gpio">GPIO to check (use broadcom gpio number)</param>
        /// <returns>true if exists</returns>
        public static bool existsGPIO(string gpio)
        {
            return Directory.Exists(string.Format("/sys/class/gpio/gpio{0}", gpio));
        }

        /// <summary>
        /// gets status of gpio value
        /// </summary>
        /// <param name="gpio">GPIO to check (use broadcom gpio number)</param>
        /// <returns>value of gpio (0 or 1) as string</returns>
        public static string getGPIOstatus(string gpio)
        {
            string currentval = File.ReadAllText(string.Format("/sys/class/gpio/gpio{0}/value", gpio));
            if (currentval == "1")
                return "off";
            else
                return "on";
        }

        /// <summary>
        /// sets value of gpio pin
        /// </summary>
        /// <param name="gpio">GPIO to set (use broadcom gpio number)</param>
        /// <param name="value">value to set (usually string 0 or 1)</param>
        public static void setGPIOstatus(string gpio, string value)
        {
            string writeval;
            if (value == "off")
                writeval = "1";
            else
                writeval = "0";
            File.WriteAllText(string.Format("/sys/class/gpio/gpio{0}/value", gpio), writeval);
        }
    }
}
