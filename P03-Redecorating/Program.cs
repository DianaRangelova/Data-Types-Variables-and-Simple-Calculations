int amountOfNylonSqM  = int.Parse(Console.ReadLine());
int amountOfPaintL = int.Parse(Console.ReadLine());
int quantityOfThinner  = int.Parse(Console.ReadLine());
int hoursOfWork = int.Parse(Console.ReadLine());

double nylonAmount = (amountOfNylonSqM + 2) * 1.5;
double paintAmount = (amountOfPaintL + 0.1 * amountOfPaintL) * 14.5;
int tinnerAmount = quantityOfThinner * 5;
double bagsAmount = 0.4;
double totalAmountOfMaterials = nylonAmount + paintAmount + tinnerAmount + bagsAmount;
double craftsmenAmountPerHour = totalAmountOfMaterials * 0.3;
double craftsmenTotalSalaryLv = craftsmenAmountPerHour * hoursOfWork;
double totalAmount = totalAmountOfMaterials + craftsmenTotalSalaryLv;

Console.WriteLine(totalAmount);
