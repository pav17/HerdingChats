using System.Collections;
using System.Collections.Generic;
using TwitchLib.Unity;
using TwitchLib.Client.Models;
using UnityEngine;

public class TwitchClient : MonoBehaviour
{

    public Client client;
    public string channelName;
    
    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;

        ConnectionCredentials credentials = new ConnectionCredentials('mrtwitchboto', Secrets.Instance.accessToken);
        client = new Client();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
