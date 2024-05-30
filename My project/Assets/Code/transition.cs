using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    public int scennumber;

    public void transitin()
    {
        SceneManager.LoadScene(scennumber);
    }


}
