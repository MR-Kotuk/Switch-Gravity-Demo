using UnityEngine;

public class GameControler : MonoBehaviour
{
    [SerializeField] private TrainTrToStopBus _trainTrToStopBus;
    [SerializeField] private RotateSun _rotateSun;
    [SerializeField] private CreateNoGravityObj _createNoGravityObj;
    [SerializeField] private MovementPlayer _movementPlayer;
    [SerializeField] private CameraMove _cameraMove;

    private void Start()
    {
        _createNoGravityObj.AwMode();
        _movementPlayer.AwMode();
    }

    private void Update()
    {
        _trainTrToStopBus.StayMode();
        _rotateSun.StayMode();
        _createNoGravityObj.StayMode();
        _movementPlayer.StayMode();
        _cameraMove.MouseActiveMove();
    }
}
