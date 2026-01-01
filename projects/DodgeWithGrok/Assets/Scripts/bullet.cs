using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody bulletRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletRigidbody.linearVelocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerControler playerControler= other.GetComponent<PlayerControler>();
            if(playerControler != null )
            {
                playerControler.Die();
            }
        }

    }
    void Update()
    {
        
    }
}
