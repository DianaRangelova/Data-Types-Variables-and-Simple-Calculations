int annualBasketballTrainingFee = int.Parse(Console.ReadLine());

double priceOfBasketballSneakers = annualBasketballTrainingFee - annualBasketballTrainingFee * 0.4;
double pricePerBalsetballTeam = priceOfBasketballSneakers - priceOfBasketballSneakers * 0.2;
double priceOfBasketball = (1.0 / 4) * pricePerBalsetballTeam;
double priceOfBasketballАccessories = (1.0 / 5) * priceOfBasketball;
double totalPriceFortheEquipment = annualBasketballTrainingFee + priceOfBasketballSneakers + pricePerBalsetballTeam + 
    priceOfBasketball + priceOfBasketballАccessories;

Console.WriteLine(totalPriceFortheEquipment);
