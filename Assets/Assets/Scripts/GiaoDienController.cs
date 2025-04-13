using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GiaoDienController : MonoBehaviour
{
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button Play = root.Q<Button>("Play");
        //Button Level = root.Q<Button>("Level");
        //Button Option = root.Q<Button>("Option");
        Play.clicked += () =>
        {
            SceneManager.LoadScene("Level 1");
        };
        //next.clicked += () =>
        //{
        //    SceneManager.LoadScene("Man1");
        //};
    }
}
