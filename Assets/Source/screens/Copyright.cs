using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Copyright : MonoBehaviour {
    public Button backButton;
    // Start is called before the first frame update
    public void Start() {
        Button btn = backButton.GetComponent<Button>();
		btn.onClick.AddListener(onClickBackButton);
    }

    public void onClickBackButton() { 
        SceneManager.LoadScene("Initial");
        Debug.Log ("onClickBackButton() on Copyright screen has been pressed!");
    }
}
