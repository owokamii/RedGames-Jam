using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] Timer gameTimer;
    public int timer;

    private void Awake()
    {
        gameTimer = GetComponentInChildren<Timer>();
    }

    private void Start()
    {
        gameTimer.SetDuration(timer).Begin();
    }
}