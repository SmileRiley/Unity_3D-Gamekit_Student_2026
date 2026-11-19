using UnityEngine;
using UnityEngine.Events;
using FMOD.Studio;
using FMODUnity;

public enum MusicEventType
{
    Calm,
    Explore,
    Combat
}

[System.Serializable]
public struct MusicData
{
    [SerializeField]
    public MusicEventType musicType;
    public EventReference eventReference;
}

public class AudioManager : MonoBehaviour
{
    [SerializeField]
        private MusicData[] musicEvents;
        
    public EventReference eventReference;
    private EventInstance eventInstance;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        eventInstance = RuntimeManager.CreateInstance(eventReference);
        eventInstance.start();
        Debug.Log("Playing music");
    }
}
