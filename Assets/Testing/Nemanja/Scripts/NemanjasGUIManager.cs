using UnityEngine;
using TMPro;

public class NemanjasGUIManager : MonoBehaviour
{
      [SerializeField]
    private StringVariable infoText;

    [SerializeField]
    private TMP_Text buttonLabel;

    [SerializeField]
    private BoolVariable showInfoOrStats;

    [SerializeField]
    private FloatVariable statsNumber;

    [SerializeField]
    private GameEvent gravityEnabled;

    public void ChangeButtonLabel() {
        if (statsNumber.Value == 0) {
            buttonLabel.text = "Activate Gravity";
            return;
        }
        buttonLabel.text = "Activate Gravity\nGrounded: " + (showInfoOrStats.Value ? infoText.Value : statsNumber.Value);
    }

    public void ActivateGravity() {
        gravityEnabled.Raise();
        infoText.Value = "Falling";
        ChangeButtonLabel();
    }

    public void ToggleInfoOrStats() {
        showInfoOrStats.Toggle();
        ChangeButtonLabel();
    }
}
