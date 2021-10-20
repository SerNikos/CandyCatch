using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {

       

        if (col.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //Increment score;
            GameManager.instance.IncrementScore();
        }


        if (col.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
            GameManager.instance.DecriseLife();

            CameraShake.instance.Shake();
        }
    }
}
