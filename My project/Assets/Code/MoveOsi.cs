using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MoveOsi : MonoBehaviour
{
    public int sceneNumber = 0;
    
    
    public float rotationSpeed = 100.0f;

    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    public void transiton()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
