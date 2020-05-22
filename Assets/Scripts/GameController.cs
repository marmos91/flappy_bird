using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject _canvas;

    public void Start()
    {
        this._canvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        this._canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0); 
    }
}
