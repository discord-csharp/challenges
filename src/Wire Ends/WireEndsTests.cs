using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Wire_Ends
{
    [TestClass]
    public class WireEndsTests
    {
        public int CountWireEnds(string s)
        {
            string chars = "║╠╩╦═╬╣╚╝╔╗ ";
            // -----------------------
            // complete challenge here
            // -----------------------
            throw new DELETEME();
        }

        [TestMethod]
        public void Test()
        {
            (string Input, int Output)[] testCases =
            {
                (
                    "║╔╗║\n" +
                    "║║║║\n" +
                    "║║║║\n" +
                    "╚╝╚╝",
                    2
                ),
                (
                    "╔══╗\n" +
                    "║╔╗║\n" +
                    "║╚╝║\n" +
                    "╚══╝",
                    0
                ),
                (
                    "╔╦╦╗\n" +
                    "╠╬╬╣\n" +
                    "╠╬╬╣\n" +
                    "╚╩╩╝",
                    0
                ),
                (
                    "╔══╗\n" +
                    "║╬╬║\n" +
                    "║╬╬║\n" +
                    "╚══╝",
                    8
                ),
                (
                    "╔══╗\n" +
                    "║╚╝║\n" +
                    "║╔╗║\n" +
                    "╚══╝",
                    4
                ),
                (
                    " ╔╗\n" +
                    "╔╝╚═╗\n" +
                    "╚╗  ╚═╗\n" +
                    " ╚════╝",
                    0
                ),
                (
                    " ╔╗\n" +
                    "╔╝╚═╗\n" +
                    "╚╗  ╚═╗\n" +
                    " ╚════╝",
                    
                ),
            };

            foreach (var (input, output) in testCases)
            {
                int actualOutput;
                try
                {
                    actualOutput = CountWireEnds(input);
                }
                catch (DELETEME)
                {
                    return;
                }
                Assert.IsTrue(actualOutput == output);
            }
        }

        class DELETEME : Exception { }
    }
}