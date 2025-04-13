using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ReturnToScene0 : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ReturnToSceneAfterDelay());
    }

    IEnumerator ReturnToSceneAfterDelay()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(0);
    }
}