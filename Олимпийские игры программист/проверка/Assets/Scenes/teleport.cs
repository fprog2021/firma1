using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void v1()
    {
        SceneManager.LoadScene(1);
    }

    public void v2()
    {
        SceneManager.LoadScene(0);
    }

    public void v3()
    {
        SceneManager.LoadScene(1);
    }
    public void v4()
    {
        SceneManager.LoadScene(2);
    }
    
    
}
