using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;

    public static int GamesPlayed = 0;

    public void EndGame ()
	{
		if (gameHasEnded)
			return;

		rotator.enabled = false;
		spawner.enabled = false;

		gameHasEnded = true;

        GamesPlayed += 1;

        SceneManager.LoadScene("Death");
	}
}
