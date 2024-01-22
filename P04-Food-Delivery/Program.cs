int numberOfChuckenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

double totalCostOfMenus = numberOfChuckenMenus * 10.35 + numberOfFishMenus * 12.40 + numberOfVegetarianMenus * 8.15;
double priceOfDesert = totalCostOfMenus * 20 / 100;
// or double priceOfDesert = totalCostOfMenus * 0.2;
double deliveryPrice = 2.50;
double totalOrderPrice = totalCostOfMenus + priceOfDesert + deliveryPrice;

Console.WriteLine(totalOrderPrice);
