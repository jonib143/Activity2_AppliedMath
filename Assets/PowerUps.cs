using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public Rocket rocket;
    public Transform player;
    private int maxMissileCount = 8;

    void Update()
    {
        Vector3 distance = player.position - transform.position;
        if (distance.magnitude <= 1f)
        {
            if (rocket.rocketCount < maxMissileCount)
            {
                rocket.rocketCount++;
                Destroy(gameObject);
            }
        }
    }
}
