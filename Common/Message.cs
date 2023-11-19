using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatter
{
	public enum MessageType
	{
		Chat,
		Meta
	}
	public interface IMessage
	{
		MessageType Type { get;}
	}
}
