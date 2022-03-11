using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button[] lvls;

    void Start()
    {
        if(PlayerPrefs.HasKey("Lvls"))
        {
            for (int i = 0; i < lvls.Length - 1; i++)
            {
                if (i <= PlayerPrefs.GetInt("Lvls"))
                {
                    lvls[i].interactable = true;
                }
                else
                    lvls[i].interactable = false;
            }
        }
    }
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void DelKeys()
    {
        
    }
}
