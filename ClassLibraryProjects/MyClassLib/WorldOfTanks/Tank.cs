using System;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string TankName { get; set; }
        private int Ammunition { get; set; }
        private int ArmorLevel { get; set; }
        private int ManeuvarabilityLevel { get; set; }

        public Tank()
        {
            TankName = "";
            Ammunition = 0;
            ArmorLevel = 0;
            ManeuvarabilityLevel = 0;
        }

        public Tank(string name)
        {
            TankName = name;

            Random rand = new Random();
            Ammunition = rand.Next() % 100;
            
            rand = new Random();
            ArmorLevel = rand.Next() % 100;

            rand = new Random();
            ManeuvarabilityLevel = rand.Next() % 100;
        }

        /*public void GetInfo()
        {
            Console.WriteLine($"Tank name: {TankName}");
            Console.WriteLine($"Ammunition level: {Ammunition}");
            Console.WriteLine($"Armor level: {ArmorLevel}");
            Console.WriteLine($"Maneuvarability level: {ManeuvarabilityLevel}");
        }*/

        public static string operator *(Tank firstTank, Tank secondTank)
        {
            Tank winner = new Tank();

            if ((firstTank.Ammunition > secondTank.Ammunition
                && firstTank.ArmorLevel > secondTank.ArmorLevel)
                || (firstTank.ManeuvarabilityLevel > secondTank.ManeuvarabilityLevel
                && firstTank.ArmorLevel > secondTank.ArmorLevel)
                || (firstTank.ArmorLevel > secondTank.Ammunition
                && firstTank.ManeuvarabilityLevel > secondTank.ManeuvarabilityLevel))
            {
                winner.TankName = firstTank.TankName;
                winner.Ammunition = firstTank.Ammunition;
                winner.ArmorLevel = firstTank.ArmorLevel;
                winner.ManeuvarabilityLevel = firstTank.ManeuvarabilityLevel;
            }
            else
            {
                winner.TankName = secondTank.TankName;
                winner.Ammunition = secondTank.Ammunition;
                winner.ArmorLevel = secondTank.ArmorLevel;
                winner.ManeuvarabilityLevel = secondTank.ManeuvarabilityLevel;
            }
            return winner.TankName;
        }

    }
}