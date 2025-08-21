namespace DataAccessLayer.Models;

public class ChatEntity
{
    public int ChatId { get; set; }
    public UserEntity[] Users { get; set; }
    public MessageEntity[] Messages { get; set; }
}