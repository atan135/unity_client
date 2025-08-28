namespace Interfaces
{
    /// <summary>
    /// Interface for objects that can take damage
    /// </summary>
    public interface IDamageable
    {
        /// <summary>
        /// Current health of the object
        /// </summary>
        float CurrentHealth { get; }

        /// <summary>
        /// Maximum health of the object
        /// </summary>
        float MaxHealth { get; }

        /// <summary>
        /// Whether the object is currently alive
        /// </summary>
        bool IsAlive { get; }

        /// <summary>
        /// Take damage from a source
        /// </summary>
        /// <param name="damage">Amount of damage to take</param>
        /// <param name="damageSource">Source of the damage</param>
        void TakeDamage(float damage, GameObject damageSource = null);

        /// <summary>
        /// Heal the object
        /// </summary>
        /// <param name="healAmount">Amount to heal</param>
        void Heal(float healAmount);

        /// <summary>
        /// Event called when the object dies
        /// </summary>
        event System.Action OnDeath;

        /// <summary>
        /// Event called when the object takes damage
        /// </summary>
        event System.Action<float> OnDamaged;
    }
}
