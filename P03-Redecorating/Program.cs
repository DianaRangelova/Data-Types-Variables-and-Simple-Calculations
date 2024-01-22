int AmountOfNylonSqM = int.Parse(Console.ReadLine());
int AmountOfPaintL = int.Parse(Console.ReadLine());
int quantityOfThinner = int.Parse(Console.ReadLine());
int hoursOfWork = int.Parse(Console.ReadLine());

double nylonAmount = (AmountOfNylonSqM + 2) * 1.50;
double basePaintAmount = AmountOfPaintL * 14.50;
double paintAmount = basePaintAmount + (basePaintAmount * 0.1);
double tinnerAmount = quantityOfThinner * 5.00;
double bagsAmount = 0.40;
double totalAmountOfMaterials = nylonAmount + paintAmount + tinnerAmount + bagsAmount;
double craftsmenAmount = (totalAmountOfMaterials * 0.3) * hoursOfWork;
double totalAmount = totalAmountOfMaterials + craftsmenAmount;

Console.WriteLine($"{totalAmount:F2}");
