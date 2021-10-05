using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool canMove = true;

    [SerializeField]
    float moveSpeed = 15f;

    [SerializeField]
    float maxPos = 7.73f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Move();
        }
    }
    private void Move()
    {
        float xInput = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * xInput * moveSpeed * Time.deltaTime;

        //Screen boundaries
        float xPos =  Mathf.Clamp(transform.position.x,-maxPos,maxPos);

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}
