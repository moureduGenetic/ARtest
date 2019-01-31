using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Cards/New Card", order = 1)]
public class Card : ScriptableObject {
    new public string name;
    public GameObject bust;
    [TextArea(3, 10)]
    public string bio;
    

}
