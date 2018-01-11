using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {
        public bool alarmStatus = false;
        public string alarmTime = "5:10 am";
        public string currentStation = "103.7";
        public int currentVolume = 50;
        public string currentTime;
        public bool radioStatus = false;

        public ClockRadio()
        {
            currentTime = SetCurrentTime();
        }
        public void SwitchAlarm()
            
        {
            alarmStatus = !alarmStatus;
        }

        public void GetAlarmTime()
        {
            Console.WriteLine("What time would you like to set your alarm?");
            alarmTime = Console.ReadLine();
        }
        public void ToggleRadio()
        {
            radioStatus = !radioStatus;
        } 
        public string SetStation()
        {
            Console.WriteLine("What station would like to listen to?");
            string stationChoice = Console.ReadLine();
            currentStation = stationChoice;
            return currentStation;
        }
        public void SetVolume()
        {
            Console.WriteLine("Your volume is currently set at: " + currentVolume + "\n" + "What level would you like to set your volume at?");
            string newVolume = Console.ReadLine();
            int convertVolume = int.Parse(newVolume);
            if (convertVolume > 100)
            {
                currentVolume = 100;
            }
            if (convertVolume < 0)
            {
                currentVolume = 0;
            }
            else
            {
                currentVolume = convertVolume;
            }
            
            
        }

        public string SetCurrentTime()
        {
            string currentTime;
            Console.WriteLine("What time would you like to set your clock to?");
            currentTime = Console.ReadLine();
            return currentTime;
        }

        

        public void Menu()
        {
            string onOff = "off";
            if (alarmStatus == true)
            {
                onOff = "on";
            }
            if (alarmStatus == false)
            {
                onOff = "off";
            }
            string radio = "off";
            if (radioStatus == true)
            {
                radio = "on";
            } 
            if (radioStatus == false)
            {
                radio = "off";
            }
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" +"            " + currentTime + "\n");
            Console.ResetColor();
            Console.WriteLine("What would you like to do:" + "\n");
            Console.WriteLine("(1) Change the current time");
            Console.WriteLine("(2) Flip the alarm switch - Currently set to " + onOff);
            Console.WriteLine("(3) Set the alarm time - Currently set to " + alarmTime);
            Console.WriteLine("(4) Turn on/off the radio - Currently set to " + radio);
            Console.WriteLine("(5) Change the radio station - Currently set to " + currentStation);
            Console.WriteLine("(6) Change the volume of the radio - Currently set to " + currentVolume + "%");
            Console.WriteLine("(0) To Exit");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Console.Clear();
                    currentTime = SetCurrentTime();
                    break;
                case "2":
                    Console.Clear();
                    SwitchAlarm();
                    break;
                case "3":
                    Console.Clear();
                    GetAlarmTime();
                    break;
                case "4":
                    Console.Clear();
                    ToggleRadio();
                    break;
                case "5":
                    Console.Clear();
                    SetStation();
                    break;
                case "6":
                    Console.Clear();
                    SetVolume();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Menu();
                    break;
            }
            Console.Clear();
            Menu();
        }
    }
}
