using System;
namespace OOPS{
    public class Father{
        public void FatherMethod(){
            Console.WriteLine("This property belongs to Father.");
        }
    }

    public class Child:Father{
        public void ChildMethod(){
            Console.WriteLine("This property belongs to Child.");
        }
    }
}