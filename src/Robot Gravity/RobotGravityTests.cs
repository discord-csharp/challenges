using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Timers;

namespace Space_Robot
{
	[TestClass]
	public class RobotGravityTests
	{
		public double DetermineGravity(Robot robot)
		{
			// -----------------------
			// Complete challenge here.
			//
			// You are making a robot to explore other planets. Your robot has a gravity sensor but you want to 
			// have a back up way to determine the current gravity in case the sensor is damaged.Your robot has
			// the ability to jump and it has an height sensor that asynchronously scans about every .01 seconds.
			// Use those features to determine the current acceleration due to gravity as a positive number
			// within 0.1 units.
			//
			// - robot.Jump
			// - robot.MaxJumpForce
			// - robot.HeightSensor
			// - robot.Mass
			//
			// -----------------------
			throw new NotImplementedException(); // <- delete
		}

		public class Robot
		{
			[Obsolete("You don't need to make any Robots. :P")]
			public Robot(Func<(double, DateTime)> getHeight, Action<double> jump)
			{
				Timer timer = new((int)HeightSensorInterval.TotalMilliseconds);
				timer.Elapsed += (o, e) =>
				{
					var (height, time) = getHeight();
					HeightSensor?.Invoke(height, time);
				};
				timer.Enabled = true;
				JumpCallback = jump;
			}
			private Action<double> JumpCallback { get; set; }
			private readonly TimeSpan HeightSensorInterval = TimeSpan.FromSeconds(.01);
			public double Mass { get; private set; } = 5;
			public double MaxJumpForce { get; private set; } = 50d;
			public event Action<double, DateTime>? HeightSensor;
			public void Jump(double force) => JumpCallback?.Invoke(force);
		}

		[TestMethod]
		public void Test()
		{
			// measurements in meters per second squared (m/s²)
			const double GravityOnMercury = 3.7;
			const double GravityOnVenus = 8.87;
			const double GravityOnEarth = 9.807;
			const double GravityOnMars = 3.721;
			const double GravityOnJupiter = 24.79;
			const double GravityOnSaturn = 10.44;
			const double GravityOnUranus = 8.87;
			const double GravityOnNeptune = 11.15;
			const double GravityOnPluto = 0.62;
			const double GravityOnEarthMoon = 1.62;

			Robot InitializeRobot(double gravity)
			{
				(double InitialVelocity, DateTime Time)? jump = null;

				Robot robot = default!;
#pragma warning disable CS0618 // Type or member is obsolete
				robot = new(
					getHeight: GetHeight,
					jump: force =>
					{
						if (GetHeight().Height is 0)
						{
							jump = (force / robot.Mass, DateTime.Now);
						}
					});
#pragma warning restore CS0618 // Type or member is obsolete

				(double Height, DateTime Time) GetHeight()
				{
					DateTime now = DateTime.Now;
					if (jump is null)
					{
						return (0, now);
					}
					double seconds = (now - jump.Value.Time).TotalSeconds;
					double height = -.5 * gravity * seconds * seconds + jump.Value.InitialVelocity * seconds;
					if (height < 0)
					{
						jump = null;
						height = 0;
					}
					return (height, now);
				}

				return robot;
			}

			void Test(double gravity)
			{
				try
				{
					Robot robot = InitializeRobot(gravity);
					double determinedGravity = Math.Abs(DetermineGravity(robot));
					Assert.IsTrue(Math.Abs(determinedGravity - gravity) <= 0.1, $"expected {gravity} but got {determinedGravity}");
				}
				catch (NotImplementedException)
				{
					Assert.Inconclusive();
				}
			}

			Test(GravityOnMercury);
			Test(GravityOnVenus);
			Test(GravityOnEarth);
			Test(GravityOnMars);
			Test(GravityOnJupiter);
			Test(GravityOnSaturn);
			Test(GravityOnUranus);
			Test(GravityOnNeptune);
			Test(GravityOnPluto);
			Test(GravityOnEarthMoon);
		}
	}
}