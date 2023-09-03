using UnityEngine;

public class NoGravity : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    [SerializeField] private Transform _player;

    [SerializeField] private AudioSource _switchGravityOn;
    [SerializeField] private AudioSource _switchGravityOff;

    [SerializeField] private int powerHit;
    private void OnMouseDown()
    {
        transform.LookAt(_player);
        _rb.AddForce(-transform.forward * powerHit);
    }
    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _rb.useGravity = !_rb.useGravity;
            if (_rb.useGravity)
                _switchGravityOn.Play();
            else
                _switchGravityOff.Play();
        }
           
    }
}
