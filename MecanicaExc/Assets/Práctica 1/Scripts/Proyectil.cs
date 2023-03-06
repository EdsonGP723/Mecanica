using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _bullet;
    private float _timer;
    private float _height;


    [SerializeField] private float _holdingTime;
    [SerializeField] private float _maxHeight;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _timer += 1* Time.deltaTime;
            if (_timer >= _holdingTime) _timer = _holdingTime;
            Debug.Log(_timer);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (_timer <= 0.1)
            {
                _timer = _holdingTime;
            }

            _height = (_maxHeight / _holdingTime) * _timer;

            var v = Mathf.Sqrt(_height*2*9.81f);

            var actualObject = Instantiate(_bullet, gameObject.transform);

            actualObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up*v,ForceMode2D.Impulse);
          
            _timer = 0;
        }

       
        
    }
}
