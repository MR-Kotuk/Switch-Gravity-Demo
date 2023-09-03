using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private int speed, powerJump, maxSpeed, speedUp;
    [SerializeField] private Rigidbody rb;

    private bool isUp = false;

    private int CurrentSpeed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "UpTr")
            NewIsUp(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "UpTr")
            NewIsUp(false);
    }
    public void AwMode()
    {
        CurrentSpeed = speed;
    }
    public void StayMode()
    {
        MovePlayer();
        
    }

    private void MovePlayer()
    {
        if (isUp)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(new Vector3(0, 1, 0) * Time.fixedDeltaTime * speedUp);
            if (Input.GetKey(KeyCode.S))
                transform.Translate(new Vector3(0, -1, 0) * Time.fixedDeltaTime * speedUp);
        }


        if (Input.GetKey(KeyCode.W) && isUp == false)
            transform.localPosition += transform.forward * speed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.S) && isUp == false)
            transform.localPosition -= transform.forward * speed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.A))
            transform.localPosition -= transform.right * speed * Time.fixedDeltaTime;
        if (Input.GetKey(KeyCode.D))
            transform.localPosition += transform.right * speed * Time.fixedDeltaTime;

        if (Input.GetKeyDown(KeyCode.Q))
            rb.useGravity = !rb.useGravity;

        if (Input.GetKey(KeyCode.LeftShift))
            PlusSpeed();
        else
            speed = CurrentSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(new Vector3(0, powerJump, 0) * speed * Time.fixedDeltaTime);
    }
    private void PlusSpeed()
    {
        if (speed <= maxSpeed)
            speed++;
    }

    private void NewIsUp(bool newIsUp)
    {
        isUp = newIsUp;
        rb.useGravity = !newIsUp;
    }
}
