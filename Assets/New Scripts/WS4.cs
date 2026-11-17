using System;
using UnityEngine;

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
  public CharacterInformation characterInformation;

  public int[] highScores;
  
  private void Start()
  {
    Debug.Log(elementKraft);
    
    Debug.Log(characterInformation);
    
    Debug.Log(highScores[2]);
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

