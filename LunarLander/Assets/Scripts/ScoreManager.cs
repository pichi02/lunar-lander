using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] Text score;
    [SerializeField] Text fuel;
    
    void Update()
    {
        score.text = "Score: " + player.GetScore();
        fuel.text = "Fuel: " + player.GetFuel();
    }
 
}
