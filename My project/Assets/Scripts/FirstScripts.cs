using UnityEngine;

namespace JAY
{
    /// <summary>
    /// 第一個程式
    /// </summary>
    public class FirstScripts : MonoBehaviour
    {
        #region 註解區域
        // 縮排 快捷鍵 Tab
        // 格式化文件 Ctrl + K D
        // 單行註解
        #endregion
            // 喚醒事件
        private void Awake()
        {
            print("哈囉");
        }

        // 開始事件
        private void Start()
        {
            print("<color=yellow>這是開始事件</color>");
        }

        // 更新事件：在 Start 後執行 執行次數約 60 FPS
        private void Update()
        {
            print("<color=red>更新事件！</color>");
        }
        #region 事件區域


        #endregion
    }
}

 