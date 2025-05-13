using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotationOfPropeller : MonoBehaviour
{
    public float rotationSpeed = 1000f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}


public abstract class Shape
{
    public abstract float CalculateArea();
}
public class Circle : Shape
{
    public float Radius;
    public Circle(float radius)
    {
        Radius = radius;
    }

    public override float CalculateArea()
    {
        return Mathf.PI * Radius * Radius;
    }
}
public class Rectangle : Shape
{
    public float Width;
    public float Height;

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public override float CalculateArea()
    {
        return Width * Height;
    }
}




public class Vehicle
{
    public float speed = 100;
    public Vector3 direction;
    public void GoForward()
    {
        
    }
    public void Reverse()
    {
        
    }
    public void TurnRight()
    {
        
    }
    public void TurnLeft()
    {
        
    }
}





public class Navigator
{
    public void Move(Vehicle vehicle)
    {
        vehicle.GoForward();
        vehicle.TurnLeft();
        vehicle.GoForward();
        vehicle.TurnRight();
        vehicle.GoForward();
    }
}












public interface IMovable
{
    void GoForward();
    void Reverse();
}

public interface ITurnable
{
    void TurnLeft();
    void TurnRight();
}


public class EnemyUnit : MonoBehaviour, IDamageable, IMovable, IUnitStats
{
 if(){
        }
}



public class ExplodingBarrel : MonoBehaviour, IDamageable, IExplodable
{
    // Implements only health and explosion
}

