namespace IsAsFunctionality
{
    public class Program
    {
        /// <summary>
        /// main method will checks for is and as functionality without using is and as
        /// </summary>
        public static void Main()
        {
            Animal animalObj = new Dog();

            if (IsFunctionality.IsType(animalObj, typeof(Animal)))//Instead of writing animalobj is animal we call IsType() method
            {
                Animal animalInstance = (Animal)animalObj;
                animalInstance.Eat();
            }

            Dog dogObj = new Dog();

            if (IsFunctionality.IsType(dogObj, typeof(Animal)))
            {
                Animal animalObj1 = dogObj;//Implicit casting instead of writing dogobj as Animal
                animalObj1.Bark();
            }

            if (IsFunctionality.IsType(animalObj, typeof(Dog)))
            {
                Dog dogObj2 = (Dog)animalObj;//Instead of writing animalobj as D we do explicit casting

                if (dogObj2 != null)
                {
                    dogObj2.Bark();
                }
            }
        }
    }
}