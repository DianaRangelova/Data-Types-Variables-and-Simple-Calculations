int numberOfChuckenMenus = int.Parse(Console.ReadLine());
int numberOfFishMenus = int.Parse(Console.ReadLine());
int numberOfVegetarianMenus = int.Parse(Console.ReadLine());

double priceForChickenMenus = numberOfChuckenMenus * 10.35;
double priceForFishMenus = numberOfFishMenus * 12.4;
double priceForVegetarianMenus = numberOfVegetarianMenus * 8.15;
double totalCostOfMenus = priceForChickenMenus + priceForFishMenus + priceForVegetarianMenus;
double priceOfDesert = (totalCostOfMenus * 20) / 100;
double deliveryPrice = 2.5;
double totalOrderPrice = totalCostOfMenus + priceOfDesert + deliveryPrice;

Console.WriteLine(totalOrderPrice);
