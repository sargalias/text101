using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State")]
public class State : ScriptableObject {
    // Start is called before the first frame update
    [SerializeField]
    [TextArea(10, 14)]
    string storyText;

    public string getStoryText() {
        return storyText;
    }
}
