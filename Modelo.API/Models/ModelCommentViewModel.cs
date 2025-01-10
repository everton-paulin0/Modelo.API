using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class ModelCommentViewModel: BaseEntity
    {
        public ModelCommentViewModel( string content, int userId,int personId)
        {
            Content = content;
            UserId = userId;            
            PersonId = personId;
            
        }

        
        public string Content { get; set; }
        public int UserId{ get; set; }
        public User User { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }


        public static ModelCommentViewModel FromEntity(ModelComment entity)
            => new ModelCommentViewModel(entity.Content, entity.PersonId, entity.UserId);
    }
}
