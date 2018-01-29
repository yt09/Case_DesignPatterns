using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 游戏循环脚本
/// </summary>
public class GameLoop : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}