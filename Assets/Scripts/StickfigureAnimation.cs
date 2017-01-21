using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}



//// http://cliparts.co/clipart/3276564
//
//var assert = function(val, message) {
//	if (!val) {
//		throw new Error('Assertion failed: ' + message);
//	}
//};
//var Stickfigure;
//var Animation;
//var stickfigureAnimationData;
//
//
//// ########################################################################
//// Define Scene
//
//var sceneObjects;
//
//setup = function() {
//	var guy1 = new Stickfigure(200, 200, stickfigureAnimationData);
//	guy1.setAnimation('walking');
//
//	sceneObjects = [guy1];
//};
//
//
//// define animation
//var defaultAnimKeyframeDuration = 100;
//var stickfigureAnimationData = {
//	walking: {
//		frames: [
//			{   // 0
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						//neck: 3, leftUpperArm: -53, leftLowerArm: -114, rightUpperArm: 69, rightLowerArm: 73,
//						neck: 3, leftUpperArm: -50, leftLowerArm: -122, rightUpperArm: 65, rightLowerArm: 73,
//						leftLegHip: 14, leftKnee: 10, rightLegHip: -38, rightKnee: 14
//					}
//				}
//			},
//			{   // 1
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -56, leftLowerArm: -112, rightUpperArm: 64, rightLowerArm: 60,
//						leftLegHip: 13, leftKnee: 8, rightLegHip: -31, rightKnee: 8
//					}
//				}
//			},
//			{   // 2
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -62, leftLowerArm: -99, rightUpperArm: 71, rightLowerArm: 56,
//						leftLegHip: 8, leftKnee: 23, rightLegHip: -28, rightKnee: 8
//					}
//				}
//			},
//			{   // 3
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -69, leftLowerArm: -99, rightUpperArm: 77, rightLowerArm: 56,
//						leftLegHip: -2, leftKnee: 44, rightLegHip: -23, rightKnee: 9
//					}
//				}
//			},
//			{   // 4
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -77, leftLowerArm: -99, rightUpperArm: 85, rightLowerArm: 60,
//						leftLegHip: -13, leftKnee: 44, rightLegHip: -18, rightKnee: 9
//					}
//				}
//			},
//			{   // 5
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -87, leftLowerArm: -99, rightUpperArm: 91, rightLowerArm: 73,
//						leftLegHip: -13, leftKnee: 9, rightLegHip: -18, rightKnee: 48
//					}
//				}
//			},
//			{   // 6
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -93, leftLowerArm: -99, rightUpperArm: 99, rightLowerArm: 73,
//						leftLegHip: -9, leftKnee: 9, rightLegHip: -23, rightKnee: 65
//					}
//				}
//			},
//			{   // 7
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -80, leftLowerArm: -99, rightUpperArm: 89, rightLowerArm: 73,
//						leftLegHip: -4, leftKnee: 9, rightLegHip: -37, rightKnee: 79
//					}
//				}
//			},
//			{   // 8
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -70, leftLowerArm: -102, rightUpperArm: 87, rightLowerArm: 73,
//						leftLegHip: 0, leftKnee: 9, rightLegHip: -41, rightKnee: 74
//					}
//				}
//			},
//			{   // 9
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -60, leftLowerArm: -107, rightUpperArm: 75, rightLowerArm: 73,
//						leftLegHip: 6, leftKnee: 9, rightLegHip: -46, rightKnee: 62
//					}
//				}
//			},
//			{   // 10
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -53, leftLowerArm: -114, rightUpperArm: 71, rightLowerArm: 73,
//						leftLegHip: 12, leftKnee: 9, rightLegHip: -48, rightKnee: 44
//					}
//				}
//			},
//			{   // 11
//				duration: defaultAnimKeyframeDuration,
//				state: {
//					angles: {
//						neck: 3, leftUpperArm: -53, leftLowerArm: -114, rightUpperArm: 68, rightLowerArm: 73,
//						leftLegHip: 16, leftKnee: 9, rightLegHip: -52, rightKnee: 37
//					}
//				}
//			}
//		]
//	}
//};
//
//
//// ########################################################################
//// Animation
//
///**
// * An animation, using linear key-frame interpolation
// */
//var Animation = function(obj, animationData) {
//	this.obj = obj;
//	this.keyFrames = animationData.frames;
//
//	assert(this.obj, "Animation.obj");
//	assert(this.keyFrames, "Animation.keyFrames");
//
//	this.currentState = {};
//	this.currentKeyFrameStartTime = 0;
//};
//Animation.prototype = {
//	getNextKeyFrameIndex: function() {
//		return (this.keyFrameIndex+1) % this.keyFrames.length;
//	},
//
//	getCurrentKeyFrame: function() {
//		return this.keyFrames[this.keyFrameIndex];
//	},
//
//	reset: function(time) {
//		this.currentKeyFrameStartTime = time;
//		this.keyFrameIndex = 0;
//	},
//
//	update: function(time) {
//		if (!this.currentKeyFrameStartTime) {
//			this.reset(time);
//		}
//
//		// check if we moved to a new frame
//		var currentFrame = this.getCurrentKeyFrame();
//		var dt = time - this.currentKeyFrameStartTime;
//		while (dt >  + currentFrame.duration) {
//			// move to next keyFrame
//			this.currentKeyFrameStartTime = time;
//			this.keyFrameIndex = this.getNextKeyFrameIndex();
//			currentFrame = this.getCurrentKeyFrame();
//			dt = time - this.currentKeyFrameStartTime;
//			//println(this.keyFrameIndex);
//		}
//
//		// compute keyFrame ratio
//		var nextFrameIndex = this.getNextKeyFrameIndex();
//		var nextFrame = this.keyFrames[nextFrameIndex];
//		var ratio = dt / currentFrame.duration;
//
//		for (var fieldName in currentFrame.state) {
//			var state1 = currentFrame.state[fieldName];
//			var state2 = nextFrame.state[fieldName];
//			var fieldState = this.currentState[fieldName];
//			if (!fieldState) {
//				this.currentState[fieldName] = fieldState = {};
//			}
//			for (var stateName in state1) {
//				var value1 = state1[stateName];
//				var value2 = state2[stateName];
//				fieldState[stateName] = lerp(value1, value2, ratio);
//			}
//		}
//
//		this.obj.applyState(this.currentState);
//	}
//};
//
//
//// ########################################################################
//// Stickfigure
//
//var Stickfigure = function(x, y, animationData, color, headColor) {
//	this.x = x;
//	this.y = y;
//	this.color = color || { r: 0, g: 0, b: 0 };                 // black by default
//	this.headColor = headColor || { r: 0, g: 0, b: 0 };         // black by default
//	this.weight = 4;       // stroke weight (line thickness)
//	this.sizes = {
//		head: 20,
//		body: 50,
//		upperArms: 20,
//		lowerArms: 15,
//		thighs: 20,
//		calves: 20
//	};
//	this.angles = {
//		neck: 0,
//		leftUpperArm: -45,
//		leftLowerArm: -45,
//		rightUpperArm: 10,
//		rightLowerArm: 10,
//		leftLegHip: 30,
//		leftKnee: - 20,
//		rightLegHip: -30,
//		rightKnee: 20
//	};
//	this.animationData = animationData;
//	this.currentAnimation = null;
//};
//
//Stickfigure.prototype.applyState = function(state) {
//	for (var fieldName in state) {
//		var newFieldState = state[fieldName];
//		var fieldState = this[fieldName];
//		for (var stateName in newFieldState) {
//			fieldState[stateName] = newFieldState[stateName];
//		}
//	}
//};
//
//Stickfigure.prototype.setAnimation = function(animationName) {
//	var animationData = this.animationData[animationName];
//	if (!animationData) {
//		throw new Error('Animation does not exist: ' + animationName);
//	}
//	this.currentAnimation = new Animation(this, animationData);
//};
//
//Stickfigure.prototype.updateObject = function(time) {
//	if (this.currentAnimation) {
//		this.currentAnimation.update(time);
//	}
//};
//
///**
// * Draw one body part of the stickfigure
// */
//Stickfigure.prototype._drawStickfigureLine = function(x, y, length, angle) {
//	pushMatrix();
//	translate(x, y);
//	rotate(angle);
//	line(0, 0, 0, length);
//};
//Stickfigure.prototype.drawObject = function() {
//	var x = this.x;
//	var y = this.y;
//
//	// configure drawing options
//	strokeWeight(this.weight);
//	stroke(this.color.r, this.color.g, this.color.b);
//	fill(this.headColor.r, this.headColor.g, this.headColor.b);
//
//	// head
//	ellipse(x, y, this.sizes.head - this.weight, this.sizes.head - this.weight);
//
//	// body
//	this._drawStickfigureLine(x, y, this.sizes.body, this.angles.neck);
//
//	// limbs are relative to body
//	{
//		// left arm
//		{
//			this._drawStickfigureLine(0, this.sizes.head/2 + this.sizes.body/10, this.sizes.upperArms, this.angles.leftUpperArm + 90);
//			this._drawStickfigureLine(0, this.sizes.upperArms, this.sizes.lowerArms, this.angles.leftLowerArm + 90);
//			popMatrix();
//			popMatrix();
//		}
//
//		// right arm
//		{
//			this._drawStickfigureLine(0, this.sizes.head/2 + this.sizes.body/10, this.sizes.upperArms, this.angles.rightUpperArm - 90);
//			this._drawStickfigureLine(0, this.sizes.upperArms, this.sizes.lowerArms, this.angles.rightLowerArm - 90);
//			popMatrix();
//			popMatrix();
//		}
//
//		// left leg
//		{
//			this._drawStickfigureLine(0, this.sizes.body, this.sizes.thighs, this.angles.leftLegHip);
//			this._drawStickfigureLine(0, this.sizes.thighs, this.sizes.calves, this.angles.leftKnee);
//			popMatrix();
//			popMatrix();
//		}
//
//		// right leg
//		{
//			this._drawStickfigureLine(0, this.sizes.body, this.sizes.thighs, this.angles.rightLegHip);
//			this._drawStickfigureLine(0, this.sizes.thighs, this.sizes.calves, this.angles.rightKnee);
//			popMatrix();
//			popMatrix();
//		}
//
//		// right leg
//		this._drawStickfigureLine(0, this.sizes.body, this.sizes.legs, this.angles.rightLeg);
//		popMatrix();
//
//		popMatrix();    // pop body matrix
//	}
//};
//
//// ########################################################################
//// Main Loop
//
//
//var draw = function() {
//	// draw background
//	background(161, 241, 255);
//
//	var now = millis();
//
//	//guy1.applyState(animationData.walking[11].state);
//
//	// update objects
//	for (var i = 0; i < sceneObjects.length; ++i) {
//		sceneObjects[i].updateObject(now);
//	}
//
//	// draw objects
//	for (var i = 0; i < sceneObjects.length; ++i) { 
//		sceneObjects[i].drawObject(now);
//	}
//
//	// draw static floor
//	noStroke();
//	fill(196, 140, 43);
//	rect(-5, 288, 500, 10);
//};
//
//
//var keyPressed = function() {
//
//};
//
//
//setup();