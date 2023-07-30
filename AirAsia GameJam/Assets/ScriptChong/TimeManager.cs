using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField] Timer gameTimer;

    private void Start()
    {
        gameTimer.SetDuration(5).Begin();
    }
}