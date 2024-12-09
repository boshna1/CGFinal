using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCount : MonoBehaviour
{
    [SerializeField] Text coinText;
    int coinCounter;

     void Update()
    {
        coinText.text = "Coins: " + coinCounter.ToString();
    }

    public void Add()
    {
        coinCounter++;
    }
}
