using System;
using System.Collections.Generic;
using System.Linq;
using LogRegPage.Models;
using LogRegPage.Repositories;
using Moq;
using NUnit.Framework;

[TestFixture]
public class UserRepositoryTests
{
    private Mock<GeoQuestContext> _mockContext;
    private UserRepository _userRepo;

    [SetUp]
    public void Setup()
    {
        _mockContext = new Mock<GeoQuestContext>();
        _userRepo = new UserRepository(_mockContext.Object);
    }
    
    [Test]
    public void GetUser_ShouldReturnUser()
    {
        // Arrange
        var user = new User { Id = 1, UserName = "admin" };
        var users = new List<User>{ user }.AsQueryable();

       _mockContext.Setup(x => x.Users).Returns(users);

        // Act
        var result = _userRepo.GetUser(u => u.UserName == "admin");

        // Assert
        Assert.AreEqual(user, result);
        _mockContext.Verify(x => x.Users, Times.Once);

    }

    [Test]
    public void Update_ShouldCallUpdateAndSaveChanges()
    {

        // Arrange
        var user = new User { Id = 1, UserName = "admin" };

        // Act
        _userRepo.Update(user);

        // Assert
        _mockContext.Verify(x => x.Update(user), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }

    [Test]
    public void Delete_ShouldCallRemoveAndSaveChanges()
    {
        // Arrange
        var user = new User { Id = 1, UserName = "admin"/*, Grade = "1", Password = "123", ScoreId = 1, UserType = "admin" */};

        // Act
        _userRepo.Delete(user);

        // Assert
        _mockContext.Verify(x => x.Users.Remove(user), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }
}

