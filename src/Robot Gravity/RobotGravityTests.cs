using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Timers;

namespace Space_Robot
{
    [TestClass]
    public class RobotGravityTests
    {
        public static double DetermineGravity(Robot robot)
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

        // measurements in meters per second squared (m/s²)
        [TestMethod] public void TestGravityOnMercury()   => Test(3.7);
        [TestMethod] public void TestGravityOnVenus()     => Test(8.87);
        [TestMethod] public void TestGravityOnEarth()     => Test(9.807);
        [TestMethod] public void TestGravityOnMars()      => Test(3.721);
        [TestMethod] public void TestGravityOnJupiter()   => Test(24.79);
        [TestMethod] public void TestGravityOnSaturn()    => Test(10.44);
        [TestMethod] public void TestGravityOnUranus()    => Test(8.87);
        [TestMethod] public void TestGravityOnNeptune()   => Test(11.15);
        [TestMethod] public void TestGravityOnPluto()     => Test(0.62);
        [TestMethod] public void TestGravityOnEarthMoon() => Test(1.62);

        static void Test(double gravity)
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

        static Robot InitializeRobot(double gravity)
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
    }
}