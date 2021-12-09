
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class SceneChange : MonoBehaviour
    {
        public void SceneChangerTo(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}