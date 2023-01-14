//define an interface named IDamageable
interface IDamageable
{
    void TakeDamage(int damage);
}

//Add IDamageable interface to Player class. So Player can implement the TakeDamage function
class Player : IDamageable
{
    public int Health { get; private set; }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
//Add IDamageable interface to Enemy class. So Enemy can implement the TakeDamage function
class Enemy : IDamageable
{
    public int Health { get; private set; }
    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
//This logic can be expandable with another interface like IAttackable, IMovable etc. By this way we get a modular code structure.
//To Implement interface segregation principle, your interface should not contain more than one functionality.  
