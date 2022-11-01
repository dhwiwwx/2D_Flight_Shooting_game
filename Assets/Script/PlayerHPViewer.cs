using UnityEngine;
using UnityEngine.UI;

public class PlayerHPViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerHP playerHP;
    private Slider sliderHP;

    private void Awake()
    {
        sliderHP = GetComponent<Slider>();
    }
    void Update()
    {
        sliderHP.value = playerHP.CurrentHP / playerHP.MaxHp;   
    }
}