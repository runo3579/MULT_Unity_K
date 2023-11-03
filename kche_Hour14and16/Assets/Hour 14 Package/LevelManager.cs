using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "kche_Hour14";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
