namespace DroneControlSystem
{
    public class Drone
    {
        public string Model { get; private set; }
        public int BatteryLevel { get; private set; }

        // Основной конструктор (из начальной версии)
        public Drone(string model, int batteryLevel)
        {
            Model = model;
            BatteryLevel = batteryLevel;
        }

        // Задание 3: Конструктор с параметром по умолчанию
        public Drone(string model) : this(model, 100)
        {
        }

        // Задание 2: Метод для подзарядки
        public void ChargeBattery(int amount)
        {
            BatteryLevel += amount;
            if (BatteryLevel > 100)
            {
                BatteryLevel = 100;
            }
            Console.WriteLine($"Заряд после подзарядки: {BatteryLevel}%");
        }

        // Методы из начальной версии (предположительно)
        public void PrintInfo()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Заряд: {BatteryLevel}%");
        }

        public void TakeOff()
        {
            if (BatteryLevel < 15)
            {
                Console.WriteLine("Ошибка: недостаточно заряда для взлёта. Требуется минимум 15%.");
                return;
            }
            Console.WriteLine($"Дрон {Model} взлетает.");
            // Для примера уменьшим заряд при взлёте
            BatteryLevel -= 5;
            Console.WriteLine($"Текущий заряд: {BatteryLevel}%");
        }
    }
}