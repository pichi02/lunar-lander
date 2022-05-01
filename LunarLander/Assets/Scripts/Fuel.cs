using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] private Player player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.IncreaseFuel();
            Destroy(gameObject);
        }
    }
}
