using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] Timer gameTimer;

    private void Start()
    {
        gameTimer.SetDuration(90).Begin();
    }
}