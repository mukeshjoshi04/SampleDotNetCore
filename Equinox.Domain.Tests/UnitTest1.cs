using System;
using Xunit;
using Equinox.Domain.Commands;
namespace Equinox.Domain.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void RegisterNewCustomerCommandIsValidMethodType()
        {
            DateTime dt = new DateTime(1993,10,04);
            var controller = new RegisterNewCustomerCommand("mukesh","mukeshjoshi121@gmail.com",dt);
            var result = controller.IsValid();
            Assert.IsType<bool>(result);
        }

        [Fact]
        public void UpdateCustomercommandIsValidMethodType()
        {
            DateTime dt = new DateTime(1993, 10, 04);
            Guid guid = new Guid("403d076a-d473-4077-8e0d-2c306498f2d6");
            var controller = new UpdateCustomerCommand(guid,"mukesh", "mukeshjoshi121@gmail.com", dt);
            var result = controller.IsValid();
            Assert.IsType<bool>(result);
        }
    }
}
