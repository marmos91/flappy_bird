using UnityEngine;

public class Fly : MonoBehaviour
{
    [SerializeField]
    private GameController _controller;

    [SerializeField]
    private Rigidbody2D _rigid_body;

    [SerializeField]
    private float _velocity = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
            this._rigid_body.velocity = Vector2.up * this._velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this._controller.GameOver();
    }
}
