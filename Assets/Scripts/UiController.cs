using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] PlayerMovementAdvanced player;

    [Header("UI Stats")]
    [SerializeField] private TextMeshProUGUI GameLoseText;
    [SerializeField] private Slider HeatBarSlider;
    [SerializeField] private Slider StaminaBarSlider;

    private void Update()
    {
        GameLoseText.text = player.countDown.ToString("0.00");

        HeatBarSlider.value = player.displayHeat;

        StaminaBarSlider.value = player.displayStamina;
    }
}
