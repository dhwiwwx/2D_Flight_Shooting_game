using TMPro;
using UnityEngine;

public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerController PlayerController;
    private TextMeshProUGUI texeScore;

    private void Awake()
    {
        texeScore = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        texeScore.text = "Score " + PlayerController.Score;
    }
}
