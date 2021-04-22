﻿namespace Lightbug.CharacterControllerPro.Core
{
	

/// <summary>
/// This class contain all the constants used for collision detection, steps detection, ground probing, etc. All the values were carefully chosen, this means that it is not recommended to modify these values at all,
/// however if you need to do it do so at your own risk (make a backup before).
/// </summary>
public class CharacterConstants
{
    /// <summary>
	/// Distance between the origins of the upper and lower edge detection rays.
	/// </summary>
	public const float EdgeRaysSeparation = 0.02f;

	/// <summary>
	/// Cast distance used for the raycasts in the edge detection algorithm.
	/// </summary>
	public const float EdgeRaysCastDistance = 2f;

    /// <summary>
	/// Space between the collider and the collision shape (used by the physics queries).
	/// </summary>
	public const float SkinWidth = 0.01f;   

	/// <summary>
	/// Minimum offset applied to the bottom of the capsule (upwards) to avoid contact with the ground.
	/// </summary>
	public const float ColliderMinBottomOffset = 0.1f;
	
	/// <summary>
	/// Minimum angle between upper and lower normals (from the edge detector) that defines an edge.
	/// </summary>
	public const float MinEdgeAngle = 0.5f;

	/// <summary>
	/// Maximum angle between upper and lower normals (from the edge detector) that defines an edge.
	/// </summary>
	public const float MaxEdgeAngle = 170f;

	/// <summary>
	/// Minimum angle between upper and lower normals (from the edge detector) that defines a step.
	/// </summary>
	public const float MinStepAngle = 85f;

	/// <summary>
	/// Maximum angle between upper and lower normals (from the edge detector) that defines a step.
	/// </summary>
	public const float MaxStepAngle = 95f;

	/// <summary>
	/// Base distance used for ground probing.
	/// </summary>
	public const float GroundCheckDistance = 0.1f;

	/// <summary>
	/// Base distance used for stable ground probing.
	/// </summary>
	public const float StableGroundCheckDistance = 1f;
	
	/// <summary>
	/// Maximum number of iterations available for the collide and slide algorithm. This becomes useful for ending the loop.
	/// </summary>
	public const int MaxSlideIterations = 3;	


	/// <summary>
	/// Length used for the collision info containers. These are arrays used for storing the information gathered from the physics queries, 
	/// collision messages, etc.
	/// </summary>
	public const int HitCollidersBufferLength = 10;
	

	/// <summary>
	/// The default gravity value used by the weight function.
	/// </summary>
	public const float DefaultGravity = 9.8f;

	/// <summary>
	/// Minimum angle value considered when choosing the "head contact". The angle is measured between the contact normal and the "Up" vector.
	/// The valid range goes from "MinHeadContactAngle" to 180 degrees.
	/// </summary>
	public const float MinHeadContactAngle = 100f;

	/// <summary>
	/// Tolerance value considered when choosing the "wall contact". The angle is measured between the contact normal and the "Up" vector.
	/// The valid range goes from 90 - "WallContactAngleTolerance" to 90 degrees.
	/// </summary>
	public const float WallContactAngleTolerance = 10f;

	/// <summary>
	/// Distance use to predict the ground below the character.
	/// </summary>
	public const float GroundPredictionDistance = 10f;
	
	
}


}