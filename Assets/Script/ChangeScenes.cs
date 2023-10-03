using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    //次のScene名前
    public string NextSceneName = "Stage2";                                                           

    public void Start()
    {
        this.transform.tag = "Gate";
    }
    public void LoadScene()
    {
        //次のSceneに遷移
        SceneManager.LoadScene(NextSceneName);                                                         
    }
}
