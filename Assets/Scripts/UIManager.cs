using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI moneyDisplay;

    public void UpdateMoneyText(string money)
    {
        moneyDisplay.text = "Money: $" + money;
    }
}
