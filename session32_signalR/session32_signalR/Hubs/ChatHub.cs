using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

public class ChatHub: Hub 
{
    // serve get event from client
    public async Task SendPrivateMessage(string user, string messageInput) 
    {
        // Gui Event den clients
        await Clients.All.SendAsync("ReceiveMessage", user, messageInput);
    }

    public async Task SendGroupMessage(string group, string user, string message) {
        // gửi event đến clients trong group
        await Clients.Group(group).SendAsync("ReceiveMessageGroup", group, user, message);
    }

    public async Task JoinGroup(string group, string user) {
        await Groups.AddToGroupAsync(Context.ConnectionId, group);

        // gửi event thông báo user A đã join group
        await Clients.Group(group).SendAsync("ReceiveMessageGroup", group, "System", $"{user} joined {group}");
    }

    // rời nhóm
    public async Task LeaveGroup(string group, string user) 
    {
        Console.WriteLine("LeaveGroup");
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);

        await Clients.Group(group).SendAsync("ReceiveMessageGroup", group, "System", $"{user} left {group}");
    }
}