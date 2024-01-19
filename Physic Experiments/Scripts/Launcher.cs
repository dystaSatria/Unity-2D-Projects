using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Transform target;
    public Transform throwPoint;
    public float timeTillHit = 1f;

    private Rigidbody2D _rigidBody;
    private float _startPoint, _endPoint;

    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _rigidBody.gravityScale = 0;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _startPoint = temp.x;
            Throw();
        }

        if (Input.GetMouseButtonUp(0))
        {
            var temp2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _endPoint = temp2.y;
            
        }
    }

    private void Throw()
    {
        _rigidBody.gravityScale = 1;
        var xDistance = _endPoint - _startPoint;
        var yDistance = target.position.y - throwPoint.position.y;
        var angle = Mathf.Atan((yDistance + 4.905f * (timeTillHit * timeTillHit)) / xDistance);
        var totalVel = xDistance / (Mathf.Cos(angle) * timeTillHit);
        var xVel = totalVel * Mathf.Cos(angle);
        var yVel = totalVel * Mathf.Sin(angle);
        _rigidBody.velocity = new Vector2(xVel, yVel);

        float height = Mathf.Abs(yDistance);
        float distance = Mathf.Abs(xDistance);
        Debug.Log("Uzunluk: " + height.ToString("F2"));
        Debug.Log("Mesafe: " + distance.ToString("F2"));
    }
}
