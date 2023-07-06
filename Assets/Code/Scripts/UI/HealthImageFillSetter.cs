using UnityEngine;

public class HealthImageFillSetter : ImageFillSetter
{
    IDamageable damageable;

    private void Awake()
    {
        damageable = transform.parent.gameObject.GetComponent<IDamageable>();
    }

    protected override void Update()
    {        
        if(damageable != null )
        {
            value = damageable.Health;
            max = damageable.MaxHealth;
        }
        bar.fillAmount = value / max;
    }
}
