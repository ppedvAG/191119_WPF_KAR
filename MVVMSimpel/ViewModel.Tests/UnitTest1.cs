using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ViewModel.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPersonCommand_Sets_Correct_Property()
        {
            MainViewModel vm = new MainViewModel();

            // Logik des VM testen:
            vm.GetPeopleCommand.Execute(null); // Simulation: User drückt den Button in WPF

            Assert.IsNotNull(vm.Personenliste);
            Assert.AreEqual(1000, vm.Personenliste.Count);
        }
    }
}
