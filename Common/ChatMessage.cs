using System.Text.Json.Serialization;

namespace Chatter
{
	public struct ChatMessage : IMessage
	{
		[JsonInclude] public string   Author    {get; set;}
		[JsonInclude] public string   Content   {get; set;}
		[JsonInclude] public DateTime Timestamp {get; set;}

		public MessageType Type => MessageType.Chat;

		public ChatMessage(string author, string content)
		{
			Author = author;
			Content = content;
			Timestamp = DateTime.Now;
		}

		[JsonConstructor]
		public ChatMessage(DateTime timeStamp, string author, string content)
		{
			Author = author;
			Content = content;
			Timestamp = timeStamp;
		}

		public override readonly string ToString()
		{
			return $"[{Timestamp:HH:mm:ss}] {Author}: {Content}";
		}
	}
}