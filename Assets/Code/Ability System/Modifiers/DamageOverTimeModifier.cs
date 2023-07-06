using ScriptableObjectArchitecture;

public class DamageOverTimeModifier : Modifier
{
    public const string DAMAGE_OVER_TIME_DAMAGE = "damage_over_time_damage";
    public const string DAMAGE_OVER_TIME_LISTENER = "damage_over_time_listener";

    private float damage;
    private ParametersGameEvent eventToRaise;
    private Entity listeningEntity;

    public DamageOverTimeModifier(float damage, float duration, float tickTime, ParametersGameEvent eventToRaise, Entity toListen)
    {
        isInstant = duration <= 0;
        currentDuration = duration;
        this.tickTime = tickTime;
        nextTickTime = currentDuration - tickTime;
        this.damage = damage;
        this.eventToRaise = eventToRaise;
        listeningEntity = toListen;

        //DeployListener(listeningEntity);
    }

    public override void Tick()
    {
        /*Parameters parameters = new();
        parameters.PutInfo(DAMAGE_OVER_TIME_DAMAGE, damage);
        parameters.PutObjectInfo(DAMAGE_OVER_TIME_LISTENER, listeningEntity);
        eventToRaise.Raise(parameters);*/
        listeningEntity.DamageHealth(damage);
    }

    public override void DisposeSelf()
    {
        listeningEntity.SelfModifiers.Remove(this);
    }

    /*public void DeployListener(Entity toListen)
    {
        void response(Parameters parameters)
        {
            if (parameters.GetObjectInfo(DAMAGE_OVER_TIME_LISTENER) as Entity == toListen)
                toListen.DamageHealth(parameters.GetFloatInfo(DAMAGE_OVER_TIME_DAMAGE, 0));
        }

        eventToRaise.AddListener(response);
    }*/
}
