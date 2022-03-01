using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FPSUI : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private TMP_Text enemyDefeatText;

    public void ShowHealthFraction(float fraction) {
        healthBar.fillAmount = fraction;
    }

    public void ShowEnemyDefeatCount(float count) {
        enemyDefeatText.text = "Enemies Defeated: " + count;
    }
}
