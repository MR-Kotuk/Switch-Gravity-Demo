using UnityEngine;

public class TrainTrToStopBus : MonoBehaviour
{
    [SerializeField] private Transform _trainStop;

    [SerializeField] private Transform[] _trainStopsLeft = new Transform[1];

    private float _trainX;

    public void StayMode()
    {
        _trainX = _trainStop.eulerAngles.x;

        for (int i = 0; i <= _trainStopsLeft.Length - 1; i++)
            _trainStopsLeft[i].eulerAngles = new Vector3(_trainX, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TrainTr")
        {
            NewRotatePlank(0f);
            Invoke("RestartToUp", 17f);
        }   
    }

    private void RestartToUp()
    {
        NewRotatePlank(90f);
    }

    private void NewRotatePlank(float num)
    {
        if (num == 0f && _trainX == 90)
            _trainStop.eulerAngles = new Vector3(num, 0, 0);

        if (num == 90f && _trainX == 0)
            _trainStop.eulerAngles = new Vector3(num, 0, 0);
    }
}
