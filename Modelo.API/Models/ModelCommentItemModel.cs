namespace Modelo.API.Models
{
    public class ModelCommentItemModel
    {
        public ModelCommentItemModel(int id, string content, string userName, string nameModel)
        {
            Id = id;
            Content = content;
            UserName = userName;
            NameModel = nameModel;
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public string NameModel { get; set; }
    }
}
