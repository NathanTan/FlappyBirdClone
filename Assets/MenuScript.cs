using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FlappyBird {

public class MenuScript : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject mainMenu;

    public void showSettings() {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void hideSettings() {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }


    public void DropdownItemSelected(Dropdown dropdown) {
        int index = dropdown.value;

        Difficulty difficulty;
        switch (index) {
            case 0:
                difficulty = Difficulty.Easy;
                break;
            case 1:
                difficulty = Difficulty.Normal;
                break;
            case 2:
                difficulty = Difficulty.Hard;
                    break;
            default:
                difficulty = Difficulty.Normal;
                break;
        }

        Debug.Log("SETTING DIFFICULTY " + difficulty);

        GlobalControl.Instance.difficulty = difficulty;
    }
  
}

}