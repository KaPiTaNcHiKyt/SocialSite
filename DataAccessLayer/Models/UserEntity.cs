namespace DataAccessLayer.Models;

public class UserEntity
{
    public string NickName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public ChatEntity[] Chats { get; set; }
}