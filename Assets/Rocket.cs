using UnityEngine;

public class Rocket : MonoBehaviour
{
    public RocketMovement rocketPrefab;
    public int rocketCount = 4;
    public float startingAngle = 45;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("FireRocket",3, 3f); 
    }

    void FireRocket()
    {
        float angle = 360f / rocketCount;
        
        for (int i = 0; i < rocketCount; i++)
        {
            float firingDegrees = startingAngle + (i * angle);
            
            Vector3 targetDir = new Vector3(
                Mathf.Cos(firingDegrees * Mathf.Deg2Rad), 
                Mathf.Sin(firingDegrees * Mathf.Deg2Rad), 
                0
            ); 
            
            RocketMovement r = Instantiate(rocketPrefab); 
            r.transform.position = this.transform.position; 
            r.dir = targetDir;
        }
    }
}
