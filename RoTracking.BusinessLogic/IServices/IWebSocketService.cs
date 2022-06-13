using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace RoTracking.BusinessLogic.IServices
{
    public interface IWebSocketService
    {
        public Task Echo(WebSocket webSocket);
    }
}
