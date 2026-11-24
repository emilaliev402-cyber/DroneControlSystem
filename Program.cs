// Program.cs (Ветка feature/drone-array)
using DroneControlSystem;

Console.WriteLine("=== Система управления БПЛА (версия 1.0) ===\n");

// 1. Создание массива из трех дронов
Drone[] drones = new Drone[]
{
    new Drone("DJI Mini 3", 85),
    new Drone("Autel EVO Lite", 45),
    new Drone("Parrot Anafi", 15)
};

// 2. Перебор массива и вывод информации
foreach (var drone in drones)
{
    drone.PrintInfo();

    // 3. Проверка критического уровня заряда
    if (drone.BatteryLevel < 20)
    {
        Console.WriteLine("ВНИМАНИЕ: Заряд ниже 20%! Срочно на базу.");
    }
    Console.WriteLine("---");
}

Console.WriteLine("\nПроверка массива завершена.");

Console.WriteLine("\n--- Запуск модуля подзарядки ---");

for (int i = 0; i < drones.Length; i++)
{
    Drone drone = drones[i];
    if (drone.BatteryLevel < 50)
    {
        Console.WriteLine($"\nДрон {drone.Model} имеет заряд {drone.BatteryLevel}%. Подзарядить? (y/n)");
        string answer = Console.ReadLine();

        if (answer?.ToLower() == "y")
        {
            drone.ChargeBattery(60);
        }
        else
        {
            Console.WriteLine("Подзарядка пропущена.");
        }
    }
}
Console.WriteLine("\n--- Проверка конструктора по умолчанию ---");
Drone premiumDrone = new Drone("Autel EVO II Pro");

premiumDrone.PrintInfo();

Console.WriteLine("\nПрограмма завершена.");