using System.Collections;
using System.Collections.Generic;
using TwitchLib.Unity;
using TwitchLib.Client.Models;
using UnityEngine;

public class TwitchClient : MonoBehaviour
{

    public Client client;
    public string channelName = "sulu244";
    
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;

        ConnectionCredentials credentials = new ConnectionCredentials("mrtwitchboto", Secrets.Instance.accessToken);
        client = new Client();
        client.Initialize(credentials, channelName);

        client.OnMessageReceived += ChatListen;
        client.OnChatCommandReceived += CommandListen;

        client.Connect();
    }

    private void CommandListen(object sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
    {
        if(e.Command.CommandText == "help")
        {
            Help();
        }
    }

    private void ChatListen(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
    {
        Debug.Log("Someone just sent a message in Twitch Chat");
        Debug.Log(e.ChatMessage.Username + ": " + e.ChatMessage.Message);
    }

    private void Help()
    {
        client.SendMessage(client.JoinedChannels[0], "Welcome to Chasing Chats! You can use chat commands to help the cats avoid the player! The valid commands are: !Up, !Down, !Left, !Right");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            client.SendMessage(client.JoinedChannels[0], "Hello World");
        }
    }
}
