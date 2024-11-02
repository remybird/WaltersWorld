namespace WaltersWorld {

using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card")]
public class CardData : ScriptableObject {

  public Sprite image;
  public CardStatsData normal;
  public CardStatsData plus;
}
}
