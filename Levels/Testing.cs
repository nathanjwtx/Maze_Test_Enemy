using Godot;
using System;

public class Testing : Node2D
{
    private Sprite _sprite;
    private Texture _texture = (Texture) GD.Load("res://Assets/coin.png");
    public Random _random;

    public override void _Ready()
    {
        _sprite = GetNode<Sprite>("Sprite");
        _sprite.Texture = _texture;
        _random = new Random();
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
