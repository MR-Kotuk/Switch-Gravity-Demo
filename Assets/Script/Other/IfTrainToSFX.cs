using UnityEngine;

public class IfTrainToSFX : MonoBehaviour
{
    [SerializeField] private AudioSource _trainSFX;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TrainSFX")
            _trainSFX.Play();
    }
}
