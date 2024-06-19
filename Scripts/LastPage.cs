using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastPage : MonoBehaviour
{
    public void FinalPage()
    {
        SceneManager.LoadSceneAsync(4);
    }
}
