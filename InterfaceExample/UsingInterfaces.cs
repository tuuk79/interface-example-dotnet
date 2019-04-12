using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterfaceExample
{
    public interface IAnimal
    {
        string makeSound();
    }

    public class Dog : IAnimal
    {
        public string makeSound()
        {
            return "ruff";
        }
    }

    public class Person
    {
        private IAnimal animal { get; set; }

        public Person(IAnimal animal)
        {
            this.animal = animal;
        }

        public string pet()
        {
            return animal.makeSound();
        }
    }


    public class Cat : IAnimal
    {
        public string makeSound()
        {
            return "meow";
        }
    }


    [TestClass]
    public class UsingInterfaces
    {
        [TestMethod]
        public void Person_Pets_Cat_And_Gets_Sound()
        {
            IAnimal cat = new Cat();

            var person = new Person(cat);

            var response = person.pet();

            Assert.IsTrue(response.Equals("meow"));
        }

        [TestMethod]
        public void Person_Pets_Dog_And_Gets_Sound()
        {
            IAnimal dog = new Dog();

            var person = new Person(dog);

            var response = person.pet();

            Assert.IsTrue(response.Equals("ruff"));
        }
    }
}
