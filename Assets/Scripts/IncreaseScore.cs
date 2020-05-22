using UnityEngine;

public class IncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
