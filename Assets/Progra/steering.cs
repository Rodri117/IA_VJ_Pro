using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering : MonoBehaviour
{

    public float ffollowSpeed = 15f;       // la velocidad
    

    Vector2 V2_velocity = Vector2.zero;   // se define la velocidad en un vector de 2 dimenciones

    // Update is called once per frame
    void Update()
    {
        Vector2 v2_targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  // se toman cordenadas del mause
        Vector2 v2_playerDistance = (v2_targetPosition - (Vector2)transform.position);  // identifica la direccion
        Vector2 v2_disiredVelocity = v2_playerDistance.normalized * ffollowSpeed;  //se agrega la velocidad
        Vector2 v2_steering = v2_disiredVelocity - V2_velocity;  

        V2_velocity += v2_steering * Time.deltaTime;  //  actualiza la direccion y la velocidad

        transform.position += (Vector3)V2_velocity * Time.deltaTime;  
    }
}
