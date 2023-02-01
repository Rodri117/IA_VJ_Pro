using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering : MonoBehaviour
{

    public float followSpeed = 15f;
    public float slowdowDistance = 1f;

    Vector2 velocity = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        Vector2 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerDistance = (targetPosition - (Vector2)transform.position);
        Vector2 disiredVelocity = playerDistance.normalized * followSpeed;
        Vector2 steering = disiredVelocity - velocity;

        velocity += steering * Time.deltaTime;

        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}
