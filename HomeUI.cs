using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeUI : BaseUI
{
    Button startButton; // Reference to the start button
    Button exitButton; // Reference to the exit button
    protected override UIState GetUIState()
    {
        return UIState.Home;
    }

    public override void Init(UIManager uiManager)
    {
        base.Init(uiManager);
        // Initialize any specific components or settings for the Home UI here

        startButton = transform.Find("StartButton").GetComponent<Button>();
        exitButton = transform.Find("ExitButton").GetComponent<Button>();

        startButton.onClick.AddListener(OnClickStartButton); // Add listener for start button click
        exitButton.onClick.AddListener(OnClickExitButton); // Add listener for exit button click
    }

    void OnClickStartButton()
    {
        uiManager.OnClickStart(); // Call the start method in UIManager
    }

    void OnClickExitButton()
    {
        uiManager.OnClickExit(); // Call the exit method in UIManager
    }

}
