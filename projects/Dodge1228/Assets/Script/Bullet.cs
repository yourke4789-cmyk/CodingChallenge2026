using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 8f;
    public Rigidbody bulletRigidbody;
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.linearVelocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)
    {
     if(other.tag == "Player")
        {
            PlayerCtrller playerCtrller = other.GetComponent<PlayerCtrller>();

            if(playerCtrller != null )
            {
                playerCtrller.Die();
            }
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
