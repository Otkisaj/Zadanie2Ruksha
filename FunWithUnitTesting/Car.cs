using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class Car
    {
        private const int _maxSpeed = 220; // Сделал _maxSpeed константой
        public int CurrentSpeed { get; private set; }

        public Car(int currentSpeed)
        {
            if (currentSpeed < _maxSpeed)
            {
                CurrentSpeed = currentSpeed;
            }
            else
            {
                CurrentSpeed = _maxSpeed;
            }
        }

        public void SpeedUp(int speed)
        {
            // Если новая скорость превышает максимальную, устанавливаем максимальную скорость
            if (CurrentSpeed + speed > _maxSpeed)
            {
                CurrentSpeed = _maxSpeed;
            }
            else
            {
                CurrentSpeed += speed;
            }
        }
    }
}



