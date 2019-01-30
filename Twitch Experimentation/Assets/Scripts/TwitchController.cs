using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TwitchLib.Client.Models;
using TwitchLib.Unity;

public class TwitchController : MonoBehaviour
{

    public Client client;
    public string channelName;

    // Start is called before the first frame update
    void Start()
    {
        Application.runInBackground = true;

        ConnectionCredentials credentials = new ConnectionCredentials("mrtwitchboto", Secrets.accessToken);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
