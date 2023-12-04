using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StateLoader : MonoBehaviour
{
	public Animator transition;
	public float transitionTime = 1f;

	// Update is called once per frame
    void Update()
	{
		if (Input.GetKey("right"))
		{
			NextState();
		}
		if (Input.GetKey("left"))
		{
			PreviousState();
		}
	}

    public void NextState()
	{
		StartCoroutine(LoadState(SceneManager.GetActiveScene().buildIndex + 1));
	}

	public void PreviousState()
	{
		StartCoroutine(LoadState(SceneManager.GetActiveScene().buildIndex - 1));
	}

	public void HomeState()
	{
		SceneManager.LoadScene("HomeScene");
	}

    public void MapScene()
	{
		SceneManager.LoadScene("MapScene");
	}

	public void SampleScene()
	{
		SceneManager.LoadScene("SampleScene");
	}

	//Creating coroutine??
	//Creating coroutine??
	IEnumerator LoadState(int sceneIndex)
	{
		

		yield return new WaitForSeconds(transitionTime);

		SceneManager.LoadScene(sceneIndex);
	}
}