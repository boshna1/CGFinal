using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] CoinCount coin;

    void Start()
    {
      coin = GameObject.FindWithTag("CoinCount").GetComponent<CoinCount>();
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0), 5);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            coin.Add();
            Destroy(gameObject);
        }
    }
}
