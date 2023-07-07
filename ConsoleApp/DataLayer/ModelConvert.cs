using AutoMapper;
using System.Reflection;
namespace DataLayer
{
    //public static class ModelConverter
    //{

    //    public static DataModels.User ToDataModel(BusinessModels.User user)
    //    {
    //        return new DataModels.User
    //        {
    //            Username = user.Username,
    //            Password = user.Password,
    //            Email = user.Email
    //        };
    //    }

    //    public static BusinessModels.User ToBusinessModel(DataModels.User user)
    //    {
    //        return new BusinessModels.User
    //        {
    //            Username = user.Username,
    //            Password = user.Password,
    //            Email = user.Email
    //        };
    //    }
    //}

    public static class ModelConverter<T1, T2> where T2:new()
    {
        public static T2 ConvertToRequiredModel(T1 userobj)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<T1, T2>());
            //var mapper = config.CreateMapper();
            //return mapper.Map<T2>(userobj);

            T2 requiredModel = new T2();


            PropertyInfo[] sourceProperties = typeof(T1).GetProperties();
            PropertyInfo[] destinationProperties = typeof(T2).GetProperties();

            foreach (var property in sourceProperties)
            {

                var destinationProperty = destinationProperties.FirstOrDefault(destProperty => destProperty.Name == property.Name && destProperty.PropertyType == property.PropertyType);

                if (destinationProperty != null)
                {
                    var value = property.GetValue(userobj);
                    destinationProperty.SetValue(requiredModel, value);
                }


            }

            return requiredModel;
        }
    }        
}
