> This is a challenge developed for the C# discord server.<br/>
> Want to Participate? Join the C# discord: <sub><a href="https://discord.gg/csharp"><img src="https://img.shields.io/discord/143867839282020352?logo=discord&logoColor=ffffff&color=7389D8" title="C# Discord Server" /></a></sub>

# Robot Gravity

You are making a robot to explore other planets. Your robot has a gravity sensor but you want to 
have a back up way to determine the current gravity in case the sensor is damaged.Your robot has
the ability to jump and it has an height sensor that asynchronously scans about every .01 seconds.
Use those features to determine the current acceleration due to gravity as a positive number
within 0.1 units.

Use these members from `Robot robot`:
- `robot.Jump`
- `robot.MaxJumpForce`
- `robot.HeightSensor`
- `robot.Mass`

<details>
<summary>Hint #1</summary>

The equation for the vertical position of a projectile is `p = -.5*g*s^2 + v*s + i` where
- `p` is vertical position
- `g` is acceleration due to gravity
- `s` is time
- `v` is initial velocity (in this case initial velocity is the parameter to `robot.Jump` divided by `robot.Mass`)
- `i` is initial vertical (in this case i is always 0)

</details>

<details>
<summary>Hint #2</summary>

`robot.HeightSensor` is an event. You need to make an event handler with the same method signature and subscribe to the event.

```cs
void HandleHeightSensor(double height, DateTime time)
{
	// some code here...
}

robot.HeightSensor += HandleHeightSensor;
```

</details>

### Quick start

Cloning this repo is recommended.

Complete the challenge in the MS Test project here: [RobotGravityTests.cs](RobotGravityTests.cs)

### Feedback

If you have any feedback on the challenges, [please open an issue](https://github.com/discord-csharp/challenges/issues/new/choose), mention the challenge, and ping the contributor(s) of the challenge.

### Contributor(s)

- [@zacharypatten](https://github.com/ZacharyPatten)

### Source

This was an original challege. :)

---

Discord meta data. Do not edit. This is used for GitHub => Discord linking.

<table>
<tr>
	<td>Name
	<td>Robot Gravity Challenge
<tr>
	<td>Description
	<td>You are making a robot to explore other planets. Your robot has a gravity sensor but you want to have a back up way to determine the current gravity in case the sensor is damaged. Your robot has the ability to jump and it has an height sensor that asynchronously scans about every .01 seconds. Use those features to determine the current acceleration due to gravity as a positive number within 0.1 units.
<tr>
	<td>Sample
	<td>
    
Cloning the repoand complete the challenge in the MS Test project here: https://github.com/discord-csharp/challenges/tree/main/src/Robot%20Gravity/RobotGravityTests.cs

```cs
public double DetermineGravity(Robot robot)
{
	// -----------------------
	// Complete challenge here.
	//
	// - robot.Jump
	// - robot.MaxJumpForce
	// - robot.HeightSensor
	// - robot.Mass
	//
	// -----------------------
}
```

<details>
<summary>Hint #1</summary>

The equation for the vertical position of a projectile is `p = -.5*g*s^2 + v*s + i` where
- `p` is vertical position
- `g` is acceleration due to gravity
- `s` is time
- `v` is initial velocity (in this case initial velocity is the parameter to `robot.Jump` divided by `robot.Mass`)
- `i` is initial vertical (in this case i is always 0)

</details>

<details>
<summary>Hint #2</summary>

`robot.HeightSensor` is an event. You need to make an event handler with the same method signature and subscribe to the event.

```cs
void HandleHeightSensor(double height, DateTime time)
{
	// some code here...
}

robot.HeightSensor += HandleHeightSensor;
```

</details>
<tr>
	<td>Contributed by
	<td>438382611929366537
<tr>
	<td>Self link
	<td>https://github.com/discord-csharp/challenges/tree/main/src/Robot%20Gravity
</table>