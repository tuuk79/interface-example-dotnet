using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConcreteClassExample
{
    public class Cat
    {
        public string MakeSound()
        {
            return "meow";
        }
    }

    public class Dog
    {
        public string MakeSound()
        {
            return "ruff";
        }
    }

    public class Person
    {
        public Dog dog { get; set; }
        public Cat cat { get; set; }
        public Person(Dog dog)
        {
            this.dog = dog;
        }

        public Person(Cat cat)
        {
            this.cat = cat;
        }

        public string PetDog()
        {
            return dog.MakeSound();
        }

        public string PetCat()
        {
            return cat.MakeSound();
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Person_Pets_Cat_And_Gets_Sound()
        {
            Cat cat = new Cat();

            var person = new Person(cat);

            var response = person.PetCat();

            // plus person.PetDog() fails

            Assert.IsTrue(response.Equals("meow"));
        }

        [TestMethod]
        public void Person_Pets_Dog_And_Gets_Sound()
        {
            Dog dog = new Dog();

            var person = new Person(dog);

            var response = person.PetDog();

            // plus person.PetCat() fails

            Assert.IsTrue(response.Equals("ruff"));
        }
    }
}
