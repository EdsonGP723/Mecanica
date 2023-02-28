using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public Rigidbody2D rb;
	public float aceleration;
	float counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)){
			counter += Time.deltaTime;
			Debug.Log(counter);
		}
		
		Move();
    }
    
	void Move(){
		rb.velocity += new Vector2(Input.GetAxisRaw("Horizontal"),0)- new Vector2(0,0)/ counter;
	}
}
