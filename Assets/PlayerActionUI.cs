using _JabJob.Scripts.Inputs;
using UnityEngine;

public class PlayerActionUI : MonoBehaviour
{
    public GameObject gamepadPanel;
    public GameObject keyboardPanel;

    private void Start()
    {
        SwitchInputType(InputType.KeyboardAndMouse);
    }

    public void SwitchInputType(InputType inputType)
    {
        if (ReferenceEquals(gamepadPanel, null) || ReferenceEquals(keyboardPanel, null))
            return;
        
        if (inputType == InputType.Gamepad)
        {
            gamepadPanel.SetActive(true);
            keyboardPanel.SetActive(false);
        }
        else
        {
            gamepadPanel.SetActive(false);
            keyboardPanel.SetActive(true);
        }
    }
}
