using System.ServiceModel;
using PostComment;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceComment
    {
        [OperationContract]
        bool AddComment(Comment comment);

        [OperationContract]
        Comment UpdateComment(Comment newComment);

        [OperationContract]
        Comment GetCommentById(int id);
    }
}
