using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    [SerializeField] private Player player;
    private void OnCollisionEnter(Collision collision)
    {
        player.SetGameOver(true);
    }
}
