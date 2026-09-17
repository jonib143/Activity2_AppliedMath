using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    public Vector3 dir = Vector3.zero;
    public float speed = 7; 
    public float lifeTime = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (dir == Vector3.zero) return;

        transform.position += dir * speed * Time.deltaTime;
    
    }
}
