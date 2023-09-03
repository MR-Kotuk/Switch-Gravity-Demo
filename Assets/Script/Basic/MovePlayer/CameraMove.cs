using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Camera player;
    [SerializeField] private GameObject playerGameObject;

    [SerializeField] private float sensitivity = 10f;
    [SerializeField] private float smoothTime = 5f;

    private float xRot, yRot;
    private float xRotCurrent, yRotCurrent;
    private float curentVelosityX, curentVelosityY;

    public void MouseActiveMove()
    {
        Cursor.lockState = CursorLockMode.Locked;

        xRot += Input.GetAxis("Mouse X") * sensitivity;
        yRot += Input.GetAxis("Mouse Y") * sensitivity;
        yRot = Mathf.Clamp(yRot, -90, 90);

        xRotCurrent = Mathf.SmoothDamp(xRot, xRotCurrent, ref curentVelosityX, smoothTime);
        yRotCurrent = Mathf.SmoothDamp(yRot, yRotCurrent, ref curentVelosityY, smoothTime);

        player.transform.rotation = Quaternion.Euler(-yRotCurrent, xRotCurrent, 0f);
        playerGameObject.transform.rotation = Quaternion.Euler(-yRotCurrent, xRot, 0f);
    }
}
