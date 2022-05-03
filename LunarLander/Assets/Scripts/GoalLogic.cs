using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalLogic : MonoBehaviour
{
    [SerializeField] Player player;
    private float angle;

    private void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == player.gameObject)
        {
            if (Vector3.Angle(transform.up, player.gameObject.transform.up) < 45 && collision.relativeVelocity.magnitude < 3)
            {
                Debug.Log(collision.relativeVelocity.magnitude);
                if (transform.tag == "10pGoal")
                {
                    player.IncreaseScore(10);
                }
                else if (transform.tag == "20pGoal")
                {
                    player.IncreaseScore(20);
                }

            }
            else
            {
                player.SetGameOver(true);
            }
        }
    }
}
