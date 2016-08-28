using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class homescript : MonoBehaviour {
	float timeLeft = 60.0f;
	public Text secsTime;
	public InputField userAnswer;
	public Text randomNumber;
	public Text userScore;
	public Text totalScore;
	// Use this for initialization
	void Start () {
		generateRandomNumber ();
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		secsTime.text = timeLeft.ToString ();
		if ((int)timeLeft == 0) {
			SceneManager.LoadScene ("GameOver");
		}
	}

	void generateRandomNumber() {
		randomNumber.text = (Random.Range (1, 500)).ToString();
	}

	public void submitButtonClicked() {
		if (userAnswer.text == "") {
			
		} else {
			if (int.Parse(userAnswer.text) == (int.Parse(randomNumber.text) * 2)) {
				userScore.text = (int.Parse(userScore.text) + 1).ToString();
			}
		}
		
		totalScore.text = (int.Parse (totalScore.text) + 1).ToString();
		generateRandomNumber ();
		userAnswer.text = "";
	}
}
