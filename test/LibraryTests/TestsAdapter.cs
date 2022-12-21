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
    public class TestsAdapter
    {
        /// <summary>
        /// Acá testeo el Adapter para verificar que se adapta correctamente a un SmartDevice.
        /// </summary>
        [Test]
        public void AdapterTest()
        {
            Plug plug = new Plug("4582");
            ISmartDevice SmartPlug = new Adapter(plug);
            SmartPlug.On();
            SmartPlug.Off();
            Assert.AreEqual(SmartPlug.GetStatus(), "off");
        }
    }
}