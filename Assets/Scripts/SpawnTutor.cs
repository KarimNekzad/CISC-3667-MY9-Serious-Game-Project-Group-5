using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnTutor : MonoBehaviour
{
    private const int _mainMenuIndex = 0;
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(_mainMenuIndex);
    }

    public void SpawnPrefab() {
        DontDestroyOnLoad(Instantiate(myPrefab, new Vector3(8, 90, 0), Quaternion.identity));
        myPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
