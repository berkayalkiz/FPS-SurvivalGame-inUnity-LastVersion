using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDrop : MonoBehaviour
{
    public static CoinDrop instance;

    public GameObject CoinPrefab;

    [SerializeField]
    private Transform transform;


    public void CoinDropFromEnemy()
    {
        Vector3 position = transform.position;

        GameObject coin = Instantiate(CoinPrefab, position, Quaternion.identity);

        coin.SetActive(true);

        Destroy(coin, 15f);
    }

   
}
