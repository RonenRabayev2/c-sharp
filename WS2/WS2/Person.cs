using System;

namespace WS2
{
    public class Person
    {
        private string name;
        private int age;
        private int id;
        private Pet pet;

        public Person(int id, string name, int age, Pet pet)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.pet = pet;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet Pet { get; set; }

        public override string ToString()
        {
            return "Person:\nname: " + name + "\nid: " + id+ "\nage: " + age + "\n" + pet.ToString();
        }
    }
 
}

