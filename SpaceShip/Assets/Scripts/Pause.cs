using UnityEngine;

public class QuestWindow : MonoBehaviour
{
    private bool isOn;
    public GameObject Pause;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isOn = !isOn;
            Pause.SetActive(isOn);
            
            if (isOn)
            {
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                Time.timeScale = 1;
                
            }
        }
    }
}