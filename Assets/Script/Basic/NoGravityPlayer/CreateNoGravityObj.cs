using UnityEngine;

public class CreateNoGravityObj : MonoBehaviour
{
    [SerializeField] private Rigidbody _createdCube;

    [SerializeField] private GameObject _mapSpawn;

    [SerializeField] private AudioSource _sfxSwitchGravityOn;
    [SerializeField] private AudioSource _sfxCreateObj;
    [SerializeField] private AudioSource _sfxSwithGravityOff;

    private Rigidbody[] _beCreatedCubes = new Rigidbody[1];

    private int howCreatedCubes = 0;
    private bool isGravity;

    public void AwMode()
    {
        _beCreatedCubes[0] = _createdCube;
    }

    public void StayMode()
    {
        if (Input.GetKeyDown(KeyCode.E) && !Input.GetKey(KeyCode.Mouse1))
        {
            _sfxCreateObj.Play();
            howCreatedCubes++;

            System.Array.Resize(ref _beCreatedCubes, _beCreatedCubes.Length + 1);
            _beCreatedCubes[howCreatedCubes] = Instantiate(_createdCube, _mapSpawn.transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.E) && Input.GetKey(KeyCode.Mouse1))
        {
            isGravity = !isGravity;
            for (int i = 0; i <= _beCreatedCubes.Length - 1; i++)
                _beCreatedCubes[i].useGravity = !_beCreatedCubes[i].useGravity;

            if (isGravity)
                _sfxSwitchGravityOn.Play();
            else
                _sfxSwithGravityOff.Play();
        }
        
    }
}
