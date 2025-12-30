using UnityEngine;

public class PlayerCtrller : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody playerRigidbody;
    public float speed = 8f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float XInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = XInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;
    }   

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}
