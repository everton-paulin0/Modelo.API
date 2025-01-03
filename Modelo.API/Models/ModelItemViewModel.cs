namespace Modelo.API.Models
{
    public class ModelItemViewModel
    {
        public ModelItemViewModel(int id, string fullName, int age, string userName)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            UserName = userName;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }        
        public string UserName { get; set; }
    }
}
