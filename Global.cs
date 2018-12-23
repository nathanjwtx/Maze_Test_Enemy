using System;
using Godot;


    public class Global : Node
    {
        public Random _Random;

        public override void _Ready()
        {
            _Random = new Random();
        }
    }
