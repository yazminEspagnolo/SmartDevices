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
    public class TestBulb
    {
        /// <summary>
        /// Acá testeo el ISmartDevice.
        /// </summary>
        [Test]
        public void BulbTest()
        {
            Bulb bulb = new Bulb("1");
            Assert.AreEqual("1", bulb.id);
            Assert.AreEqual("off", bulb.status);
            bulb.On();
            Assert.AreEqual("on", bulb.status);
            bulb.Off();
            Assert.AreEqual("off", bulb.status);
        }
    }
}