// See https://aka.ms/new-console-template for more information

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Client.Models;
using ClientGeneration.Models;



abstract class CarParkValueDetails
{
    protected float hourGarage ;
    protected float FixedValue;
    protected float additionalFeelGarage1;
    protected float additionalFeelGarage2;
    protected float additionalFeelGarage3;


    public float getHourGarage(float hourgarage)
    {
        return hourgarage;
    }



    public CarParkValueDetails()
    {
        hourGarage = 0f;
        FixedValue = 2;
        this.additionalFeelGarage1 = 0f;
        this.additionalFeelGarage2 = 0f;
        this.additionalFeelGarage3 = 0f;
    }

    abstract public void additionalFeelGarage(float aadditionalFeelGarage);

}


class CarPark : CarParkValueDetails
{


    public CarPark()
    {
        additionalFeelGarage1 = 0.50f;
        additionalFeelGarage2 = 0.60f;
        additionalFeelGarage3 = 0.75f;
    }

    public float garage1(float hourGarage)
    {
        float valueTotal = 0f;

        if (hourGarage <= 3) {
            valueTotal = 2;
        }

        else if (hourGarage > 3) {
            valueTotal = 2 + (additionalFeelGarage1 + (hourGarage - 3));
        }

        return valueTotal;
    }


    public float garage2(float hourGarage)
    {
        float valueTotal = 0f;

        if (hourGarage <= 3)
        {
            valueTotal = FixedValue;
        }

        else if (hourGarage > 3)
        {
            valueTotal = FixedValue  + (additionalFeelGarage2 + (hourGarage - 3));
        }

        return valueTotal;
    }



    public float garage3(float hourGarage)
    {
        float valueTotal = 0f;

        if (hourGarage <= 3)
        {
            valueTotal = FixedValue ;
        }

        else if (hourGarage > 3)
        {
            valueTotal = FixedValue  + (additionalFeelGarage3 + (hourGarage - 3));
        }

        return valueTotal;
    }

}

class EachPark
{
    public static void Main()
    {
        float hours, c1, c2, c3;

        CarPark.client1 = new CarPark();
        CarPark.client2 = new CarPark();
        CarPark.client3 = new CarPark();


        hours = client1.getHourGarage(6);
        c1 = client1.garage1(hours);
        Console.WriteLine($"garage 1 - Client 1: {c1}");
        Console.WriteLine("==================================================");


        hours = client2.getHourGarage(6);
        c2 = client1.garage2(hours);
        Console.WriteLine($"garage 2 - Client 2: {c2}");
        Console.WriteLine("==================================================");




        hours = client3.getHourGarage(6);
        c1 = client1.garage3(hours);
        Console.WriteLine($"garage 3 - Client 1: {c3}");
        Console.WriteLine("==================================================");


        hours = client1.getHourGarage(6);
        c4 = client1.garage3(hours);
        Console.WriteLine($"garage 3 - Client 1: {c3}");
        Console.WriteLine("==================================================");



        Console.WriteLine($"{garage1.getHourGarage}");


        foreach (var user in ClientGeneration.Client())
        {
            Console.WriteLine(user.ToString());

        }

    }
}

  

    




