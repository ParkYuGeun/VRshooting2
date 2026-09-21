using UnityEngine;

public class GazeInteractionSelect : MonoBehaviour
{
    [SerializeField] private GameObject childObj;

    public void GazeIn() {
        childObj.SetActive(true);
    }

    public void GazeOut() {
        childObj.SetActive(false);

    }
}
