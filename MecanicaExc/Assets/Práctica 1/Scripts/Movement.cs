using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _aceleration;
    private float _horizontalAxis;
    void Start()
    {
        
    }

    private void Update()
    {
        _horizontalAxis = Input.GetAxis("Horizontal");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Aceleration();
    }

    void Aceleration()
    {
        _rb.velocity += (Vector2.right * (_horizontalAxis * _aceleration*Time.fixedDeltaTime));

        if (_horizontalAxis == 0 && _rb.velocity!=Vector2.zero)
        {
            var x= _rb.velocity.x;
            var sign = Mathf.Sign(x);
            _rb.velocity -= (Vector2.right * ((_aceleration * sign) * Time.fixedDeltaTime));

          

        }
    }

}
