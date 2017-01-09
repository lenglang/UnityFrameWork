using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadSceneAsync("摇杆"));
        Debug.Log(Application.persistentDataPath);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator LoadSceneAsync(string name)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(name);
        ao.allowSceneActivation=false;
        while (ao.progress < 0.9f)
        {
            Debug.Log(ao.progress);
            yield return new WaitForEndOfFrame();
        }
        //ao.allowSceneActivation = true;
    }
}
