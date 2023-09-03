using UnityEngine;

public class RotateSun : MonoBehaviour
{
    [SerializeField] private float speedRotSun;

    public void StayMode()
    {
        transform.Rotate(new Vector3(1, 0, 0) * Time.fixedDeltaTime * speedRotSun);
    }
}
