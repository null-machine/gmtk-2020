using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

class Interviewer : MonoBehaviour {
	
	internal static Interviewer instance;
	
	[SerializeField]
	Text text;
	[SerializeField]
	Image image;
	
	bool ready;
	
	void Awake() {
		instance = this;
		NextQuestion();
	}
	
	void Update() {
		if (ready && Input.GetKeyDown(KeyCode.Mouse0)) {
			NextQuestion();
		}
	}
	
	internal void Respond(string text, string sprite) {
		this.text.text = text;
		image.sprite = Resources.Load<Sprite>("Sprites/" + sprite);
	}
	
	void NextQuestion() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		if (Saver.state.fatigue >= 0) Debug.Log("fuck");
	}
	
	string[] questions = {
		"question one",
		"question two"
	};
}

/*
turret shoots ball affected by gravity
slingshot
slot machine
footsteps
new scene for every level
*/