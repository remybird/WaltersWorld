namespace WaltersWorld {

using UnityEngine;

public enum CardType { Melee, Ranged, Magic, Elemental, Healing }

[System.Serializable]
public struct CardStatsData {

  public CardType type;
  public string name;
  public int energyCost;
  public string ability;
}
}
