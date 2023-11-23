using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    static DontDestroy _dontDestroy = null;
    public static DontDestroy D0ntDestroy { get { return _dontDestroy; } }
    bool isTrue = false;
    public GameObject purpelOnion;

    private void Awake()
    {
        if (_dontDestroy == null)
        {
            _dontDestroy = this;
            DontDestroyOnLoad(purpelOnion);
            return;
        }
        else
        {
            Destroy(purpelOnion);
        }

        isTrue = purpelOnion.activeSelf;

        if (isTrue)
        {
            Scene nowScene = SceneManager.GetActiveScene();

            switch (nowScene.name)
            {
                case "2.Main":
                    purpelOnion.SetActive(true);
                    break;

                case "3.MiniGame":
                    purpelOnion.SetActive(false);
                    break;
            }
        }

    }
}

