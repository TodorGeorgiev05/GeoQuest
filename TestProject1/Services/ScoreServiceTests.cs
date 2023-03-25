using NUnit.Framework;
using Moq;
using LogRegPage.Models;
using LogRegPage.Repositories;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

[TestFixture]
public class ScoreRepositoryTests
{
    private Mock<GeoQuestContext> _mockContext;
    private Mock<DbSet<Score>> _mockSet;
    private ScoreRepository _scoreRepo;

    [SetUp]
    public void Setup()
    {
        _mockContext = new Mock<GeoQuestContext>();
        _scoreRepo = new ScoreRepository(_mockContext.Object);
        _mockSet = new Mock<DbSet<Score>>();
    }

    [Test]
    public void Update_ShouldCallUpdateAndSaveChanges()
    {
        // Arrange
        var score = new Score { Id = 1, ScoreGameOne = 100 };

        // Act
        _scoreRepo.Update(score);

        // Assert
        _mockContext.Verify(x => x.Update(score), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }

    [Test]
    public void FindScoreByUserId_ShouldReturnScore()
    {
        // Arrange.
        var userid = 1;
        var scores = new List<Score>
        {
            new Score { Id = 1, ScoreGameOne = 100 },
            new Score { Id = 2, ScoreGameOne = 200 }
        };

        this.SetScoreMock(scores.AsQueryable());

        // Act
        var foo = _scoreRepo.FindScoreByUserId(userid);

        // Assert
        Assert.IsNotNull(foo);
        Assert.AreEqual(foo.Id, scores.First().Id);
    }
     
    [Test]
    public void Delete_ShouldCallRemoveAndSaveChanges()
    {
        // Arrange
        var scores = new List<Score>
        {
            new Score { Id = 1, ScoreGameOne = 100 },
            new Score { Id = 2, ScoreGameOne = 200 }
        };
        this.SetScoreMock(scores.AsQueryable());

        var score = new Score { Id = 1, ScoreGameOne = 100 };

        // Act
        _scoreRepo.Delete(score);

        // Assert
        _mockSet.Verify(x => x.Remove(score), Times.Once);
        _mockContext.Verify(x => x.SaveChanges(), Times.Once);
    }
    private void SetScoreMock(IQueryable scores)
    {
        _mockSet.As<IQueryable<Score>>().Setup(m => m.Provider).Returns(scores.Provider);
        _mockSet.As<IQueryable<Score>>().Setup(m => m.Expression).Returns(scores.Expression);
        _mockSet.As<IQueryable<Score>>().Setup(m => m.ElementType).Returns(scores.ElementType);
        _mockSet.As<IQueryable<Score>>().Setup(m => m.GetEnumerator()).Returns((IEnumerator<Score>)scores.GetEnumerator());
        this._mockContext.Setup(x => x.Scores).Returns(_mockSet.Object);
    }
}