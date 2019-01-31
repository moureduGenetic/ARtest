using UnityEngine;
using TMPro;

public class CardManager : MonoBehaviour {

    [SerializeField]
    private Card card;
    [SerializeField]
    private TextMeshProUGUI nameLabel;
    [SerializeField]
    private TextMeshProUGUI bioLabel;

    // Use this for initialization
    void Start () {
        nameLabel.text = card.name;
        bioLabel.text = card.bio;
	}
}
