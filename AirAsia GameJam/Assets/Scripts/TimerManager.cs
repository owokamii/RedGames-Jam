using UnityEngine;

public class TimerManager : MonoBehaviour
{
    [SerializeField] Timer gameTimer;

    private void Start()
    {
        gameTimer.SetDuration(5).Begin();
    }
}