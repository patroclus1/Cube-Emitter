using System.Collections;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    public float CubeDistance = 5f;
    public float CubeSpeed = 5f;
    public float CubeFireCooldown = 1f;
    private Transform _transform;
    [SerializeField] private GameObject _cube;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        StartCoroutine(ShootWithCooldown());
    }

    private IEnumerator ShootWithCooldown()
    {
        while (true)
        {
            var emittedPart = Instantiate(_cube, _transform.position, Quaternion.identity);
            emittedPart.GetComponent<Cube>().InitCube(CubeSpeed, CubeDistance);
            yield return new WaitForSeconds(CubeFireCooldown);
        }
    }
}
