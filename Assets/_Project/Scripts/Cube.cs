using UnityEngine;

public class Cube : MonoBehaviour
{
    private Transform _transform;
    private Vector3 _startPosition;
    private float _range;
    private float _speed;

    private void Awake()
    {
        _transform = transform;
        _startPosition = _transform.position;
    }

    public void InitCube(float speed, float distance)
    {
        _range = distance;
        _speed = speed;
    }

    private void Update()
    {
        _transform.position += Vector3.right * _speed * Time.deltaTime;

        if (Vector3.Distance(_startPosition, _transform.position) > _range)
        {
            Destroy(gameObject);
        }
    }
}
