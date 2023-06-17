using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChanger : MonoBehaviour
{
//Перезагружаем сцену при соприкосновении с шипами
    private void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene("Level_1");
    }
}
