
namespace IsAsFunctionality
{
    public static class IsFunctionality
    {
        /// <summary>
        /// this method checks whether the object can be casted to given type
        /// </summary>
        /// <param name="animalObj"></param>
        /// <param name="Animal"></param>
        /// <returns></returns>
        public static bool IsType(object animalObj, Type Animal)
        {
            return Animal.IsAssignableFrom(animalObj.GetType());
        }
    }
}
