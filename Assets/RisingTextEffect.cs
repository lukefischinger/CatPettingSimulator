using UnityEngine;

public class RisingTextEffect : MonoBehaviour
{

    [SerializeField] float _risingSpeed = 0.5f;
    float _startTime;
    Transform myTransform;


    void Start()
    {
        myTransform = transform;
        _startTime = Time.time;
    }

    void Update()
    {
        myTransform.position += _risingSpeed * Time.deltaTime * Vector3.up;
    }
}
