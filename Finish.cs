
using UnityEngine;

public class Finish : MonoBehaviour {

    public gameManager gameManager;
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
