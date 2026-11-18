using System;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public enum ElementalPower
{
  None = 0,
  Fire = 1,
  Ice = 2,
  Lightning = 3,
  Earth = 4
}

[System.Serializable]
public struct CharacterInformation
{
  public string name;
  public ElementalPower power;
  public float speed;
  public int health;
  public bool canFly;
  public int damagePower;
}

public class WS4 : MonoBehaviour
{
  public ElementalPower elementKraft;
  public CharacterInformation[] characterInformation;

  public EventReference eventRef;
  private EventInstance eventInstance;
  
  public int[] highScores;
  
  private void Start()
  {
    eventInstance = RuntimeManager.CreateInstance(eventRef);
    eventInstance.start();
    
    eventInstance.getPlaybackState(out PLAYBACK_STATE state);
    Debug.Log(state);
    
    foreach (CharacterInformation score in characterInformation)
    {
      Debug.Log(score.name);
    }

    foreach (CharacterInformation score in characterInformation)
    {
      switch (score.name)
      {
        case "Link":
          Debug.Log("TRIFORCE!");
          break;
        case "Mario":
          Debug.Log("WAAAHOOO!");
          break;
        case "Samus":
          Debug.Log("METROID!");
          break;
        default:
          Debug.Log("Something Wong...");
          break;
      }
    }
 
  }

  private void OnTriggerEnter(Collider other)
  {
    /*if (other.tag == "Player")
    {
      Debug.Log("I'm a Player!");
    }
    Debug.Log("I'm not!");*/
  }
}

