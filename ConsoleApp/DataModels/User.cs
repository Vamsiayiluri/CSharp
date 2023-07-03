namespace DataModels
{
    /// <summary>
    /// This class contains user properties like Username,password,Email which is stored in database
    /// </summary>
    public class User
    {
        public string Username { get; set; } = null!;
        public string? Password { get; set; } = null!;
        public string? Email { get; set; } = null!;        
    }
}