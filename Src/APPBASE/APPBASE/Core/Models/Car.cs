using System;

namespace APPBASE.Models
{
    public class Car : Vehicle
    {
        public int year { get; set; }
        public double price { get; set; }

        //Constructor 1
        public Car()
        {
            this.type = "Car";
        } //End Constructor

    } //End class

} //End namespace
