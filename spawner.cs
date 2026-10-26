using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float timeSinceLastSpawn;
    public float timeBetweenSpawn;
    public bool isSpawning = true;
    InputAction AttackAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        AttackAction = InputSystem.actions.FindAction("attack");
        timeSinceLastSpawn = 0.0f;
        timeBetweenSpawn = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

       if (timeBetweenSpawn == 0.0f)
        {
           
            timeBetweenSpawn = 0.1f;
        }
        
        if (AttackAction.IsPressed() && (timeBetweenSpawn > timeSinceLastSpawn))
        {
                Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                timeBetweenSpawn = 0.0f;     
        }
        //secondsPassed += Time.delta
        //if ( secondsPassed> spawnIntervalS
    }
}
