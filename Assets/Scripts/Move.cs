using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private readonly float _velocity = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * this._velocity * Time.deltaTime;
    }
}
