using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;

public class ChatHub: Hub 
{
    // Define variable user online with dictionary type
    // with key connectionId and value username
    private static Dictionary<string, string> OnlineUser = new Dictionary<string, string>();

    public async Task JoinChat(string user) 
    {
        Console.WriteLine("JoinChat server");
        // B1: kiểm tra user đã tồn tại trong OnlineUser chưa
        if(!OnlineUser.ContainsValue(user)) 
        {
            OnlineUser[Context.ConnectionId] = user;

            await Clients.All.SendAsync("UserConnected", user);

            await Clients.All.SendAsync("OnlineUsers", OnlineUser.Values.ToList());
        }
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        if(OnlineUser.ContainsKey(Context.ConnectionId)) 
        {
            var user = OnlineUser[Context.ConnectionId];
            OnlineUser.Remove(Context.ConnectionId);

            await Clients.All.SendAsync("UserDisconnected", user);
        }

        await base.OnDisconnectedAsync(exception);
    }

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