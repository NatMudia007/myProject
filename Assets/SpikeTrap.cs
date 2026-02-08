using UnityEngine;
public class SpikeTrap : MonoBehaviour
{
    [SerializeField] float damage = 10f;
    
    void OnTriggerStay2D(Collider2D other)  //TRIGGER INSTEAD OF COLLISION. WILL CAUSE DAMAGE
    {
        if(other.TryGetComponent(out IDamageable damageable))
        {
            damageable.ApplyDamage(damage);
        }
    }
}