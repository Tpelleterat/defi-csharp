using System;
using Controllers;
using Database;
using Microsoft.EntityFrameworkCore;
using Models;
using Moq;
using Xunit;

namespace defi_csharp_tests;

public class UnitTest1
{
    [Fact]
    public void TestThatControllerReturnsValue() {
        var mockSet = new Mock<DbSet<Client>>();
        var mock = new Mock<DatabaseContext>();
        var controller = new ClientController(mock.Object);
        mock.Setup(x => x.Clients).Returns(mockSet.Object);
        mockSet.Setup(x => x.Find(It.IsAny<long>())).Returns(new Client {
            Id = 1,
            FirstName = "Test",
        });

        var cli = controller.FindClientById(1);
        Assert.NotNull(cli);
    }

    [Fact]
    public void TestAge()
    {
        Client c = new Client() {
            Birthdate = new DateTime(2000, 1, 1)
        };
        //Assert.Equal(Math.Floor(client.Age), 21);
    }
}