using System.Collections;
using System.Collections.Generic;
using HelloTicher;
using UnityEngine;
using UnityEngine.UI;

public sealed class Reference
{
    internal Player PlayerBall;
    internal object MainCamera;
    internal object RestartButton;
    private PlayerBall _playerBall;
    private Camera _mainCamera;
    private GameObject _bonuse;
    private GameObject _endGame;
    private Canvas _canvas;

    public Canvas Canvas
    {
        get
        {
            if (_canvas == null)
            {
                _canvas = Object.FindObjectOfType<Canvas>();
            }

            return _canvas;
        }
    }

    public GameObject Bonuse
    {
        get
        {
            if (_bonuse == null)
            {
                var gameObject = Resources.Load<GameObject>("UI/Bonuse");
                _bonuse = Object.Instantiate(gameObject, Canvas.transform);
            }

            return _bonuse;
        }
    }

    public GameObject EndGame
    {
        get
        {
            if (_endGame == null)
            {
                var gameObject = Resources.Load<GameObject>("UI/EndGame");
                _endGame = Object.Instantiate(gameObject, Canvas.transform);
            }

            return _endGame;
        }
    }
}


    

