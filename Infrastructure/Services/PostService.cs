using Domain.Models;
namespace Infrastructure.Services;

public class PostService
{
    public List<Post> posts;

    public PostService()
    {
        posts = new List<Post>();
    }
    public List<Post> GetPosts()
    {
        return posts;
    }
    public void AddPost(Post post)
    {
        posts.Add(post);
    }
    public void UpdatePost(Post post)
    {
        var find = posts.FirstOrDefault(x=>x.Id == post.Id);
        find.Id = post.Id;
        find.Title = post.Title;
        find.Description = post.Description;
        find.VoteAmount = post.VoteAmount;
        find.CreatedAt = post.CreatedAt;
    }
    public void Delete(int id)
    {
        posts.RemoveAt(id);
    }
}
