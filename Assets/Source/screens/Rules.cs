using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Rules : MonoBehaviour {
    public Button backButton;
    // Start is called before the first frame update
    public void Start() {
        Button btn = backButton.GetComponent<Button>();
		btn.onClick.AddListener(onClickBackButton);
    }

    public void onClickBackButton() { 
        SceneManager.LoadScene("Start Menu");
        Debug.Log ("onClickBackButton() on Rules screen has been pressed!");
    }
}
