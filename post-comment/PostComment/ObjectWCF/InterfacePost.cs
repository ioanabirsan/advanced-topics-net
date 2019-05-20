using System.Collections.Generic;
using System.ServiceModel;
using PostComment;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);

        [OperationContract]
        Post UpdatePost(Post post);

        [OperationContract]
        int DeletePost(int id);

        [OperationContract]
        Post GetPostById(int id);

        [OperationContract]
        List<Post> GetPosts();
    }
}