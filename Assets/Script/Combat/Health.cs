using UnityEngine;

namespace RPG.Combat
{
    
    public class Health : MonoBehaviour
    {
        [SerializeField] float healthPoint = 100f;

        bool isDead = false;

        public bool IsDead()
        {
            return isDead;
        }

        public void TakeDamage(float damage)
        {
            healthPoint = Mathf.Max(healthPoint - damage,0);
            if(healthPoint==0)
            {
                Die();
            }
        }

        private void Die()
        {
            if (isDead) return;
            isDead = true;
            GetComponent<Animator>().SetTrigger("die");
        }
    }
}