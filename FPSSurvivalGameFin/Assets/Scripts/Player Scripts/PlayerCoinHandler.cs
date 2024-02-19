using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCoinHandler : MonoBehaviour
{
    public static int coin ;

    [SerializeField]
    private TextMeshProUGUI coinText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coin.ToString();
    }
}
