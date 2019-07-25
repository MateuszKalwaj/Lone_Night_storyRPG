using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates; //array stanów gry

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextStates() {
        return nextStates;
    }
}
