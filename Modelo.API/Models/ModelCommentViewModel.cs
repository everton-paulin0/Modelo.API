using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class ModelCommentViewModel
    {
        public ModelCommentViewModel(int id, string content, int userId, string userName, int idModel, string nameModel)
        {
            Id = id;
            Content = content;
            UserId = userId;
            UserName = userName;
            IdModel = idModel;
            NameModel = nameModel;
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId{ get; set; }
        public string UserName { get; set; }
        public int IdModel { get; set; }
        public string NameModel { get; set; }

        public static ModelCommentViewModel FromEntity(ModelComment entity)
            => new ModelCommentViewModel(entity.Id, entity.Content, entity.IdUser, entity.User.UserName, entity.IdModel, entity.Model.FullName);
    }
}
