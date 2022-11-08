using UnityEngine;

namespace JAY
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSestem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預製物")]
        private GameObject prefabExplosion;

        // 碰撞開始事件 一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print("碰撞：" + collision.gameObject);

            // 如果 碰到物件的名稱 包含 敵機 就爆炸
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                // Destory 刪除
                // gameObject 此物件
                Destroy(gameObject);
            }
        }

        // 碰撞結束事件 一次
        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }

        // 碰撞持續事件
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}
 