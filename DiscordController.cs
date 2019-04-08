using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DiscordController : MonoBehaviour
{
    public DiscordRpc.RichPresence presence = new DiscordRpc.RichPresence();
    public string applicationID;
    public string optionalSteamID;
    public string DRPCDetails;
    public string DRPCSmallImage;
    public string DRPCLargeImage;

    DiscordRpc.EventHandlers handlers;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        DiscordRpc.UpdatePresence(presence);
    }

    void OnEnable()
    {
        Debug.Log("Discord: init");
        handlers = new DiscordRpc.EventHandlers();
        
        presence.details = string.Format(DRPCDetails);
        presence.smallImageKey = string.Format(DRPCSmallImage);
        presence.largeImageKey = string.Format(DRPCLargeImage);
        DiscordRpc.Initialize(applicationID, ref handlers, true, optionalSteamID);
    }

    void OnDisable()
    {
        Debug.Log("Discord: shutdown");
        DiscordRpc.Shutdown();
    }
}
