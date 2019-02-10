using System;

namespace DDDHotList
{

    /// <summary>
    /// Abstract base class for a motor vehicle
    /// </summary>
    public abstract class MotorVehicle
    {
        protected readonly Transmission PowerTrain;

        public readonly string Model;

        public readonly string Make;

        public MotorVehicle(string make, string model, int firstGearRpms, int secondGearRpms)
        {
            Make = make;
            Model = model;
            PowerTrain = new Transmission(firstGearRpms, secondGearRpms);
        }

        public abstract void TestDrive();

        /// <summary>
        /// Print the speed of the vehicle
        /// </summary>
        /// <param name="speed"></param>
        protected void PrintSpeed(int speed)
        {
            Console.WriteLine($"{Make} {Model}: Driving at a current speed of {speed} mph");
        }

        /// <summary>
        /// Class modeling the transmission of a motor vehicle
        /// </summary>
        protected class Transmission
        {
            private readonly Gear _firstGear;

            private readonly Gear _secondGear;

            public Transmission(int firstGearRpms, int secondGearRpms)
            {
                _firstGear = new Gear(100, firstGearRpms, 10);
                _secondGear = new Gear(firstGearRpms + 1, secondGearRpms, 30);
            }

            /// <summary>
            /// Adjust the speed of the car based on the engine rpms
            /// </summary>
            /// <param name="engineRpms"></param>
            /// <returns></returns>
            public int TransferEnergy(int engineRpms)
            {
                if (_firstGear.isInRange(engineRpms))
                {
                    return _firstGear.Speed;
                }
                else if (_secondGear.isInRange(engineRpms))
                {
                    return _secondGear.Speed;
                }

                return 5;
            }
        }

        /// <summary>
        /// Private class to handle shifting. This class takes enginer rpms and 
        /// </summary>
        private class Gear
        {
            public Gear(int minRpms, int maxRpms, int speed)
            {
                _minRpms = minRpms;
                _maxRpms = maxRpms;
                Speed = speed;
            }

            /// <summary>
            /// The minimum number of rpms in this gear range
            /// </summary>
            private readonly int _minRpms;

            /// <summary>
            /// The maximum number of rpms in this gear range
            /// </summary>
            private readonly int _maxRpms;

            /// <summary>
            /// The speed produced by the gear
            /// </summary>
            public readonly int Speed;

            /// <summary>
            /// Determine if the gear is in range
            /// </summary>
            /// <param name="engineRpms"></param>
            /// <returns></returns>
            public bool isInRange(int engineRpms)
            {
                if (engineRpms >= _minRpms && engineRpms <= _maxRpms)
                {
                    return true;
                }

                return false;
            }
        }
    }
}