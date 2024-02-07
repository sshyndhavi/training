using System;
namespace Covariance
{
    // Define a delegate with a return type of Animal
    public delegate Animal AnimalDelegate();

    // Derived class
    public class Dog : Animal { }

    class Program
    {

        static Dog GetDog() => new Dog();

        static void Main(string[] args)
        {
            // Covariance allows assigning a delegate with a more derived return type to a delegate with a less derived return type.
            AnimalDelegate animalDelegate = GetDog;

            // Invoking the delegate returns a Dog instance, but the delegate return type is Animal.
            Animal animal = animalDelegate();
        }
       

    }




}
