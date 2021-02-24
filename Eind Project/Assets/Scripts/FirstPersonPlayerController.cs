using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonPlayerController : MonoBehaviour
{
    [SerializeField] private GameObject PlayerBody;
    [SerializeField] private float playerspeed;
    private Rigidbody PlayerRB;
    Vector3 Mousepos;

    private float JumpCooldown = 1f;
    void Start()
    {
        PlayerRB = PlayerBody.GetComponent<Rigidbody>();
    }
    void Update()
    { 
        if (JumpCooldown <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                PlayerRB.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse);
                JumpCooldown = 3f;
            }
        }
        else
        {
            JumpCooldown -= Time.deltaTime;
        }

        Mousepos = Input.mousePosition;
       

        if (Input.GetKey(KeyCode.W))
        {
            PlayerBody.transform.position = new Vector3(PlayerBody.transform.position.x, PlayerBody.transform.position.y, PlayerBody.transform.position.z + playerspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerBody.transform.position = new Vector3(PlayerBody.transform.position.x, PlayerBody.transform.position.y, PlayerBody.transform.position.z - playerspeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerBody.transform.position = new Vector3(PlayerBody.transform.position.x - playerspeed, PlayerBody.transform.position.y, PlayerBody.transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerBody.transform.position = new Vector3(PlayerBody.transform.position.x + playerspeed, PlayerBody.transform.position.y, PlayerBody.transform.position.z);
        }
    }
}
