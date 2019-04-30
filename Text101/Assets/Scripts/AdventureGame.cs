using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    [SerializeField]
    Text textComponent;

    [SerializeField]
    State startingState;

    private State state;

    // Start is called before the first frame update
    void Start() {
        state = startingState;
        DisplayState();
    }

    // Update is called once per frame
    void Update() {
        UpdateState();
        DisplayState();
    }

    private void DisplayState() {
        textComponent.text = state.GetStoryText();
    }

    private void UpdateState() {
        State[] nextStates = state.GetNextStates();
        for (int i = 0; i < nextStates.Length; i++) {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i)) {
                state = nextStates[i];
            }
        }
    }
}
