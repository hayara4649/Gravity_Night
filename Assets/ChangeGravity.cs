using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    [SerializeField] private Vector3 localGravity;
    private Rigidbody rbody;
    float direction;

    void Start()
    {
        rbody = this.GetComponent<Rigidbody>();
        rbody.useGravity = false;
        
        direction =localGravity.y;
        Debug.Log(direction);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetLocalGravity();

        if(Input.GetMouseButtonDown(0))
        {
            direction *= -1;
            Debug.Log(direction);

            localGravity = new Vector3(0,direction,0);
        }
    }

    private void SetLocalGravity()
    {
        rbody.AddForce(localGravity, ForceMode.Acceleration);
    }
}
