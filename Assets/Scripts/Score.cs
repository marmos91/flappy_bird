using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        Score.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
    }
}
