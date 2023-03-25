using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;
using LogRegPage.Models;
using LogRegPage.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

[TestFixture]
public class UserRepositoryTests
{
    private Mock<GeoQuestContext> _mockContext;
    private UserRepository _userRepo;
    private Mock<DbSet<User>> _mockSet;
    [SetUp]
    public void Setup()
    {
        _mockContext = new Mock<GeoQuestContext>();
        _userRepo = new UserRepository(_mockContext.Object);
        _mockSet = new Mock<DbSet<User>>();
    }
    
    [Test]
    public void GetUser_ShouldReturnUser()
    {
        // Arrange
        var user = new User { Id = 1, UserName = "admin" }; 
        var users = new List<User>{ user }.AsQueryable();
        this.SetUserMock(users);
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
        Score score= new Score();  
        var user = new User { Id = 1, UserName = "admin" ,Grade="3",HighScore=score,Password="123",ScoreId=1,UserType="asd"};
        Assert.IsNotNull(user); // check if user object is not null

        var users = new List<User> { user }.AsQueryable();
        this.SetUserMock(users);
       // Act
       var res= _userRepo.Update(user);
        // Assert
        Assert.AreEqual(true,res);
        _mockSet.Verify(x => x.Update(user), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }
 

    [Test]
    public void Delete_ShouldCallRemoveAndSaveChanges()
    {
        // Arrange
        var user = new User { Id = 1, UserName = "admin"/*, Grade = "1", Password = "123", ScoreId = 1, UserType = "admin" */};
        this.SetUserMock(new[] {user}.AsQueryable());
        // Act
        var result =_userRepo.Delete(user);

        // Assert
        _mockContext.Verify(x => x.Users.Remove(user), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }

    private void SetUserMock(IQueryable users)
    {
        _mockSet.As<IQueryable<User>>().Setup(m => m.Provider).Returns(users.Provider);
        _mockSet.As<IQueryable<User>>().Setup(m => m.Expression).Returns(users.Expression);
        _mockSet.As<IQueryable<User>>().Setup(m => m.ElementType).Returns(users.ElementType);
        _mockSet.As<IQueryable<User>>().Setup(m => m.GetEnumerator()).Returns((IEnumerator<User>)users.GetEnumerator());
        this._mockContext.Setup(x=>x.Users).Returns(_mockSet.Object);
    }
}

