using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;
    public float upwardsForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("left shift"))
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("left ctrl"))
        {
            rb.AddForce(0, -upwardsForce * Time.deltaTime, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
 