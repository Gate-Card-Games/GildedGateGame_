/*This is the base for all defensive cards
 * 
 * @author ryan weinstein
 * 

    collaborators n\a
 */

public interface IDefensiveCard
{
    //Places the tower
    public void activate(int x, int y);

    //fires a projectile at the target enemy
    //public void attack(IEnemy targetedEnemy);
}
