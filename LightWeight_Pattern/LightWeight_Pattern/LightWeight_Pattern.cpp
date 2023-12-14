#include <iostream>
#include <string>
#include <map>

using namespace std;


class CarFlyWeight
{
private:
    string serialNumber;
    string color;
    unsigned int price;

public:
    CarFlyWeight(string& serialnumber, string& color, unsigned int price)
    {
        this->serialNumber = serialnumber;
        this->color = color;
        this->price = price;
    }

    CarFlyWeight() = default;

    void GetCarData()
    {
        cout << "\nSerial Number: " << this->serialNumber << "\nColor : " << this->color << "\nPrice: " << this->price << endl;
    }

};


class CarFactory
{
private:
    map<string, CarFlyWeight> map_car;

public:
    CarFlyWeight GetCarFlyWeight(string& serialnumber, string& color, unsigned int price)
    {
        if (map_car.find(serialnumber) == map_car.end())
        {
            map_car[serialnumber] = CarFlyWeight(serialnumber, color, price);
        }

        return map_car[serialnumber];
    }


};


class Car
{
private:
    string make;
    string model;
    CarFlyWeight* carFlyWeight;

public:

    Car(string model, string make, CarFlyWeight& carflyweight)
    {
        this->model = model;
        this->make = make;
        this->carFlyWeight = &carflyweight;
    }


    void GetCarData()
    {
        cout << "\nModel: " << this->model << "\nMake: " << this->make;
        this->carFlyWeight->GetCarData();
    }

};





int main()
{
    CarFactory carFactory;
    string serialnumber = "99-AB-123";
    string color = "Black";
    CarFlyWeight carFlyWeight = carFactory.GetCarFlyWeight(serialnumber, color, 40000);


    Car car1("Sedan", "Toyota", carFlyWeight);
    Car car2("SUV", "Honda", carFlyWeight);
    
    car1.GetCarData();
    cout << "\n--------------\n";
    car2.GetCarData();

}

