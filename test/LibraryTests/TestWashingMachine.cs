//-------------------------------------------------------------------------
// <copyright file="Song.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using AdapterExample;
using NUnit.Framework;

namespace Tests
{
    /// <summary>
    /// Clase de tests
    /// </summary>
    public class TestWashingMachine
    {
        /// <summary>
        /// Acá testeo el ISmartDevice.
        /// </summary>
        [Test]
        public void WashingMachineTest()
        {
            WashingMachine washingMachine = new WashingMachine("123");
            Assert.AreEqual("123", washingMachine.id);
            Assert.AreEqual("off", washingMachine.status);
            washingMachine.On();
            Assert.AreEqual("on", washingMachine.status);
            washingMachine.Off();
            Assert.AreEqual("off", washingMachine.status);
        }
    }
}