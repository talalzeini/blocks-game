using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -6f){
            Score.score += 0.25;
            Destroy(gameObject);
        }
    }
}
