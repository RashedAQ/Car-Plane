using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    
    public GameObject plane;
    private Vector3 offset = new Vector3(21.66f, 2.426f, 10.11f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}



public class RoadVehicle : IMovable, ITurnable
{
    public float speed = 100f;
    public float turnSpeed = 5f;
    public virtual void GoForward()
    {}
    public virtual void Reverse()
    {
    }
    public virtual void TurnLeft()
    {
    }
    public virtual void TurnRight()
    { }
}
public class RailVehicle : IMovable
{
    public float speed = 100;
    public virtual void GoForward()
    {}
    public virtual void Reverse()
    {}
}
public class Car : RoadVehicle
{}
public class Train : RailVehicle
{}














public interface IDamageable
{
    float Health { get; set; }
    int Defense { get; set; }
    void Die();
    void TakeDamage();
    void RestoreHealth();
}
public interface IMovable
{
    float MoveSpeed { get; set; }
    float Acceleration { get; set; }
    void GoForward();
    void Reverse();
    void TurnLeft();
    void TurnRight();
}
public interface IUnitStats
{
    int Strength { get; set; }
    int Dexterity { get; set; }
    int Endurance { get; set; }
}
public interface IExplodable
{
    float Mass { get; set; }
    float ExplosiveForce { get; set; }
    float FuseDelay { get; set; }
    void Explode();
}



