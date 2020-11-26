using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTO : MonoBehaviour
{
    public void Button(string newBP){
        SceneManagement.LoadScene(newBP);
    }
}
