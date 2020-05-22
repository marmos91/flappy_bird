using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private float _max_time = 1f;

    [SerializeField]
    private GameObject _pipe;

    [SerializeField]
    private float _height;

    private float _timer = 0;

    // Update is called once per frame
    void Update()
    {
        if(this._timer > this._max_time)
        {
            GameObject new_pipe = Instantiate(this._pipe);
            new_pipe.transform.position = transform.position + new Vector3(0, Random.Range(-this._height, this._height), 0);

            Destroy(new_pipe, 15);

            this._timer = 0;
        }
         
        this._timer += Time.deltaTime;
    }
}
