﻿using System;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

namespace HelloTicher
{
    public class TestException : MonoBehaviour
    {
        [SerializeField] private Transform Tes;
        [SerializeField] private Transform Tes3;
        [SerializeField] private Sprite _sprite;

        private void Awake()
        {
            FindObjectOfType<Image>().sprite = _sprite;
            try
            {
                NewMethod();
            }
            catch (Exception e)
            {
            }
        }

        private void NewMethod()
        {
            if (Tes == null)
            {
                throw new DataException($"Tes not found");
            }

            if (ReferenceEquals(Tes3, null))
            {
                throw new DataException($"Tes3 not found");
            }
        }

        private void Start()
        {
            try
            {
                int x = int.Parse("-3");
                if (x < 0) throw new MyException("введено недопустимое значение", x);
                Debug.Log("ok");
            }
            catch (MyException e)
            {
                Debug.Log($"{e.Message} {e.Value}");
            }

            try
            {

            }
            catch (MyException e) when(enabled)
            {
                Debug.Log($"{e.Message} {e.Value}");
            }
            catch (InvalidOperationException e) when(enabled)
            {
                Debug.Log($"{e.Message}");
            }
            catch (Exception e) when(enabled)
            {
                Debug.Log($"{e.Message}");
            }
            finally
            {
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DataException"></exception>
        private Toggle NameMethod()
        {
            return null;
        }
    }
}
