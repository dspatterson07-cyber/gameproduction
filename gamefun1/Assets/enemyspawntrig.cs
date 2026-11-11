using UnityEngine;

public class enemyspawntrig : MonoBehaviour
{
    public spawner spawner;
    public bool isgrounded = false;
    public bool isSpawning = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner = GetComponent<spawner>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        playercc player = collision.gameObject.GetComponent<playercc>();
        if (collision.GetComponent<playercc>() != null)
        {
            
            spawner.isSpawning = true;
            //collision.CompareTag("Player");
        }
    }   
    private void OnTriggerExit2D(UnityEngine.Collider2D collision)
    {
        playercc player = collision.gameObject.GetComponent<playercc>();
        spawner.isSpawning = false;
        //isGrounded = false;
    }
    void Update()
    {
        
    }
}
