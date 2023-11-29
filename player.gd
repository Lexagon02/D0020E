extends CharacterBody3D


const SPEED = 5.0
const JUMP_VELOCITY = 4.5

# Get the gravity from the project settings to be synced with RigidBody nodes.
var gravity = ProjectSettings.get_setting("physics/3d/default_gravity")

@onready var camera = $Camera3D
@onready var anim_playerRight = $AnimationPlayerRight
@onready var anim_playerLeft = $AnimationPlayerLeft
@onready var hittbox_left = $Camera3D/WeaponPivotLeft/SwordLeft/HittboxLeft
@onready var hittbox_right = $Camera3D/WeaponPivotRight/SwordRight/HittboxRight

func _ready():
	Input.set_mouse_mode(Input.MOUSE_MODE_CAPTURED)

func _unhandled_input(event):
	if event is InputEventMouseMotion:
		rotate_y(-event.relative.x * 0.003)
		camera.rotate_x(-event.relative.y * 0.003)
		camera.rotation.x = clamp(camera.rotation.x , -(PI/2), PI/2)

func _process(delta):
	if Input.is_action_just_pressed("quit"):
		get_tree().quit()
		
	if Input.is_action_just_pressed("attackRight"):
		anim_playerRight.play("attackRight")
		hittbox_right.monitoring = true
	
	if Input.is_action_just_pressed("attackLeft"):
		anim_playerLeft.play("attackLeft")
		hittbox_left.monitoring = true
	

func _physics_process(delta):
	# Add the gravity.
	if not is_on_floor():
		velocity.y -= gravity * delta

	# Handle Jump.
	if Input.is_action_just_pressed("ui_accept") and is_on_floor():
		velocity.y = JUMP_VELOCITY

	# Get the input direction and handle the movement/deceleration.
	# As good practice, you should replace UI actions with custom gameplay actions.
	var input_dir = Input.get_vector("left", "right", "forward", "back")
	var direction = (transform.basis * Vector3(input_dir.x, 0, input_dir.y)).normalized()
	if direction:
		velocity.x = direction.x * SPEED
		velocity.z = direction.z * SPEED
	else:
		velocity.x = move_toward(velocity.x, 0, SPEED)
		velocity.z = move_toward(velocity.z, 0, SPEED)

	move_and_slide()
	

func _on_animation_player_right_animation_finished(anim_name):
	if anim_name == "attackRight":
		anim_playerRight.play("idleRight")
		hittbox_right.monitoring = false




func _on_animation_player_left_animation_finished(anim_name):
	if anim_name == "attackLeft":
		anim_playerLeft.play("idelLeft")
		hittbox_left.monitoring = false


func _on_hittbox_left_area_entered(area):
	if area.is_in_group("enemy"):
		print("enemy hit")


func _on_hittbox_right_area_entered(area):
	if area.is_in_group("enemy"):
		print("enemy hit")
