using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arroww : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rb;
    void Start()
    {
        _rb= this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("aim") == true)
        {
            _rb.isKinematic = true;
        }
    }
}
