using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    [SerializeField] private string scenename;

    // Update is called once per frame
    public void changeit()
    {
        SceneManager.LoadScene(scenename);
    }
}
