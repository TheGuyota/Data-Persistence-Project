using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUIHandler : MonoBehaviour
{
    

    public void UpdatePlayerName(string name)
    {
        GameManager.Instance.currentPlayerName = name;
    }

    public void OnStartClicked()
    {
        SceneManager.LoadScene(1);
    }
}
