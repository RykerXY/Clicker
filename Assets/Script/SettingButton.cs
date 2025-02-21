using UnityEngine;

public class SettingButton : MonoBehaviour
{
    public GameObject settingPanel;
    public GameObject settingPanel1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggleSettingPanel();
        }
    }
    public void toggleSettingPanel()
    {
        settingPanel.SetActive(!settingPanel.activeSelf);
        settingPanel1.SetActive(!settingPanel1.activeSelf);
    }

}
