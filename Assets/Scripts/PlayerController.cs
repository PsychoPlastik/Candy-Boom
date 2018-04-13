using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    private Rigidbody rb;
    Vector3 position;

        
void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<AudioSource>().playOnAwake = false;

        //position = transform.position;
    }
    void FixedUpdate()
    {
        //faz o personagem andar
        position = new Vector3(speed  * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical"));
        rb.velocity = position;

        //Movimentação do personagem
        //transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        // rb.MovePosition(position);


        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //rb.AddForce(movement * speed);
        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


       float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (Mathf.Abs(x) >= Mathf.Abs(z))
            z = 0;
        else if (Mathf.Abs(z) >= Mathf.Abs(x))
            x = 0;
        Vector3 movimento = new Vector3(x, 0, z) * speed * Time.deltaTime;

        rb.velocity = movimento;*/

    }
}