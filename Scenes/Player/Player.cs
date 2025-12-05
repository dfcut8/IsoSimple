using Godot;

namespace Scenes.Player;

public partial class Player : CharacterBody2D
{
    private const float acceleration = 600.0f;
    private const float friction = 400.0f;

    [Export]
    public int Speed = 70;

    private Vector2 direction = Vector2.Zero;

    private void PlayerMovement(float delta)
    {
        direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
    }
}
