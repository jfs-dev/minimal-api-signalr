using Microsoft.AspNetCore.SignalR;
using minimal_api_signalr.Shared;

namespace minimal_api_signalr.Hubs;

public class MonitoringHub : Hub
{
    public async Task SendMonitoring(int monitoring)
    {
        AppState.Monitoring = monitoring;

        await Clients.All.SendAsync(AppState.RECEIVE_MONITORING, monitoring);
    }
}
