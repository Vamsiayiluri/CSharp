namespace IsAsFunctionality
{
    /// <summary>
    /// the animal class contains eat and bark methods
    /// </summary>
    class Animal
    {
        /// <summary>
        /// this method displays that animal is eating
        /// </summary>
        public void Eat()
        {
            Output.Display(Literals.animalEat);
        }
        /// <summary>
        /// this method displays that animal is barking
        /// </summary>
        public virtual void Bark()
        {
            Output.Display(Literals.animalBark);
        }
    }

}
