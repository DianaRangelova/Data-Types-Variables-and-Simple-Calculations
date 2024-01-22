int lenghtCm = int.Parse(Console.ReadLine());
int widthCm = int.Parse(Console.ReadLine());
int heightCm = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double volumeCm3 = lenghtCm * widthCm * heightCm;
double occupiedVolume = volumeCm3 * (percentage / 100.0);
double remainingVolume = volumeCm3 - occupiedVolume;
double remainingLiters = remainingVolume / 1000.00;

Console.WriteLine($"{remainingLiters:F2}");