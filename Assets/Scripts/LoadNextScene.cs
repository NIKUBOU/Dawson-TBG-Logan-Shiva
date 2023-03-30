using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    [SerializeField] string _sceneName;

    void OnTriggerEnter(Collider collision)
    {
        var player = collision.GetComponent<Unit>();
        if (player == null || player.IsEnemy())
            return;

        StartCoroutine(LoadAfterDelay());
    }

    IEnumerator LoadAfterDelay()
    {
        yield return new WaitForSeconds(1.5f);
        // load new level
        SceneManager.LoadScene(_sceneName);

    }
}
