using System;

namespace Giraffe3 {
    class Animal {
        private string name1 = "Koral"; //accessed only within the class
        public string name2 = "Bob";
        public int age = 13;

        public void Print() {
            Console.WriteLine("Name: "+ name2);
            Console.WriteLine("Age: "+ age);
        }
        
    }
    class Program {
        static void Main(string[] args) {
            Animal dog = new Animal();
            Console.WriteLine(dog.name2);
            dog.name2 = "Bobby";
            Console.WriteLine(dog.name2);
            dog.Print();
        }
    }
}
