using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.parent.name=="LeftHand" && transform.parent.name == "RightHand")
        {
            _rb.isKinematic = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
       if (other.gameObject.CompareTag("earth")==true)
        {
            _rb.isKinematic = true;
        }
    }
}
