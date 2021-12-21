using UnityEngine;

namespace Character.Options
{
    public delegate void ReturnVoid();
    public class HealthController : MonoBehaviour
    {
        public int HealthCount;
        public event ReturnVoid IsDead;
        
        public void ReduceHealth()
        {

        }

        public void Dead()
        {
            if (HealthCount <= 0)
            {
                IsDead?.Invoke();
            }
        }
    }
}
