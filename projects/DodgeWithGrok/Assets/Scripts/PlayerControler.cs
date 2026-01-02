using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float XInput = Input.GetAxis("Horizontal");
        float ZInput = Input.GetAxis("Vertical");

        float XSpeed = XInput * speed;
        float ZSpeed = ZInput * speed;

        Vector3 newVector = new Vector3(XSpeed, 0f, ZSpeed);
        playerRigidbody.linearVelocity = newVector;

    }

    public void Die()
    {
        gameObject.SetActive(false);
    }

}
