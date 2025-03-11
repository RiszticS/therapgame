using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameStartMenuAggregator : MonoBehaviour
{   
    [SerializeField] private InputField[] selectionPanels = new InputField[4];
    [SerializeField] private Toggle[] aiToggles = new Toggle[4];
    [SerializeField] private GameObject selectionPanel3Parent, selectionPanel4Parent;

    private string GetNameFromCreationPanel(int num, InputField nameField, Toggle aiToggle)
    {
        if (aiToggle.isOn)
            return "Gép " + num;

        if (nameField.text.Equals(""))
            return "Játékos " + num;

        return nameField.text;
    }

    

    public void StartGameClicked()
    {
        for (int i = 0; i < 4; i++)
        {
            if ((i == 2 && !selectionPanel3Parent.activeSelf) || (i == 3 && !selectionPanel4Parent.activeSelf))
            {
                Debug.Log("Skipping player " + (i + 1));
                continue;
            }
            
            Gameplay.instance.RegisterNewPlayer(GetNameFromCreationPanel(i, selectionPanels[i], aiToggles[i]), aiToggles[i].isOn);
        }
        
        Gameplay.instance.StartGame();
        
        gameObject.SetActive(false);
    }

    public void btn_change_scene(string scene_name)
    { SceneManager.LoadScene(scene_name); }
}
