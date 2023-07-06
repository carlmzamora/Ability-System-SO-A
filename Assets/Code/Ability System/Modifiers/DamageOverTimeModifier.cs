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
    }

    public override void Tick()
    {
        Parameters parameters = new();
        parameters.PutInfo(DAMAGE_OVER_TIME_DAMAGE, damage);
        parameters.PutObjectInfo(DAMAGE_OVER_TIME_LISTENER, listeningEntity);
        eventToRaise.Raise(parameters);
    }
}
