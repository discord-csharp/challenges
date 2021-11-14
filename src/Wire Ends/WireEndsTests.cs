﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Wire_Ends
{
    [TestClass]
    public class WireEndsTests
    {
        public int CountWireEnds(string s)
        {
            string chars = "║╠╩╦═╬╣╚╝╔╗ \n";
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
                    "", 0
                ),
                (
                    " ", 0
                ),
                (
                    "║", 2
                ),
                (
                    "╠", 3
                ),
                (
                    "╩", 3
                ),
                (
                    "╦", 3
                ),
                (
                    "═", 2
                ),
                (
                    "╬", 4
                ),
                (
                    "╣", 3
                ),
                (
                    "╚", 2
                ),
                (
                    "╝", 2
                ),
                (
                    "╔", 2
                ),
                (
                    "╗", 2
                ),
                ("║╠╩╦═╬╣╚╝╔╗ ", 14),

                (
                    "╔╦╦══╦╗\n" +
                    "║╠╩╦═╬╣\n" +
                    "╚╩═╩═╩╝\n",
                    0
                ),
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
                    "╔╝╚╦╗\n" +
                    "╚╦═╣╚═╗\n" +
                    " ╚═╩══╝",
                    0
                ),
                (
                    " ╔╗\n" +
                    "╔╝╚╦╗\n" +
                    "╚╦  ╚═╗\n" +
                    " ╚═╩══╝",
                    3
                ),
                (
                    "╔═════════╗\n" +
                    "╚═╗       ║\n" +
                    "  ╚═╗     ║\n" +
                    "    ╚═╗   ║\n" +
                    "      ╚═╗ ║\n" +
                    "        ╚═╝\n",
                    0
                ),
                (
                    "╔════╦══╦═╗\n" +
                    "╚═╗  ╚╗ ╚═╣\n" +
                    "  ╚═╗ ╚═╗ ║\n" +
                    "    ╚═╗ ╚═╣\n" +
                    "      ╚═╗ ║\n" +
                    "        ╚═╝\n",
                    0
                ),
                (
                    "╔ ═ ═╦══ ═ \n" +
                    " ═╗   ╗ ╚ ╣\n" +
                    "   ═╗  ═  ║\n" +
                    "     ═╗ ╚  \n" +
                    "       ═╗  \n" +
                    "         ═╝\n",
                    30
                ),
                (
                    "╔═══════════════════╦═══════════════════╗\n" +
                    "║                   ║                   ║\n" +
                    "║   ╔═╗   ╔═════╗   ║   ╔═════╗   ╔═╗   ║\n" +
                    "║   ╚═╝   ╚═════╝   ║   ╚═════╝   ╚═╝   ║\n" +
                    "║                                       ║\n" +
                    "║   ═══   ║   ══════╦══════   ║   ═══   ║\n" +
                    "║         ║         ║         ║         ║\n" +
                    "╚═════╗   ╠══════   ║   ══════╣   ╔═════╝\n" +
                    "      ║   ║                   ║   ║      \n" +
                    "══════╝   ║   ╔════   ════╗   ║   ╚══════\n" +
                    "              ║           ║              \n" +
                    "══════╗   ║   ║           ║   ║   ╔══════\n" +
                    "      ║   ║   ╚═══════════╝   ║   ║      \n" +
                    "      ║   ║                   ║   ║      \n" +
                    "╔═════╝   ║   ══════╦══════   ║   ╚═════╗\n" +
                    "║                   ║                   ║\n" +
                    "║   ══╗   ═══════   ║   ═══════   ╔══   ║\n" +
                    "║     ║                           ║     ║\n" +
                    "╠══   ║   ║   ══════╦══════   ║   ║   ══╣\n" +
                    "║         ║         ║         ║         ║\n" +
                    "║   ══════╩══════   ║   ══════╩══════   ║\n" +
                    "║                                       ║\n" +
                    "╚═══════════════════════════════════════╝",
                    46
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