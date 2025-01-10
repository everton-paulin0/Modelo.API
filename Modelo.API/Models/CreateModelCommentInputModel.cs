using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class CreateModelCommentInputModel
    {
        public string Content { get; set; }
        public int PersonId { get; set; }
        public int UserId { get; set; }


        public ModelComment ToEntity()
            => new ModelComment(Content, PersonId, UserId);
    }
}
