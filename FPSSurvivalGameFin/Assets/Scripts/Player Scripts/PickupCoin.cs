using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCoin : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, 50f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == Tags.PLAYER_TAG)
        {
            Destroy(gameObject);

            PlayerCoinHandler.coin += Random.Range(1, 8);
        }
    }
}
