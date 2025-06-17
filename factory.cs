using System;

namespace factory {
    

    // Abstract Product class

    public interface Transport {

        void deliver();

    }   

    // First concrete class that implements the product interface

    public class Truck : Transport{ 


        public void deliver() {
            Console.WriteLine("Delivered over land");
        }

    }

    // Second concrete class that implements the product interface

    public class Boat : Transport {

        public void deliver() {
            Console.WriteLine("Delivered over sea");
        }

    }

    // Factory interface that all factory classes will implement
    public interface Creator
    {
        Transport createOperation();
        public void doSomething()
        {
            Transport t = this.createOperation();
            t.deliver();
        }
    }

    // First concrete implementation of the Creator interface
    public class TruckCreator : Creator
    {
        public override Transport createOperation()
        {
            return new Truck();
        }

    }

    // Second concrete implementation of the Creator interface

    public class BoatCreator : Creator
    {
        public override Transport createOperation()
        {
            return new Boat();
        }

    }



    class Program
    {
        static void main(string[] args)
        {
            Truck new_truck = TruckCreator.createOperation();
            Boat new_boat = BoatCreator.createOperation();

            new_truck.deliver();
            new_boat.deliver();

        }

    }


}