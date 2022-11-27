using Backend.Entities;
using Backend.GameHubs;
using Chess2Tests.IntegrationalHelpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using NUnit.Framework;

namespace Chess2Tests;

[TestFixture]
public class GameHubIntegrationalTests
{
    private readonly WebApiFactory _factory = new WebApiFactory();
    [SetUp]
    public void Setup()
    {
        _factory.CreateClient();
    }

    [Test]
    public async Task EnterUserName()
    {
        // Arrange
        var server = _factory.Server;
        var connection = await StartConnectionAsync(server.CreateHandler());
        List<Player> players = null;
        string errorMsg = null;
        Player player = null;
        
        // Act
        connection.On<List<Player>, string, Player>("ConfirmUserName", (playersSent, msg, playerSent) =>
        {
            players = playersSent;
            errorMsg = msg;
            player = playerSent;
        });
        await connection.InvokeAsync("EnterUserName", "Gin");
        
        // Assert
        Assert.That(players!.Count, Is.EqualTo(1));
    }
    
    private static async Task<HubConnection> StartConnectionAsync(HttpMessageHandler handler)
    {
        var hubConnection = new HubConnectionBuilder()
            .WithUrl($"ws://localhost/game", o =>
            {
                o.HttpMessageHandlerFactory = _ => handler;
            })
            .Build();

        await hubConnection.StartAsync();

        return hubConnection;
    }
}