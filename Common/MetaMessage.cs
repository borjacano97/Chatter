using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Chatter
{
	public enum Command
	{
		JOIN,
		LEAVE,
	}
	struct MetaMessage : IMessage
	{
		public readonly MessageType Type => MessageType.Meta;

		[JsonInclude]
		public required Command Command { get; set; }


		[JsonConstructor]
		public MetaMessage(Command command)
		{
			Command = command;
		}
	}
}
