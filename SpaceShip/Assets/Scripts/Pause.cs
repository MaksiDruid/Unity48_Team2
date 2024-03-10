using UnityEngine;

public class QuestWindow : MonoBehaviour
{
    private bool isOn;
    public GameObject Pause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            isOn = !isOn;
            Pause.SetActive(isOn);
            
            if (isOn)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1;
                
            }
        }
    }
}