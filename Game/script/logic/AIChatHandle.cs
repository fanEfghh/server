using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class MsgHandler
{
    public static void MsgAIChat(ClientState c, MsgBase msgBase)
    {
        MsgAIChat msg =(MsgAIChat) msgBase;
        AIdialogue.AIdialogueSendMessage(msg.message,out msg.message);
        NetManager.Send(c,msg); 
    }

}
