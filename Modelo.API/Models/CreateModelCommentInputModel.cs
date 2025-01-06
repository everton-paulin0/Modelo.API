using Modelo.Core.Entities;

namespace Modelo.API.Models
{
    public class CreateModelCommentInputModel
    {
        public string Content { get; set; }
        public int IdModel { get; set; }
        public int IdUser { get; set; }

        public ModelComment ToEntity()
            => new ModelComment(Content, IdModel, IdUser);
    }
}
