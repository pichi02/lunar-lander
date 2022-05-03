using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private Player player;
    void Update()
    {
        if (player.GameOver())
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
