using System;
using System.Collections.Generic;

public class Car
{
    public string OilType { get; set; }
    public double OilAmountNeeded { get; set; }
    public string PaymentMethod { get; set; }
}

public class OilShop
{
    private int gasolinePrice = 1800;
    private int dieselPrice = 1600;

    private int totalCashEarnings = 0;
    private int totalCardEarnings = 0;
    private double totalGasolineSold = 0;
    private double totalDieselSold = 0;

    public List<Car> cars = new List<Car>();

    public void ShowOrder()
    {
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            Car car = new Car();
            car.OilType = random.Next(2) == 0 ? "gasoline" : "diesel";
            car.OilAmountNeeded = (random.NextDouble() * 9.0) + 1.0; 
            car.PaymentMethod = random.Next(2) == 0 ? "cash" : "card";
            cars.Add(car);

            double fuelPrice = car.OilType == "gasoline" ? gasolinePrice : dieselPrice;
            double totalPrice = car.OilAmountNeeded * fuelPrice;

            if (car.PaymentMethod == "cash")
            {
                Console.WriteLine("현금 계산");
                totalCashEarnings += (int)totalPrice;
            }
            else if (car.PaymentMethod == "card")
            {
                Console.WriteLine("카드 계산");
                totalCardEarnings += (int)totalPrice;
            }

            if (car.OilType == "gasoline")
            {
                totalGasolineSold += car.OilAmountNeeded;
            }
            else if (car.OilType == "diesel")
            {
                totalDieselSold += car.OilAmountNeeded;
            }
        }

        Console.WriteLine("현금으로 벌은 금액: " + totalCashEarnings + "원");
        Console.WriteLine("카드로 벌은 금액: " + totalCardEarnings + "원");
        Console.WriteLine("총 수입: " + (totalCashEarnings + totalCardEarnings) + "원");
        Console.WriteLine("휘발유 판매량: " + totalGasolineSold + "리터");
        Console.WriteLine("경유 판매량: " + totalDieselSold + "리터");
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        OilShop oilShop = new OilShop();
        oilShop.ShowOrder();
    }
}